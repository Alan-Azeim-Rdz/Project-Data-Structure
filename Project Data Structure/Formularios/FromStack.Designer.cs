namespace Project_Data_Structure.Formularios
{
    partial class FromStack
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
            ComboBoxStack = new ComboBox();
            btnSize = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            label8 = new Label();
            txtStackValue = new TextBox();
            lstStaticStack = new ListBox();
            SuspendLayout();
            // 
            // ComboBoxStack
            // 
            ComboBoxStack.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            ComboBoxStack.FormattingEnabled = true;
            ComboBoxStack.Items.AddRange(new object[] { "Static", "Dynamic" });
            ComboBoxStack.Location = new Point(311, 6);
            ComboBoxStack.Name = "ComboBoxStack";
            ComboBoxStack.Size = new Size(196, 37);
            ComboBoxStack.TabIndex = 24;
            ComboBoxStack.SelectedIndexChanged += ComboBoxStack_SelectedIndexChanged;
            // 
            // btnSize
            // 
            btnSize.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            btnSize.Location = new Point(12, 300);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(96, 42);
            btnSize.TabIndex = 23;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnPeek
            // 
            btnPeek.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            btnPeek.Location = new Point(12, 227);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(96, 42);
            btnPeek.TabIndex = 22;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            btnPop.Location = new Point(12, 150);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(96, 42);
            btnPop.TabIndex = 21;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            btnPush.Location = new Point(12, 68);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(96, 42);
            btnPush.TabIndex = 20;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(115, 29);
            label8.TabIndex = 19;
            label8.Text = "Number:";
            // 
            // txtStackValue
            // 
            txtStackValue.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            txtStackValue.Location = new Point(152, 6);
            txtStackValue.Name = "txtStackValue";
            txtStackValue.Size = new Size(119, 36);
            txtStackValue.TabIndex = 18;
            // 
            // lstStaticStack
            // 
            lstStaticStack.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Italic);
            lstStaticStack.FormattingEnabled = true;
            lstStaticStack.ItemHeight = 29;
            lstStaticStack.Location = new Point(152, 68);
            lstStaticStack.Name = "lstStaticStack";
            lstStaticStack.Size = new Size(466, 323);
            lstStaticStack.TabIndex = 17;
            // 
            // FromStack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(ComboBoxStack);
            Controls.Add(btnSize);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(label8);
            Controls.Add(txtStackValue);
            Controls.Add(lstStaticStack);
            Name = "FromStack";
            Text = "FromStack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxStack;
        private Button btnSize;
        private Button btnPeek;
        private Button btnPop;
        private Button btnPush;
        private Label label8;
        private TextBox txtStackValue;
        private ListBox lstStaticStack;
    }
}