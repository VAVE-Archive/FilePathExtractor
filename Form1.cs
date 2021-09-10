using System;
using System.IO;
using System.Windows.Forms;

namespace FilePathExtractor
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        string outPath;
        string inPath;

        private void writeLn(string str) {
            var file = My.MyProject.Computer.FileSystem.OpenTextFileWriter(outPath, true);
            file.WriteLine(str);
            Console.WriteLine("String found - " + str);
            file.Close();
        }

        private void dumpStrings() {
            var reader = My.MyProject.Computer.FileSystem.OpenTextFileReader(inPath);
            string line;
            uint entryCount = 0U;
            do {
                line = reader.ReadLine();
                try {
                    if (line.Contains(@":\")) {
                        string tmpLine;
                        if (line.StartsWith("I@")) {
                            tmpLine = line.Substring(2).Replace("?", "").Replace("@", "");
                        }
                        else {
                            tmpLine = line.Replace("?", "").Replace("@", "");
                        }

                        writeLn(tmpLine);
                        if (ReconstructPaths.Checked == true) {
                            try {
                                var f = File.Create(tmpLine);
                            }
                            catch (Exception ex) {

                            }
                        }
                        entryCount = (uint)(entryCount + 1L);
                    }
                }
                catch (Exception ex) {

                }
            }
            while (!(line is null));
            reader.Close();
            ExtractBtn.Enabled = true;
        }

        private void InpFile_Browse_Click(object sender, EventArgs e) {
            var dialog = OpenFileDialog1;
            if (dialog.ShowDialog() == DialogResult.OK) {
                inPath = dialog.FileName;
                InpFile_TextBox.Text = inPath;
            }
        }

        private void OutFile_Browse_Click(object sender, EventArgs e) {
            var dialog = SaveFileDialog1;
            if (dialog.ShowDialog() == DialogResult.OK) {
                outPath = dialog.FileName;
                OutFile_TextBox.Text = outPath;
            }
        }

        private void ExtractBtn_Click(object sender, EventArgs e) {
            dumpStrings();
            ExtractBtn.Enabled = false;
        }
    }
}