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
using System.Drawing.Drawing2D;

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

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }
    }
}
