using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 상영 정보 
    public class Cinema_Movie_tbl
    {
        // 영화관 번호 
        public int Cinema_No { get; set; }

        // 영화 번호 
        public int Movie_No { get; set; }

        // 시작일 
        public DateTime Start_date { get; set; }

        // 종료일 
        public DateTime End_date { get; set; }

        // Cinema_Movie_tbl 모델 복사
        public void CopyData(Cinema_Movie_tbl param)
        {
            this.Cinema_No = param.Cinema_No;
            this.Movie_No = param.Movie_No;
            this.Start_date = param.Start_date;
            this.End_date = param.End_date;
        }
    }
}