namespace Project_Data_Structure.Formularios
{
    partial class QueuePriorityFrom
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
            label8 = new Label();
            txtPriority = new TextBox();
            btnSizePQ = new Button();
            btnPeekPQ = new Button();
            btnDequeuePQ = new Button();
            btnEnqueuePQ = new Button();
            ListBoxData = new ListBox();
            label6 = new Label();
            cmbTypeOfPQ = new ComboBox();
            label7 = new Label();
            TextValue = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(549, 9);
            label8.Name = "label8";
            label8.Size = new Size(80, 24);
            label8.TabIndex = 52;
            label8.Text = "Priority:";
            // 
            // txtPriority
            // 
            txtPriority.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriority.Location = new Point(526, 36);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(119, 29);
            txtPriority.TabIndex = 51;
            // 
            // btnSizePQ
            // 
            btnSizePQ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSizePQ.Location = new Point(566, 114);
            btnSizePQ.Name = "btnSizePQ";
            btnSizePQ.Size = new Size(96, 42);
            btnSizePQ.TabIndex = 50;
            btnSizePQ.Text = "Size";
            btnSizePQ.UseVisualStyleBackColor = true;
            btnSizePQ.Click += btnSizePQ_Click;
            // 
            // btnPeekPQ
            // 
            btnPeekPQ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeekPQ.Location = new Point(423, 124);
            btnPeekPQ.Name = "btnPeekPQ";
            btnPeekPQ.Size = new Size(96, 42);
            btnPeekPQ.TabIndex = 49;
            btnPeekPQ.Text = "Peek";
            btnPeekPQ.UseVisualStyleBackColor = true;
            btnPeekPQ.Click += btnPeekPQ_Click;
            // 
            // btnDequeuePQ
            // 
            btnDequeuePQ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeuePQ.Location = new Point(282, 124);
            btnDequeuePQ.Name = "btnDequeuePQ";
            btnDequeuePQ.Size = new Size(96, 42);
            btnDequeuePQ.TabIndex = 48;
            btnDequeuePQ.Text = "Dequeue";
            btnDequeuePQ.UseVisualStyleBackColor = true;
            btnDequeuePQ.Click += btnDequeuePQ_Click;
            // 
            // btnEnqueuePQ
            // 
            btnEnqueuePQ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueuePQ.Location = new Point(141, 114);
            btnEnqueuePQ.Name = "btnEnqueuePQ";
            btnEnqueuePQ.Size = new Size(96, 42);
            btnEnqueuePQ.TabIndex = 47;
            btnEnqueuePQ.Text = "Enqueue";
            btnEnqueuePQ.UseVisualStyleBackColor = true;
            btnEnqueuePQ.Click += btnEnqueuePQ_Click;
            // 
            // ListBoxData
            // 
            ListBoxData.Font = new Font("Microsoft Sans Serif", 14.25F);
            ListBoxData.FormattingEnabled = true;
            ListBoxData.ItemHeight = 24;
            ListBoxData.Location = new Point(156, 200);
            ListBoxData.Name = "ListBoxData";
            ListBoxData.Size = new Size(473, 220);
            ListBoxData.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 68);
            label6.Name = "label6";
            label6.Size = new Size(271, 24);
            label6.TabIndex = 45;
            label6.Text = "Select type of Prority Queue";
            // 
            // cmbTypeOfPQ
            // 
            cmbTypeOfPQ.FormattingEnabled = true;
            cmbTypeOfPQ.Items.AddRange(new object[] { "Vector Of Vectors", "Vector Of Lists", "List Of Vectors", "List Of Lists" });
            cmbTypeOfPQ.Location = new Point(282, 95);
            cmbTypeOfPQ.Name = "cmbTypeOfPQ";
            cmbTypeOfPQ.Size = new Size(201, 23);
            cmbTypeOfPQ.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(146, 9);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 43;
            label7.Text = "Number:";
            // 
            // TextValue
            // 
            TextValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextValue.Location = new Point(130, 36);
            TextValue.Name = "TextValue";
            TextValue.Size = new Size(119, 29);
            TextValue.TabIndex = 42;
            // 
            // QueuePriorityFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtPriority);
            Controls.Add(btnSizePQ);
            Controls.Add(btnPeekPQ);
            Controls.Add(btnDequeuePQ);
            Controls.Add(btnEnqueuePQ);
            Controls.Add(ListBoxData);
            Controls.Add(label6);
            Controls.Add(cmbTypeOfPQ);
            Controls.Add(label7);
            Controls.Add(TextValue);
            Name = "QueuePriorityFrom";
            Text = "QueuePriorityFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txtPriority;
        private Button btnSizePQ;
        private Button btnPeekPQ;
        private Button btnDequeuePQ;
        private Button btnEnqueuePQ;
        private ListBox ListBoxData;
        private Label label6;
        private ComboBox cmbTypeOfPQ;
        private Label label7;
        private TextBox TextValue;
    }
}