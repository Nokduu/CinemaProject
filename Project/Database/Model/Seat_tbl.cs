using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 좌석 정보 
    public class Seat_tbl
    {
        // 좌석 번호 
        public int Seat_No { get; set; }

        // 상영관 번호 
        public int Theater_No { get; set; }

        // 좌석 행 
        public string Seat_row { get; set; }

        // 좌석 열 
        public string Seat_col { get; set; }

        // Seat_tbl 모델 복사
        public void CopyData(Seat_tbl param)
        {
            this.Seat_No = param.Seat_No;
            this.Theater_No = param.Theater_No;
            this.Seat_row = param.Seat_row;
            this.Seat_col = param.Seat_col;
        }
    }
}