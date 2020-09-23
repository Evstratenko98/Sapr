namespace LabRab1SAPRKS
{
    partial class LabRabCAD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabRabCAD));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTreeDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteObjectToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // DeleteObjectToolStripMenuItem1
            // 
            this.DeleteObjectToolStripMenuItem1.Name = "DeleteObjectToolStripMenuItem1";
            this.DeleteObjectToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.DeleteObjectToolStripMenuItem1.Text = "Delete Object";
            this.DeleteObjectToolStripMenuItem1.Click += new System.EventHandler(this.DeleteObjectToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "doc.bmp");
            this.imageList1.Images.SetKeyName(1, "pdf.bmp");
            this.imageList1.Images.SetKeyName(2, "txt.bmp");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTreeToolStripMenuItem,
            this.CreateTreeDriveToolStripMenuItem,
            this.AddObjectToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateTreeToolStripMenuItem
            // 
            this.CreateTreeToolStripMenuItem.Name = "CreateTreeToolStripMenuItem";
            this.CreateTreeToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.CreateTreeToolStripMenuItem.Text = "Create Tree (Programm)";
            this.CreateTreeToolStripMenuItem.Click += new System.EventHandler(this.CreateTreeToolStripMenuItem_Click);
            // 
            // CreateTreeDriveToolStripMenuItem
            // 
            this.CreateTreeDriveToolStripMenuItem.Name = "CreateTreeDriveToolStripMenuItem";
            this.CreateTreeDriveToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.CreateTreeDriveToolStripMenuItem.Text = "Create Tree (Drive)";
            this.CreateTreeDriveToolStripMenuItem.Click += new System.EventHandler(this.CreateTreeDriveToolStripMenuItem_Click);
            // 
            // AddObjectToolStripMenuItem
            // 
            this.AddObjectToolStripMenuItem.Name = "AddObjectToolStripMenuItem";
            this.AddObjectToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.AddObjectToolStripMenuItem.Text = "Add Object";
            this.AddObjectToolStripMenuItem.Click += new System.EventHandler(this.AddObjectToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(212, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 426);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(209, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 426);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // LabRabCAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LabRabCAD";
            this.Text = "LabRabCAD";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTreeDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddObjectToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteObjectToolStripMenuItem1;
    }
}

