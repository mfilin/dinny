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
    public partial class frmDelivery : frmChild
    {
        public Delivery entity { get; set; }
        public eActions action { get; set; }

        private DeliveryCost SelectedCost
        {
            get
            {
                return this.gridDeliveryNmkCost.SelectedObject as DeliveryCost;
            }
        }

        public frmDelivery()
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
            this.RefreshGrid();
            // данные справочников
            this.RefreshBindings();
        }

        private void RefreshGrid()
        {            
            this.gridDeliveryNmkCost.SetObjects(this.entity.DeliveryCosts);
        }

        private void RefreshBindings()
        {
            this.bindingSource.ResetBindings(false);
            this.bindingSource.DataSource = this.entity;
            // обновление суммы документа
            this.RefreshSum();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as Delivery;
            Save(this.entity);
        }

        private void Save(Delivery lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                new DeliveryManager().SaveOrUpdate(lpObject);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDeliveryCost ctl = new frmDeliveryCost
            {
                entity = new DeliveryCost(), // новая запись о составе накладной
                StartPosition = FormStartPosition.CenterParent,
            };
            if (ctl.ShowDialog() == DialogResult.OK)
            {
                ctl.entity.Delivery = this.entity;
                this.entity.DeliveryCosts.Add(ctl.entity);
                this.RefreshGrid();
                // обновление суммы документа
                this.RefreshSum();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранную запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                DialogResult.Yes)
            {
                if (null != this.SelectedCost)
                {
                    this.entity.DeliveryCosts.Remove(this.SelectedCost);
                    this.RefreshGrid();
                    // обновление суммы документа
                    this.RefreshSum();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (null != this.SelectedCost)
            {
                frmDeliveryCost ctl = new frmDeliveryCost
                {
                    entity = this.SelectedCost, // запись о составе накладной
                    StartPosition = FormStartPosition.CenterParent,
                };
                if (ctl.ShowDialog() == DialogResult.OK)
                {
                    ctl.entity.Delivery = this.entity;
                    this.entity.DeliveryCosts.Remove(this.SelectedCost);
                    this.entity.DeliveryCosts.Add(ctl.entity);
                    this.RefreshGrid();
                    // обновление суммы документа
                    this.RefreshSum();
                }
            }
        }

        /// <summary>
        /// Пересчет общих сумм
        /// </summary>
        private void RefreshSum()
        {
            decimal sum = 0;
            foreach (DeliveryCost dc in this.entity.DeliveryCosts) sum += dc.price * dc.quantity;
            if (sum != 0)
                this.txtSumDoc.Text = sum.ToString();
        }
    }
}
