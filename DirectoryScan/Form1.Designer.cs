namespace DirectoryScan
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
            this.butDir1 = new System.Windows.Forms.Button();
            this.labDir1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.butArqRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDir1
            // 
            this.butDir1.Location = new System.Drawing.Point(12, 25);
            this.butDir1.Name = "butDir1";
            this.butDir1.Size = new System.Drawing.Size(126, 23);
            this.butDir1.TabIndex = 0;
            this.butDir1.Text = "Selecione a pasta";
            this.butDir1.UseVisualStyleBackColor = true;
            this.butDir1.Click += new System.EventHandler(this.butDir1_Click);
            // 
            // labDir1
            // 
            this.labDir1.AutoSize = true;
            this.labDir1.Location = new System.Drawing.Point(12, 9);
            this.labDir1.Name = "labDir1";
            this.labDir1.Size = new System.Drawing.Size(22, 13);
            this.labDir1.TabIndex = 1;
            this.labDir1.Text = "C:/";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(659, 346);
            this.treeView1.TabIndex = 2;
            // 
            // butArqRep
            // 
            this.butArqRep.Location = new System.Drawing.Point(145, 25);
            this.butArqRep.Name = "butArqRep";
            this.butArqRep.Size = new System.Drawing.Size(155, 23);
            this.butArqRep.TabIndex = 3;
            this.butArqRep.Text = "Verificar Arquivos Repetidos";
            this.butArqRep.UseVisualStyleBackColor = true;
            this.butArqRep.Click += new System.EventHandler(this.butArqRep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 412);
            this.Controls.Add(this.butArqRep);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.butDir1);
            this.Controls.Add(this.labDir1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDir1;
        private System.Windows.Forms.Label labDir1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button butArqRep;



    }
}

