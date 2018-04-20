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
using Project.Database;
using Project.Database.Model;

namespace Project.Contents.Admin
{
    public partial class AdminMovieUpdate : Form
    {
        DBUSE dbuse;
        AdminMovieContent content;
        public AdminMovieUpdate(AdminMovieContent content, int movie_no)
        {
            InitializeComponent();
            this.content = content;

            dbuse = new DBUSE();
            Movie_tbl movie_Tbl = new Movie_tbl();
            movie_Tbl = dbuse.MovieSelect(movie_no);

            DTP_playdate.Format = DateTimePickerFormat.Custom;
            DTP_playdate.CustomFormat = "yyyy-MM-dd";

            DTP_time.Format = DateTimePickerFormat.Custom;
            DTP_time.CustomFormat = "HH:mm";

            MessageBox.Show(movie_Tbl.Movie_No + "/" + movie_Tbl.Title + "/" + movie_Tbl.genre + "/" + movie_Tbl.playdate + "/" + movie_Tbl.time);
            TB_MovieNo.Text = movie_Tbl.Movie_No.ToString();
            TB_MovieTitle.Text = movie_Tbl.Title;
            TB_MovieGenre.Text = movie_Tbl.genre;
            DTP_playdate.MinDate = movie_Tbl.playdate;
            DTP_time.MinDate = movie_Tbl.time;
            pictureBox1.Image = new Bitmap(new MemoryStream(movie_Tbl.ImageFile, 0, movie_Tbl.ImageFile.Length));
            
        }

        private void BTN_image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            content.selectList();
            this.Close();
        }

        private void Insert_Movie(object sender, EventArgs e)
        {
            Movie_tbl movie_Tbl = new Movie_tbl();


            try
            {
                movie_Tbl.Movie_No = Convert.ToInt32(TB_MovieNo.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
            movie_Tbl.Title = TB_MovieTitle.Text;
            movie_Tbl.genre = TB_MovieGenre.Text;
            movie_Tbl.playdate = DTP_playdate.Value;
            movie_Tbl.time = DTP_time.Value;
            movie_Tbl.Image = openFileDialog1.FileName;

            int chk = dbuse.MovieInsert(movie_Tbl);
            if (chk == 0)
            {
                content.selectList();
                this.Close();
            }
        }
    }
}
