using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DirectoryScan directoryScan = new DirectoryScan();

        private void butDir1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //instanciar o FolderBrowserDialog
            folderBrowserDialog.ShowDialog();
            //abrir o FolderBrowserDialog
            labDir1.Text = folderBrowserDialog.SelectedPath;

            FileInfo[] teste = directoryScan.ListarArquivos(folderBrowserDialog.SelectedPath);
            string teste1 = "";

            for (int i = 0; i < teste.Length; i++)
            {
                teste1 = teste1 + teste[i].ToString() + " | ";
            }

            MessageBox.Show(teste1);
        }

        private void butDir2_Click(object sender, EventArgs e)
        {

        }

    }
}
