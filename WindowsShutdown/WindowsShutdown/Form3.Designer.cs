namespace WindowsShutdown
{
    partial class Form3
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelStg = new System.Windows.Forms.Button();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.cbAutoRunTimer = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbAutoRunMnz = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Язык интерфейса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расположение файлов настроек:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Версия 1b";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBox1.Location = new System.Drawing.Point(130, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Русский";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(9, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Открыть папку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelStg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnDelStg
            // 
            this.btnDelStg.Location = new System.Drawing.Point(9, 83);
            this.btnDelStg.Name = "btnDelStg";
            this.btnDelStg.Size = new System.Drawing.Size(257, 23);
            this.btnDelStg.TabIndex = 6;
            this.btnDelStg.Text = "Стереть настройки";
            this.btnDelStg.UseVisualStyleBackColor = true;
            this.btnDelStg.Click += new System.EventHandler(this.btnDelStg_Click);
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Location = new System.Drawing.Point(12, 161);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(191, 17);
            this.cbAutoRun.TabIndex = 8;
            this.cbAutoRun.Text = "Запускать при запуске Windows";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            this.cbAutoRun.CheckedChanged += new System.EventHandler(this.cbAutoRun_CheckedChanged);
            // 
            // cbAutoRunTimer
            // 
            this.cbAutoRunTimer.AutoSize = true;
            this.cbAutoRunTimer.Location = new System.Drawing.Point(12, 207);
            this.cbAutoRunTimer.Name = "cbAutoRunTimer";
            this.cbAutoRunTimer.Size = new System.Drawing.Size(265, 17);
            this.cbAutoRunTimer.TabIndex = 9;
            this.cbAutoRunTimer.Text = "Автоматически запускать таймер выключения";
            this.cbAutoRunTimer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbAutoRunMnz
            // 
            this.cbAutoRunMnz.AutoSize = true;
            this.cbAutoRunMnz.Enabled = false;
            this.cbAutoRunMnz.Location = new System.Drawing.Point(12, 184);
            this.cbAutoRunMnz.Name = "cbAutoRunMnz";
            this.cbAutoRunMnz.Size = new System.Drawing.Size(128, 17);
            this.cbAutoRunMnz.TabIndex = 12;
            this.cbAutoRunMnz.Text = "Запускать свернуто";
            this.cbAutoRunMnz.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.cbAutoRunMnz);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbAutoRunTimer);
            this.Controls.Add(this.cbAutoRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки программы";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.CheckBox cbAutoRunTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbAutoRunMnz;
        private System.Windows.Forms.Button btnDelStg;
    }
}