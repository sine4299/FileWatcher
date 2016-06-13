/*
 * Name: Caleb Gray
 *
 * Description: Gui program that produces a interface for a file watcher. The files or directories are 
 * watcher for changes and then reported to a widow on screen. the user then has the option to wirte 
 * the file information to a SQLite database. The users has controls to append to the current database 
 * as well as clearing the content of the existing DB.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class Watcher : Form
    {   
        public Watcher()
        {
            InitializeComponent();
        }

        private FileSystemWatcher watcher;

        private delegate void ObjectDelegate(object obj);

        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        private DataSet dataSet;
        private DataTable filesWatchedTable;
        private DataRow row;

        private QueryWindow query;

        public void Run(string filename)
        {
            watcher = new FileSystemWatcher();
            watcher.Path = filename;

            // Sets the filters fro what the file watcher is checking for
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //Gets the extension selected by the user and sets the filter
            string ext = extensionComboBox.GetItemText(extensionComboBox.SelectedItem);
            watcher.Filter = "*" + ext;

            // Adds the envents to watch for to the event handler 
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            string pathName = e.FullPath;
            string filename = Path.GetFileName(pathName);
            string changed = e.ChangeType.ToString();
            string ext = Path.GetExtension(pathName);
            // currTime.LastAccessTIme will have a data type of DateTime
            FileInfo currTime = new FileInfo(pathName);

            //Builds the message to be displayed in the textbox
            string message = "File: " + filename +
                             " Path: " + pathName + " " + changed + " Date: " + currTime.LastAccessTime;

            // Allows for the writing of text to a textbox,
            // i.e. safe hadling of CrossThreadException.
            ObjectDelegate del = new ObjectDelegate(UpdateTextBox);
            del.Invoke(message);

            // Adds a row to the table with the info on the changes to a file.
            if(filesWatchedTable == null)
            {
                createTable();
            }
            row = filesWatchedTable.NewRow();
            row["file_name"] = filename;
            row["path_name"] = pathName;
            row["event_occurred"] = changed;
            row["day_time"] = currTime.LastAccessTime;
            row["extension"] = ext;
            filesWatchedTable.Rows.Add(row);

        }
        private void OnRenamed(object source, RenamedEventArgs e)
        {
            string oldPath = e.OldFullPath;
            string newPath = e.FullPath;
            string filename = Path.GetFileName(oldPath);
            string changed = e.ChangeType.ToString();
            string ext = Path.GetExtension(newPath);
            // currTime.LastAccessTIme will have a data type of DateTime
            FileInfo currTime = new FileInfo(oldPath);
            string message = "File: " + filename + " Renamed "
                             + Path.GetFileName(newPath) + " Path: " + newPath + " " +
                             e.ChangeType + " Date: " + currTime.LastAccessTime;

            // Allows for the writing of text to a textbox,
            // i.e. safe hadling of CrossThreadException.
            ObjectDelegate del = new ObjectDelegate(UpdateTextBox);
            del.Invoke(message);

            // Adds a row to the table with the info on the renamed file.
            if (filesWatchedTable == null)
            {
                createTable();
            }
            row = filesWatchedTable.NewRow();
            row["file_name"] = filename;
            row["path_name"] = newPath;
            row["event_occurred"] = changed;
            row["day_time"] = currTime.LastAccessTime;
            row["extension"] = ext;
            filesWatchedTable.Rows.Add(row);

        }

        private void createTable()
        {
            // Creates a table with columns for the file name, 
            // the event that occurred(renamed, changed, deleted created), 
            // date and time, and extention. 
            dataSet = new DataSet("dataset");
            filesWatchedTable = new DataTable("Files_Watched");

            
            DataColumn column;

            // Creates column for the file name and adds to the table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "file_name";
            column.ReadOnly = true;
            column.Unique = true;
            filesWatchedTable.Columns.Add(column);

            // Creates column for the path name and adds to the table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "path_name";
            column.ReadOnly = true;
            column.Unique = true;
            filesWatchedTable.Columns.Add(column);

            // Creates column for the event that occurred and adds to the table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "event_occurred";
            column.ReadOnly = true;
            column.Unique = true;
            filesWatchedTable.Columns.Add(column);

            // Creates column for the date and time and adds to the table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "day_time";
            column.ReadOnly = true;
            column.Unique = true;
            filesWatchedTable.Columns.Add(column);

            // Creates column for the extension and adds to the table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "extension";
            column.ReadOnly = true;
            column.Unique = true;
            filesWatchedTable.Columns.Add(column);

            dataSet.Tables.Add(filesWatchedTable);
            dataSet.EnforceConstraints = false;
        }

        //showTable used for testing the Datatable for correct entries
        private void showTable()
        {
            foreach (DataColumn col in filesWatchedTable.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            foreach (DataRow row in filesWatchedTable.Rows)
            {
                foreach (DataColumn col in filesWatchedTable.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-14:C}", row[col]);
                    else
                        Console.Write("{0,-14}", row[col]);
                }
            }
        }

        // Delegate created to avoid Illegeal Cross Thread Expection when writing to the text box.
        private void UpdateTextBox(object obj)
        {
            if (InvokeRequired)
            {
                ObjectDelegate method = new ObjectDelegate(UpdateTextBox);
                Invoke(method, obj);
                return;
            }
            string text = (string)obj + "\n";
            logWindowTextBox.AppendText(text);
        }
        #region User inout validation
        /*
         * USER INPUT VALIDATION
         */
        private void directoryTextBox_Validated(object sender, EventArgs e)
        {
            directoryErrorProvider.SetError(directoryTextBox, "");
        }

        private void directoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidateDirectory(directoryTextBox.Text, out errorMsg))
            {
                e.Cancel = true;
                directoryTextBox.Select(0, directoryTextBox.Text.Length);
                this.directoryErrorProvider.SetError(directoryTextBox, errorMsg);
            }
        }
        public bool ValidateDirectory(string directory, out string errorMsg)
        {
            if(directory.Length == 0)
            {
                errorMsg = "Directory required";
                return false;
            }
            if (Directory.Exists(directory))
            {
                errorMsg = "";
                return true;
            }
            errorMsg = "You must enter a valid directory path.";
            return false;
        }

        // Starts the file watcher and diables the start button and enables the stop button
        private void startWatch_Click(object sender, EventArgs e)
        {
            Run(directoryTextBox.Text);
            stopWatcher.Enabled = true;
            startWatch.Enabled = false;
        }

        // Kills the file watcher and disables the stop button and re-enables the start button 
        private void stopWatcher_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            stopWatcher.Enabled = false;
            startWatch.Enabled = true;
        }
        #endregion

        #region Database stuff
        /*
         * SQLITE DATABASE STUFF
         */
        private void writeDatabaseButton_Click(object sender, EventArgs e)
        {
            //showTable();
            writeToSQL();
            querybutton.Enabled = true;
            clearTableButton.Enabled = true;
        }
        private void clearTableButton_Click(object sender, EventArgs e)
        {
            clearDatabase();
            clearTableButton.Enabled = false;
            querybutton.Enabled = false;

        }
        private void writeToSQL()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
                sqlite_conn.Open();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS files_watched (file_name varchar(50), path_name varchar(100), event_occurred varchar(10), day_time date, extension varchar(10));";
                sqlite_cmd.ExecuteNonQuery();

                var adapter = new SQLiteDataAdapter("select * from files_watched", sqlite_conn);
                var builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(dataSet, "Files_Watched");

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void clearDatabase()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
                sqlite_conn.Open();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DROP TABLE IF EXISTS files_watched;";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            query = new QueryWindow();
            query.Show();
            queryDatabase();
        }

        private void queryDatabase()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
                sqlite_conn.Open();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM files_watched WHERE extension='" + queryComboBox.Text + "\'";

                SQLiteDataReader reader = sqlite_cmd.ExecuteReader(); 
                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ReadSingleRow(IDataRecord record)
        {
            string result = String.Format("{0}, {1}, {2}, {3}, {4}",
                                          record[0], record[1], record[2], record[3], record[4]) + "\n";
            query.printToQueryLog(result);
        }
        #endregion

        #region Menu bar controls
        /*
         * MENU BAR CONTROLS
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                startWatch_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("File watcher is already running");
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                stopWatcher_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("File watcher is not currently running");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "File Watcher is designed to watch\n" +
                                  "directories for changed made to files.\n\n" +
                                  "Version: 1.0\n" +
                                  "Developed by: Caleb Gray";
            MessageBox.Show(aboutMessage);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                clearTableButton_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                writeDatabaseButton_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                querybutton_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Watcher_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripButton_Click(object sender, EventArgs e)
        {
            startWatch_Click(sender, e);
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            stopWatcher_Click(sender, e);
        }

        private void writeToolStripButton_Click(object sender, EventArgs e)
        {
            writeDatabaseButton_Click(sender, e);
        }
    }
}
