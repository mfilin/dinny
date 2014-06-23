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
    public partial class frmPerson : frmChild
    {
        public Person entity { get; set; }
        public eActions action { get; set; }

        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
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
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.entity = this.bindingSource.DataSource as Person;
            Save(this.entity);
        }

        private void Save(Person lpObject)
        {
            ValidatorEngine vtor = new ValidatorEngine();
            var invalidValues = vtor.Validate(lpObject);
            if (invalidValues.Length == 0)
            {
                new PersonManager().SaveOrUpdate(lpObject);
                if (null != lpObject.Parent) // сохранить признак узла
                    new PersonManager().SaveOrUpdate(lpObject.Parent);
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
