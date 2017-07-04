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
            this.dropTablePanel = new System.Windows.Forms.Panel();
            this.dropDefinitionGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npcDropTablesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcDropTablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.dropTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDefinitionGridView)).BeginInit();
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
            this.loadDropsToolStripMenuItem.Size = new System.Drawing.Size(349, 42);
            this.loadDropsToolStripMenuItem.Text = "Load Drops";
            this.loadDropsToolStripMenuItem.Click += new System.EventHandler(this.loadDropsToolStripMenuItem_Click);
            // 
            // saveDropsToolStripMenuItem
            // 
            this.saveDropsToolStripMenuItem.Name = "saveDropsToolStripMenuItem";
            this.saveDropsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDropsToolStripMenuItem.Size = new System.Drawing.Size(349, 42);
            this.saveDropsToolStripMenuItem.Text = "Save Drops";
            this.saveDropsToolStripMenuItem.Click += new System.EventHandler(this.saveDropsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(346, 6);
            // 
            // loadItemsToolStripMenuItem
            // 
            this.loadItemsToolStripMenuItem.Name = "loadItemsToolStripMenuItem";
            this.loadItemsToolStripMenuItem.Size = new System.Drawing.Size(349, 42);
            this.loadItemsToolStripMenuItem.Text = "Load Items";
            this.loadItemsToolStripMenuItem.Click += new System.EventHandler(this.loadItemsToolStripMenuItem_Click);
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
            this.newTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTableToolStripMenuItem.Size = new System.Drawing.Size(342, 42);
            this.newTableToolStripMenuItem.Text = "New Table";
            this.newTableToolStripMenuItem.Click += new System.EventHandler(this.newTableToolStripMenuItem_Click);
            // 
            // newDropToolStripMenuItem
            // 
            this.newDropToolStripMenuItem.Name = "newDropToolStripMenuItem";
            this.newDropToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.newDropToolStripMenuItem.Size = new System.Drawing.Size(342, 42);
            this.newDropToolStripMenuItem.Text = "New Drop";
            this.newDropToolStripMenuItem.Click += new System.EventHandler(this.newDropToolStripMenuItem_Click);
            // 
            // dropTablePanel
            // 
            this.dropTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropTablePanel.Controls.Add(this.dropDefinitionGridView);
            this.dropTablePanel.Location = new System.Drawing.Point(247, 45);
            this.dropTablePanel.Name = "dropTablePanel";
            this.dropTablePanel.Size = new System.Drawing.Size(525, 476);
            this.dropTablePanel.TabIndex = 2;
            this.dropTablePanel.Visible = false;
            // 
            // dropDefinitionGridView
            // 
            this.dropDefinitionGridView.AutoGenerateColumns = false;
            this.dropDefinitionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dropDefinitionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dropRateDataGridViewTextBoxColumn});
            this.dropDefinitionGridView.DataSource = this.dropDefinitionBindingSource;
            this.dropDefinitionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDefinitionGridView.Location = new System.Drawing.Point(0, 0);
            this.dropDefinitionGridView.Name = "dropDefinitionGridView";
            this.dropDefinitionGridView.RowHeadersVisible = false;
            this.dropDefinitionGridView.RowTemplate.Height = 37;
            this.dropDefinitionGridView.Size = new System.Drawing.Size(525, 476);
            this.dropDefinitionGridView.TabIndex = 0;
            this.dropDefinitionGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dropTables_CellEndEdit);
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
            this.Controls.Add(this.dropTablePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PocketRogue Drop Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Shown += new System.EventHandler(this.MainForm_Show);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dropTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropDefinitionGridView)).EndInit();
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
        private System.Windows.Forms.Panel dropTablePanel;
        private System.Windows.Forms.DataGridView npcDropTablesDataGridView;
        private System.Windows.Forms.BindingSource npcDropTablesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dropDefinitionGridView;
        private System.Windows.Forms.BindingSource dropDefinitionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropRateDataGridViewTextBoxColumn;
    }
}

