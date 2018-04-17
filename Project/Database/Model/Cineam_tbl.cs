using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 영화관 정보 
    public class Cinema_tbl
    {
        // 영화관 번호 
        public int Cinema_No { get; set; }

        // 영화관 이름 
        public string name { get; set; }

        // Cinema_tbl 모델 복사
        public void CopyData(Cinema_tbl param)
        {
            this.Cinema_No = param.Cinema_No;
            this.name = param.name;
        }
    }
}