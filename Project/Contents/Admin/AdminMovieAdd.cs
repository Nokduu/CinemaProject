using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Database;
using Project.Database.Model;

namespace Project.Contents.Admin
{
    public partial class AdminMovieAdd : Form
    {
        AdminMovieContent content;
        public AdminMovieAdd(AdminMovieContent content)
        {
            InitializeComponent();
            this.content = content;
 
            DTP_playdate.Format = DateTimePickerFormat.Custom;
            DTP_playdate.CustomFormat = "yyyy-MM-dd";
            DTP_playdate.MinDate = DateTime.Today;


            DTP_time.Format = DateTimePickerFormat.Custom;
            DTP_time.CustomFormat = "HH:mm";
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
            catch (Exception ex) { Console.WriteLine(ex); }
            movie_Tbl.Title = TB_MovieTitle.Text;
            movie_Tbl.genre = TB_MovieGenre.Text;
            movie_Tbl.playdate = DTP_playdate.Value;
            movie_Tbl.time = DTP_time.Value;
            movie_Tbl.Image = openFileDialog1.FileName;

            DBUSE dbuse = new DBUSE();
            int chk = dbuse.MovieInsert(movie_Tbl);
            if (chk == 0)
            {
                content.selectList();
                this.Close();
            }
        }

    }
}
