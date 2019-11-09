using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using System.Windows;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using Microsoft.Speech.Recognition;
//using Microsoft.Speech.Synthesis;
//using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace WindowsShutdown
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //Загрузка переменных
            try
            {
                // тут возникнет исключение
                //dateTimePicker1.Value = Convert.ToDateTime(Properties.Settings.Default.dt.ToString("HH, mm"));


                dateTimePicker1.Value = DateTime.Parse(Properties.Settings.Default.dt);//.ToString("HH, mm");
                Console.WriteLine(dateTimePicker1.Value);
                //Console.WriteLine("Завершение блока try");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Ошибка: " + ex.Message);
            }

            Properties.Settings.Default.Save(); // Сохранить переменные
        }

        //SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ru-RU"));
        BackgroundWorker bw;

        /*[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool PostMessage(IntPtr handleWnd, UInt32 Msg, Int32 wParam, Int32 lParam);*/

        /* [DllImport("user32.dll")]
         public extern static bool ShutdownBlockReasonCreate(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string pwszReason);

         [DllImport("user32.dll")]
         public extern static bool ShutdownBlockReasonDestroy(IntPtr hWnd);*/

        //const int WM_ENDSESSION = 0x0016;
        /*const int WM_QUERYENDSESSION = 0x0011,
                  WM_TRUE = 0x1,
                  WM_FALSE = 0x0;*/

        //Process currentProcess = Process.GetCurrentProcess();
        //IntPtr handle;

        private bool isShuttingDown = false;
        /*protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_QUERYENDSESSION) { isShuttingDown = true; Cancelbtn.Enabled = true; }
            base.WndProc(ref m); //label2.Text = "shutdown";
        }*/

        DateTime count;
        double temp;
        int duration;
        static public int tph;
        static public int tpm;
        public int i=0;

        private void ResetAllControlsBackColor(Control control) //ThemeDefault
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;
            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ResetAllControlsBackColor(childControl);
                }
            }
        }

        private void DarkThemeColor(Control Form1) //ThemeDark
        {
            Form1.BackColor = Color.FromArgb(37,36,37);
            Form1.ForeColor = SystemColors.ControlText;
            if (Form1.HasChildren)
            {
                foreach (Control childControl in Form1.Controls)
                {
                    DarkThemeColor(childControl);
                }
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timepicker_CheckedChanged(object sender, EventArgs e)
        {
            if (timepicker.Checked == true) { timepick.Enabled = true; Acceptbtn.Enabled = true; }
            else timepick.Enabled = false;
        }

        private void ShutdownNow_CheckedChanged(object sender, EventArgs e)
        {
            if (ShutdownNow.Checked == true) Acceptbtn.Enabled = true; 
        }

        private void Acceptbtn_Click(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(progressBar1, 1);//Зеленый progressbar

            if (isShuttingDown == true) {
                Process.Start(new ProcessStartInfo("shutdown", "-a")            // Во избежание проблем,
                {                                                               // убираем все возможные,
                    CreateNoWindow = true,                                      // запланированные выключения
                    UseShellExecute = false                                     // и перезагрузки ПК
                });
            }

            toolStripStatusLabel1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            if (ShutdownNow.Checked == true) { //Сейчас
                if (btnChoice.Text == "Выключение ПК") { label2.Text = "Запланировано выключение ПК"; }//Выключение ПК
                else if (btnChoice.Text == "Перезагрузка ПК") { label2.Text = "Запланирована перезагрузка ПК"; }//Перезагрузка ПК
                else if (btnChoice.Text == "Гибернация ПК") { label2.Text = "Запланирована гибернация ПК"; }//Гибернация ПК

                Process.Start(new ProcessStartInfo("shutdown", "-s -t 30")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                });
                progressBar1.Value = 100;
                isShuttingDown = true;
                label3.Visible = false;
            }

            if (timepicker.Checked == true) { //Через...
                if (btnChoice.Text == "Выключение ПК") { label2.Text = "Запланировано выключение ПК"; }//Выключение ПК
                else if (btnChoice.Text == "Перезагрузка ПК") { label2.Text = "Запланирована перезагрузка ПК"; }//Перезагрузка ПК
                else if (btnChoice.Text == "Гибернация ПК") { label2.Text = "Запланирована гибернация ПК"; }//Гибернация ПК

                DateTime dt2 = DateTime.Now.AddMinutes(Int32.Parse(timepick.Text));
                isShuttingDown = true;
                duration = (int)(dt2 - DateTime.Now).TotalMilliseconds;// Int32.Parse(timepick.Text) * 60;//Console.WriteLine("duration= " + duration);
                count = dt2;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Math.Abs(duration);
                timer1.Interval = 100;
                timer1.Start();
            }

            if (radioButton1.Checked == true)
            { //По расписанию...
                if (btnChoice.Text == "Выключение ПК") { label2.Text = "Запланировано выключение ПК"; }//Выключение ПК
                else if (btnChoice.Text == "Перезагрузка ПК") { label2.Text = "Запланирована перезагрузка ПК"; }//Перезагрузка ПК
                else if (btnChoice.Text == "Гибернация ПК") { label2.Text = "Запланирована гибернация ПК"; }//Гибернация ПК

                DateTime dt = dateTimePicker1.Value;

                isShuttingDown = true;

                if (dt < DateTime.Now) { dt = dt.AddDays(1); }
                duration =(int)(dt - DateTime.Now).TotalMilliseconds; //3539446
                //Console.WriteLine("duration= " + duration);

                count = dt;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = Math.Abs(duration);
                //Console.WriteLine(progressBar1.Maximum);
                timer1.Interval = 100;
                timer1.Start();
            }


            if (isShuttingDown == true) {
                Cancelbtn.Enabled = true;
                Acceptbtn.Enabled = false;
                btnPause.Enabled = true;

                label5.Enabled = false;
                btnChoice.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temp = Math.Abs(duration) - (count - DateTime.Now).TotalMilliseconds;
            //Console.WriteLine("temp=" + (int)temp);
            if ((int)temp <= Math.Abs(duration))
            {
                progressBar1.Value = (int)temp;
                TimeSpan ts = count - DateTime.Now;
                label3.Text = "через " + ts.Hours + " ч. " + ts.Minutes + " мин. " + ts.Seconds + " сек.";

                //Console.WriteLine(progressBar1.Value);
            }
            else
            {
                timer1.Stop();
                string param = "";
                progressBar1.Value = Math.Abs(duration);
                Acceptbtn.Enabled = false;
                btnPause.Enabled = false;
                Cancelbtn.Enabled = true;
                //Console.WriteLine(count);
                //Console.WriteLine(DateTime.Now);
                if (btnChoice.Text == "Выключение ПК") { param = "s"; } //Выбрано выключение ПК
                else if (btnChoice.Text == "Перезагрузка ПК") { param = "r"; } //Выбрана перезагрузка ПК
                else if (btnChoice.Text == "Гибернация ПК") { param = "h"; } //Выбрана Гибернация ПК
                Process.Start(new ProcessStartInfo("shutdown", "-" + param + " -t 30") {
                    CreateNoWindow = true,
                    UseShellExecute = false });
                //MessageBox.Show("End");
            }
            progressBar1.Refresh();

            Application.DoEvents();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(progressBar1, 2);//Красный progressbar
            if (isShuttingDown == true)
            {
                Process.Start(new ProcessStartInfo("shutdown", "-a")            // Во избежание проблем,
                {                                                               // убираем все возможные,
                    CreateNoWindow = true,                                      // запланированные выключения
                    UseShellExecute = false                                     // и перезагрузки ПК
                });
            }
            timer1.Stop();

            label5.Enabled = true;
            btnChoice.Enabled = true;
            groupBox2.Enabled = true;

            isShuttingDown = false;
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.ForeColor=Color.Green;
            if (btnChoice.Text == "Перезагрузка ПК") { toolStripStatusLabel1.Text = "Перезагрузка ПК отменена!"; }
            else if (btnChoice.Text == "Выключение ПК") { toolStripStatusLabel1.Text = "Выключение ПК отменено"; }
            else if(btnChoice.Text == "Гибернация ПК") { toolStripStatusLabel1.Text = "Гибернация ПК отменена"; }
            Acceptbtn.Enabled = true;
            Cancelbtn.Enabled = false;
            btnPause.Enabled = false;

            label5.Enabled = true;
            btnChoice.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Загрузка lib распознования голоса
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-RU");
            SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ru-RU"));

            Choices commands = new Choices();
            commands.Add(new string[] { "Компьютер прибавь один час", "Компьютер погнали", "Компьютер остановись", "Компьютер выключайся", "Сколько осталось до выключения" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Culture = ci;
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            notifyIcon1.Visible = false;
            if (Properties.Settings.Default.AutoRunMnz == true)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            
            i++; //Счётчик запусков программы (загрузки формы)
            //Console.WriteLine(i);
            //Console.WriteLine(DateTime.Now.TimeOfDay);
            duration = 0;
            label2.Visible = true;
            label2.Text = "Ожидание...";

            btnChoice.Text = "Выключение ПК";

            if (btnChoice.Text == "Выключение ПК" && ShutdownNow.Checked == true) { Acceptbtn.Enabled = true; groupBox2.Enabled = true; }
             if (isShuttingDown == true) Cancelbtn.Enabled = true;

            //Если 1ый запуск И АвтоЗапуск таймера
            if (i == 1 && Properties.Settings.Default.AutoRunTimer) Acceptbtn_Click(sender, e); i++;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void стандартнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //toolStrip
            стандартнаяToolStripMenuItem1.Checked = true;
            темнаяToolStripMenuItem1.Checked = false;

            //ThemeDefault
            ResetAllControlsBackColor(this);
        }

        private void темнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //toolStrip
            темнаяToolStripMenuItem1.Checked = true;
            стандартнаяToolStripMenuItem1.Checked = false;

            //ThemeDark
            DarkThemeColor(this);
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = false;
                //this.Visible = true;
                menuStrip1.Visible = true;
                statusStrip1.Visible = true;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            }*/
            toolStripMenuItem2_Click(sender, e);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Пауза") {
                timer1.Stop(); btnPause.Text = "Возобновить";
                ModifyProgressBarColor.SetState(progressBar1, 3); //Желтый progressbar 
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.OrangeRed;
                toolStripStatusLabel1.Text = "Пауза";
            } 
            else {
                timer1.Start();
                btnPause.Text = "Пауза";
                ModifyProgressBarColor.SetState(progressBar1, 1); //Зеленый progressbar
                toolStripStatusLabel1.Visible = false;
                toolStripStatusLabel1.ForeColor = Color.Green;
            } 

        }

         protected override void OnFormClosing(FormClosingEventArgs e)
         {
             base.OnFormClosing(e);

            //Сохранение переменных
            Properties.Settings.Default.dt = dateTimePicker1.Value.ToString("HH:mm"); //Сохраненное время
            Properties.Settings.Default.Save(); // Сохранить переменные

            // e.Cancel = false;
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
                //this.Visible = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnChoice.Text == "Выключение ПК") groupBox2.Enabled = true;
            else if (btnChoice.Text == "Перезагрузка ПК") groupBox2.Enabled = true;
            else if (btnChoice.Text == "Гибернация ПК") groupBox2.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        //Распознование речи
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.10)
            {
                switch (e.Result.Text)
                {
                    case "Компьютер прибавь один час":
                        if (isShuttingDown == true)
                        {
                            Cancelbtn_Click(sender, e);
                            dateTimePicker1.Value = dateTimePicker1.Value.AddHours(1);
                            Acceptbtn_Click(sender, e);
                        }
                        else dateTimePicker1.Value = dateTimePicker1.Value.AddHours(1);
                        Console.Beep(280, 300);
                        break;

                    case "Компьютер погнали":
                        if (isShuttingDown == false) { Acceptbtn_Click(sender, e); Console.Beep(400, 300); Console.Beep(400, 300); }
                        else Console.Beep(700, 600);
                        break;

                    case "Компьютер выключайся":
                        Process.Start(new ProcessStartInfo("shutdown", "-s -t 10")
                        {
                            CreateNoWindow = true,
                            UseShellExecute = false
                        });
                        Console.Beep(280, 300);
                        break;

                    case "Компьютер остановись":
                        if (isShuttingDown == true) { Cancelbtn_Click(sender, e); Console.Beep(200, 300); Console.Beep(100, 500); }
                        else Console.Beep(700, 600);
                        break;

                    case "Сколько осталось до выключения":
                        TimeSpan ts = count - DateTime.Now;
                        SpeechSynthesizer speaker = new SpeechSynthesizer();
                        speaker.Rate = 1;
                        speaker.Volume = 100;
                        if (isShuttingDown == true) { speaker.SpeakAsync("До выключения осталось" + ts.Hours + " часов " + ts.Minutes + " минут "); }
                        else speaker.SpeakAsync("Выключение не запланировано");
                        break;

                }
            }
        }


    }
}
