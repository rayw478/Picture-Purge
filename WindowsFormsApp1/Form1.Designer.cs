namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.analyze = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Enlarge = new System.Windows.Forms.Button();
            this.selectedFolder = new System.Windows.Forms.TextBox();
            this.analyzeProgress = new System.Windows.Forms.ProgressBar();
            this.currentFile = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.analyze);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 447);
            this.panel1.TabIndex = 0;
            // 
            // analyze
            // 
            this.analyze.FlatAppearance.BorderSize = 0;
            this.analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyze.ForeColor = System.Drawing.Color.White;
            this.analyze.Location = new System.Drawing.Point(40, 326);
            this.analyze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(109, 80);
            this.analyze.TabIndex = 2;
            this.analyze.Text = "Analyze";
            this.analyze.UseVisualStyleBackColor = true;
            this.analyze.Click += new System.EventHandler(this.analyze_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(6, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Picture Purge";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(32, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 16.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(766, -1);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 31);
            this.close.TabIndex = 1;
            this.close.Text = "×";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Enlarge
            // 
            this.Enlarge.BackColor = System.Drawing.Color.Transparent;
            this.Enlarge.FlatAppearance.BorderSize = 0;
            this.Enlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enlarge.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enlarge.Location = new System.Drawing.Point(730, 2);
            this.Enlarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enlarge.Name = "Enlarge";
            this.Enlarge.Size = new System.Drawing.Size(33, 31);
            this.Enlarge.TabIndex = 2;
            this.Enlarge.Text = "☐";
            this.Enlarge.UseVisualStyleBackColor = false;
            // 
            // selectedFolder
            // 
            this.selectedFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedFolder.Location = new System.Drawing.Point(218, 35);
            this.selectedFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(486, 20);
            this.selectedFolder.TabIndex = 3;
            this.selectedFolder.Text = "No selected folder.";
            // 
            // analyzeProgress
            // 
            this.analyzeProgress.Location = new System.Drawing.Point(218, 91);
            this.analyzeProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analyzeProgress.Name = "analyzeProgress";
            this.analyzeProgress.Size = new System.Drawing.Size(316, 40);
            this.analyzeProgress.TabIndex = 4;
            this.analyzeProgress.Value = 50;
            // 
            // currentFile
            // 
            this.currentFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentFile.Location = new System.Drawing.Point(220, 185);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(510, 20);
            this.currentFile.TabIndex = 5;
            this.currentFile.Text = "Current File:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 444);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.analyzeProgress);
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.Enlarge);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Picture Purge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Enlarge;
        private System.Windows.Forms.TextBox selectedFolder;
        private System.Windows.Forms.Button analyze;
        private System.Windows.Forms.ProgressBar analyzeProgress;
        private System.Windows.Forms.TextBox currentFile;
    }
}

