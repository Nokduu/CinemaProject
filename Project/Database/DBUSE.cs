using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Project.Database;

namespace Project.Database
{
    class DBUSE
    {
        OracleConnection con;
        OracleCommand cmd;
        OracleDataReader reader;

        public DBUSE()
        {
            con = DB_Connect.DBConnect();

            cmd = new OracleCommand();
        }

        public void SignUp(Model.Member_tbl memberTbl)
        {
            String sql = "INSERT INTO Member_tbl (Member_No, id, password, name, phone, grade, address) VALUES (Member_TBL_SEQ.NEXTVAL, '"+ memberTbl.id+ "', '" + memberTbl.password + "', '" + memberTbl.name + "', '" + memberTbl.phone + "', '일반', '" + memberTbl.address + "')";

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e + "");
            }
            finally
            {
                con.Close();
            }
        }


        public int Login(Model.Member_tbl memberTbl)
        {
            
            String sql = "SELECT Member_No FROM Member_TBL WHERE id='"+memberTbl.id+"' AND password='"+ memberTbl.password+ "'";
            int Member_No = 0;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("로그인 성공!");
                    Member_No = Convert.ToInt32(reader.GetValue(0));
                }
                else
                {
                    MessageBox.Show("로그인 실패");
                }


            }catch(Exception e)
            {
                MessageBox.Show(e + "");
            }
            finally
            {
                if (!reader.IsClosed)
                {
                    reader.Close();
                }
                con.Close();

            }

            return Member_No;

        }

        public DataTable MovieList()
        {
            String sql = "SELECT * FROM movie_tbl";
            DataTable dt = null;
            OracleDataAdapter adapter;
            OracleCommandBuilder builder;
            try
            {
                con.Open();

                adapter = new OracleDataAdapter(sql, con);
                builder = new OracleCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);


            }catch(Exception e)
            {
                MessageBox.Show(e + "");
            }
            finally
            {
                con.Close();
            }


            return dt;
        }
    }
}
