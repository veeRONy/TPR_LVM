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
    public partial class FormInitEvent : Form
    {
        public FormInitEvent()
        {
            InitializeComponent();
            initEventName = "";
            this.p = 0.005;
        }

        public FormInitEvent(string name, double p)
        {
            InitializeComponent();
            initEventName = name;
            this.p = p;
        }

        public string initEventName;
        public double p;

        private void btnOK_Click(object sender, EventArgs e)
        {
            initEventName = tbInitEventName.Text;
            p = Convert.ToDouble(tbProbability.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void FormInitEvent_Load(object sender, EventArgs e)
        {
            tbInitEventName.Text = initEventName;
            tbProbability.Text = p.ToString();
        }
    }
}
