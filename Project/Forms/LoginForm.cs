using Project.Forms;
using System;
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
    }
}
