namespace Project_Data_Structure
{
    partial class Lineale
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
            BtnStack = new Button();
            BtnQueue = new Button();
            Btnlists = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnStack
            // 
            BtnStack.Location = new Point(469, 128);
            BtnStack.Name = "BtnStack";
            BtnStack.Size = new Size(159, 66);
            BtnStack.TabIndex = 8;
            BtnStack.Text = "Stack";
            BtnStack.UseVisualStyleBackColor = true;
            BtnStack.Click += BtnStack_Click;
            // 
            // BtnQueue
            // 
            BtnQueue.Location = new Point(151, 128);
            BtnQueue.Name = "BtnQueue";
            BtnQueue.Size = new Size(159, 66);
            BtnQueue.TabIndex = 6;
            BtnQueue.Text = "Queue";
            BtnQueue.UseVisualStyleBackColor = true;
            BtnQueue.Click += BtnQueue_Click;
            // 
            // Btnlists
            // 
            Btnlists.Location = new Point(309, 296);
            Btnlists.Name = "Btnlists";
            Btnlists.Size = new Size(159, 66);
            Btnlists.TabIndex = 9;
            Btnlists.Text = "Lists";
            Btnlists.UseVisualStyleBackColor = true;
            Btnlists.Click += Btnlists_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 55);
            label1.Name = "label1";
            label1.Size = new Size(605, 42);
            label1.TabIndex = 10;
            label1.Text = "Estructura de datos lineales";
            // 
            // Lineale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Btnlists);
            Controls.Add(BtnStack);
            Controls.Add(BtnQueue);
            Name = "Lineale";
            Text = "Lineale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStack;
        private Button BtnQueue;
        private Button Btnlists;
        private Label label1;
    }
}