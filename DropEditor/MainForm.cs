using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropEditor
{
    public partial class MainForm : Form
    {
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
            string path = Properties.Settings.Default.JsonFilePath;
            if (String.IsNullOrEmpty(path))
            {
                openJsonFile();
                return;
            }

            loadJsonFile();
        }

        public void openJsonFile()
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
                                Properties.Settings.Default.JsonFilePath = selectedPath;
                                Properties.Settings.Default.Save();
                                loadJsonFile(json);
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
        private void loadJsonFile()
        {
            Stream fileStream = null;
            try
            {
                if ((fileStream = File.OpenRead(Properties.Settings.Default.JsonFilePath)) != null)
                {
                    using (fileStream)
                    {
                        using (var reader = new StreamReader(fileStream))
                        {
                            string json = reader.ReadToEnd();
                            loadJsonFile(json);
                        }
                    }
                }
            }
            catch (Exception)
            {
                openJsonFile();
                //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        //Load the json file from a string.
        private void loadJsonFile(string json)
        {
            List<NpcDropDefinition> defs = JsonConvert.DeserializeObject<List<NpcDropDefinition>>(json);
            this.npcDropTablesBindingSource.DataSource = defs;
            this.npcDropTablesDataGridView.ClearSelection();
            //this.itemDefinitionBindingSource.DataSource = defs;
            //this.itemGridView.ClearSelection();
            //this.itemGridView.Rows[1].Selected = true;
        }

        private void loadDropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JsonFilePath = "";
            Properties.Settings.Default.Save();
            //loadJsonFile();
        }

        private void npcDropTables_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
