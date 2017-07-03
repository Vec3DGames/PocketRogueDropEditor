namespace DropEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npcDropTablesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcDropTablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDefinitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDropTablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDropTablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDropsToolStripMenuItem,
            this.saveDropsToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadItemsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDropsToolStripMenuItem
            // 
            this.loadDropsToolStripMenuItem.Name = "loadDropsToolStripMenuItem";
            this.loadDropsToolStripMenuItem.Size = new System.Drawing.Size(262, 42);
            this.loadDropsToolStripMenuItem.Text = "Load Drops";
            this.loadDropsToolStripMenuItem.Click += new System.EventHandler(this.loadDropsToolStripMenuItem_Click);
            // 
            // saveDropsToolStripMenuItem
            // 
            this.saveDropsToolStripMenuItem.Name = "saveDropsToolStripMenuItem";
            this.saveDropsToolStripMenuItem.Size = new System.Drawing.Size(262, 42);
            this.saveDropsToolStripMenuItem.Text = "Save Drops";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // loadItemsToolStripMenuItem
            // 
            this.loadItemsToolStripMenuItem.Name = "loadItemsToolStripMenuItem";
            this.loadItemsToolStripMenuItem.Size = new System.Drawing.Size(262, 42);
            this.loadItemsToolStripMenuItem.Text = "Load Items";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTableToolStripMenuItem,
            this.newDropToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(78, 41);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newTableToolStripMenuItem
            // 
            this.newTableToolStripMenuItem.Name = "newTableToolStripMenuItem";
            this.newTableToolStripMenuItem.Size = new System.Drawing.Size(248, 42);
            this.newTableToolStripMenuItem.Text = "New Table";
            // 
            // newDropToolStripMenuItem
            // 
            this.newDropToolStripMenuItem.Name = "newDropToolStripMenuItem";
            this.newDropToolStripMenuItem.Size = new System.Drawing.Size(248, 42);
            this.newDropToolStripMenuItem.Text = "New Drop";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(247, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 476);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dropRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dropDefinitionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(525, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dropRateDataGridViewTextBoxColumn
            // 
            this.dropRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dropRateDataGridViewTextBoxColumn.DataPropertyName = "DropRate";
            this.dropRateDataGridViewTextBoxColumn.HeaderText = "DropRate";
            this.dropRateDataGridViewTextBoxColumn.Name = "dropRateDataGridViewTextBoxColumn";
            // 
            // dropDefinitionBindingSource
            // 
            this.dropDefinitionBindingSource.DataSource = typeof(DropEditor.DropDefinition);
            // 
            // npcDropTablesDataGridView
            // 
            this.npcDropTablesDataGridView.AllowUserToAddRows = false;
            this.npcDropTablesDataGridView.AutoGenerateColumns = false;
            this.npcDropTablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.npcDropTablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.npcDropTablesDataGridView.DataSource = this.npcDropTablesBindingSource;
            this.npcDropTablesDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.npcDropTablesDataGridView.Location = new System.Drawing.Point(0, 45);
            this.npcDropTablesDataGridView.Name = "npcDropTablesDataGridView";
            this.npcDropTablesDataGridView.ReadOnly = true;
            this.npcDropTablesDataGridView.RowHeadersVisible = false;
            this.npcDropTablesDataGridView.RowTemplate.Height = 37;
            this.npcDropTablesDataGridView.Size = new System.Drawing.Size(240, 476);
            this.npcDropTablesDataGridView.TabIndex = 3;
            this.npcDropTablesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.npcDropTables_CellMouseDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // npcDropTablesBindingSource
            // 
            this.npcDropTablesBindingSource.DataSource = typeof(DropEditor.NpcDropDefinition);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 521);
            this.Controls.Add(this.npcDropTablesDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PocketRogue Drop Editor";
            this.Shown += new System.EventHandler(this.MainForm_Show);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDefinitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDropTablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDropTablesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDropsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDropsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDropToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView npcDropTablesDataGridView;
        private System.Windows.Forms.BindingSource npcDropTablesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dropDefinitionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropRateDataGridViewTextBoxColumn;
    }
}

