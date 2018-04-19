using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Database.Model;
using Project.Database;

namespace Project.Contents.Admin
{
    public partial class AdminCinemaContent : Form
    {
        DBUSE dbuse;
        public AdminCinemaContent()
        {
            InitializeComponent();
            dbuse = new DBUSE();
            selectList();
        }

        public void selectList()
        {
            dataGridView1.DataSource = dbuse.CinemaList();

        }

    }
}
