using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 상영관 정보 
    public class Theater_tbl
    {
        // 상영관 번호 
        public int Theater_No { get; set; }

        // 영화관 번호 
        public int Cinema_No { get; set; }

        // Theater_tbl 모델 복사
        public void CopyData(Theater_tbl param)
        {
            this.Theater_No = param.Theater_No;
            this.Cinema_No = param.Cinema_No;
        }
    }
}