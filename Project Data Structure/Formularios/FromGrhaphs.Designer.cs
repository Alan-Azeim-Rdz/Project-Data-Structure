namespace Project_Data_Structure.Formularios
{
    partial class FromGrhaphs
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
            btnAddNode = new Button();
            txtNode = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnAddEdge = new Button();
            btnRemoveEdge = new Button();
            txtGraphRepresentation = new TextBox();
            txtWeight = new TextBox();
            chkDirected = new CheckBox();
            btnShowDFS = new Button();
            txtStartNode = new TextBox();
            btnRemoveNode = new Button();
            btnShowBFS = new Button();
            btnShowDFSRecursive = new Button();
            btnRemoveAll = new Button();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label22 = new Label();
            label23 = new Label();
            SuspendLayout();
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(149, 86);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(75, 23);
            btnAddNode.TabIndex = 33;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // txtNode
            // 
            txtNode.Location = new Point(139, 53);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(180, 23);
            txtNode.TabIndex = 34;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(130, 183);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(104, 23);
            txtFrom.TabIndex = 35;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(130, 221);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(104, 23);
            txtTo.TabIndex = 36;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(267, 183);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(75, 23);
            btnAddEdge.TabIndex = 37;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // btnRemoveEdge
            // 
            btnRemoveEdge.Location = new Point(267, 221);
            btnRemoveEdge.Name = "btnRemoveEdge";
            btnRemoveEdge.Size = new Size(75, 39);
            btnRemoveEdge.TabIndex = 38;
            btnRemoveEdge.Text = "Remove Edge";
            btnRemoveEdge.UseVisualStyleBackColor = true;
            btnRemoveEdge.Click += btnRemoveEdge_Click;
            // 
            // txtGraphRepresentation
            // 
            txtGraphRepresentation.Font = new Font("Microsoft Sans Serif", 14F);
            txtGraphRepresentation.Location = new Point(490, 68);
            txtGraphRepresentation.Multiline = true;
            txtGraphRepresentation.Name = "txtGraphRepresentation";
            txtGraphRepresentation.Size = new Size(362, 303);
            txtGraphRepresentation.TabIndex = 39;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(130, 255);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(104, 23);
            txtWeight.TabIndex = 40;
            // 
            // chkDirected
            // 
            chkDirected.AutoSize = true;
            chkDirected.Location = new Point(130, 284);
            chkDirected.Name = "chkDirected";
            chkDirected.Size = new Size(70, 19);
            chkDirected.TabIndex = 41;
            chkDirected.Text = "Directed";
            chkDirected.UseVisualStyleBackColor = true;
            // 
            // btnShowDFS
            // 
            btnShowDFS.Location = new Point(138, 413);
            btnShowDFS.Name = "btnShowDFS";
            btnShowDFS.Size = new Size(75, 39);
            btnShowDFS.TabIndex = 42;
            btnShowDFS.Text = "Show DFS Algorithm";
            btnShowDFS.UseVisualStyleBackColor = true;
            btnShowDFS.Click += btnShowDFS_Click;
            // 
            // txtStartNode
            // 
            txtStartNode.Location = new Point(161, 384);
            txtStartNode.Name = "txtStartNode";
            txtStartNode.Size = new Size(104, 23);
            txtStartNode.TabIndex = 43;
            // 
            // btnRemoveNode
            // 
            btnRemoveNode.Location = new Point(244, 86);
            btnRemoveNode.Name = "btnRemoveNode";
            btnRemoveNode.Size = new Size(75, 23);
            btnRemoveNode.TabIndex = 44;
            btnRemoveNode.Text = "Remove";
            btnRemoveNode.UseVisualStyleBackColor = true;
            btnRemoveNode.Click += btnRemoveNode_Click;
            // 
            // btnShowBFS
            // 
            btnShowBFS.Location = new Point(57, 413);
            btnShowBFS.Name = "btnShowBFS";
            btnShowBFS.Size = new Size(75, 39);
            btnShowBFS.TabIndex = 45;
            btnShowBFS.Text = "Show BFS Algorithm";
            btnShowBFS.UseVisualStyleBackColor = true;
            btnShowBFS.Click += btnShowBFS_Click;
            // 
            // btnShowDFSRecursive
            // 
            btnShowDFSRecursive.Location = new Point(219, 413);
            btnShowDFSRecursive.Name = "btnShowDFSRecursive";
            btnShowDFSRecursive.Size = new Size(75, 39);
            btnShowDFSRecursive.TabIndex = 46;
            btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm";
            btnShowDFSRecursive.UseVisualStyleBackColor = true;
            btnShowDFSRecursive.Click += btnShowDFSRecursive_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(490, 39);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(84, 23);
            btnRemoveAll.TabIndex = 47;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label29.Location = new Point(125, 347);
            label29.Name = "label29";
            label29.Size = new Size(114, 25);
            label29.TabIndex = 55;
            label29.Text = "Traversals";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label28.Location = new Point(139, 144);
            label28.Name = "label28";
            label28.Size = new Size(73, 25);
            label28.TabIndex = 54;
            label28.Text = "Edges";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label27.Location = new Point(149, 16);
            label27.Name = "label27";
            label27.Size = new Size(74, 25);
            label27.TabIndex = 53;
            label27.Text = "Nodes";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(60, 386);
            label26.Name = "label26";
            label26.Size = new Size(101, 20);
            label26.TabIndex = 52;
            label26.Text = "Node Start:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(58, 255);
            label25.Name = "label25";
            label25.Size = new Size(70, 20);
            label25.TabIndex = 51;
            label25.Text = "Weight:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(45, 221);
            label24.Name = "label24";
            label24.Size = new Size(81, 20);
            label24.TabIndex = 50;
            label24.Text = "Node To:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(25, 183);
            label22.Name = "label22";
            label22.Size = new Size(102, 20);
            label22.TabIndex = 49;
            label22.Text = "Node From:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(27, 53);
            label23.Name = "label23";
            label23.Size = new Size(107, 20);
            label23.TabIndex = 48;
            label23.Text = "Node Name:";
            // 
            // FromGrhaphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 542);
            Controls.Add(btnAddNode);
            Controls.Add(txtNode);
            Controls.Add(txtFrom);
            Controls.Add(txtTo);
            Controls.Add(btnAddEdge);
            Controls.Add(btnRemoveEdge);
            Controls.Add(txtGraphRepresentation);
            Controls.Add(txtWeight);
            Controls.Add(chkDirected);
            Controls.Add(btnShowDFS);
            Controls.Add(txtStartNode);
            Controls.Add(btnRemoveNode);
            Controls.Add(btnShowBFS);
            Controls.Add(btnShowDFSRecursive);
            Controls.Add(btnRemoveAll);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label22);
            Controls.Add(label23);
            Name = "FromGrhaphs";
            Text = "FromGrhaphs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNode;
        private TextBox txtNode;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnAddEdge;
        private Button btnRemoveEdge;
        private TextBox txtGraphRepresentation;
        private TextBox txtWeight;
        private CheckBox chkDirected;
        private Button btnShowDFS;
        private TextBox txtStartNode;
        private Button btnRemoveNode;
        private Button btnShowBFS;
        private Button btnShowDFSRecursive;
        private Button btnRemoveAll;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label22;
        private Label label23;
    }
}