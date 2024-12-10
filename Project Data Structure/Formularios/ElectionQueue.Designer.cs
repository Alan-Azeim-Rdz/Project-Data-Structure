namespace Project_Data_Structure.Formularios
{
    partial class ElectionQueue
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
            BtnDouble = new Button();
            BtnPriority = new Button();
            BtnQueue = new Button();
            SuspendLayout();
            // 
            // BtnDouble
            // 
            BtnDouble.Location = new Point(320, 276);
            BtnDouble.Name = "BtnDouble";
            BtnDouble.Size = new Size(159, 66);
            BtnDouble.TabIndex = 12;
            BtnDouble.Text = "Queue Double";
            BtnDouble.UseVisualStyleBackColor = true;
            BtnDouble.Click += BtnDouble_Click;
            // 
            // BtnPriority
            // 
            BtnPriority.Location = new Point(480, 108);
            BtnPriority.Name = "BtnPriority";
            BtnPriority.Size = new Size(159, 66);
            BtnPriority.TabIndex = 11;
            BtnPriority.Text = "Priority";
            BtnPriority.UseVisualStyleBackColor = true;
            BtnPriority.Click += BtnPriority_Click;
            // 
            // BtnQueue
            // 
            BtnQueue.Location = new Point(162, 108);
            BtnQueue.Name = "BtnQueue";
            BtnQueue.Size = new Size(159, 66);
            BtnQueue.TabIndex = 10;
            BtnQueue.Text = "Queue";
            BtnQueue.UseVisualStyleBackColor = true;
            BtnQueue.Click += BtnQueue_Click;
            // 
            // ElectionQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDouble);
            Controls.Add(BtnPriority);
            Controls.Add(BtnQueue);
            Name = "ElectionQueue";
            Text = "ElectionQueue";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDouble;
        private Button BtnPriority;
        private Button BtnQueue;
    }
}