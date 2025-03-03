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
    public partial class FormDangerState : Form
    {
        public FormDangerState()
        {
            InitializeComponent();
            dangerStateName = "";
            loss = 50000;
        }

        public FormDangerState(string name, double loss)
        {
            InitializeComponent();
            dangerStateName = name;
            this.loss = loss;
        }

        public string dangerStateName;
        public double loss;

        private void btnOKDangerState_Click(object sender, EventArgs e)
        {
            this.dangerStateName = tbDangerStateName.Text;
            this.loss = Convert.ToDouble(tbLoss.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelDangerState_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangerState_Load(object sender, EventArgs e)
        {
            tbDangerStateName.Text = dangerStateName;
            tbLoss.Value = Convert.ToDecimal(loss);
        }
    }
}
