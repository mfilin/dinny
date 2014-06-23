using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dinny.Domain;
using NHibernate.Validator.Engine;
using ExtControl2;

namespace dinny.Forms.ctl
{
    public partial class frmDishNmk : frmChild
    {
        public DishNmk entity { get; set; }
        public eActions action { get; set; }

        public frmDishNmk()
        {
            InitializeComponent();
        }

        private void xfrmSetting_Load(object sender, EventArgs e)
        {
            InitBindings();
        }

        private void InitBindings()
        {
            // данные на форме
            this.RefreshBindings();
            // данные справочников            
        }

        private void RefreshBindings()
        {
            this.bindingSource.DataSource = this.entity;

            if (null != this.entity.nmk)
                this.cmbRFNmk.Text = this.entity.nmk.name;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as DishNmk;
            Save(this.entity);
        }

        private void Save(DishNmk lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                //new DishNmkManager().SaveOrUpdate(lpObject);

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

        private void cmbRFNmk_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmNmkList ctl = new frmNmkList();
            if (ctl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (null != ctl.Selected)
                {
                    this.entity.nmk = (Nmk)ctl.Selected;
                    this.RefreshBindings();
                }
            }
        }
    }
}
