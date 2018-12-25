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
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Enlarge = new System.Windows.Forms.Button();
            this.analyzeProgress = new System.Windows.Forms.ProgressBar();
            this.minimize = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.selectedFolder = new System.Windows.Forms.Label();
            this.currentFile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.analyze);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.analyze.Margin = new System.Windows.Forms.Padding(2);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(109, 80);
            this.analyze.TabIndex = 2;
            this.analyze.Text = "Analyze";
            this.analyze.UseVisualStyleBackColor = true;
            this.analyze.Click += new System.EventHandler(this.analyze_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(32, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
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
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(753, 0);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 30);
            this.close.TabIndex = 1;
            this.close.Text = "✕";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Enlarge
            // 
            this.Enlarge.BackColor = System.Drawing.Color.Transparent;
            this.Enlarge.FlatAppearance.BorderSize = 0;
            this.Enlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enlarge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enlarge.Location = new System.Drawing.Point(708, 0);
            this.Enlarge.Margin = new System.Windows.Forms.Padding(2);
            this.Enlarge.Name = "Enlarge";
            this.Enlarge.Size = new System.Drawing.Size(45, 30);
            this.Enlarge.TabIndex = 2;
            this.Enlarge.Text = "☐";
            this.Enlarge.UseVisualStyleBackColor = false;
            // 
            // analyzeProgress
            // 
            this.analyzeProgress.Location = new System.Drawing.Point(218, 119);
            this.analyzeProgress.Margin = new System.Windows.Forms.Padding(2);
            this.analyzeProgress.Name = "analyzeProgress";
            this.analyzeProgress.Size = new System.Drawing.Size(486, 35);
            this.analyzeProgress.TabIndex = 4;
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(663, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(45, 29);
            this.minimize.TabIndex = 6;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minimize_KeyDown);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name.Location = new System.Drawing.Point(4, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(85, 17);
            this.Name.TabIndex = 7;
            this.Name.Text = "Picture Purge";
            // 
            // selectedFolder
            // 
            this.selectedFolder.AutoSize = true;
            this.selectedFolder.Location = new System.Drawing.Point(214, 43);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(134, 21);
            this.selectedFolder.TabIndex = 7;
            this.selectedFolder.Text = "Selected Folder:";
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Location = new System.Drawing.Point(214, 76);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(102, 21);
            this.currentFile.TabIndex = 8;
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
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.analyzeProgress);
            this.Controls.Add(this.Enlarge);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button Enlarge;
        private System.Windows.Forms.Button analyze;
        private System.Windows.Forms.ProgressBar analyzeProgress;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label selectedFolder;
        private System.Windows.Forms.Label currentFile;
    }
}

