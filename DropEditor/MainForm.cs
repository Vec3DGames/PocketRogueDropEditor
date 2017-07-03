using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DropEditor
{
    public partial class MainForm : Form
    {
        private List<ItemDefinition> itemDefintions;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prompts the user to select a drop table definitions file to work with
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Show(object sender, EventArgs e)
        {
            loadJsonFile("drops");
            loadJsonFile("items");
        }

        /// <summary>
        /// Prompts the user to select a JSON file to be used for either drop tables or
        /// item definitions.
        /// </summary>
        public void openJsonFile(string fileType)
        {
            //Prompt to select file.
            Stream fileStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFile.Filter = "json files (*.json)|*.json";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFile.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            using (var reader = new StreamReader(fileStream))
                            {
                                string json = reader.ReadToEnd();
                                string selectedPath = openFile.FileName;

                                if (fileType == "drops")
                                    Properties.Settings.Default.JsonFilePath = selectedPath;
                                if (fileType == "items")
                                    Properties.Settings.Default.ItemJsonFilePath = selectedPath;

                                Properties.Settings.Default.Save();
                                loadJsonFromString(json, fileType);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        //Load the json file from the settings property.
        private void loadJsonFile(string fileType)
        {
            Stream fileStream = null;
            try
            {
                string path = GetPathForFileType(fileType);
                if ((fileStream = File.OpenRead(path)) != null)
                {
                    using (fileStream)
                    {
                        using (var reader = new StreamReader(fileStream))
                        {
                            string json = reader.ReadToEnd();
                            loadJsonFromString(json, fileType);
                        }
                    }
                }
            }
            catch (Exception)
            {
                openJsonFile(fileType);
                //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private string GetPathForFileType(string fileType)
        {
            switch (fileType)
            {
                case "drops":
                    return Properties.Settings.Default.JsonFilePath;
                case "items":
                    return Properties.Settings.Default.ItemJsonFilePath;
                default:
                    return String.Empty;
            }
        }

        //Load the json file from a string.
        private void loadJsonFromString(string json, string fileType)
        {
            if (fileType == "drops")
            {
                List<NpcDropDefinition> defs = JsonConvert.DeserializeObject<List<NpcDropDefinition>>(json);
                npcDropTablesBindingSource.DataSource = defs;
                npcDropTablesDataGridView.ClearSelection();
            }
            if (fileType == "items")
            {
                itemDefintions = JsonConvert.DeserializeObject<List<ItemDefinition>>(json);
            }
        }

        private void loadDropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JsonFilePath = "";
            Properties.Settings.Default.Save();
            openJsonFile("drops");
        }

        private void npcDropTables_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateRowSelected(e.RowIndex);
        }

        private void updateRowSelected(int rowIndex)
        {
            npcDropTablesDataGridView.Rows[rowIndex].Selected = true;
            npcDropTablesDataGridView.Focus();
            DataGridViewRow row = npcDropTablesDataGridView.Rows[rowIndex];
            if (row.Selected)
            {
                dropTablePanel.Visible = true;
                dropTablePanel.Refresh();
                dropTablePanel.Show();
                refreshNpcDropsTable(row);
            }
        }

        private void refreshNpcDropsTable(DataGridViewRow rowSelected)
        {
            NpcDropDefinition dropDefinition = (NpcDropDefinition)rowSelected.DataBoundItem;
            List<DropDefinition> drops = dropDefinition.Drops;
            dropDefinitionBindingSource.DataSource = drops;
        }

        /// <summary>
        /// Creates a new drop table for the specified entity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTableForm newTableForm = new NewTableForm();
            newTableForm.addTableButton.Click += addTableButton_Click;
            newTableForm.ShowDialog(this);
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            NewTableForm newTableForm = ((Button)sender).TopLevelControl as NewTableForm;
            int id = Convert.ToInt32(newTableForm.idTextBox.Text);
            string name = newTableForm.nameTextBox.Text;
            NpcDropDefinition dropTable = new NpcDropDefinition(id, name, new List<DropDefinition>());
            npcDropTablesBindingSource.Add(dropTable);
            npcDropTablesDataGridView.Refresh();
            newTableForm.Close();
            NotifySaveNeeded();
        }

        private void NotifySaveNeeded()
        {
            isSaveNeeded = true;
            if (!Text.Contains("*"))
                Text += "*";
        }

        private void NotifySaveDone()
        {
            isSaveNeeded = false;
            Text = Text.Trim('*');
        }

        private bool isSaveNeeded = false;

        private void dropTables_CellEndEdit(object sender, EventArgs e)
        {
            NotifySaveNeeded();
        }

        private void saveDropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<NpcDropDefinition> dropTables = (List<NpcDropDefinition>)npcDropTablesBindingSource.DataSource;
            string json = JsonConvert.SerializeObject(dropTables, Formatting.Indented);
            File.WriteAllText(Properties.Settings.Default.JsonFilePath, json);
            NotifySaveDone();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (isSaveNeeded)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close without saving? " +
                    "The drops will not be saved", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void newDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dropTablePanel.Visible)
                return;

            List<string> itemNames = itemDefintions?.Select(itemDefinition => itemDefinition.Name).ToList();
            List<string> itemIds = itemDefintions?.Select(itemDefinition => itemDefinition.Id.ToString()).ToList();

            NewDropForm newDropForm = new NewDropForm();

            AutoCompleteStringCollection itemNameAutoComplete = new AutoCompleteStringCollection();
            itemNameAutoComplete.AddRange(itemNames?.ToArray());
            AutoCompleteStringCollection itemIdAutoComplete = new AutoCompleteStringCollection();
            itemIdAutoComplete.AddRange(itemIds?.ToArray());

            newDropForm.nameTextBox.AutoCompleteCustomSource = itemNameAutoComplete;
            newDropForm.nameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            newDropForm.nameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            newDropForm.nameTextBox.KeyDown += nameTextBox_KeyEnter;

            newDropForm.idTextBox.AutoCompleteCustomSource = itemIdAutoComplete;
            newDropForm.idTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            newDropForm.idTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            newDropForm.idTextBox.KeyDown += idTextBod_KeyEnter;

            newDropForm.ShowDialog(this);
        }

        private void addDropButton_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                string name = box.Text;
                int id = itemDefintions.Where(itemDefinition => itemDefinition.Name.ToLower().Equals(name.ToLower())).Select(itemDefinition => itemDefinition.Id).FirstOrDefault();
                NewDropForm newDropForm = box.TopLevelControl as NewDropForm;
                newDropForm.idTextBox.Text = id.ToString();
            }
        }

        private void idTextBod_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                TextBox box = sender as TextBox;
                int id = Convert.ToInt32(box.Text);
                string name = itemDefintions.Where(itemDefinition => itemDefinition.Id == id).Select(itemDefinition => itemDefinition.Name).FirstOrDefault();
                NewDropForm newDropForm = box.TopLevelControl as NewDropForm;
                newDropForm.nameTextBox.Text = name;
            }
        }

        /// <summary>
        /// Attempts to load item definitions to enable auto-complete on adding new drops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ItemJsonFilePath = "";
            Properties.Settings.Default.Save();
            openJsonFile("items");
        }
    }
}
