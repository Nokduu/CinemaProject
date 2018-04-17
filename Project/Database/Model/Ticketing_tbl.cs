using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 티켓 정보 
    public class Ticketing_tbl
    {
        // 티켓 번호 
        public int Ticketing_No { get; set; }

        // 영화 번호 
        public int Movie_No { get; set; }

        // 회원 번호 
        public int Member_No { get; set; }

        // 영화관 번호 
        public int Cinema_No { get; set; }

        // 상영 번호 
        public int Time_No { get; set; }

        // 가격 
        public int Price { get; set; }

        // 인원 수 
        public int People { get; set; }

        // Ticketing_tbl 모델 복사
        public void CopyData(Ticketing_tbl param)
        {
            this.Ticketing_No = param.Ticketing_No;
            this.Movie_No = param.Movie_No;
            this.Member_No = param.Member_No;
            this.Cinema_No = param.Cinema_No;
            this.Time_No = param.Time_No;
            this.Price = param.Price;
            this.People = param.People;
        }
    }
}