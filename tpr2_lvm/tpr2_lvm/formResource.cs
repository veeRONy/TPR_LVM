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
    public partial class formResource : Form
    {
        public formResource()
        {
            InitializeComponent();
            resourceName = "";
        }

        public formResource(string name)
        {
            InitializeComponent();
            resourceName = name;
        }

        public string resourceName;


        private void btnOKResource_Click(object sender, EventArgs e)
        {
            this.resourceName = tbResourceName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelResource_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formResource_Load(object sender, EventArgs e)
        {
            tbResourceName.Text = resourceName;
        }
    }
}
