namespace Project_Data_Structure.Formularios
{
    partial class FromSeach
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(145, 161);
            button1.Name = "button1";
            button1.Size = new Size(129, 83);
            button1.TabIndex = 0;
            button1.Text = "Secuentail and binary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 161);
            button2.Name = "button2";
            button2.Size = new Size(129, 83);
            button2.TabIndex = 1;
            button2.Text = "Table Hash";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FromSeach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 436);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FromSeach";
            Text = "FromSeach";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}