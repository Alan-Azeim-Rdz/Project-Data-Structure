namespace Project_Data_Structure.Formularios
{
    partial class Secuential_and_binary
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
            btnAddNumber = new Button();
            label2 = new Label();
            txtNewNumber = new TextBox();
            lstNumbers = new ListView();
            btnSearch = new Button();
            label1 = new Label();
            txtKey = new TextBox();
            cmbSearchMethod = new ComboBox();
            SuspendLayout();
            // 
            // btnAddNumber
            // 
            btnAddNumber.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            btnAddNumber.Location = new Point(48, 131);
            btnAddNumber.Margin = new Padding(4, 4, 4, 4);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(96, 31);
            btnAddNumber.TabIndex = 15;
            btnAddNumber.Text = "Add";
            btnAddNumber.UseVisualStyleBackColor = true;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            label2.Location = new Point(22, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 14;
            label2.Text = "write an ordered array";
            // 
            // txtNewNumber
            // 
            txtNewNumber.Location = new Point(22, 47);
            txtNewNumber.Margin = new Padding(4, 4, 4, 4);
            txtNewNumber.Name = "txtNewNumber";
            txtNewNumber.Size = new Size(247, 27);
            txtNewNumber.TabIndex = 13;
            // 
            // lstNumbers
            // 
            lstNumbers.Location = new Point(577, 33);
            lstNumbers.Margin = new Padding(4, 4, 4, 4);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(430, 543);
            lstNumbers.TabIndex = 12;
            lstNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            btnSearch.Location = new Point(48, 377);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 31);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            label1.Location = new Point(22, 269);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 10;
            label1.Text = "write a number to search";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(22, 293);
            txtKey.Margin = new Padding(4, 4, 4, 4);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(247, 27);
            txtKey.TabIndex = 9;
            // 
            // cmbSearchMethod
            // 
            cmbSearchMethod.FormattingEnabled = true;
            cmbSearchMethod.Items.AddRange(new object[] { "Secuencial", "Binaria" });
            cmbSearchMethod.Location = new Point(333, 293);
            cmbSearchMethod.Margin = new Padding(4, 4, 4, 4);
            cmbSearchMethod.Name = "cmbSearchMethod";
            cmbSearchMethod.Size = new Size(154, 28);
            cmbSearchMethod.TabIndex = 8;
            // 
            // Secuential_and_binary
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(btnAddNumber);
            Controls.Add(label2);
            Controls.Add(txtNewNumber);
            Controls.Add(lstNumbers);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(cmbSearchMethod);
            Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Secuential_and_binary";
            Text = "Secuential_and_binary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNumber;
        private Label label2;
        private TextBox txtNewNumber;
        private ListView lstNumbers;
        private Button btnSearch;
        private Label label1;
        private TextBox txtKey;
        private ComboBox cmbSearchMethod;
    }
}