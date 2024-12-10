namespace Project_Data_Structure.Formularios
{
    partial class FromList
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
            cmbListType = new ComboBox();
            btnCount = new Button();
            btnContains = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtValue = new TextBox();
            lstSimpleLinkedList = new ListBox();
            SuspendLayout();
            // 
            // cmbListType
            // 
            cmbListType.FormattingEnabled = true;
            cmbListType.Items.AddRange(new object[] { "Simple Linked List", "Doubly Linked List", "Circular Linked List", "Doubly Circular Linked List" });
            cmbListType.Location = new Point(24, 52);
            cmbListType.Name = "cmbListType";
            cmbListType.Size = new Size(201, 23);
            cmbListType.TabIndex = 23;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCount.Location = new Point(142, 178);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(96, 42);
            btnCount.TabIndex = 22;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnContains
            // 
            btnContains.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContains.Location = new Point(24, 178);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(96, 42);
            btnContains.TabIndex = 21;
            btnContains.Text = "Contains";
            btnContains.UseVisualStyleBackColor = true;
            btnContains.Click += btnContains_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(142, 104);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(96, 42);
            btnRemove.TabIndex = 20;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(24, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 42);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(101, 24);
            label5.TabIndex = 18;
            label5.Text = "Number:";
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(119, 4);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(119, 29);
            txtValue.TabIndex = 17;
            // 
            // lstSimpleLinkedList
            // 
            lstSimpleLinkedList.Font = new Font("Microsoft Sans Serif", 14.25F);
            lstSimpleLinkedList.FormattingEnabled = true;
            lstSimpleLinkedList.ItemHeight = 24;
            lstSimpleLinkedList.Location = new Point(276, 9);
            lstSimpleLinkedList.Name = "lstSimpleLinkedList";
            lstSimpleLinkedList.Size = new Size(433, 412);
            lstSimpleLinkedList.TabIndex = 16;
            // 
            // FromList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbListType);
            Controls.Add(btnCount);
            Controls.Add(btnContains);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txtValue);
            Controls.Add(lstSimpleLinkedList);
            Name = "FromList";
            Text = "FromList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbListType;
        private Button btnCount;
        private Button btnContains;
        private Button btnRemove;
        private Button btnAdd;
        private Label label5;
        private TextBox txtValue;
        private ListBox lstSimpleLinkedList;
    }
}