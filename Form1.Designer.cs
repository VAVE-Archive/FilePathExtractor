using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FilePathExtractor
{
    [DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            InpFile_TextBox = new TextBox();
            GroupBox1 = new GroupBox();
            _InpFile_Browse = new Button();
            _InpFile_Browse.Click += new EventHandler(InpFile_Browse_Click);
            GroupBox2 = new GroupBox();
            _OutFile_Browse = new Button();
            _OutFile_Browse.Click += new EventHandler(OutFile_Browse_Click);
            OutFile_TextBox = new TextBox();
            _ExtractBtn = new Button();
            _ExtractBtn.Click += new EventHandler(ExtractBtn_Click);
            Label1 = new Label();
            OpenFileDialog1 = new OpenFileDialog();
            SaveFileDialog1 = new SaveFileDialog();
            ReconstructPaths = new CheckBox();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // InpFile_TextBox
            // 
            InpFile_TextBox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(42)));
            InpFile_TextBox.BorderStyle = BorderStyle.FixedSingle;
            InpFile_TextBox.ForeColor = Color.White;
            InpFile_TextBox.Location = new Point(6, 19);
            InpFile_TextBox.Name = "InpFile_TextBox";
            InpFile_TextBox.Size = new Size(257, 20);
            InpFile_TextBox.TabIndex = 0;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_InpFile_Browse);
            GroupBox1.Controls.Add(InpFile_TextBox);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(346, 49);
            GroupBox1.TabIndex = 1;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Input File";
            // 
            // InpFile_Browse
            // 
            _InpFile_Browse.FlatAppearance.BorderColor = Color.White;
            _InpFile_Browse.FlatStyle = FlatStyle.Popup;
            _InpFile_Browse.Location = new Point(270, 19);
            _InpFile_Browse.Name = "_InpFile_Browse";
            _InpFile_Browse.Size = new Size(70, 20);
            _InpFile_Browse.TabIndex = 1;
            _InpFile_Browse.Text = "Browse";
            _InpFile_Browse.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(_OutFile_Browse);
            GroupBox2.Controls.Add(OutFile_TextBox);
            GroupBox2.ForeColor = Color.White;
            GroupBox2.Location = new Point(12, 67);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(346, 49);
            GroupBox2.TabIndex = 2;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Output File";
            // 
            // OutFile_Browse
            // 
            _OutFile_Browse.FlatAppearance.BorderColor = Color.White;
            _OutFile_Browse.FlatStyle = FlatStyle.Popup;
            _OutFile_Browse.Location = new Point(270, 19);
            _OutFile_Browse.Name = "_OutFile_Browse";
            _OutFile_Browse.Size = new Size(70, 20);
            _OutFile_Browse.TabIndex = 1;
            _OutFile_Browse.Text = "Browse";
            _OutFile_Browse.UseVisualStyleBackColor = true;
            // 
            // OutFile_TextBox
            // 
            OutFile_TextBox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(42)));
            OutFile_TextBox.BorderStyle = BorderStyle.FixedSingle;
            OutFile_TextBox.ForeColor = Color.White;
            OutFile_TextBox.Location = new Point(6, 19);
            OutFile_TextBox.Name = "OutFile_TextBox";
            OutFile_TextBox.Size = new Size(257, 20);
            OutFile_TextBox.TabIndex = 0;
            // 
            // ExtractBtn
            // 
            _ExtractBtn.FlatStyle = FlatStyle.Flat;
            _ExtractBtn.ForeColor = Color.White;
            _ExtractBtn.Location = new Point(283, 161);
            _ExtractBtn.Name = "_ExtractBtn";
            _ExtractBtn.Size = new Size(75, 23);
            _ExtractBtn.TabIndex = 4;
            _ExtractBtn.Text = "Extract";
            _ExtractBtn.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(15, 119);
            Label1.Name = "Label1";
            Label1.Size = new Size(308, 13);
            Label1.TabIndex = 5;
            Label1.Text = @"This tool will extract all strings with "":\"" and write them to a TXT.";
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // SaveFileDialog1
            // 
            SaveFileDialog1.DefaultExt = "txt";
            SaveFileDialog1.Filter = "Text files|*.txt";
            SaveFileDialog1.Title = "File save";
            // 
            // ReconstructPaths
            // 
            ReconstructPaths.AutoSize = true;
            ReconstructPaths.ForeColor = Color.White;
            ReconstructPaths.Location = new Point(229, 138);
            ReconstructPaths.Name = "ReconstructPaths";
            ReconstructPaths.Size = new Size(129, 17);
            ReconstructPaths.TabIndex = 6;
            ReconstructPaths.Text = "Reconstruct file paths";
            ReconstructPaths.UseVisualStyleBackColor = true;
            ReconstructPaths.Enabled = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(32)), Conversions.ToInteger(Conversions.ToByte(32)), Conversions.ToInteger(Conversions.ToByte(32)));
            ClientSize = new Size(370, 191);
            Controls.Add(ReconstructPaths);
            Controls.Add(Label1);
            Controls.Add(_ExtractBtn);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "File Path Extractor";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox InpFile_TextBox;
        internal GroupBox GroupBox1;
        private Button _InpFile_Browse;

        internal Button InpFile_Browse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InpFile_Browse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InpFile_Browse != null)
                {
                    _InpFile_Browse.Click -= InpFile_Browse_Click;
                }

                _InpFile_Browse = value;
                if (_InpFile_Browse != null)
                {
                    _InpFile_Browse.Click += InpFile_Browse_Click;
                }
            }
        }

        internal GroupBox GroupBox2;
        private Button _OutFile_Browse;

        internal Button OutFile_Browse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OutFile_Browse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OutFile_Browse != null)
                {
                    _OutFile_Browse.Click -= OutFile_Browse_Click;
                }

                _OutFile_Browse = value;
                if (_OutFile_Browse != null)
                {
                    _OutFile_Browse.Click += OutFile_Browse_Click;
                }
            }
        }

        internal TextBox OutFile_TextBox;
        private Button _ExtractBtn;

        internal Button ExtractBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExtractBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExtractBtn != null)
                {
                    _ExtractBtn.Click -= ExtractBtn_Click;
                }

                _ExtractBtn = value;
                if (_ExtractBtn != null)
                {
                    _ExtractBtn.Click += ExtractBtn_Click;
                }
            }
        }

        internal Label Label1;
        internal OpenFileDialog OpenFileDialog1;
        internal SaveFileDialog SaveFileDialog1;
        internal CheckBox ReconstructPaths;
    }
}