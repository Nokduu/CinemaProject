using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    // 영화 정보 
    // 영화 정보 
    public class Movie_tbl
    {
        // 영화 번호 
        public int Movie_No { get; set; }

        // 영화 제목 
        public string Title { get; set; }

        // 영화 장르 
        public string genre { get; set; }

        // 개봉일 
        public DateTime playdate { get; set; }

        // 상영 시간 
        public DateTime time { get; set; }

        // 이미지 경로 
        public string Image { get; set; }

        public byte[] ImageFile { get; set; }

        // Movie_tbl 모델 복사
        public void CopyData(Movie_tbl param)
        {
            this.Movie_No = param.Movie_No;
            this.Title = param.Title;
            this.genre = param.genre;
            this.playdate = param.playdate;
            this.time = param.time;
            this.Image = param.Image;
        }
    }
}