namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.Name = new System.Windows.Forms.Label();
            this.analyze = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.enlarge = new System.Windows.Forms.Button();
            this.analyzeProgress = new System.Windows.Forms.ProgressBar();
            this.minimize = new System.Windows.Forms.Button();
            this.selectedFolder = new System.Windows.Forms.Label();
            this.currentFile = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.controlPanel.Controls.Add(this.Name);
            this.controlPanel.Controls.Add(this.analyze);
            this.controlPanel.Controls.Add(this.selectFolder);
            this.controlPanel.Location = new System.Drawing.Point(0, -1);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(189, 447);
            this.controlPanel.TabIndex = 0;
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
            // selectFolder
            // 
            this.selectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectFolder.FlatAppearance.BorderSize = 0;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectFolder.Location = new System.Drawing.Point(32, 77);
            this.selectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(125, 78);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.button1_Click);
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
            // enlarge
            // 
            this.enlarge.BackColor = System.Drawing.Color.Transparent;
            this.enlarge.FlatAppearance.BorderSize = 0;
            this.enlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enlarge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enlarge.Location = new System.Drawing.Point(708, 0);
            this.enlarge.Margin = new System.Windows.Forms.Padding(2);
            this.enlarge.Name = "enlarge";
            this.enlarge.Size = new System.Drawing.Size(45, 30);
            this.enlarge.TabIndex = 2;
            this.enlarge.Text = "☐";
            this.enlarge.UseVisualStyleBackColor = false;
            // 
            // analyzeProgress
            // 
            this.analyzeProgress.Location = new System.Drawing.Point(218, 119);
            this.analyzeProgress.Margin = new System.Windows.Forms.Padding(2);
            this.analyzeProgress.Name = "analyzeProgress";
            this.analyzeProgress.Size = new System.Drawing.Size(486, 35);
            this.analyzeProgress.TabIndex = 4;
            this.analyzeProgress.Click += new System.EventHandler(this.analyzeProgress_Click);
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
            // selectedFolder
            // 
            this.selectedFolder.AutoSize = true;
            this.selectedFolder.Location = new System.Drawing.Point(214, 43);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(134, 21);
            this.selectedFolder.TabIndex = 7;
            this.selectedFolder.Text = "Selected Folder:";
            this.selectedFolder.Click += new System.EventHandler(this.selectedFolder_Click);
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
            // MainForm
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
            this.Controls.Add(this.enlarge);
            this.Controls.Add(this.close);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Picture Purge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button enlarge;
        private System.Windows.Forms.Button analyze;
        private System.Windows.Forms.ProgressBar analyzeProgress;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label selectedFolder;
        private System.Windows.Forms.Label currentFile;
    }
}

