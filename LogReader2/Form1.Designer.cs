namespace LogReader2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SearchFile = new System.Windows.Forms.Button();
            this.ContentToSearch = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(499, 13);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(171, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Otwórz plik";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(12, 13);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(454, 20);
            this.FilePath.TabIndex = 1;
            // 
            // SearchFile
            // 
            this.SearchFile.Location = new System.Drawing.Point(499, 61);
            this.SearchFile.Name = "SearchFile";
            this.SearchFile.Size = new System.Drawing.Size(195, 23);
            this.SearchFile.TabIndex = 2;
            this.SearchFile.Text = "Szukaj w pliku podanego wyrażenia";
            this.SearchFile.UseVisualStyleBackColor = true;
            this.SearchFile.Click += new System.EventHandler(this.SearchFile_Click);
            // 
            // ContentToSearch
            // 
            this.ContentToSearch.Location = new System.Drawing.Point(13, 61);
            this.ContentToSearch.Name = "ContentToSearch";
            this.ContentToSearch.Size = new System.Drawing.Size(453, 20);
            this.ContentToSearch.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(223, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 167);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ContentToSearch);
            this.Controls.Add(this.SearchFile);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button SearchFile;
        private System.Windows.Forms.TextBox ContentToSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

