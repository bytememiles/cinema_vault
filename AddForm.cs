using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaVault
{
    public partial class AddForm : Form
    {
        SqlConnection connection;
        string connectionString;
        static FetchData fetch = new FetchData();
        static string apiKey = Environment.GetEnvironmentVariable("CinemaVault_Key");

        public AddForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundWinform.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //rounds the corners of the form          
            connectionString = ConfigurationManager.ConnectionStrings["TvMovieDatabase.Properties.Settings.DBConnectionString"].ConnectionString;
        }

        private void ShowDbTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showDbTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void ShowDbTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.showDbTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            showYearComboBox.Items.Add("N/A");
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {      
                    showYearComboBox.Items.Add(i);                   
            }

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {           
            string Query = "INSERT INTO ShowDbTable (ShowName, ShowGenre, ShowRating, ShowRecommend, ShowDescription, ShowYear, ShowPoster) " +
                                         "VALUES (@ShowName, @ShowGenre, @ShowRating, @ShowRecommend, @ShowDescription, @ShowYear, @ShowPoster)";
            
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(Query, connection);

            char showRec;
            if (yesRadio.Checked == true)
            {
                showRec = 'Y';
            }
            else
            {
                showRec = 'N';
            }

            if (String.IsNullOrEmpty(showNameTextBox.Text) || showGenreComboBox.SelectedItem == null)
            {
                MessageBox.Show("Name and Genre cannot be empty");
                return;
            }
            else
            {       
                    connection.Open();
                    command.Parameters.AddWithValue("ShowName", showNameTextBox.Text);
                    command.Parameters.AddWithValue("ShowGenre", showGenreComboBox.SelectedItem);
                    command.Parameters.AddWithValue("ShowRating", showRatingNumericUpDown.Value);
                    command.Parameters.AddWithValue("ShowRecommend", showRec);
                    command.Parameters.AddWithValue("ShowDescription", showDescriptionTextBox.Text);
                    if (showYearComboBox.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("ShowYear", showYearComboBox.SelectedItem);                       
                    }
                    else
                        command.Parameters.AddWithValue("ShowYear", "N/A");
                    if(imageBox.Image != null)
                    { 
                        command.Parameters.AddWithValue("ShowPoster", fetch.Poster);
                    }
                    else
                        command.Parameters.AddWithValue("ShowPoster", "N/A");

                    command.ExecuteNonQuery();
                    connection.Close();
                
                    Close();                    
            }                      
        }

        private void ClientSetup(HttpClient httpClient)
        {
            
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com/?apikey="+apiKey+"/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void FetchImage_Click(object sender, EventArgs e)
        {                       
            HttpClient client = new HttpClient();

            if (string.IsNullOrEmpty(showNameTextBox.Text) != true)
            {
                ClientSetup(client);
            }
            else
            {
                MessageBox.Show("Please insert title.","Empty search field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                HttpResponseMessage response = null;
                if (showYearComboBox.SelectedItem == null)      //picks between the two based on if a year was supplied prior to fetching
                {
                     response = client.GetAsync("?apikey="+apiKey+"&t=" + showNameTextBox.Text + "&y&plot=short&director&actors&poster").Result;
                }
                else
                {
                     response = client.GetAsync("?apikey="+apiKey+"&t=" + showNameTextBox.Text + "&y="+showYearComboBox.SelectedItem+"&plot=short&director&actors&poster").Result;
                }
                if (response.IsSuccessStatusCode)
                {
                    fetch = await response.Content.ReadAsAsync<FetchData>();
                    
                    if (showPlot.Checked == true)
                    {
                        string editedActors = fetch.Actors.Replace(", ", " | ");
                        showDescriptionTextBox.Text = "Director: " + fetch.Director + "\r\n" + "\r\n" + "Actors: " + editedActors + "\r\n" + "\r\n" + fetch.Plot;
                    }
                    try
                    {
                        
                        if (fetch.Title != null || fetch.Year != null || fetch.Poster != null)
                        {
                            
                            string editedYear = fetch.Year.Substring(0, Math.Min(fetch.Year.Length, 4));
                            showYearComboBox.Text = editedYear;
                            var request = WebRequest.Create(fetch.Poster);
                            using (var answer = request.GetResponse())
                            using (var stream = answer.GetResponseStream())
                            {
                                imageBox.Image = Image.FromStream(stream);
                                showYearComboBox.Text = editedYear;
                            }         
                        }
                        else
                        {
                            MessageBox.Show("Boxart/Cover artwork not found for title." + "\r\n" + "Are the Title and Year correct? " +
                                "Select N/A if you do not know the year.",
                            "Artwork not found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    catch (Exception ex) when(ex is UriFormatException || ex is WebException)
                    {
                        MessageBox.Show("Boxart/Cover artwork not found for title." + "\r\n" + "Are the Title and Year correct? " +
                                "Select N/A if you do not know the year.",
                            "Artwork not found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Key not supplied, unable to fetch information. Click on the key icon located in the bottom right corner " +
                        "on the home screen to insert your key " +
                        "to use this feature.", "401 unauthorized");
                    return;
                }
            }
            catch (AggregateException)
            {
                MessageBox.Show("Network issue found." + "\r\n" + "Cannot fetch data without internet source. Restore Connection to use feature.",
                            "No network connection found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)        //clears last search upon cancelling; appeared to have kept cache search upon re-entering
        {            
            fetch.Plot = null;
            fetch.Director = null; 
            fetch.Actors = null;
            Close();
        }

        private void ShowPlot_CheckedChanged(object sender, EventArgs e)
        {                          
                if (showPlot.Checked == true & string.IsNullOrEmpty(fetch.Title)!=true & string.IsNullOrEmpty(fetch.Actors) != true)
                {
                    string editedActors = fetch.Actors.Replace(", ", " | ");
                    showDescriptionTextBox.Text = "Director: " + fetch.Director + "\r\n" + "\r\n" + "Actors: " + editedActors + "\r\n" + "\r\n" + fetch.Plot;
                }
                else
                    showDescriptionTextBox.Text = null;       
        }

        private void ShowNameTextBox_TextChanged(object sender, EventArgs e)    //resets year's box to N/A if the textbox is emptied
        {                                                                       //(possibly searching for different title) to allow searches to made when the year is not known
            while (string.IsNullOrEmpty(showNameTextBox.Text))
            {
                showYearComboBox.SelectedIndex = 0;
                return;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)        //Mouse enter and leave events are for hover effect of exit/minimize
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
    }
}
