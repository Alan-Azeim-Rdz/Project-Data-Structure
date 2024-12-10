namespace Project_Data_Structure.Formularios
{
    partial class Binary_TreesFrom
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
            label30 = new Label();
            txtOutput = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnInOrder = new Button();
            btnDelete = new Button();
            btnPostOrder = new Button();
            btnPreOrder = new Button();
            btnInsertNode = new Button();
            txtNodeValue = new TextBox();
            panelTree = new Panel();
            SuspendLayout();
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(12, 7);
            label30.Name = "label30";
            label30.Size = new Size(127, 24);
            label30.TabIndex = 62;
            label30.Text = "Node Value:";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 14F);
            txtOutput.Location = new Point(12, 147);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(381, 39);
            txtOutput.TabIndex = 61;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(379, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 42);
            btnSearch.TabIndex = 60;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(412, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 42);
            btnClear.TabIndex = 59;
            btnClear.Text = "Clear Tree";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInOrder
            // 
            btnInOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInOrder.Location = new Point(268, 90);
            btnInOrder.Name = "btnInOrder";
            btnInOrder.Size = new Size(108, 42);
            btnInOrder.TabIndex = 58;
            btnInOrder.Text = "In Order";
            btnInOrder.UseVisualStyleBackColor = true;
            btnInOrder.Click += btnInOrder_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(271, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 42);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPostOrder
            // 
            btnPostOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostOrder.Location = new Point(144, 90);
            btnPostOrder.Name = "btnPostOrder";
            btnPostOrder.Size = new Size(108, 42);
            btnPostOrder.TabIndex = 56;
            btnPostOrder.Text = "Post Order";
            btnPostOrder.UseVisualStyleBackColor = true;
            btnPostOrder.Click += btnPostOrder_Click;
            // 
            // btnPreOrder
            // 
            btnPreOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreOrder.Location = new Point(20, 90);
            btnPreOrder.Name = "btnPreOrder";
            btnPreOrder.Size = new Size(108, 42);
            btnPreOrder.TabIndex = 55;
            btnPreOrder.Text = "Pre Order";
            btnPreOrder.UseVisualStyleBackColor = true;
            btnPreOrder.Click += btnPreOrder_Click;
            // 
            // btnInsertNode
            // 
            btnInsertNode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertNode.Location = new Point(163, 23);
            btnInsertNode.Name = "btnInsertNode";
            btnInsertNode.Size = new Size(83, 42);
            btnInsertNode.TabIndex = 54;
            btnInsertNode.Text = "Insert";
            btnInsertNode.UseVisualStyleBackColor = true;
            btnInsertNode.Click += btnInsertNode_Click;
            // 
            // txtNodeValue
            // 
            txtNodeValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNodeValue.Location = new Point(12, 35);
            txtNodeValue.Name = "txtNodeValue";
            txtNodeValue.Size = new Size(119, 29);
            txtNodeValue.TabIndex = 53;
            // 
            // panelTree
            // 
            panelTree.Location = new Point(2, 205);
            panelTree.Name = "panelTree";
            panelTree.Size = new Size(625, 319);
            panelTree.TabIndex = 52;
            // 
            // Binary_TreesFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 566);
            Controls.Add(label30);
            Controls.Add(txtOutput);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnInOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnPostOrder);
            Controls.Add(btnPreOrder);
            Controls.Add(btnInsertNode);
            Controls.Add(txtNodeValue);
            Controls.Add(panelTree);
            Name = "Binary_TreesFrom";
            Text = "Binary_TreesFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label30;
        private TextBox txtOutput;
        private Button btnSearch;
        private Button btnClear;
        private Button btnInOrder;
        private Button btnDelete;
        private Button btnPostOrder;
        private Button btnPreOrder;
        private Button btnInsertNode;
        private TextBox txtNodeValue;
        private Panel panelTree;
    }
}