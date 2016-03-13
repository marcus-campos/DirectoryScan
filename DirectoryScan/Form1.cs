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

        public static FileInfo[] fileInfo;


        private void butDir1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //instanciar o FolderBrowserDialog
            folderBrowserDialog.ShowDialog();
            //abrir o FolderBrowserDialog
            labDir1.Text = folderBrowserDialog.SelectedPath;

            Cursor.Current = Cursors.WaitCursor;

            fileInfo = directoryScan.ListarArquivos(folderBrowserDialog.SelectedPath);

            treeView1.Nodes.Clear();
            for (int i = 0; i < fileInfo.Length; i++)
            {
                treeView1.Nodes.Add(fileInfo[i].FullName.ToString());
            }
        }

        private void butArqRep_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FileInfo[] fi = directoryScan.ListarArquivosRepetidos(fileInfo);
            treeView1.Nodes.Clear();
            for (int i = 0; i < fi.Length; i++)
            {
                treeView1.Nodes.Add(fi[i].FullName.ToString());
            }

            MessageBox.Show("Concluido");

        }

    }
}
