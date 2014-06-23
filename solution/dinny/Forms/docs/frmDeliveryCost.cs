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
    public partial class frmDeliveryCost : frmChild
    {
        public DeliveryCost entity { get; set; }
        public eActions action { get; set; }

        private DeliveryCost SelectedCost
        {
            get
            {
                return null;
                //return this.gridDeliveryNmkCost.SelectedObject as DeliveryCost;
            }
        }

        public frmDeliveryCost()
        {
            InitializeComponent();
        }

        private void xfrmSetting_Load(object sender, EventArgs e)
        {
            InitBindings();            
        }

        private void InitBindings()
        {
            // данные справочников
            this.RefreshBindings();
        }

        private void RefreshBindings()
        {
            this.bindingSource.ResetBindings(false);
            this.bindingSource.DataSource = this.entity;

            if (null != this.entity.Nmk)
                this.cmbRFNmk.Text = this.entity.Nmk.name;
            if (null != this.entity.Unit)
                this.cmbRFUnit.Text = this.entity.Unit.name;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as DeliveryCost;
            Save(this.entity);
        }

        private void Save(DeliveryCost lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                //new DeliveryCostManager().SaveOrUpdate(lpObject);

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
                    this.entity.Unit = (Unit)ctl.Selected;
                    this.RefreshBindings();
                }
            }
        }

        private void cmbRFNmk_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmNmkList ctl = new frmNmkList();
            if (ctl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (null != ctl.Selected)
                {
                    this.entity.Nmk = (Nmk)ctl.Selected;
                    this.RefreshBindings();
                }
            }
        }
    }
}
