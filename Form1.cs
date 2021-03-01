using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroverGamingCodeAssessment_GriffinFlaxman
{
    public enum QueryTask
    {
        Insert,
        Update,
        Delete
    }

    public partial class DirectoryForm : Form
    {
        private QueryTask Task { get; set; }

        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void DirectoryForm_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'employeeDirectory_GroverGamingDataSet.Directory' table. You can move, or remove it, as needed.
            FillDirectory();
        }

        private void LogMessage(int message)
        {
            var msg = string.Empty;
            switch (message)
            {
                case 0:
                    msg = "New Record Inserted.\r\n";
                    break;
                case 1:
                    msg = "Record Updated.\r\n";
                    break;
                case 2:
                    msg = "Record Deleted.\r\n";
                    break;
                default:
                    MessageBox.Show("An error occurred causing the operation to fail, please try again.");
                    break;
            }
            taskLog.Text += msg;
        }

        private void FillDirectory() => directoryTableAdapter.Fill(employeeDirectory_GroverGamingDataSet.Directory);

        private void DoCheck(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if its a new row
            if (string.IsNullOrEmpty(Directory.CurrentCell.Value.ToString()))
                Task = QueryTask.Insert;
            else
                Task = QueryTask.Update;

        }

        private void InsertAndUpdateRecord(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Task == QueryTask.Insert)
                {
                    var cells = Directory.CurrentRow.Cells;
                    if (!(string.IsNullOrEmpty(cells[0].Value.ToString()) || string.IsNullOrEmpty(cells[1].Value.ToString())))
                    {
                        directoryTableAdapter.Insert(cells[0].Value.ToString(), cells[1].Value.ToString());
                        LogMessage(0);
                    }
                }
                else if (Task == QueryTask.Update)
                {
                    if (Validate())
                    {
                        directoryTableAdapter.Update(employeeDirectory_GroverGamingDataSet.Directory);
                        LogMessage(1);
                    }
                    else
                    {
                        LogMessage(-1);
                    }
                }
                else
                {
                    LogMessage(-1);
                }
            }
            catch (Exception)
            {
                LogMessage(-1);
            }
        }

        private void DeleteRecord(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Delete))
                {
                    directoryTableAdapter.Delete(Convert.ToInt32(Directory.CurrentRow.Cells["ID"].Value), Directory.CurrentRow.Cells["nameColumn"].Value.ToString(),
                        Directory.CurrentRow.Cells["titleColumn"].Value.ToString());
                    FillDirectory();
                    LogMessage(2);
                }
            }
            catch (Exception)
            {
                LogMessage(-1);
            }
        }
    }
}
