using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace spoty2
{
    public partial class AdminMain : Form
    {
        string connectionString = null;
        SqlConnection connection = null;
        SqlCommand com;
        SqlDataAdapter data;
        DataTable dT;
        int LenTable;
        string sql;
        int index = 0;
        int selectedLine;
        string result;


            public AdminMain()
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                InitializeComponent();
                GetTrakcs();
                nextTrack();
                NewTable();

            }




        private void InfoLabel_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.ForeColor = Color.Pink;
            InfoLabel.Font = new System.Drawing.Font("Niagara Engraved", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void InfoLabel_MouseLeave(object sender, EventArgs e)
        {
            InfoLabel.ForeColor = Color.Pink;
            InfoLabel.Font = new System.Drawing.Font("Niagara Engraved", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Track: " + dT.Rows[index][6].ToString()
                + "\nSinger NickName: " + dT.Rows[index][4].ToString()
                + "\nSinger real name: " + dT.Rows[index][5].ToString()
                + "\nLENGTH:  " + dT.Rows[index][8].ToString()
                + "\nPlaylist: " + dT.Rows[index][2].ToString() + ", " + dT.Rows[index][3].ToString()
                + "\nAlbum: " + dT.Rows[index][1].ToString() + ", " + dT.Rows[index][0].ToString());



        }



        private void GetAndDhowData(string SQLQuery, DataGridView dataGrid)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            com = new SqlCommand(SQLQuery, connection);
            data = new SqlDataAdapter(com);
            dT = new DataTable();
            data.Fill(dT);
            dataGrid.DataSource = dT.DefaultView;
            LenTable = dT.Rows.Count;
            connection.Close();
        }

        private void NewTable()
        {

            sql = " SELECT dbo.album.album_year, dbo.album.album_name, dbo.playlist.playlist_name, dbo.playlist.playlist_year, dbo.singer.singer_name, dbo.singer.singer_surname, dbo.track.track_name, dbo.track.year_of, dbo.track.length"
                  + " FROM dbo.album INNER JOIN"
                  + " dbo.track ON dbo.album.album_id = dbo.track.album_id INNER JOIN"
                  + " dbo.playlist ON dbo.track.playlist_id = dbo.playlist.playlist_id INNER JOIN"
                  + " dbo.singer ON dbo.track.singer_id = dbo.singer.singer_id";




            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                com = new SqlCommand(sql, connection);
                data = new SqlDataAdapter(com);
                dT = new DataTable();
                data.Fill(dT);
                LenTable = dT.Rows.Count;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            tracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void GetTrakcs()
        {
            sql = " SELECT dbo.track.track_id, dbo.track.track_name, dbo.singer.singer_name, dbo.album.album_name, dbo.track.length"

                          + " FROM     dbo.album INNER JOIN"
                          + " dbo.track ON dbo.album.album_id = dbo.track.album_id INNER JOIN"
                          + " dbo.playlist ON dbo.track.playlist_id = dbo.playlist.playlist_id INNER JOIN"
                          + " dbo.singer ON dbo.track.singer_id = dbo.singer.singer_id";

            try
            {
                GetAndDhowData(sql, tracks);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            tracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void nextTrack()

        {
            NewTable();
            TrackNameLabel.Text = dT.Rows[index][6].ToString();
            SingerNameLabel.Text = dT.Rows[index][4].ToString();
        }

        private void nextLine()
        {

            if (selectedLine == LenTable - 1 )
            {
                tracks.ClearSelection();
                tracks.Rows[selectedLine].Cells[selectedLine].Selected = true;
            }
            else
            {
                selectedLine++;
                tracks.ClearSelection();
                tracks.Rows[selectedLine].Cells[selectedLine].Selected = true;
            }

        }

        private void backLine()
        {
            if (selectedLine == 0)
            {
                tracks.ClearSelection();
                tracks.Rows[selectedLine].Cells[selectedLine].Selected = true;
            }
            else
            {
                selectedLine--;
                tracks.ClearSelection();
                tracks.Rows[selectedLine].Cells[selectedLine].Selected = true;
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

            if (index >= LenTable - 1)
            {

            }
            else
            {
                index++;
                nextTrack();
            }

            nextLine();
            NewTable();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {


            if (index <= 0)
            {

            }
            else
            {
                index--;
                nextTrack();
            }

            backLine();
            NewTable();
        }

        private void AddButton_Click(object sender, EventArgs k)
        {

            AddForm addForm = new AddForm();
            addForm.Show();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            tracks.DataSource = null;
            tracks.Update();
            tracks.Refresh();
            GetTrakcs();
        }

        private void deleteTrack()
        {
            foreach (DataGridViewRow row in tracks.SelectedRows)
            {
                tracks.Rows.RemoveAt(row.Index);

                sql = "DELETE FROM track  WHERE track_id = 6;";
                

                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    com = new SqlCommand(sql, connection);
                    data = new SqlDataAdapter(com);
                    dT = new DataTable();
                    data.Fill(dT);
                    LenTable = dT.Rows.Count;
                    connection.Close();
                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            deleteTrack();
   
        }

        private void list_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                MessageBox.Show(s);
            }

        }
    
    }
}

     

