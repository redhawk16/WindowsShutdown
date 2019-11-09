using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using System.IO;


namespace WindowsShutdown
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cbAutoRun.Checked = Properties.Settings.Default.AutoRun;
            cbAutoRunMnz.Checked = Properties.Settings.Default.AutoRunMnz;
            cbAutoRunTimer.Checked = Properties.Settings.Default.AutoRunTimer;
        }

        string path = "\"" + Application.ExecutablePath + "\"";

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                if (!File.Exists(config.FilePath)) { textBox1.Text = "Файлы с настройками отсутствуют"; button1.Enabled = false; btnDelStg.Enabled = false; }
                else textBox1.Text = config.FilePath;
            }
            catch (ConfigurationErrorsException)
            {
                textBox1.Text = "Error reading app settings";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text)) System.Diagnostics.Process.Start("explorer.exe", @"/select, " + textBox1.Text);
            else MessageBox.Show("Файла с настройками нет!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoRunMnz = cbAutoRunMnz.Checked;
            Properties.Settings.Default.AutoRun = cbAutoRun.Checked;
            Properties.Settings.Default.AutoRunTimer = cbAutoRunTimer.Checked;
            Properties.Settings.Default.Save();

            //Автозапуск приложения при старте Windows
            if (Properties.Settings.Default.AutoRun == true)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("ShutdownManager", @path);
            }
            else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("ShutdownManager", false);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoRun.Checked == true) { cbAutoRunMnz.Enabled = true; }
            else { cbAutoRunMnz.Checked = false; cbAutoRunMnz.Enabled = false;  }
        }

        private void btnDelStg_Click(object sender, EventArgs e)
        {
            try
            {
                string sPath = textBox1.Text;
                sPath = sPath.Substring(0, sPath.LastIndexOf('\\'));
                Directory.Delete(sPath, true);
                bool directoryExists = Directory.Exists(sPath);
                cbAutoRunMnz.Checked = false;
                cbAutoRun.Checked = false;
                cbAutoRunTimer.Checked = false;
                textBox1.Text = "Файлы с настройками отсутствуют";
                if (!File.Exists(sPath)) { textBox1.Text = "Файлы с настройками отсутствуют"; button1.Enabled = false; btnDelStg.Enabled = false; }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
            }

        }
    }
}
