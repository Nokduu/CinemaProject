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
            List<Movie_tbl> list = dbuse.MovieList();

            Panel panel;

            MessageBox.Show(list.Count+"");
            for (int i = 0; i < list.Count; i++)
            {
                panel = new Panel();

                Label label = new Label();
                label.Text = list[i].Movie_No+"/"+list[i].Title;
                label.Dock = DockStyle.Top;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Arial", 18.0f);

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = new Bitmap(new MemoryStream(list[i].ImageFile,0,list[i].ImageFile.Length));
                pb.Dock = DockStyle.Top;


                panel.Controls.Add(label);
                panel.Controls.Add(pb);

                panel.Visible = true;

                FLP1.Controls.Add(panel);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMovieAdd ama = new AdminMovieAdd();
            ama.ShowDialog();
        }
    }
}
