﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point lastPoint; //for dragging window
        bool isFolderSelected = false;
        FolderBrowserDialog fbd;    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                while (files.Length == 0)
                {
                    var res = System.Windows.Forms.MessageBox.Show("No files in selected folder. Reselect?", "Error", MessageBoxButtons.RetryCancel);
                    if (res == DialogResult.Cancel)
                    {
                        this.Close();
                    } else
                    {
                        result = fbd.ShowDialog();
                        files = Directory.GetFiles(fbd.SelectedPath);
                    }
                }
                isFolderSelected = true;
                System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                selectedFolder.Text = "Selected folder: " + fbd.SelectedPath;
            }
        }

        private void analyze_Click(object sender, EventArgs e)
        {
            System.Threading.Thread uiUpdater;
            if (isFolderSelected)
            {
                //TODO
                // iterate through files, 
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                analyzeProgress.Maximum = files.Length;
                // = new System.Threading.Thread(null);
                for (int i = 0; i < Directory.GetFiles(fbd.SelectedPath).Length; i++)
                {
                    //do somethin
                    analyzeProgress.Value = i + 1;
                    currentFile.Text = "Current File: " + files.GetValue(i);
                    System.Threading.Thread.Sleep(15); //temporary simulation
                }
                currentFile.Text = "Current File: Done!";
            } else
            {
                System.Windows.Forms.MessageBox.Show("Select a folder first!");
            }
        }

        private void currentFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void minimize_KeyDown(object sender, KeyEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
