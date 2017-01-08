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

        //variables globales pas belles ici
        string[] files;
        FolderBrowserDialog fbd;

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!(string.IsNullOrWhiteSpace(fbd.SelectedPath)))
            {
                resetComboBox();

                ExtensionComboBox.Enabled = true;
                ClasserBtn.Enabled = true;
            }
        }

        private void ClasserBtn_Click(object sender, EventArgs e)
        {
            if (!(ExtensionComboBox.Items.Contains(ExtensionComboBox.Text)))
            {
                MessageBox.Show("Extension invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetComboBox();
            }

            else
            {
                string newFolderName = "All " + ExtensionComboBox.SelectedItem.ToString() + " files";
                string newFolderPath = System.IO.Path.Combine(fbd.SelectedPath, newFolderName);

                if (!(System.IO.Directory.Exists(newFolderPath)))
                {
                    System.IO.Directory.CreateDirectory(newFolderPath);

                    foreach (string var in files)
                    {
                        if (Path.GetExtension(var) == ExtensionComboBox.SelectedItem.ToString())
                        {
                            string sourceFile = System.IO.Path.Combine(fbd.SelectedPath, Path.GetFileName(var));
                            System.IO.File.Move(sourceFile, System.IO.Path.Combine(newFolderPath, Path.GetFileName(var)));
                        }
                    }

                    resetComboBox();
                }

                else
                {
                    string message = "Un répertoire \"" + newFolderName + "\" existe déjà, voulez vous ajouter des fichiers dans ce répertoire?";

                    DialogResult resultMB = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultMB == DialogResult.Yes)
                    {
                        foreach (string var in files)
                        {
                            if (Path.GetExtension(var) == ExtensionComboBox.SelectedItem.ToString())
                            {
                                string sourceFile = System.IO.Path.Combine(fbd.SelectedPath, Path.GetFileName(var));
                                System.IO.File.Move(sourceFile, System.IO.Path.Combine(newFolderPath, Path.GetFileName(var)));
                            }
                        }

                        resetComboBox();
                    }
                }
            }
        }

        private string[] resetComboBox()
        {
            ExtensionComboBox.ResetText();
            ExtensionComboBox.Items.Clear();
            files = Directory.GetFiles(fbd.SelectedPath);

            for (int i = 0; i < files.Length; i++)
            {
                if (!(ExtensionComboBox.Items.Contains(Path.GetExtension(files[i]))))
                    ExtensionComboBox.Items.Add(Path.GetExtension(files[i]));
            }

            return files;
        }
    }
}
