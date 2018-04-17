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
    public partial class AdminMovieAdd : Form
    {
        String FileName;
        String FilePath;
        public AdminMovieAdd()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.MinDate = DateTime.Today;

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.ShowCheckBox = false;
            dateTimePicker2.ShowUpDown = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
