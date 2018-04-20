using Project.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Project.Database.Model;

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
            Member_tbl member_Tbl = new Member_tbl();
            member_Tbl.id = TB_id.Text;
            member_Tbl.password = TB_pw.Text;
            member_Tbl.Member_No = dbuse.Login(member_Tbl);
            if(member_Tbl.Member_No != 0)
            {
                if (member_Tbl.id.Equals("admin") || member_Tbl.password.Equals("admin"))
                {
                    AdminForm adminForm = new AdminForm(member_Tbl);
                    adminForm.Show();
                    this.Close();
                }
                else
                {
                    MainForm mainForm = new MainForm(member_Tbl);
                    mainForm.Show();
                    this.Close();

                }
            }
        }
        
        private void BT_register_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                      , int nTopRect
                                                      , int nRightRect
                                                      , int nBottomRect
                                                      , int nWidthEllipse
                                                      , int nHeightEllipse);

    
    }
}
