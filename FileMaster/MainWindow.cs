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

namespace FileMaster
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!(string.IsNullOrWhiteSpace(fbd.SelectedPath)))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] fileExtensions=files;

                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = Path.GetFileName(files[i]);
                    fileExtensions[i] = Path.GetExtension(files[i]);

                    if (!(ExtensionComboBox.Items.Contains(fileExtensions[i])))
                    {
                        ExtensionComboBox.Items.Add(fileExtensions[i]);
                    }
                }

                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                MessageBox.Show("Path: " + fbd.SelectedPath);
            }
        }
    }
}
