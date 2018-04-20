using Project.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        Database.DBUSE dbuse;

        public LoginForm()
        {
            InitializeComponent();
            dbuse = new Database.DBUSE();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 50, 50));
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            Database.Model.Member_tbl memberTbl = new Database.Model.Member_tbl();
            memberTbl.id = TB_id.Text;
            memberTbl.password = TB_pw.Text;
            memberTbl.Member_No = dbuse.Login(memberTbl);

            if (memberTbl.Member_No != 0)
            {
                if (memberTbl.id.Equals("admin") && memberTbl.password.Equals("admin"))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Program.ac.MainForm = adminForm;
                    this.Close();
                }
                else
                {
                    MainForm mainForm = new MainForm(memberTbl);
                    mainForm.Show();
                    Program.ac.MainForm = mainForm;
                    this.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.ShowDialog();
        }

        private void BT_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                      , int nTopRect
                                                      , int nRightRect
                                                      , int nBottomRect
                                                      , int nWidthEllipse
                                                      , int nHeightEllipse);

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BT_register_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
