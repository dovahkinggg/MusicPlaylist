using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlaylist
{
    public partial class Form1 : Form
    {
        String connectionString = "Data source=music.db;Version=3";
        SQLiteConnection connection;
        List<string> allTrackTitles;
        OpenFileDialog openFileDialog;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*"; //allows user to browse and select a music file.
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String createTableSQL = "Create table if not exists Tracks(" +
                "Track_Title Text primary key," +
                "Artist Text," +
                "Release_Date integer," +
                "Music_Style Text," +
                "Language Text," +
                "Photo Text," +
                "MP3_Path Text," +
                "Play_Count integer default 0)";
            SQLiteCommand command = new SQLiteCommand(createTableSQL, connection);
            command.ExecuteNonQuery();

            String selectIDsSQL = "Select Track_Title from Tracks";
            SQLiteCommand command2 = new SQLiteCommand(selectIDsSQL, connection);
            SQLiteDataReader sQLiteDataReaderreader = command2.ExecuteReader();
            allTrackTitles = new List<string>();
            while (sQLiteDataReaderreader.Read())
            {
                AvailableTracks_cb.Items.Add(sQLiteDataReaderreader.GetString(0));
                allTrackTitles.Add(sQLiteDataReaderreader.GetString(0));
            }
            
            connection.Close();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            // Validate that required textboxes have values
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            // Validate that textBox4 and textBox5 contain integers
            if (!long.TryParse(textBox3.Text, out long release_date))
            {
                MessageBox.Show("Release Date must be valid integer.");
                return;
            }
            //validate that it ends with jpg jpeg png
            Uri uriResult;
            if (!Uri.TryCreate(textBox6.Text, UriKind.Absolute, out uriResult) ||
                (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps) ||
                !(textBox6.Text.ToLower().EndsWith(".jpeg") ||
                  textBox6.Text.ToLower().EndsWith(".jpg") ||
                  textBox6.Text.ToLower().EndsWith(".png")))
            {
                MessageBox.Show("Photo URL must be a valid URL ending with '.jpeg' '.png' or '.jpg'.");
                return;
            }
            // Show file dialog to select an MP3 file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string currentRelativePath = Environment.CurrentDirectory;
                //Console.WriteLine(currentRelativePath);
                //Console.WriteLine(openFileDialog.FileName);
                // Get the selected file path and save it to the database

                // Get the selected file path
                string absoluteFilePath = openFileDialog.FileName;

                // Convert absolute path to relative path
                string currentDirectory = Environment.CurrentDirectory;
                string relativeFilePath = MakeRelativePath(currentDirectory, absoluteFilePath);
                textBox7.Text = openFileDialog.FileName;
            }

            connection.Open();

            SQLiteTransaction transaction = connection.BeginTransaction();
            //efoson ola einai swsta tote ta kanei insert sto db 
            try
            {
                String insertSQL = "INSERT INTO Tracks(" +
                    "Track_Title, Artist, Release_Date, Music_Style, Language, Photo, MP3_Path)" +
                    "VALUES(@track_title, @artist, @release_date, @music_style, @language, @photo, @mp3_path)";
                SQLiteCommand insertCommand = new SQLiteCommand(insertSQL, connection);
                insertCommand.Parameters.AddWithValue("track_title", textBox1.Text);
                insertCommand.Parameters.AddWithValue("artist", textBox2.Text);
                insertCommand.Parameters.AddWithValue("release_date", release_date);
                insertCommand.Parameters.AddWithValue("music_style", textBox4.Text);
                insertCommand.Parameters.AddWithValue("language", textBox5.Text);
                insertCommand.Parameters.AddWithValue("photo", textBox6.Text);
                insertCommand.Parameters.AddWithValue("mp3_path", textBox7.Text);
                int rowsInserted = insertCommand.ExecuteNonQuery();

                transaction.Commit();

                String selectIDsSQL = "SELECT Track_Title FROM Tracks";
                SQLiteCommand selectCommand = new SQLiteCommand(selectIDsSQL, connection);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                AvailableTracks_cb.Items.Clear();
                while (reader.Read())
                {
                    AvailableTracks_cb.Items.Add(reader.GetString(0));
                }
                MessageBox.Show(" record inserted");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            pictureBox1.Load(textBox6.Text);

            // Clear the form fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;
        }

        private void AvailableTracks_cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //open db
            connection.Open();
            String selectIDsSQL = "Select * from Tracks where Track_Title=@track_title";
            SQLiteCommand command2 = new SQLiteCommand(selectIDsSQL, connection);
            command2.Parameters.AddWithValue("@track_title", AvailableTracks_cb.Text);
            SQLiteDataReader sQLiteDataReaderreader = command2.ExecuteReader();
            {
                while (sQLiteDataReaderreader.Read())
                {
                    textBox1.Text = sQLiteDataReaderreader.GetString(0);  // Track_Title
                    textBox2.Text = sQLiteDataReaderreader.GetString(1);  // Artist
                    textBox3.Text = sQLiteDataReaderreader.GetInt32(2).ToString();  // Release Date
                    textBox4.Text = sQLiteDataReaderreader.GetString(3);  // Music Style
                    textBox5.Text = sQLiteDataReaderreader.GetString(4); // Language
                    textBox6.Text = sQLiteDataReaderreader.GetString(5);  // Photo
                    textBox7.Text = sQLiteDataReaderreader.GetString(6);  // Mp3_path
                    pictureBox1.Load(textBox6.Text);
                }
            }
            connection.Close();
            PlaySelectedSong();
        }
        private void PlaySelectedSong()
        {
            // Get the MP3 path from the database
            string mp3Path = GetSelectedTrackMP3Path(); //textBox7.Text;

            // Increment play count in the database
            UpdatePlayCount(AvailableTracks_cb.SelectedItem.ToString());

            // Play the selected track
            if (!string.IsNullOrEmpty(mp3Path) && File.Exists(mp3Path)) //checks if the string is null or empty & if the file exists at the path
            {
                mediaPlayer.URL = mp3Path; // load and play the mp3 file
                mediaPlayer.Ctlcontrols.play(); // gives access to the media player controls
                DisplayMostPlayedSongs(); // Refresh the list when a song is played
            }
            else
            {
                MessageBox.Show("Invalid MP3 file path or file not found.");
            }
        }

        private void UpdatePlayCount(string trackTitle)
        {
            // Update the play count in the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                String updatePlayCountSQL = "UPDATE Tracks SET Play_Count = Play_Count + 1 WHERE Track_Title = @track_title";
                using (SQLiteCommand updatePlayCountCommand = new SQLiteCommand(updatePlayCountSQL, connection))
                {
                    updatePlayCountCommand.Parameters.AddWithValue("@track_title", trackTitle);
                    updatePlayCountCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPaused || mediaPlayer.playState == WMPPlayState.wmppsStopped)
            {

                mediaPlayer.Ctlcontrols.play();
                //DisplayMostPlayedSongs(); // Refresh the list when a song is played
            }
        }

        private void pause_btn_Click_1(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                mediaPlayer.Ctlcontrols.pause();
            }
        }

        private void stop_btn_Click_1(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsPlaying ||
                mediaPlayer.playState == WMPPlayState.wmppsPaused)
            {
                mediaPlayer.Ctlcontrols.stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ensure the media player is stopped and released when the form is closing
            mediaPlayer.Ctlcontrols.stop();
            mediaPlayer.close();
        }

        private string GetSelectedTrackMP3Path()
        {
            // Retrieve the MP3 file path for the selected track
            string selectedTrackTitle = AvailableTracks_cb.SelectedItem.ToString();
            string selectMP3PathSQL = "SELECT MP3_Path FROM Tracks WHERE Track_Title=@track_title";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();  // Open the connection locally
                using (SQLiteCommand command = new SQLiteCommand(selectMP3PathSQL, connection))
                {
                    command.Parameters.AddWithValue("@track_title", selectedTrackTitle);
                    object result = command.ExecuteScalar();
                    connection.Close();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            // Clear the form fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (AvailableTracks_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a song to delete.");
                return;
            }

            // Open database connection
            connection.Open();

            // Get the selected track title
            string selectedTrackTitle = AvailableTracks_cb.SelectedItem.ToString();

            // Delete the track from the database
            String deleteSQL = "DELETE FROM Tracks WHERE Track_Title=@track_title";
            SQLiteCommand deleteCommand = new SQLiteCommand(deleteSQL, connection);
            deleteCommand.Parameters.AddWithValue("@track_title", selectedTrackTitle);

            // Execute the delete command
            int rowsAffected = deleteCommand.ExecuteNonQuery();

            // Clear the textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;

            // Reload the combo box
            String selectIDsSQL = "SELECT Track_Title FROM Tracks";
            SQLiteCommand command2 = new SQLiteCommand(selectIDsSQL, connection);
            SQLiteDataReader reader = command2.ExecuteReader();
            AvailableTracks_cb.Items.Clear();
            allTrackTitles.Clear();
            while (reader.Read())
            {
                AvailableTracks_cb.Items.Add(reader.GetString(0));
                allTrackTitles.Add(reader.GetString(0));
            }

            if (rowsAffected > 0)
            {
                MessageBox.Show("Selected song deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete the selected song.");
            }

            connection.Close();
        }

        private void shuffle_btn_Click(object sender, EventArgs e)
        {
            if (AvailableTracks_cb.Items.Count == 0)
            {
                MessageBox.Show("No available tracks to shuffle.");
                return;
            }

            // Generate a random index within the range of available tracks
            int randomIndex = random.Next(AvailableTracks_cb.Items.Count);

            // Select the track at the random index
            AvailableTracks_cb.SelectedIndex = randomIndex;

            // Display the information of the selected song
            AvailableTracks_cb_SelectedIndexChanged_1(sender, e);

            // Play the selected song
            play_btn_Click(sender, e);
        }

        private void DisplayMostPlayedSongs()
        {
            // Query the database to get songs sorted by play count in descending order
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                String selectMostPlayedSQL = "SELECT Track_Title, Play_Count FROM Tracks ORDER BY Play_Count DESC";
                using (SQLiteCommand selectMostPlayedCommand = new SQLiteCommand(selectMostPlayedSQL, connection))
                {
                    using (SQLiteDataReader reader = selectMostPlayedCommand.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            string trackTitle = reader.GetString(0);
                            int playCount = reader.GetInt32(1);
                            listBox1.Items.Add($"{trackTitle} - Play Count: {playCount}");
                        }
                    }
                }
                connection.Close();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            {
                // Validate that a song is selected
                if (AvailableTracks_cb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a song to update.");
                    return;
                }

                // validation
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) ||
                    string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // validate that textBox3 has an integer
                if (!long.TryParse(textBox3.Text, out long release_date))
                {
                    MessageBox.Show("Release Date must be a valid integer.");
                    return;
                }

                // validate that textBox6 contains a valid URL
                Uri uriResult;
                if (!Uri.TryCreate(textBox6.Text, UriKind.Absolute, out uriResult) ||
                    (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps))
                {
                    MessageBox.Show("Photo URL must be a valid URL.");
                    return;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the textBox7 (MP3 Path) with the selected file, or select same file
                    textBox7.Text = openFileDialog.FileName;
                }
                connection.Open();

                SQLiteTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Perform the update query
                    String updateSQL = "UPDATE Tracks SET " +
                        "Artist=@artist, Release_Date=@release_date, Music_Style=@music_style, " +
                        "Language=@language, Photo=@photo, MP3_Path=@mp3_path " +
                        "WHERE Track_Title=@track_title";

                    SQLiteCommand updateCommand = new SQLiteCommand(updateSQL, connection);
                    updateCommand.Parameters.AddWithValue("@track_title", AvailableTracks_cb.SelectedItem.ToString());
                    updateCommand.Parameters.AddWithValue("@artist", textBox2.Text);
                    updateCommand.Parameters.AddWithValue("@release_date", release_date);
                    updateCommand.Parameters.AddWithValue("@music_style", textBox4.Text);
                    updateCommand.Parameters.AddWithValue("@language", textBox5.Text);
                    updateCommand.Parameters.AddWithValue("@photo", textBox6.Text);
                    updateCommand.Parameters.AddWithValue("@mp3_path", textBox7.Text);

                    int rowsUpdated = updateCommand.ExecuteNonQuery();

                    transaction.Commit();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        // Function to convert absolute path to relative path
        private static string MakeRelativePath(string fromPath, string toPath)
        {
            var fromUri = new Uri(fromPath);
            var toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme)
            {
                return toPath;
            }

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }
    }
}
