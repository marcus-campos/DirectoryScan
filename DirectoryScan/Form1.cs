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

        public DirectoryInfo dir1 = null;
        DirectoryScan dirscan1 = new DirectoryScan();

        private void butDir1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //instanciar o FolderBrowserDialog
            folderBrowserDialog.ShowDialog();
            //abrir o FolderBrowserDialog

            try
            {
                dir1 = new DirectoryInfo(folderBrowserDialog.SelectedPath.ToString());
                //Converter string para DirectoryInfo

                if (dir1.Exists)
                {
                    labDir1.Text = dir1.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void butDir2_Click(object sender, EventArgs e)
        {

        }

    }
}
