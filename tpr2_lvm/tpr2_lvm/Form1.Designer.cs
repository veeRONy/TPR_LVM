namespace tpr2_lvm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.listBoxDangerStates = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnDeleteDangerState = new System.Windows.Forms.Button();
            this.btnAddDangerState = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxInitEvents = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDangerState = new System.Windows.Forms.TextBox();
            this.listBoxProbabilities = new System.Windows.Forms.ListBox();
            this.bntDeleteInitEvent = new System.Windows.Forms.Button();
            this.bntAddInitEvent = new System.Windows.Forms.Button();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.btnEditDangerState = new System.Windows.Forms.Button();
            this.bntEditInitEvent = new System.Windows.Forms.Button();
            this.tbFAL = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPF = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbLoss = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxResources
            // 
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.ItemHeight = 16;
            this.listBoxResources.Location = new System.Drawing.Point(12, 56);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(181, 356);
            this.listBoxResources.TabIndex = 0;
            this.listBoxResources.SelectedIndexChanged += new System.EventHandler(this.listBoxResources_SelectedIndexChanged);
            // 
            // listBoxDangerStates
            // 
            this.listBoxDangerStates.FormattingEnabled = true;
            this.listBoxDangerStates.ItemHeight = 16;
            this.listBoxDangerStates.Location = new System.Drawing.Point(202, 56);
            this.listBoxDangerStates.Name = "listBoxDangerStates";
            this.listBoxDangerStates.Size = new System.Drawing.Size(181, 356);
            this.listBoxDangerStates.TabIndex = 1;
            this.listBoxDangerStates.SelectedIndexChanged += new System.EventHandler(this.listBoxDangerStates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список ресурсов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список ОС ресурса:";
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(12, 419);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(87, 35);
            this.btnAddResource.TabIndex = 5;
            this.btnAddResource.Text = "Добавить";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.Location = new System.Drawing.Point(105, 419);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(88, 35);
            this.btnDeleteResource.TabIndex = 6;
            this.btnDeleteResource.Text = "Удалить";
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // btnDeleteDangerState
            // 
            this.btnDeleteDangerState.Location = new System.Drawing.Point(295, 418);
            this.btnDeleteDangerState.Name = "btnDeleteDangerState";
            this.btnDeleteDangerState.Size = new System.Drawing.Size(88, 36);
            this.btnDeleteDangerState.TabIndex = 8;
            this.btnDeleteDangerState.Text = "Удалить";
            this.btnDeleteDangerState.UseVisualStyleBackColor = true;
            this.btnDeleteDangerState.Click += new System.EventHandler(this.btnDeleteDangerState_Click);
            // 
            // btnAddDangerState
            // 
            this.btnAddDangerState.Location = new System.Drawing.Point(202, 418);
            this.btnAddDangerState.Name = "btnAddDangerState";
            this.btnAddDangerState.Size = new System.Drawing.Size(87, 36);
            this.btnAddDangerState.TabIndex = 7;
            this.btnAddDangerState.Text = "Добавить";
            this.btnAddDangerState.UseVisualStyleBackColor = true;
            this.btnAddDangerState.Click += new System.EventHandler(this.btnAddDangerState_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сценарий ОС:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Функция алгебры логики:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Список инициирующих событий:";
            // 
            // listBoxInitEvents
            // 
            this.listBoxInitEvents.FormattingEnabled = true;
            this.listBoxInitEvents.HorizontalScrollbar = true;
            this.listBoxInitEvents.ItemHeight = 16;
            this.listBoxInitEvents.Location = new System.Drawing.Point(392, 152);
            this.listBoxInitEvents.Name = "listBoxInitEvents";
            this.listBoxInitEvents.Size = new System.Drawing.Size(261, 260);
            this.listBoxInitEvents.TabIndex = 13;
            this.listBoxInitEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxInitEvents_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Вероятности:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Потери:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 24);
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 24);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDangerState
            // 
            this.tbDangerState.Location = new System.Drawing.Point(392, 56);
            this.tbDangerState.Name = "tbDangerState";
            this.tbDangerState.ReadOnly = true;
            this.tbDangerState.Size = new System.Drawing.Size(221, 22);
            this.tbDangerState.TabIndex = 19;
            // 
            // listBoxProbabilities
            // 
            this.listBoxProbabilities.FormattingEnabled = true;
            this.listBoxProbabilities.ItemHeight = 16;
            this.listBoxProbabilities.Location = new System.Drawing.Point(659, 152);
            this.listBoxProbabilities.Name = "listBoxProbabilities";
            this.listBoxProbabilities.Size = new System.Drawing.Size(91, 260);
            this.listBoxProbabilities.TabIndex = 20;
            this.listBoxProbabilities.SelectedIndexChanged += new System.EventHandler(this.listBoxProbabilities_SelectedIndexChanged);
            // 
            // bntDeleteInitEvent
            // 
            this.bntDeleteInitEvent.Location = new System.Drawing.Point(526, 419);
            this.bntDeleteInitEvent.Name = "bntDeleteInitEvent";
            this.bntDeleteInitEvent.Size = new System.Drawing.Size(127, 36);
            this.bntDeleteInitEvent.TabIndex = 23;
            this.bntDeleteInitEvent.Text = "Удалить";
            this.bntDeleteInitEvent.UseVisualStyleBackColor = true;
            this.bntDeleteInitEvent.Click += new System.EventHandler(this.bntDeleteInitEvent_Click);
            // 
            // bntAddInitEvent
            // 
            this.bntAddInitEvent.Location = new System.Drawing.Point(392, 418);
            this.bntAddInitEvent.Name = "bntAddInitEvent";
            this.bntAddInitEvent.Size = new System.Drawing.Size(128, 36);
            this.bntAddInitEvent.TabIndex = 22;
            this.bntAddInitEvent.Text = "Добавить";
            this.bntAddInitEvent.UseVisualStyleBackColor = true;
            this.bntAddInitEvent.Click += new System.EventHandler(this.bntAddInitEvent_Click);
            // 
            // btnEditResource
            // 
            this.btnEditResource.Location = new System.Drawing.Point(12, 460);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(181, 35);
            this.btnEditResource.TabIndex = 24;
            this.btnEditResource.Text = "Изменить";
            this.btnEditResource.UseVisualStyleBackColor = true;
            this.btnEditResource.Click += new System.EventHandler(this.btnEditResource_Click);
            // 
            // btnEditDangerState
            // 
            this.btnEditDangerState.Location = new System.Drawing.Point(202, 460);
            this.btnEditDangerState.Name = "btnEditDangerState";
            this.btnEditDangerState.Size = new System.Drawing.Size(181, 35);
            this.btnEditDangerState.TabIndex = 25;
            this.btnEditDangerState.Text = "Изменить";
            this.btnEditDangerState.UseVisualStyleBackColor = true;
            this.btnEditDangerState.Click += new System.EventHandler(this.btnEditDangerState_Click);
            // 
            // bntEditInitEvent
            // 
            this.bntEditInitEvent.Location = new System.Drawing.Point(392, 461);
            this.bntEditInitEvent.Name = "bntEditInitEvent";
            this.bntEditInitEvent.Size = new System.Drawing.Size(261, 35);
            this.bntEditInitEvent.TabIndex = 26;
            this.bntEditInitEvent.Text = "Изменить";
            this.bntEditInitEvent.UseVisualStyleBackColor = true;
            this.bntEditInitEvent.Click += new System.EventHandler(this.bntEditInitEvent_Click);
            // 
            // tbFAL
            // 
            this.tbFAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFAL.Location = new System.Drawing.Point(773, 56);
            this.tbFAL.Name = "tbFAL";
            this.tbFAL.Size = new System.Drawing.Size(255, 66);
            this.tbFAL.TabIndex = 27;
            this.tbFAL.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(770, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Вероятностная функция";
            // 
            // tbPF
            // 
            this.tbPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPF.Location = new System.Drawing.Point(773, 152);
            this.tbPF.Name = "tbPF";
            this.tbPF.Size = new System.Drawing.Size(255, 96);
            this.tbPF.TabIndex = 29;
            this.tbPF.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Title = "Загрузка данных";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "data";
            this.saveFileDialog.Title = "Сохранение данных";
            // 
            // tbLoss
            // 
            this.tbLoss.Location = new System.Drawing.Point(392, 100);
            this.tbLoss.Name = "tbLoss";
            this.tbLoss.ReadOnly = true;
            this.tbLoss.Size = new System.Drawing.Size(221, 22);
            this.tbLoss.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Расчет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(770, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Оценка вероятности реализации ОС:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(773, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Риск от реализации ОС:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Оценка риска ИС:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(773, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(773, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(255, 22);
            this.textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(773, 473);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(255, 22);
            this.textBox3.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1064, 534);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbLoss);
            this.Controls.Add(this.tbPF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFAL);
            this.Controls.Add(this.bntEditInitEvent);
            this.Controls.Add(this.btnEditDangerState);
            this.Controls.Add(this.btnEditResource);
            this.Controls.Add(this.bntDeleteInitEvent);
            this.Controls.Add(this.bntAddInitEvent);
            this.Controls.Add(this.listBoxProbabilities);
            this.Controls.Add(this.tbDangerState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxInitEvents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteDangerState);
            this.Controls.Add(this.btnAddDangerState);
            this.Controls.Add(this.btnDeleteResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDangerStates);
            this.Controls.Add(this.listBoxResources);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логико-вероятностный метод";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.ListBox listBoxDangerStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Button btnDeleteDangerState;
        private System.Windows.Forms.Button btnAddDangerState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxInitEvents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.TextBox tbDangerState;
        private System.Windows.Forms.ListBox listBoxProbabilities;
        private System.Windows.Forms.Button bntDeleteInitEvent;
        private System.Windows.Forms.Button bntAddInitEvent;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.Button btnEditDangerState;
        private System.Windows.Forms.Button bntEditInitEvent;
        private System.Windows.Forms.RichTextBox tbFAL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbPF;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox tbLoss;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

