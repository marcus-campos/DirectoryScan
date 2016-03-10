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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labDir2 = new System.Windows.Forms.Label();
            this.butDir2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butDir1
            // 
            this.butDir1.Location = new System.Drawing.Point(6, 32);
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
            this.labDir1.Location = new System.Drawing.Point(6, 16);
            this.labDir1.Name = "labDir1";
            this.labDir1.Size = new System.Drawing.Size(22, 13);
            this.labDir1.TabIndex = 1;
            this.labDir1.Text = "C:/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.labDir1);
            this.groupBox1.Controls.Add(this.butDir1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diretorio 1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 73);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labDir2);
            this.groupBox2.Controls.Add(this.butDir2);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diretorio 2";
            // 
            // labDir2
            // 
            this.labDir2.AutoSize = true;
            this.labDir2.Location = new System.Drawing.Point(6, 16);
            this.labDir2.Name = "labDir2";
            this.labDir2.Size = new System.Drawing.Size(22, 13);
            this.labDir2.TabIndex = 1;
            this.labDir2.Text = "C:/";
            // 
            // butDir2
            // 
            this.butDir2.Location = new System.Drawing.Point(6, 32);
            this.butDir2.Name = "butDir2";
            this.butDir2.Size = new System.Drawing.Size(126, 23);
            this.butDir2.TabIndex = 0;
            this.butDir2.Text = "Selecione a pasta";
            this.butDir2.UseVisualStyleBackColor = true;
            this.butDir2.Click += new System.EventHandler(this.butDir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDir1;
        private System.Windows.Forms.Label labDir1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labDir2;
        private System.Windows.Forms.Button butDir2;
        private System.Windows.Forms.TreeView treeView1;


    }
}

