using Project.Database;
using Project.Database.Model;
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

namespace Project.Contents.Admin
{
    public partial class AdminMovieContent : Form
    {
        DBUSE dbuse;


        public AdminMovieContent()
        {
            InitializeComponent();
            dbuse = new DBUSE();
            selectList();
        }

        public void selectList()
        {
            FLP1.Controls.Clear();
            List<Movie_tbl> list = dbuse.MovieList();

            Panel panel;

            for (int i = 0; i < list.Count; i++)
            {
                panel = new Panel();
                panel.BackColor = Color.White;
                panel.Height = 300;
                panel.Width = 200;
                

                Label No_Title = new Label();
                No_Title.Text = list[i].Movie_No+"/"+list[i].Title;
                No_Title.Dock = DockStyle.Top;
                No_Title.TextAlign = ContentAlignment.MiddleCenter;

                PictureBox pb = new PictureBox();
                pb.Height = 200;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(new MemoryStream(list[i].ImageFile,0,list[i].ImageFile.Length));
                pb.Dock = DockStyle.Top;

                Label genre = new Label();
                genre.Text = list[i].genre;
                genre.Dock = DockStyle.Top;
                genre.TextAlign = ContentAlignment.MiddleCenter;

                Label times = new Label();
                times.Text = "상영날짜:"+list[i].playdate + "/상영 시간:" + list[i].time;
                times.Dock = DockStyle.Top;
                times.TextAlign = ContentAlignment.MiddleLeft;


                Panel btn_panel = new Panel();
                btn_panel.Height = 25;
                btn_panel.Width = 200;
                btn_panel.Dock = DockStyle.Top;

                Button btn_update = new Button();
                btn_update.Click += new System.EventHandler(this.movie_update);
                btn_update.Tag = list[i].Movie_No;
                btn_update.Dock = DockStyle.Left;
                btn_update.Margin = new Padding(15, 0, 0, 0);

                Button btn_delete = new Button();
                btn_delete.Click += new System.EventHandler(this.movie_delete);
                btn_delete.Tag = list[i].Movie_No;
                btn_delete.Dock = DockStyle.Right;
                btn_delete.Margin = new Padding(0, 0, 15, 0);



                btn_panel.Controls.Add(btn_delete);
                btn_panel.Controls.Add(btn_update);

                panel.Controls.Add(btn_panel);
                panel.Controls.Add(times);
                panel.Controls.Add(genre);
                panel.Controls.Add(pb);
                panel.Controls.Add(No_Title);

                panel.Visible = true;

                FLP1.Controls.Add(panel);
            }

        }
        private void movie_delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Tag + "");
        }

        private void movie_update(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int movie_no = 0;
            try
            {
                movie_no = Convert.ToInt32(btn.Tag);
            }catch(Exception ex) { Console.WriteLine(ex); }

            AdminMovieUpdate amu = new AdminMovieUpdate(this,movie_no);
            MessageBox.Show(btn.Tag+"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMovieAdd ama = new AdminMovieAdd(this);
            ama.ShowDialog();
        }
    }
}
