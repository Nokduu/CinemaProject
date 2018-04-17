using Project.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DataTable dt = dbuse.MovieList();
            dataGridView1.DataSource = dt;
        }

    }
}
