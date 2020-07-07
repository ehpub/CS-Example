//http://ehpub.co.kr
//002. 숫자 출력 - 형식 지정자 이용하기
using System;
namespace _002_숫자_출력_포멧
{
    class Program
    {
        static void Main(string[] args)
        {
            int iv = 12345;
            double dv = 12345.6789;
            double dv2 = 0.23;
            //D: 10 진수
            Console.WriteLine("{0:D}", iv);
            Console.WriteLine(iv.ToString("D"));
            //E: 지수
            Console.WriteLine("{0:E}",dv);
            Console.WriteLine(dv.ToString("E"));
            //F: 고정 소수점
            Console.WriteLine("{0:F}", dv);
            Console.WriteLine(dv.ToString("F"));
            //G:일반
            Console.WriteLine("{0:G}", dv);
            Console.WriteLine(dv.ToString("G"));
            Console.WriteLine("{0:G}", 0.0000023);
            //N:숫자
            Console.WriteLine("{0:N}", 123456789);
            //P: 백분율
            Console.WriteLine("{0:P}", dv2);
            Console.WriteLine(dv2.ToString("P"));
            //X: 16진수
            Console.WriteLine("0x{0:X}", iv);
            Console.WriteLine("0x{0}", iv.ToString("X"));
        }
    }
}


