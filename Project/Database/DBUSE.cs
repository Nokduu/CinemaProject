using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Project.Database;
using Project.Database.Model;

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

        public Movie_tbl MovieSelect(int Movie_No)
        {
            Movie_tbl movie = new Movie_tbl();

            movie.Movie_No = Movie_No;

            String sql = "";
            try
            {
                con.Open();
                sql += "SELECT Title, Genre, PlayDate, Time, Image FROM Movie_TBL WHERE Movie_No='"+Movie_No+"'";
                cmd = new OracleCommand(sql, con);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    movie.Title = Convert.ToString(reader.GetValue(0));
                    movie.genre = Convert.ToString(reader.GetValue(1));
                    movie.playdate = Convert.ToDateTime(reader.GetValue(2));
                    movie.time = Convert.ToDateTime(reader.GetValue(3));
                    movie.ImageFile = (byte[])reader.GetValue(4);
                }




            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }


            return movie;
        }

        public List<Movie_tbl> MovieList()
        {
            String sql = "SELECT Movie_No, Title, Genre, TO_CHAR(playdate,'YYYY-MM-DD'), TO_CHAR(time,'HH:MI'), Image FROM movie_tbl";
            Movie_tbl movie;
            List<Movie_tbl> list = new List<Movie_tbl>();
            OracleDataReader dataReader = null;
            try
            {
                con.Open();

                cmd = new OracleCommand(sql, con);
                dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    movie = new Movie_tbl();

                    movie.Movie_No = Convert.ToInt32(dataReader.GetValue(0));
                    movie.Title = Convert.ToString(dataReader.GetValue(1));
                    movie.genre = Convert.ToString(dataReader.GetValue(2));
                    movie.playdate = Convert.ToDateTime(dataReader.GetValue(3));
                    movie.time = Convert.ToDateTime(dataReader.GetValue(4));
                    movie.ImageFile = (byte[])dataReader.GetValue(5);


                    list.Add(movie);
                }


            }catch(Exception e)
            {
                MessageBox.Show(e + "");
            }
            finally
            {
                dataReader.Close();
                con.Close();
            }


            return list;
        }

        public int MovieUpdate(Movie_tbl movie_Tbl)
        {
            String sql = "";
            int chk = 0;

            try
            {
                con.Open();

                FileStream fs = new FileStream(movie_Tbl.Image, FileMode.Open, FileAccess.Read);
                byte[] Image = new byte[fs.Length];
                fs.Read(Image, 0, (int)fs.Length);
                fs.Close();

                sql += "UPDATE Movie_TBL SET Title =:Title, Genre =:Genre, PlayDate =:PlayDate, " +
                    "Time =:Time, Image =:Image WHERE Movie_No =:Movie_No";
                

                cmd = new OracleCommand(sql, con);

                cmd.Parameters.Add(":Movie_No", OracleDbType.Int32).Value = movie_Tbl.Movie_No;
                cmd.Parameters.Add(":Title", OracleDbType.Varchar2).Value = movie_Tbl.Title;
                cmd.Parameters.Add(":Genre", OracleDbType.Varchar2).Value = movie_Tbl.genre;
                cmd.Parameters.Add(":PlayDate", OracleDbType.Date).Value = movie_Tbl.playdate;
                cmd.Parameters.Add(":Time", OracleDbType.Date).Value = movie_Tbl.time;
                cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = Image;

                cmd.ExecuteNonQuery();
                MessageBox.Show("업데이트 성공");
            }
            catch (Exception e)
            {
                MessageBox.Show("업데이트 실패");
                Console.WriteLine(e);
                chk = 1;
            }
            finally
            {
                con.Close();
            }

            return chk;
        }

        public int MovieInsert(Movie_tbl movie_Tbl)
        {
            String sql = "";

            int chk = 0;

            try
            {
                con.Open();

                FileStream fs = new FileStream(movie_Tbl.Image, FileMode.Open, FileAccess.Read);
                byte[] Image = new byte[fs.Length];
                fs.Read(Image, 0, (int)fs.Length);
                fs.Close();

                sql += "INSERT INTO MOVIE_TBL (Movie_No, Title, Genre, PlayDate, Time, Image) ";
                sql += "VALUES (:Movie_no, :Title, :Genre, :PlayDate, " +
                    ":Time, :Image)";

                cmd = new OracleCommand(sql, con);

                cmd.Parameters.Add(":Movie_No", OracleDbType.Int32).Value = movie_Tbl.Movie_No;
                cmd.Parameters.Add(":Title", OracleDbType.Varchar2).Value = movie_Tbl.Title;
                cmd.Parameters.Add(":Genre", OracleDbType.Varchar2).Value = movie_Tbl.genre;
                cmd.Parameters.Add(":PlayDate", OracleDbType.Date).Value = movie_Tbl.playdate;
                cmd.Parameters.Add(":Time", OracleDbType.Date).Value = movie_Tbl.time;
                cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = Image;

                cmd.ExecuteNonQuery();
                MessageBox.Show("업로드 성공");
            }
            catch(Exception e)
            {
                MessageBox.Show("업로드 실패");
                Console.WriteLine(e);
                chk = 1;                
            }
            finally
            {
                con.Close();
            }
            return chk;
        }

        public void MovieDelete(int movie_no)
        {
            String sql = "";

            try
            {
                sql += "DELETE FROM MOVIE_TBL WHERE Movie_no='" + movie_no + "'";

                if(MessageBox.Show("정말 삭제하시겠습니까?", "영화 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new OracleCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("삭제 완료");
                }
                else
                {
                    return;
                }


            }catch(Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable CinemaList()
        {
            String sql = "";
            DataTable dt = null;
            try
            {
                con.Open();

                sql += "SELECT C.Cinema_No, C.name, T.Theater_No, S.Seat_No, S.Seat_row, S.Seat_col ";
                sql += "FROM Cinema_tbl C, Theater_tbl T, Seat_tbl S ";
                sql += "WHERE C.Cinema_No = T.Cinema_No AND T.Theater_No = S.Theater_No";

                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(sql, con);
                dt = new DataTable();
                oda.Fill(dt);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e + "");
            }



            return dt;
        }
    }
}
