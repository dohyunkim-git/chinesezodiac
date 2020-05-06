using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("태어난 년도 입력 : ");
            var year = (int)Console.Read();
            String Kyear = null;

            switch(year % 12)
            {
                case 0:
                    Kyear = "원숭이";
                    break;
                case 1:
                    Kyear = "닭";
                    break;
                case 2:
                    Kyear = "개";
                    break;
                case 3:
                    Kyear = "돼지";
                    break;
                case 4:
                    Kyear = "쥐";
                    break;
                case 5:
                    Kyear = "소";
                    break;
                case 6:
                    Kyear = "호랑이";
                    break;
                case 7:
                    Kyear = "토끼";
                    break;
                case 8:
                    Kyear = "용";
                    break;
                case 9:
                    Kyear = "뱀";
                    break;
                case 10:
                    Kyear = "말";
                    break;
                case 11:
                    Kyear = "양";
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }

            if(Kyear != null)
            {
                Console.WriteLine("{0}띠의 해에 태어남", Kyear);
            }

        }
    }
}
