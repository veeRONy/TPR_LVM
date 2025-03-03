namespace tpr2_lvm
{
    partial class FormInitEvent
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbInitEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProbability = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbInitEventName
            // 
            this.tbInitEventName.Location = new System.Drawing.Point(12, 46);
            this.tbInitEventName.Name = "tbInitEventName";
            this.tbInitEventName.Size = new System.Drawing.Size(282, 22);
            this.tbInitEventName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя инициирующего события:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(114, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 35);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вероятность:";
            // 
            // tbProbability
            // 
            this.tbProbability.DecimalPlaces = 4;
            this.tbProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbProbability.Location = new System.Drawing.Point(144, 106);
            this.tbProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbProbability.Name = "tbProbability";
            this.tbProbability.Size = new System.Drawing.Size(150, 22);
            this.tbProbability.TabIndex = 19;
            this.tbProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // FormInitEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 206);
            this.Controls.Add(this.tbProbability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbInitEventName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "FormInitEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инициирующее событие";
            this.Load += new System.EventHandler(this.FormInitEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbInitEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbProbability;
    }
}