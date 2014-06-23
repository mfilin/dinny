using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dinny.Forms.ctl;
using dinny.Domain;
using NHibernate.Validator.Engine;
using ExtControl2;

namespace dinny.Forms.docs
{
    public partial class frmRecipe : frmChild
    {
        public Recipe entity { get; set; }
        public eActions action { get; set; }

        private RecipeCost SelectedCost
        {
            get
            {
                return this.gridRecipeNmkCost.SelectedObject as RecipeCost;
            }
        }

        public frmRecipe()
        {
            InitializeComponent();
        }

        private void xfrmSetting_Load(object sender, EventArgs e)
        {
            InitBindings();
            this.RemoveDelegates();
        }

        private void InitBindings()
        {
            // данные на форме
            this.RefreshGrid();
            // данные справочников
            this.RefreshBindings();
        }

        private void RefreshGrid()
        {            
            this.gridRecipeNmkCost.SetObjects(entity.RecipeCosts);            
        }

        private void RefreshBindings()
        {
            this.bindingSource.ResetBindings(false);
            this.bindingSource.DataSource = this.entity;

            if (null != this.entity.Dish)
            {
                this.cmbRFDish.Text = this.entity.Dish.name;
                this.txtRecipe.Text = this.entity.Dish.recipe;
                this.txtOutDish.Text = this.entity.Dish.outdish.ToString();
                this.lbUnit.Text = this.entity.Dish.unit.sname;
            }
            if (null != this.entity.Org)
                this.cmbRFOrg.Text = this.entity.Org.name;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as Recipe;
            Save(this.entity);
        }

        private void Save(Recipe lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                new RecipeManager().SaveOrUpdate(lpObject);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                var errStr = "";
                foreach (var value in invalidValues) errStr += "\r\n\t" + value.Message;
                MessageBox.Show("Ошибки при сохранении:\r\n" + errStr);
                this.DialogResult = DialogResult.None;
            }
        }       
        
        /// <summary>
        /// Заполнение таблицы цен компонентов из справочника рецептов блюд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadNmks_Click(object sender, EventArgs e)
        {
            if (null == this.entity.Dish)
            {
                MessageBox.Show("Выберите блюдо");
                this.cmbRFDish.Focus();
            }
            else
            {
                foreach (DishNmk dishNmk in this.entity.Dish.DishNmks)
                {
                    this.entity.RecipeCosts.Add(new RecipeCost
                    {
                        Recipe = this.entity,
                        DishNmk = dishNmk,
                    });
                }
                //this.gridRecipeNmkCost.ClearObjects();
                this.gridRecipeNmkCost.SetObjects(this.entity.RecipeCosts);
            }
        }

        /// <summary>
        /// Редактирование цен в таблице продуктов пользователем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridRecipeNmkCost_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            // задание новых параметров
            this.SelectedCost.cost = Convert.ToDouble(e.NewValue);
            this.SelectedCost.summa = this.SelectedCost.DishNmk.result * Convert.ToDouble(e.NewValue);
            // обновление объектов и их отображения
            for (int i = 0; i < this.entity.RecipeCosts.Count; i++)
                if (this.entity.RecipeCosts[i].DishNmk.id == this.SelectedCost.DishNmk.id) {
                    this.entity.RecipeCosts[i] = this.SelectedCost;
                    break;
                }
            this.gridRecipeNmkCost.SetObjects(entity.RecipeCosts);
            // пересчет общих сумм
            this.RefreshSum();
            this.RefreshBindings();
        }

        /// <summary>
        /// Пересчет общих сумм
        /// </summary>
        private void RefreshSum()
        {
            this.entity.sumcost = 0;
            foreach (RecipeCost rc in this.entity.RecipeCosts) this.entity.sumcost += rc.summa;
            if (this.entity.quantity != 0)
                this.entity.onecost = this.entity.sumcost / this.entity.quantity;
        }

        /// <summary>
        /// Вывод справочника блюд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRFDish_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmDishList ctl = new frmDishList
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            if (ctl.ShowDialog() == DialogResult.OK)
            {
                this.entity.Dish = ctl.Selected;
                this.RefreshBindings();
            }
        }

        /// <summary>
        /// Вывод справочника организаций/котрагентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRFOrg_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmPersonList ctl = new frmPersonList
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            if (ctl.ShowDialog() == DialogResult.OK)
            {
                this.entity.Org = ctl.Selected;
                this.RefreshBindings();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            this.entity.quantity = Convert.ToInt32(txtQuantity.Text);
            this.RefreshSum();
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            // указали цену
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                this.entity.price = Convert.ToDouble(txtPrice.Text);
                // считаем процент
                this.entity.ppercent = 100 * (this.entity.price - this.entity.onecost) / this.entity.onecost;

                this.RefreshBindings();
            }
            this.RefreshSum();
        }

        private void txtPercent_EditValueChanged(object sender, EventArgs e)
        {
            // указали процент
            if (!string.IsNullOrEmpty(txtPercent.Text))
            {
                this.entity.ppercent = Convert.ToDouble(txtPercent.Text);
                // считаем цену
                this.entity.price = this.entity.onecost * (this.entity.ppercent / 100 + 1);

                this.RefreshBindings();
            }
            this.RefreshSum();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            this.txtPrice.EditValueChanged += new EventHandler(txtPrice_EditValueChanged);
        }

        private void txtPercent_Enter(object sender, EventArgs e)
        {
            this.txtPercent.EditValueChanged += new EventHandler(txtPercent_EditValueChanged);
        }

        private void RemoveDelegates()
        {
            this.txtPrice.EditValueChanged -= new EventHandler(txtPrice_EditValueChanged);
            this.txtPercent.EditValueChanged -= new EventHandler(txtPercent_EditValueChanged);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            this.RemoveDelegates();
        }

        private void txtPercent_Leave(object sender, EventArgs e)
        {
            this.RemoveDelegates();
        }
    }
}
