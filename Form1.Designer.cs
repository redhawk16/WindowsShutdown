namespace WindowsShutdown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Acceptbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timepick = new System.Windows.Forms.TextBox();
            this.timepicker = new System.Windows.Forms.RadioButton();
            this.ShutdownNow = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(284, 215);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.Text = "Выход";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // Acceptbtn
            // 
            this.Acceptbtn.Location = new System.Drawing.Point(203, 215);
            this.Acceptbtn.Name = "Acceptbtn";
            this.Acceptbtn.Size = new System.Drawing.Size(75, 23);
            this.Acceptbtn.TabIndex = 6;
            this.Acceptbtn.Text = "Выполнить";
            this.Acceptbtn.UseVisualStyleBackColor = true;
            this.Acceptbtn.Click += new System.EventHandler(this.Acceptbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.timepick);
            this.groupBox2.Controls.Add(this.timepicker);
            this.groupBox2.Controls.Add(this.ShutdownNow);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Укажите когда выполнить действие:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ч.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(51, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(238, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "В";
            this.toolTip1.SetToolTip(this.radioButton1, "Выбранное действие будет выполнено незамедлительно.");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "мин.";
            // 
            // timepick
            // 
            this.timepick.Enabled = false;
            this.timepick.Location = new System.Drawing.Point(157, 22);
            this.timepick.Name = "timepick";
            this.timepick.Size = new System.Drawing.Size(40, 20);
            this.timepick.TabIndex = 2;
            this.toolTip1.SetToolTip(this.timepick, "Укажите через сколько минут выполнить выбранное вами действие.");
            // 
            // timepicker
            // 
            this.timepicker.AutoSize = true;
            this.timepicker.Location = new System.Drawing.Point(96, 24);
            this.timepicker.Name = "timepicker";
            this.timepicker.Size = new System.Drawing.Size(60, 17);
            this.timepicker.TabIndex = 1;
            this.timepicker.Text = "Через:";
            this.toolTip1.SetToolTip(this.timepicker, "Выбранное действие будет выполнено через указанное вами время.");
            this.timepicker.UseVisualStyleBackColor = true;
            this.timepicker.CheckedChanged += new System.EventHandler(this.timepicker_CheckedChanged);
            // 
            // ShutdownNow
            // 
            this.ShutdownNow.AutoSize = true;
            this.ShutdownNow.Location = new System.Drawing.Point(6, 24);
            this.ShutdownNow.Name = "ShutdownNow";
            this.ShutdownNow.Size = new System.Drawing.Size(61, 17);
            this.ShutdownNow.TabIndex = 0;
            this.ShutdownNow.Text = "Сейчас";
            this.toolTip1.SetToolTip(this.ShutdownNow, "Выбранное действие будет выполнено незамедлительно.");
            this.ShutdownNow.UseVisualStyleBackColor = true;
            this.ShutdownNow.CheckedChanged += new System.EventHandler(this.ShutdownNow_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ожидание...";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1";
            this.label2.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem1,
            this.темыToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.настройкиToolStripMenuItem.Text = "Опции";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартнаяToolStripMenuItem1,
            this.темнаяToolStripMenuItem1});
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.темыToolStripMenuItem.Text = "Темы";
            // 
            // стандартнаяToolStripMenuItem1
            // 
            this.стандартнаяToolStripMenuItem1.Checked = true;
            this.стандартнаяToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.стандартнаяToolStripMenuItem1.Name = "стандартнаяToolStripMenuItem1";
            this.стандартнаяToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.стандартнаяToolStripMenuItem1.Text = "Стандартная";
            this.стандартнаяToolStripMenuItem1.Click += new System.EventHandler(this.стандартнаяToolStripMenuItem1_Click);
            // 
            // темнаяToolStripMenuItem1
            // 
            this.темнаяToolStripMenuItem1.Name = "темнаяToolStripMenuItem1";
            this.темнаяToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.темнаяToolStripMenuItem1.Text = "Темная";
            this.темнаяToolStripMenuItem1.Click += new System.EventHandler(this.темнаяToolStripMenuItem1_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Enabled = false;
            this.Cancelbtn.Location = new System.Drawing.Point(29, 215);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 9;
            this.Cancelbtn.Text = "Отменить";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Управление ПК";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem2.Text = "Открыть";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem3.Text = "Закрыть";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(110, 215);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(87, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnChoice.FormattingEnabled = true;
            this.btnChoice.Items.AddRange(new object[] {
            "Выключение ПК",
            "Гибернация ПК",
            "Перезагрузка ПК"});
            this.btnChoice.Location = new System.Drawing.Point(210, 30);
            this.btnChoice.MaxDropDownItems = 3;
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(166, 21);
            this.btnChoice.TabIndex = 11;
            this.btnChoice.SelectedIndexChanged += new System.EventHandler(this.btnChoice_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выберите необходимое действие:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(388, 271);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Acceptbtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление ПК";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Acceptbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox timepick;
        private System.Windows.Forms.RadioButton timepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton ShutdownNow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ComboBox btnChoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

