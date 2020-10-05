namespace LabRab1SAPRKS
{
    partial class Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTheTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToolStripMenuItem,
            this.ShowTheTableToolStripMenuItem,
            this.AddRecordToolStripMenuItem,
            this.DeleteRecordToolStripMenuItem,
            this.CreatePDFToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.BackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ConnectToolStripMenuItem.Text = "Connect";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // ShowTheTableToolStripMenuItem
            // 
            this.ShowTheTableToolStripMenuItem.Name = "ShowTheTableToolStripMenuItem";
            this.ShowTheTableToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ShowTheTableToolStripMenuItem.Text = "Show the Table";
            this.ShowTheTableToolStripMenuItem.Click += new System.EventHandler(this.ShowTheTableToolStripMenuItem_Click);
            // 
            // AddRecordToolStripMenuItem
            // 
            this.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem";
            this.AddRecordToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.AddRecordToolStripMenuItem.Text = "Add Record";
            this.AddRecordToolStripMenuItem.Click += new System.EventHandler(this.AddRecordToolStripMenuItem_Click);
            // 
            // DeleteRecordToolStripMenuItem
            // 
            this.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem";
            this.DeleteRecordToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.DeleteRecordToolStripMenuItem.Text = "Delete Record";
            this.DeleteRecordToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecordToolStripMenuItem_Click);
            // 
            // CreatePDFToolStripMenuItem
            // 
            this.CreatePDFToolStripMenuItem.Name = "CreatePDFToolStripMenuItem";
            this.CreatePDFToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.CreatePDFToolStripMenuItem.Text = "Create PDF";
            this.CreatePDFToolStripMenuItem.Click += new System.EventHandler(this.CreatePDFToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripMenuItem.Image")));
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connect";
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreatePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowTheTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
    }
}