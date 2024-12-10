namespace Project_Data_Structure.Formularios
{
    partial class QueueDoubleFrom
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
            ListQueueData = new ListBox();
            btnDoubleQSize = new Button();
            btnGetRear = new Button();
            btnGetFront = new Button();
            btnDeleteRear = new Button();
            btnDeleteFront = new Button();
            btnInsertRear = new Button();
            btnInserFront = new Button();
            label3 = new Label();
            cmbDQType = new ComboBox();
            label4 = new Label();
            txtDQValue = new TextBox();
            SuspendLayout();
            // 
            // ListQueueData
            // 
            ListQueueData.Font = new Font("Microsoft Sans Serif", 14.25F);
            ListQueueData.FormattingEnabled = true;
            ListQueueData.ItemHeight = 24;
            ListQueueData.Location = new Point(165, 219);
            ListQueueData.Name = "ListQueueData";
            ListQueueData.Size = new Size(440, 196);
            ListQueueData.TabIndex = 43;
            // 
            // btnDoubleQSize
            // 
            btnDoubleQSize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoubleQSize.Location = new Point(629, 135);
            btnDoubleQSize.Name = "btnDoubleQSize";
            btnDoubleQSize.Size = new Size(96, 42);
            btnDoubleQSize.TabIndex = 42;
            btnDoubleQSize.Text = "Size";
            btnDoubleQSize.UseVisualStyleBackColor = true;
            btnDoubleQSize.Click += btnDoubleQSize_Click;
            // 
            // btnGetRear
            // 
            btnGetRear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetRear.Location = new Point(263, 155);
            btnGetRear.Name = "btnGetRear";
            btnGetRear.Size = new Size(96, 42);
            btnGetRear.TabIndex = 41;
            btnGetRear.Text = "Get Rear";
            btnGetRear.UseVisualStyleBackColor = true;
            btnGetRear.Click += btnGetRear_Click;
            // 
            // btnGetFront
            // 
            btnGetFront.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetFront.Location = new Point(263, 107);
            btnGetFront.Name = "btnGetFront";
            btnGetFront.Size = new Size(96, 42);
            btnGetFront.TabIndex = 40;
            btnGetFront.Text = "Get Front";
            btnGetFront.UseVisualStyleBackColor = true;
            btnGetFront.Click += btnGetFront_Click;
            // 
            // btnDeleteRear
            // 
            btnDeleteRear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRear.Location = new Point(437, 155);
            btnDeleteRear.Name = "btnDeleteRear";
            btnDeleteRear.Size = new Size(140, 42);
            btnDeleteRear.TabIndex = 39;
            btnDeleteRear.Text = "Delete Rear";
            btnDeleteRear.UseVisualStyleBackColor = true;
            btnDeleteRear.Click += btnDeleteRear_Click;
            // 
            // btnDeleteFront
            // 
            btnDeleteFront.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFront.Location = new Point(437, 107);
            btnDeleteFront.Name = "btnDeleteFront";
            btnDeleteFront.Size = new Size(140, 42);
            btnDeleteFront.TabIndex = 38;
            btnDeleteFront.Text = "Delete Front";
            btnDeleteFront.UseVisualStyleBackColor = true;
            btnDeleteFront.Click += btnDeleteFront_Click;
            // 
            // btnInsertRear
            // 
            btnInsertRear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertRear.Location = new Point(51, 155);
            btnInsertRear.Name = "btnInsertRear";
            btnInsertRear.Size = new Size(129, 42);
            btnInsertRear.TabIndex = 37;
            btnInsertRear.Text = "Insert Rear";
            btnInsertRear.UseVisualStyleBackColor = true;
            btnInsertRear.Click += btnInsertRear_Click;
            // 
            // btnInserFront
            // 
            btnInserFront.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserFront.Location = new Point(51, 107);
            btnInserFront.Name = "btnInserFront";
            btnInserFront.Size = new Size(129, 42);
            btnInserFront.TabIndex = 36;
            btnInserFront.Text = "Insert Front";
            btnInserFront.UseVisualStyleBackColor = true;
            btnInserFront.Click += btnInserFront_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 42);
            label3.Name = "label3";
            label3.Size = new Size(279, 24);
            label3.TabIndex = 35;
            label3.Text = "Select type of Double Queue";
            // 
            // cmbDQType
            // 
            cmbDQType.FormattingEnabled = true;
            cmbDQType.Items.AddRange(new object[] { "Static", "Dynamic" });
            cmbDQType.Location = new Point(524, 67);
            cmbDQType.Name = "cmbDQType";
            cmbDQType.Size = new Size(201, 23);
            cmbDQType.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 36);
            label4.Name = "label4";
            label4.Size = new Size(91, 24);
            label4.TabIndex = 33;
            label4.Text = "Number:";
            // 
            // txtDQValue
            // 
            txtDQValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDQValue.Location = new Point(70, 61);
            txtDQValue.Name = "txtDQValue";
            txtDQValue.Size = new Size(119, 29);
            txtDQValue.TabIndex = 32;
            // 
            // QueueDoubleFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListQueueData);
            Controls.Add(btnDoubleQSize);
            Controls.Add(btnGetRear);
            Controls.Add(btnGetFront);
            Controls.Add(btnDeleteRear);
            Controls.Add(btnDeleteFront);
            Controls.Add(btnInsertRear);
            Controls.Add(btnInserFront);
            Controls.Add(label3);
            Controls.Add(cmbDQType);
            Controls.Add(label4);
            Controls.Add(txtDQValue);
            Name = "QueueDoubleFrom";
            Text = "QueueDoubleFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListQueueData;
        private Button btnDoubleQSize;
        private Button btnGetRear;
        private Button btnGetFront;
        private Button btnDeleteRear;
        private Button btnDeleteFront;
        private Button btnInsertRear;
        private Button btnInserFront;
        private Label label3;
        private ComboBox cmbDQType;
        private Label label4;
        private TextBox txtDQValue;
    }
}