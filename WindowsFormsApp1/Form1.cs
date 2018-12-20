using System;
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
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                if (files.Length == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No files in selected folder. Reselect?");
                }
                System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                selectedFolder.Text = "Selected folder: " + fbd.SelectedPath;
            }
        }

        private void analyze_Click(object sender, EventArgs e)
        {
            if (isFolderSelected)
            {
                //TODO
                // iterate through files, analyze
            } else
            {
                System.Windows.Forms.MessageBox.Show("Select a folder first!");
            }
        }
    }
}
