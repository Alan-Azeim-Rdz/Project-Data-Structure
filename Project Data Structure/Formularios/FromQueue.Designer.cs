namespace Project_Data_Structure.Formularios
{
    partial class FromQueue
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
            lstQueues = new ListBox();
            BtnSize = new Button();
            BtnPeek = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            ComboboxType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TxtNumberAdd = new TextBox();
            label3 = new Label();
            LabelSizeArreglo = new Label();
            SuspendLayout();
            // 
            // lstQueues
            // 
            lstQueues.Font = new Font("Microsoft Sans Serif", 14.25F);
            lstQueues.FormattingEnabled = true;
            lstQueues.ItemHeight = 24;
            lstQueues.Location = new Point(472, 47);
            lstQueues.Name = "lstQueues";
            lstQueues.Size = new Size(294, 364);
            lstQueues.TabIndex = 25;
            // 
            // BtnSize
            // 
            BtnSize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSize.Location = new Point(35, 306);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(96, 42);
            BtnSize.TabIndex = 24;
            BtnSize.Text = "Size";
            BtnSize.UseVisualStyleBackColor = true;
            BtnSize.Click += BtnSize_Click;
            // 
            // BtnPeek
            // 
            BtnPeek.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPeek.Location = new Point(35, 245);
            BtnPeek.Name = "BtnPeek";
            BtnPeek.Size = new Size(96, 42);
            BtnPeek.TabIndex = 23;
            BtnPeek.Text = "Peek";
            BtnPeek.UseVisualStyleBackColor = true;
            BtnPeek.Click += BtnPeek_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDequeue.Location = new Point(35, 184);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(96, 42);
            btnDequeue.TabIndex = 22;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnqueue.Location = new Point(35, 120);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(96, 42);
            btnEnqueue.TabIndex = 21;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // ComboboxType
            // 
            ComboboxType.FormattingEnabled = true;
            ComboboxType.Items.AddRange(new object[] { "Static", "Dynamic", "Circular" });
            ComboboxType.Location = new Point(35, 47);
            ComboboxType.Name = "ComboboxType";
            ComboboxType.Size = new Size(201, 23);
            ComboboxType.TabIndex = 26;
            ComboboxType.SelectedIndexChanged += ComboboxType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 24);
            label2.TabIndex = 29;
            label2.Text = "Tipo de Queue a usar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 183);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 28;
            label1.Text = "Number:";
            // 
            // TxtNumberAdd
            // 
            TxtNumberAdd.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumberAdd.Location = new Point(242, 208);
            TxtNumberAdd.Name = "TxtNumberAdd";
            TxtNumberAdd.Size = new Size(119, 29);
            TxtNumberAdd.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 73);
            label3.Name = "label3";
            label3.Size = new Size(199, 24);
            label3.TabIndex = 30;
            label3.Text = "Tamaño del arreglo:";
            // 
            // LabelSizeArreglo
            // 
            LabelSizeArreglo.AutoSize = true;
            LabelSizeArreglo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSizeArreglo.Location = new Point(240, 73);
            LabelSizeArreglo.Name = "LabelSizeArreglo";
            LabelSizeArreglo.Size = new Size(0, 24);
            LabelSizeArreglo.TabIndex = 31;
            // 
            // FromQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelSizeArreglo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNumberAdd);
            Controls.Add(ComboboxType);
            Controls.Add(lstQueues);
            Controls.Add(BtnSize);
            Controls.Add(BtnPeek);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Name = "FromQueue";
            Text = "Queue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstQueues;
        private Button BtnSize;
        private Button BtnPeek;
        private Button btnDequeue;
        private Button btnEnqueue;
        private ComboBox ComboboxType;
        private Label label2;
        private Label label1;
        private TextBox TxtNumberAdd;
        private Label label3;
        private Label LabelSizeArreglo;
    }
}