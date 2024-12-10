namespace Project_Data_Structure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSearchAlgorithms = new Button();
            BtnDataStructure = new Button();
            label1 = new Label();
            BtnDataStructureNotLineal = new Button();
            SuspendLayout();
            // 
            // BtnSearchAlgorithms
            // 
            BtnSearchAlgorithms.Location = new Point(288, 254);
            BtnSearchAlgorithms.Name = "BtnSearchAlgorithms";
            BtnSearchAlgorithms.Size = new Size(159, 66);
            BtnSearchAlgorithms.TabIndex = 5;
            BtnSearchAlgorithms.Text = "Algoritmos de Busqueda";
            BtnSearchAlgorithms.UseVisualStyleBackColor = true;
            BtnSearchAlgorithms.Click += BtnSearchAlgorithms_Click;
            // 
            // BtnDataStructure
            // 
            BtnDataStructure.Location = new Point(177, 159);
            BtnDataStructure.Name = "BtnDataStructure";
            BtnDataStructure.Size = new Size(159, 66);
            BtnDataStructure.TabIndex = 3;
            BtnDataStructure.Text = "Estructuras de datos Lineales";
            BtnDataStructure.UseVisualStyleBackColor = true;
            BtnDataStructure.Click += BtnDataStructure_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 68);
            label1.Name = "label1";
            label1.Size = new Size(428, 42);
            label1.TabIndex = 6;
            label1.Text = "Estructura de datos";
            // 
            // BtnDataStructureNotLineal
            // 
            BtnDataStructureNotLineal.Location = new Point(408, 159);
            BtnDataStructureNotLineal.Name = "BtnDataStructureNotLineal";
            BtnDataStructureNotLineal.Size = new Size(159, 66);
            BtnDataStructureNotLineal.TabIndex = 7;
            BtnDataStructureNotLineal.Text = "Estructura de datos no lineal";
            BtnDataStructureNotLineal.UseVisualStyleBackColor = true;
            BtnDataStructureNotLineal.Click += BtnDataStructureNotLineal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDataStructureNotLineal);
            Controls.Add(label1);
            Controls.Add(BtnSearchAlgorithms);
            Controls.Add(BtnDataStructure);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearchAlgorithms;
        private Button BtnDataStructure;
        private Label label1;
        private Button BtnDataStructureNotLineal;
    }
}
