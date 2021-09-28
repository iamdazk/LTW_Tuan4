using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//Câu 1: Lấy người chơi thuộc team A và có số điểm Score >=25.
//Câu 2: Sắp xếp tên người chơi theo số điểm Score tăng dần.
//Câu 3: Lấy ra tên 2 người chơi có số điểm cao nhất .
//Câu 4: Lấy ra tên các team và số điểm Score trung bình của team đó.
//Câu 5: Lấy ra danh sách người chới có kí tự ‘n’ và không phân biệt hoa thường.

namespace BaiTap
{
    public class Player
    {
        public string Name;
        public string Team;
        public float Score;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var listPlayer = new List<Player>
            {
            new Player { Name = "Anh", Team = "A", Score = 10 },
            new Player { Name = "Van", Team = "A", Score = 25 },
            new Player { Name = "Son", Team = "L", Score = 60 },
            new Player { Name = "Hai", Team = "L", Score = 20 },
            new Player { Name = "Sang", Team = "L", Score = 30 },
            new Player { Name = "Si", Team = "L", Score = 30 },
            new Player { Name = "Dung", Team = "A", Score = 40 },
            new Player { Name = "Vinh", Team = "L", Score = 30 },
            new Player { Name = "Nhung", Team = "L", Score = 30 },
            new Player { Name = "Nhan", Team = "L", Score = 30 },
            };
           
            
            var bai2 = from b2 in listPlayer
                       orderby b2.Score
                       select b2;
            foreach (var a in bai2)
            {
                Console.WriteLine("Name = " + a.Name + ", Team = " + a.Team + ", Score = " + a.Score);
            }
            wdwdwdwdwd;

       
        }
    }
}
