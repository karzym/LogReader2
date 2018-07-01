using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace LogReader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Global
        {
            public static string file = "";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            Global.file = openFileDialog1.FileName;
            try
            {
                FilePath.Text = Global.file.ToString();
            }
            catch (IOException)
            {
                MessageBox.Show("Wprowadź poprawną ścieżkę do pliku", "Wystąpił błąd");
            }
        }
        public void SearchFile_Click(object sender, EventArgs e)
        {
            //int i;
            string pattern = ".*" + ContentToSearch.Text + ".*";
            Regex reg = new Regex(pattern);
            string [] lines = File.ReadAllLines(FilePath.Text);
            string path = ContentToSearch.Text + ".txt";
            using (FileStream fs = File.Open(FilePath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                using (StreamWriter writetext = new StreamWriter(path))
                {
                    string s;
                    //int i = 1;
                    while ((s = sr.ReadLine()) != null)
                    {
                        //int percentage = (int)((i / (double)lines.Length) * 100.0);
                        Match m = reg.Match(s);
                        if (m.Success)
                        {
                            writetext.WriteLine(s);
                        }
                        //i++;
                        //backgroundWorker1.ReportProgress(percentage);
                    }
                    MessageBox.Show("Zakończono");
                }

            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FilePath.Text = Properties.Settings.Default.RememberFilePath;
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.RememberFilePath = FilePath.Text;
            Properties.Settings.Default.Save();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /*// Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();*/
        }
    }
}
