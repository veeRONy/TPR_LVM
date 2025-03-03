namespace tpr2_lvm
{
    partial class FormDangerState
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
            this.btnCancelDangerState = new System.Windows.Forms.Button();
            this.tbDangerStateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOKDangerState = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoss = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelDangerState
            // 
            this.btnCancelDangerState.Location = new System.Drawing.Point(228, 160);
            this.btnCancelDangerState.Name = "btnCancelDangerState";
            this.btnCancelDangerState.Size = new System.Drawing.Size(87, 35);
            this.btnCancelDangerState.TabIndex = 13;
            this.btnCancelDangerState.Text = "Отмена";
            this.btnCancelDangerState.UseVisualStyleBackColor = true;
            this.btnCancelDangerState.Click += new System.EventHandler(this.btnCancelDangerState_Click);
            // 
            // tbDangerStateName
            // 
            this.tbDangerStateName.Location = new System.Drawing.Point(15, 52);
            this.tbDangerStateName.Name = "tbDangerStateName";
            this.tbDangerStateName.Size = new System.Drawing.Size(300, 22);
            this.tbDangerStateName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя опасного состояния:";
            // 
            // btnOKDangerState
            // 
            this.btnOKDangerState.Location = new System.Drawing.Point(135, 160);
            this.btnOKDangerState.Name = "btnOKDangerState";
            this.btnOKDangerState.Size = new System.Drawing.Size(87, 35);
            this.btnOKDangerState.TabIndex = 10;
            this.btnOKDangerState.Text = "ОК";
            this.btnOKDangerState.UseVisualStyleBackColor = true;
            this.btnOKDangerState.Click += new System.EventHandler(this.btnOKDangerState_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Стоимость потерь:";
            // 
            // tbLoss
            // 
            this.tbLoss.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbLoss.Location = new System.Drawing.Point(15, 110);
            this.tbLoss.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tbLoss.Name = "tbLoss";
            this.tbLoss.Size = new System.Drawing.Size(300, 22);
            this.tbLoss.TabIndex = 15;
            this.tbLoss.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // FormDangerState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 207);
            this.Controls.Add(this.tbLoss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelDangerState);
            this.Controls.Add(this.tbDangerStateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOKDangerState);
            this.Name = "FormDangerState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опасное состояние";
            this.Load += new System.EventHandler(this.FormDangerState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelDangerState;
        private System.Windows.Forms.TextBox tbDangerStateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOKDangerState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbLoss;
    }
}