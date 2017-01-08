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
                ExtensionComboBox.Items.Clear();

                string[] files = Directory.GetFiles(fbd.SelectedPath);

                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = Path.GetExtension(files[i]);

                    if (!(ExtensionComboBox.Items.Contains(files[i])))
                    {
                        ExtensionComboBox.Items.Add(files[i]);
                    }
                }

                ExtensionComboBox.Enabled = true;
                ClasserBtn.Enabled = true;
            }
        }

        private void ClasserBtn_Click(object sender, EventArgs e)
        {
            if (!(ExtensionComboBox.Items.Contains(ExtensionComboBox.Text)))
            {
                MessageBox.Show("Extension invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
