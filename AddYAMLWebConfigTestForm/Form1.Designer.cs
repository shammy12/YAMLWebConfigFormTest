namespace AddYAMLWebConfigTestForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteFile = new System.Windows.Forms.Button();
            this.TestCopy = new System.Windows.Forms.Button();
            this.ZipFiles = new System.Windows.Forms.Button();
            this.AddtoZip = new System.Windows.Forms.Button();
            this.DeleteDir = new System.Windows.Forms.Button();
            this.DeleteFromZip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteFile
            // 
            this.DeleteFile.Location = new System.Drawing.Point(37, 149);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(75, 23);
            this.DeleteFile.TabIndex = 2;
            this.DeleteFile.Text = "DeleteFile";
            this.DeleteFile.UseVisualStyleBackColor = true;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // TestCopy
            // 
            this.TestCopy.Location = new System.Drawing.Point(37, 193);
            this.TestCopy.Name = "TestCopy";
            this.TestCopy.Size = new System.Drawing.Size(75, 23);
            this.TestCopy.TabIndex = 3;
            this.TestCopy.Text = "TestCopy";
            this.TestCopy.UseVisualStyleBackColor = true;
            this.TestCopy.Click += new System.EventHandler(this.TestCopy_Click);
            // 
            // ZipFiles
            // 
            this.ZipFiles.Location = new System.Drawing.Point(167, 104);
            this.ZipFiles.Name = "ZipFiles";
            this.ZipFiles.Size = new System.Drawing.Size(75, 23);
            this.ZipFiles.TabIndex = 4;
            this.ZipFiles.Text = "ZipFiles";
            this.ZipFiles.UseVisualStyleBackColor = true;
            this.ZipFiles.Click += new System.EventHandler(this.ZipFiles_Click);
            // 
            // AddtoZip
            // 
            this.AddtoZip.Location = new System.Drawing.Point(167, 148);
            this.AddtoZip.Name = "AddtoZip";
            this.AddtoZip.Size = new System.Drawing.Size(75, 23);
            this.AddtoZip.TabIndex = 5;
            this.AddtoZip.Text = "AddtoZip";
            this.AddtoZip.UseVisualStyleBackColor = true;
            this.AddtoZip.Click += new System.EventHandler(this.AddtoZip_Click);
            // 
            // DeleteDir
            // 
            this.DeleteDir.Location = new System.Drawing.Point(167, 192);
            this.DeleteDir.Name = "DeleteDir";
            this.DeleteDir.Size = new System.Drawing.Size(75, 23);
            this.DeleteDir.TabIndex = 6;
            this.DeleteDir.Text = "DeleteDir";
            this.DeleteDir.UseVisualStyleBackColor = true;
            this.DeleteDir.Click += new System.EventHandler(this.DeleteDir_Click);
            // 
            // DeleteFromZip
            // 
            this.DeleteFromZip.Location = new System.Drawing.Point(37, 233);
            this.DeleteFromZip.Name = "DeleteFromZip";
            this.DeleteFromZip.Size = new System.Drawing.Size(91, 23);
            this.DeleteFromZip.TabIndex = 7;
            this.DeleteFromZip.Text = "DeleteFromZip";
            this.DeleteFromZip.UseVisualStyleBackColor = true;
            this.DeleteFromZip.Click += new System.EventHandler(this.DeleteFromZip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.DeleteFromZip);
            this.Controls.Add(this.DeleteDir);
            this.Controls.Add(this.AddtoZip);
            this.Controls.Add(this.ZipFiles);
            this.Controls.Add(this.TestCopy);
            this.Controls.Add(this.DeleteFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button TestCopy;
        private System.Windows.Forms.Button ZipFiles;
        private System.Windows.Forms.Button AddtoZip;
        private System.Windows.Forms.Button DeleteDir;
        private System.Windows.Forms.Button DeleteFromZip;
    }
}

