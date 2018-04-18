using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public void MovieInsert(Model.Movie_tbl movie_Tbl)
        {
            String sql = "";


            try
            {
                con.Open();

                FileStream fs = new FileStream(movie_Tbl.Image, FileMode.Open, FileAccess.Read);
                byte[] Image = new byte[fs.Length];
                fs.Read(Image, 0, (int)fs.Length);
                fs.Close();

                sql += "INSERT INTO MOVIE_TBL (Movie_No, Title, Genre, PlayDate, Time, Image) ";
                sql += "VALUES (:Movie_no, :Title, :Genre, TO_CHAR(TO_DATE(:PlayDate,'YYYY-MM-DD tt h:mm:ss'),'YYYY-MM-DD'), " +
                    "TO_CHAR(TO_DATE(:Time,'YYYY-MM-DD tt h:mm:ss'),'HH24:MI:SS'), :Image)";

                MessageBox.Show(movie_Tbl.playdate + "/" + movie_Tbl.time);
                cmd = new OracleCommand(sql, con);

                cmd.Parameters.Add(":Movie_No", OracleDbType.Int32).Value = movie_Tbl.Movie_No;
                cmd.Parameters.Add(":Title", OracleDbType.Varchar2).Value = movie_Tbl.Title;
                cmd.Parameters.Add(":Genre", OracleDbType.Varchar2).Value = movie_Tbl.genre;
                cmd.Parameters.Add(":PlayDate", OracleDbType.Varchar2).Value = movie_Tbl.playdate;
                cmd.Parameters.Add(":Time", OracleDbType.Varchar2).Value = movie_Tbl.time;
                cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = Image;

                cmd.ExecuteNonQuery();
                MessageBox.Show("업로드 성공");
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show("업로드 실패");
                MessageBox.Show(e+"");
                MessageBox.Show(sql);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
