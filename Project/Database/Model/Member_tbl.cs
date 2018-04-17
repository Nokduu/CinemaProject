using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 회원 정보 
    public class Member_tbl
    {
        // 회원 번호 
        public int Member_No { get; set; }

        // 아이디 
        public string id { get; set; }

        // 비밀번호 
        public string password { get; set; }

        // 이름 
        public string name { get; set; }

        // 전화번호 
        public string phone { get; set; }

        // 회원 등급 
        public string grade { get; set; }

        // 주소 
        public string address { get; set; }

        // Member_tbl 모델 복사
        public void CopyData(Member_tbl param)
        {
            this.Member_No = param.Member_No;
            this.id = param.id;
            this.password = param.password;
            this.name = param.name;
            this.phone = param.phone;
            this.grade = param.grade;
            this.address = param.address;
        }
    }
}