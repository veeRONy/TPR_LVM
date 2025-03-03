using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpr2_lvm
{
    public partial class FormEnterFormula : Form
    {
        public FormEnterFormula()
        {
            InitializeComponent();
            formula = "";
        }

        public FormEnterFormula(string formula)
        {
            InitializeComponent();
            this.formula = formula;
        }

        public string formula;

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.formula = tbFormula.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEnterFormula_Load(object sender, EventArgs e)
        {
            tbFormula.Text = formula;
        }
    }
}
