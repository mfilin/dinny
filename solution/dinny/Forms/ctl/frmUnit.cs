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
    public partial class frmUnit : frmChild
    {
        public Unit entity { get; set; }
        public eActions action { get; set; }

        public frmUnit()
        {
            InitializeComponent();
        }

        private void xfrmSetting_Load(object sender, EventArgs e)
        {
            InitArrayData();
        }

        private void InitArrayData()
        {
            this.bindingSource.DataSource = this.entity;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as Unit;
            Save(this.entity);
        }

        private void Save(Unit lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                new UnitManager().SaveOrUpdate(lpObject);
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
    }
}
