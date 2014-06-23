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
    public partial class frmDish : frmChild
    {
        public Dish entity { get; set; }
        public eActions action { get; set; }

        private DishNmk SelectedNmk
        {
            get
            {
                return this.gridDishNmk.SelectedObject as DishNmk;
            }
        }

        public frmDish()
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
            this.gridDishNmk.SetObjects(entity.DishNmks);

            if (null != this.entity.unit)
                this.cmbRFUnit.Text = this.entity.unit.name;

            if (null != this.entity.tprocess)
                this.rtbDoc.Text = this.entity.tprocess;
            else
            {
                // загрузка из шаблона
                string lcFile = AppDomain.CurrentDomain.BaseDirectory + "//tpl//techcard.rtf";
                if(System.IO.File.Exists(lcFile))
                {
                    rtbDoc.LoadFile(lcFile, RichTextBoxStreamType.RichText);
                }               
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as Dish;
            Save(this.entity);
        }

        private void Save(Dish lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                new DishManager().SaveOrUpdate(lpObject);
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

        private void cmbRFUnit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmUnitList ctl = new frmUnitList();
            if (ctl.ShowDialog() == DialogResult.OK)
            {
                if (null != ctl.Selected)
                {
                    this.entity.unit = (Unit)ctl.Selected;
                    this.RefreshBindings();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDishNmk ctl = new frmDishNmk
            {
                entity = new DishNmk(), // новая запись о составе блюда
                StartPosition = FormStartPosition.CenterParent,
            };
            if (ctl.ShowDialog() == DialogResult.OK)
            {
                ctl.entity.dish = this.entity;
                this.entity.DishNmks.Add(ctl.entity);
                this.RefreshBindings();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранную запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                DialogResult.Yes)
            {
                if (null != this.SelectedNmk)
                {
                    this.entity.DishNmks.Remove(this.SelectedNmk);
                    this.RefreshBindings();
                }
            }
        }

        private void tbrFont_Click(object sender, EventArgs e)
        {
            SelectFontToolStripMenuItem_Click(this, e);
        }


        #region "Menu Methods"

        private void SelectFontToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    FontDialog1.Font = rtbDoc.SelectionFont;
                }
                else
                {
                    FontDialog1.Font = null;
                }
                FontDialog1.ShowApply = true;
                if (FontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbDoc.SelectionFont = FontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
        }
               
        private void SelectAllToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to select all document content.", "RTE - Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void CopyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Copy();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to copy document content.", "RTE - Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void CutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Cut();
            }
            catch
            {
                MessageBox.Show("Unable to cut document content.", "RTE - Cut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void PasteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Paste();
            }
            catch
            {
                MessageBox.Show("Unable to copy clipboard content to document.", "RTE - Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BoldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Bold;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void ItalicToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Italic;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void UnderlineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Underline;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void NormalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;
                    newFontStyle = FontStyle.Regular;
                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void mnuUndo_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.CanUndo)
                {
                    rtbDoc.Undo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuRedo_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.CanRedo)
                {
                    rtbDoc.Redo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void LeftToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void CenterToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void RightToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void AddBulletsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.BulletIndent = 10;
                rtbDoc.SelectionBullet = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void RemoveBulletsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionBullet = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void mnuIndent0_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void mnuIndent5_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent10_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent15_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        
        private void mnuIndent20_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        private void rtbDoc_SelectionChanged(object sender, EventArgs e)
        {
            tbrBold.Checked = rtbDoc.SelectionFont.Bold;
            tbrItalic.Checked = rtbDoc.SelectionFont.Italic;
            tbrUnderline.Checked = rtbDoc.SelectionFont.Underline;
        }

        #endregion

        private void tbrLeft_Click(object sender, EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tbrCenter_Click(object sender, EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tbrRight_Click(object sender, EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tbrBold_Click(object sender, EventArgs e)
        {
            BoldToolStripMenuItem_Click(this, e);
        }

        private void tbrItalic_Click(object sender, EventArgs e)
        {
            ItalicToolStripMenuItem_Click(this, e);
        }

        private void tbrUnderline_Click(object sender, EventArgs e)
        {
            UnderlineToolStripMenuItem_Click(this, e);
        }
    }
}
