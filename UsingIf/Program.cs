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
            //IfElseifPractice();
            IfInIf();
        }

        static void IfPractice()
        {
            Console.WriteLine("������һ������: ");
            int iInput = Convert.ToInt32(Console.ReadLine());
            if (iInput % 2 != 0)
            {
                Console.WriteLine(iInput + "��һ������!");
            }
            Console.ReadLine();
        }

        static void IfElsePractice()
        {
            Console.WriteLine("��������ķ���: ");
            float Score = Convert.ToSingle(Console.ReadLine());
            if (Score > 90)
            {
                Console.WriteLine("�������!");
            }
            else
            {
                Console.WriteLine("�����Ŭ��!");
            }
            Console.ReadLine();
        }

        static void IfElseifPractice()
        {
            Console.WriteLine("��������������:");
            int YouAge = Convert.ToInt32(Console.ReadLine());
            if (YouAge <= 18)
            {
                Console.WriteLine("�㻹���ᣬҪ����Ŭ����");
            }
            else if (YouAge > 18 && YouAge <= 30)
            {
                Console.WriteLine("�������Ƿܶ��Ļƽ�ʱ��!");
            }
            else if (YouAge > 30 && YouAge <= 50)
            {
                Console.WriteLine("�������ǻƽ�ʱ�ڣ��ú����ܰɣ�");
            }
            else
            {
                Console.WriteLine("��������Ϧ���죡");
            }
            Console.ReadLine();
        }

        static void IfInIf()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
