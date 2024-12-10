namespace Project_Data_Structure.Formularios
{
    partial class Table_HASH
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
            label3 = new Label();
            TxtSearchId = new TextBox();
            lstAlumnos = new ListBox();
            btnSearch = new Button();
            btnInsert = new Button();
            label2 = new Label();
            label1 = new Label();
            txtValue = new TextBox();
            txtKey = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            label3.Location = new Point(202, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 18;
            label3.Text = "ID";
            // 
            // TxtSearchId
            // 
            TxtSearchId.Location = new Point(121, 261);
            TxtSearchId.Margin = new Padding(4, 3, 4, 3);
            TxtSearchId.Name = "TxtSearchId";
            TxtSearchId.Size = new Size(188, 24);
            TxtSearchId.TabIndex = 17;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 17;
            lstAlumnos.Location = new Point(555, 59);
            lstAlumnos.Margin = new Padding(4, 3, 4, 3);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(603, 582);
            lstAlumnos.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            btnSearch.Location = new Point(161, 311);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 26);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            btnInsert.Location = new Point(161, 167);
            btnInsert.Margin = new Padding(4, 3, 4, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(96, 26);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            label2.Location = new Point(69, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 13;
            label2.Text = "E-Maill";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            label1.Location = new Point(69, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(161, 121);
            txtValue.Margin = new Padding(4, 3, 4, 3);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(188, 24);
            txtValue.TabIndex = 11;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(161, 76);
            txtKey.Margin = new Padding(4, 3, 4, 3);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(188, 24);
            txtKey.TabIndex = 10;
            // 
            // Table_HASH
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 700);
            Controls.Add(label3);
            Controls.Add(TxtSearchId);
            Controls.Add(lstAlumnos);
            Controls.Add(btnSearch);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValue);
            Controls.Add(txtKey);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Table_HASH";
            Text = "Table_HASH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox TxtSearchId;
        private ListBox lstAlumnos;
        private Button btnSearch;
        private Button btnInsert;
        private Label label2;
        private Label label1;
        private TextBox txtValue;
        private TextBox txtKey;
    }
}