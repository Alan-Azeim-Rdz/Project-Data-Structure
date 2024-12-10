namespace Project_Data_Structure.Formularios
{
    partial class NoLineal
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
            BtnTree = new Button();
            BtnGrafos = new Button();
            SuspendLayout();
            // 
            // BtnTree
            // 
            BtnTree.Location = new Point(94, 144);
            BtnTree.Name = "BtnTree";
            BtnTree.Size = new Size(211, 100);
            BtnTree.TabIndex = 0;
            BtnTree.Text = "Tree Binary";
            BtnTree.UseVisualStyleBackColor = true;
            BtnTree.Click += BtnTree_Click;
            // 
            // BtnGrafos
            // 
            BtnGrafos.Location = new Point(406, 144);
            BtnGrafos.Name = "BtnGrafos";
            BtnGrafos.Size = new Size(211, 100);
            BtnGrafos.TabIndex = 1;
            BtnGrafos.Text = "Grafos";
            BtnGrafos.UseVisualStyleBackColor = true;
            BtnGrafos.Click += BtnGrafos_Click;
            // 
            // NoLineal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGrafos);
            Controls.Add(BtnTree);
            Name = "NoLineal";
            Text = "NoLineal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnTree;
        private Button BtnGrafos;
    }
}