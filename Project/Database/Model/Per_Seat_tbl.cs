using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 좌석 일정 
    public class Per_Seat_tbl
    {
        // 좌석 번호 
        public int Seat_No { get; set; }

        // 상영 번호 
        public int Time_No { get; set; }

        // 예약 여부 
        public string Seat_Status { get; set; }

        // Per_Seat_tbl 모델 복사
        public void CopyData(Per_Seat_tbl param)
        {
            this.Seat_No = param.Seat_No;
            this.Time_No = param.Time_No;
            this.Seat_Status = param.Seat_Status;
        }
    }
}