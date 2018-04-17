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

namespace Project.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Member_tbl memberTbl = new Member_tbl();
            memberTbl.id = TB_Id.Text;
            memberTbl.password = TB_password.Text;
            memberTbl.name = TB_Name.Text;
            memberTbl.phone = TB_phone.Text;
            memberTbl.address = TB_address.Text;

            DBUSE dbuse = new DBUSE();
            dbuse.SignUp(memberTbl);
        }
    }
}
