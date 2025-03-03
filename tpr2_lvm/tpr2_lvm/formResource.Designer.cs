namespace tpr2_lvm
{
    partial class formResource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOKResource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResourceName = new System.Windows.Forms.TextBox();
            this.btnCancelResource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOKResource
            // 
            this.btnOKResource.Location = new System.Drawing.Point(133, 100);
            this.btnOKResource.Name = "btnOKResource";
            this.btnOKResource.Size = new System.Drawing.Size(87, 35);
            this.btnOKResource.TabIndex = 6;
            this.btnOKResource.Text = "ОК";
            this.btnOKResource.UseVisualStyleBackColor = true;
            this.btnOKResource.Click += new System.EventHandler(this.btnOKResource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя ресурса:";
            // 
            // tbResourceName
            // 
            this.tbResourceName.Location = new System.Drawing.Point(111, 34);
            this.tbResourceName.Name = "tbResourceName";
            this.tbResourceName.Size = new System.Drawing.Size(202, 22);
            this.tbResourceName.TabIndex = 8;
            // 
            // btnCancelResource
            // 
            this.btnCancelResource.Location = new System.Drawing.Point(226, 100);
            this.btnCancelResource.Name = "btnCancelResource";
            this.btnCancelResource.Size = new System.Drawing.Size(87, 35);
            this.btnCancelResource.TabIndex = 9;
            this.btnCancelResource.Text = "Отмена";
            this.btnCancelResource.UseVisualStyleBackColor = true;
            this.btnCancelResource.Click += new System.EventHandler(this.btnCancelResource_Click);
            // 
            // formResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 147);
            this.Controls.Add(this.btnCancelResource);
            this.Controls.Add(this.tbResourceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOKResource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ресурс";
            this.Load += new System.EventHandler(this.formResource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKResource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResourceName;
        private System.Windows.Forms.Button btnCancelResource;
    }
}