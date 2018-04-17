using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 상영 일정 
    public class Time_tbl
    {
        // 상영 번호 
        public int Time_No { get; set; }

        // 시작 시간 
        public string Start_time { get; set; }

        // 종료 시간 
        public string End_time { get; set; }

        // 상영일 
        public DateTime Movie_Date { get; set; }

        // 상영 회차 
        public int Movie_cnt { get; set; }

        // 영화관 번호 
        public int Cinema_No { get; set; }

        // 영화 번호 
        public int Movie_No { get; set; }

        // Time_tbl 모델 복사
        public void CopyData(Time_tbl param)
        {
            this.Time_No = param.Time_No;
            this.Start_time = param.Start_time;
            this.End_time = param.End_time;
            this.Movie_Date = param.Movie_Date;
            this.Movie_cnt = param.Movie_cnt;
            this.Cinema_No = param.Cinema_No;
            this.Movie_No = param.Movie_No;
        }
    }
}