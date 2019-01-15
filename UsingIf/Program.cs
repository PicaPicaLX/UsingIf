using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //IfPractice();
            //IfElsePractice();
            IfElseifPractice();

        }

        static void IfPractice()
        {
            Console.WriteLine("请输入一个整数: ");
            int iInput = Convert.ToInt32(Console.ReadLine());
            if (iInput%2!=0)
            {
                Console.WriteLine(iInput + "是一个奇数!");
            }
            Console.ReadLine();
        }

        static void IfElsePractice()
        {
            Console.WriteLine("请输入你的分数: ");
            float Score = Convert.ToSingle(Console.ReadLine());
            if (Score>90)
            {
                Console.WriteLine("你很优秀!");
            }
            else
            {
                Console.WriteLine("请继续努力!");
            }
            Console.ReadLine();
        }

        static void IfElseifPractice()
        {
            Console.WriteLine("请输入您的年龄:");
            int YouAge = Convert.ToInt32(Console.ReadLine());
            if (YouAge<=18)
            {
                Console.WriteLine("你还年轻，要继续努力！");
            }
            else if (YouAge>18&&YouAge<=30)
            {
                Console.WriteLine("您现在是奋斗的黄金时期!");
            }
            else if (YouAge>30&&YouAge<=50)
            {
                Console.WriteLine("您现在是黄金时期！好好享受吧！");
            }
            else
            {
                Console.WriteLine("最美不过夕阳红！");
            }
            Console.ReadLine();
            {

            }
        }
    }
}
