using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine("请选择 1三角形 2长方形");
                int i;
                i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.Write("请输入三角形的第一边：");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入三角形的第二边：");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入三角形的第三边：");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        double l = a + b + c;
                        double p = (a + b + c) / 2;
                        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("三角形的周长是：{0}，面积是：{1}", l, area);
                    }
                    else
                    {
                        Console.WriteLine("两边之和小于第三边,不能构成三角形");
                    }
                }
                else
                {
                    Console.Write("请输入长方形的长：");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入长方形的宽：");
                    int n = Convert.ToInt32(Console.ReadLine());
                    double q = 2 * (m + n);
                    double area2 = m * n;
                    Console.WriteLine("长方形的周长是：{0}，面积是：{1}", q, area2);
                }
            }
        }
    }
}
