using System;
using System.IO;
using System.Windows.Forms;

namespace Renamer
{
    public partial class RenamerForm : Form
    {
        int foldersRenamed;
        int filesRenamed;

        public RenamerForm()
        {
            InitializeComponent();

            this.tbDir.Text = Directory.GetCurrentDirectory();
            this.btDir.Click += OnDirClick;
            this.btConvert.Click += OnConvertClick;
        }

        private void OnConvertClick(object sender, EventArgs e)
        {
            filesRenamed = 0;
            foldersRenamed = 0;
            renameWordsInFolder(this.tbDir.Text);
            System.Windows.Forms.MessageBox.Show(
                string.Format(
                    "Folders renamed: {0}\nFiles renamed: {1}",
                    foldersRenamed,
                    filesRenamed));
        }

        private void OnDirClick(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = this.tbDir.Text;

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.tbDir.Text = fbd.SelectedPath;
                }
            }
        }

        private void renameWordsInFolder(string currentDir)
        {
            string destDir = currentDir.Replace(this.tbFrom.Text, this.tbTo.Text);
            if(!currentDir.Equals(destDir))
            {
                Directory.Move(currentDir, destDir);
                foldersRenamed++;
            }

            string[] files = Directory.GetFiles(destDir);
            foreach (var file in files)         
            {
                string destName = file.Replace(this.tbFrom.Text, this.tbTo.Text);
                if(!file.Equals(destName))
                {
                    File.Move(file, destName);
                    filesRenamed++;
                }
                RenameFileContents(destName);
            }

            string[] folders = Directory.GetDirectories(destDir);
            foreach (var folder in folders)
            {
                renameWordsInFolder(folder);
            }
        }

        private void RenameFileContents(string file)
        {
            string text = File.ReadAllText(file);
            text = text.Replace(this.tbFrom.Text, this.tbTo.Text);
            File.WriteAllText(file, text);
        }
    }
}
