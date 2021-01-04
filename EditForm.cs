using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Diagnostics;

namespace CinemaVault
{
    public partial class EditForm : Form
    {
        SqlConnection connection;
        string connectionString;
        static FetchData fetch = new FetchData();
        static string apiKey = Environment.GetEnvironmentVariable("CinemaVault_Key");
        static bool btnClicked = false;

        public EditForm(int id, string name, string genre, string description, string year, int rating, string recommend, string posterUrl)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundWinform.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //rounds the corners of the form
            connectionString = ConfigurationManager.ConnectionStrings["TvMovieDatabase.Properties.Settings.DBConnectionString"].ConnectionString;
            
            showYearComboBox.Items.Add("N/A");
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                showYearComboBox.Items.Add(i);
            }
            idTextBox.Text = Convert.ToString(id);
            showNameTextBox.Text = name;
            showGenreComboBox.Text = genre; 
            showRatingNumericUpDown.Value = rating;
            if (recommend.Contains('Y'))
            {
                yesRadio.Checked = true;
            }
            else
            {
                noRadio.Checked = true;
            }
            showDescriptionTextBox.Text = description;
            showYearComboBox.Text = year;
            labelPosterUrl.Text = posterUrl;

            try
            {
                if (posterUrl != "N/A")     //checks if image is present upon opening the edit form
                {
                    var request = WebRequest.Create(posterUrl);
                    using (var answer = request.GetResponse())
                    using (var stream = answer.GetResponseStream())
                    {
                        imageBox.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Network issue found." + "\r\n" + "Image cannot be loaded without internet source. Restore Connection to load image.",
                            "No network connection found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE ShowDbTable " +
                            "SET ShowName = @ShowName, ShowGenre = @ShowGenre, ShowRating = @ShowRating, ShowRecommend =@ShowRecommend, " +
                            "ShowDescription = @ShowDescription, ShowYear =@ShowYear, ShowPoster =@ShowPoster " +
                            "WHERE Id ="+idTextBox.Text;
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

            if (string.IsNullOrEmpty(showNameTextBox.Text))
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
                if (imageBox.Image != null & btnClicked == true)                            //assigns new image
                {
                    command.Parameters.AddWithValue("ShowPoster", fetch.Poster);
                }
                else if (imageBox.Image != null & btnClicked == false)                      //keeps same image
                    command.Parameters.AddWithValue("ShowPoster", labelPosterUrl.Text);
                else
                    command.Parameters.AddWithValue("ShowPoster", "N/A");                   //no image was applied before editing

                command.ExecuteNonQuery();
                connection.Close();
                Close();

                MessageBox.Show("Entry has been edited!","Edit Confirmation");               
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientSetup(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com/?apikey=" + apiKey + "/");
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
                MessageBox.Show("Please insert title.", "Empty search field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                HttpResponseMessage response = null;
                if (showYearComboBox.SelectedItem == null)      //picks between the two based on if a year was supplied prior to fetching
                {
                    response = client.GetAsync("?apikey=" + apiKey + "&t=" + showNameTextBox.Text + "&y&plot=short&director&actors&poster").Result;
                }
                else
                {
                    response = client.GetAsync("?apikey=" + apiKey + "&t=" + showNameTextBox.Text + "&y=" + showYearComboBox.SelectedItem + "&plot=short&director&actors&poster").Result;
                }
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        fetch = await response.Content.ReadAsAsync<FetchData>();
                        string editedActors = fetch.Actors.Replace(", ", " | ");
                    
                        showPlot.Visible = true;
                    
                        if (fetch.Title != null || fetch.Year != null || fetch.Poster != null)
                        {
                            string editedYear = fetch.Year.Substring(0, Math.Min(fetch.Year.Length, 4));
                            showYearComboBox.Text = editedYear;
                            var request = WebRequest.Create(fetch.Poster);
                            using (var answer = request.GetResponse())
                            using (var stream = answer.GetResponseStream())
                            {
                                imageBox.Image = Image.FromStream(stream);
                                showYearComboBox.Text = fetch.Year;
                                btnClicked = true;
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Boxart/Cover artwork not found for title." + "\r\n" + "Are the Title and Year correct? " +
                            "Select N/A if you do not know the year.",
                            "Artwork not found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    catch (Exception ex) when (ex is UriFormatException || ex is WebException || ex is NullReferenceException)
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

        private void ShowPlot_CheckedChanged(object sender, EventArgs e)    //once the Re-fetch button is pressed -> enables checkbox in order
        {                                                                 //to prevent wiping custom comments beforehand when fetching new data
            
            if (showPlot.Checked == true)
            {
                string editedActors = fetch.Actors.Replace(", ", " | ");
                showDescriptionTextBox.Text = "Director: " + fetch.Director + "\r\n" + "\r\n" + "Actors: " + editedActors + "\r\n" + "\r\n" + fetch.Plot;
            }
            else
                showDescriptionTextBox.Text = null;
        }

        private void ShowNameTextBox_TextChanged(object sender, EventArgs e)        //resets year's box to N/A if the textbox is emptied
        {                                                                           //(possibly searching for different title) to allow searches to made when the year is not known
            while (string.IsNullOrEmpty(showNameTextBox.Text))
            {
                showYearComboBox.SelectedIndex = 0;
                return;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
