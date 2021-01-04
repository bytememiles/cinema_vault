using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaVault
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundWinform.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //rounds the corners of the form
        }

        private void ShowDbTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showDbTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'databaseDataSet.ShowDbTable' table. You can move, or remove it, as needed.
            this.showDbTableTableAdapter.Fill(this.databaseDataSet.ShowDbTable);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            this.showDbTableTableAdapter.Update(this.databaseDataSet.ShowDbTable);            
            this.showDbTableTableAdapter.Fill(this.databaseDataSet.ShowDbTable);
        }

        public void BtnEdit_Click(object sender, EventArgs e)   //passes data from current row to edit form
        {
            try
            {
                EditForm editForm = new EditForm(Convert.ToInt32(showDbTableDataGridView.SelectedRows[0].Cells[0].Value.ToString()),//id
                                                showDbTableDataGridView.SelectedRows[0].Cells[1].Value.ToString(),                  //name
                                                showDbTableDataGridView.SelectedRows[0].Cells[2].Value.ToString(),                  //genre
                                                showDbTableDataGridView.SelectedRows[0].Cells[6].Value.ToString(),                  //description
                                                showDbTableDataGridView.SelectedRows[0].Cells[3].Value.ToString(),                  //recommend
                                                Convert.ToInt32(showDbTableDataGridView.SelectedRows[0].Cells[4].Value.ToString()), //rating
                                                showDbTableDataGridView.SelectedRows[0].Cells[5].Value.ToString(),                  //year
                                                showDbTableDataGridView.SelectedRows[0].Cells[7].Value.ToString());                 //posterurl
                editForm.ShowDialog();
                this.showDbTableTableAdapter.Update(this.databaseDataSet.ShowDbTable);
                this.showDbTableTableAdapter.Fill(this.databaseDataSet.ShowDbTable);               
            }

            catch(Exception ex) when(ex is NullReferenceException || ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid option: Please select a row to edit!", "Error");
            }
            
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int EntryId = Convert.ToInt32(showDbTableDataGridView.SelectedRows[0].Cells[0].Value.ToString());   //grabs current ID and title of the row
                string selectedShow = showDbTableDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                int selectedIndex = showDbTableDataGridView.CurrentCell.RowIndex;                                   //grabs index of current row
                DialogResult choice = MessageBox.Show("Are you sure that you want to delete this entry?" + "\r\n" + "Name of Title: " +
                   selectedShow, "Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    if (selectedIndex > -1)
                    {                        
                        DeleteSQLquery(EntryId);
                        showDbTableDataGridView.Rows.RemoveAt(selectedIndex);                        
                        showDbTableDataGridView.Refresh();
                        this.databaseDataSet.ShowDbTable.AcceptChanges();
                        this.showDbTableTableAdapter.Fill(this.databaseDataSet.ShowDbTable);
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex) when (ex is NullReferenceException || ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid option: Please select a row to delete!", "Error");
            }
        }

        public void DeleteSQLquery(int id)
        {
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["TvMovieDatabase.Properties.Settings.DBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            string Query = "DELETE FROM ShowDbTable WHERE Id=" + id;
            SqlCommand command = new SqlCommand(Query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)    //Mouse enter and leave events are for hover effect of exit/minimize
        {
            btnClose.Image = Properties.Resources.HoverClose;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.NormalClose;
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.MiniHover;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.MiniNormal;
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    DataView dv = this.databaseDataSet.ShowDbTable.DefaultView;
                    dv.RowFilter = string.Format("ShowName like '%{0}%'", searchBox.TextName);
                    showDbTableDataGridView.DataSource = dv.ToTable();
                }
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid search criteria", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = this.databaseDataSet.ShowDbTable.DefaultView;
                dv.RowFilter = string.Format("ShowName like '%{0}%'", searchBox.TextName);
                showDbTableDataGridView.DataSource = dv.ToTable();
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid search criteria", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a personal project in which I learned how to interact with a database table " +
                "via adding, editing, and deleting records. Through the process, I learned the basics of RESTful API services; " +
                "in which OMDBapi was applied to retrieve data for the shows and their posters."+"\r\n"+"\r\n"+
                "Credits: OMDb API and JControl tools via CustomUI on youtube", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is used to store information about movies/tv shows that you've watched " +
                "and whether you found them recommendable to others."+"\r\n"+"\r\n"+
                "Add: Add an entry to the database."+"\r\n"+"\r\n"+
                "Edit/View: Edit submitted entries or simply view details from the selected entry."+"\r\n"+"\r\n"+
                "Delete: Delete an entry from the database."+"\r\n"+"\r\n"+
                "Key Icon: Used to establish the fetch feature found in the Add and Edit window.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            DataView dv = this.databaseDataSet.ShowDbTable.DefaultView;
            dv.RowFilter = string.Format("ShowName like '%{0}%'", "");
            showDbTableDataGridView.DataSource = dv.ToTable();
        }

        private void SetApiKey_Click(object sender, EventArgs e)
        {
            ApiForm apiForm = new ApiForm();
            apiForm.ShowDialog();           
        }
    }
}
