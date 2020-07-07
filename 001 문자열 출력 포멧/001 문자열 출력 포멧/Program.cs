//https://ehpub.co.kr
//실습으로 다지는 C#
//  001. 문자열 출력 포멧
//      {index;,alignment][:formatString]}
//      {인덱스[,배치][:포멧문자열]}

using System;

namespace _001_문자열_출력_포멧
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("테스트1: {0}, {1}, {2}", "Hello", 23.7, 10);
            Console.WriteLine("테스트2: {0}, {2}, {1}", "Hello", 23.7, 10);

            //배치
            Console.WriteLine("테스트3:{0,10}, {0,-10}끝", 1234);

            //포멧 문자열
            Console.WriteLine("테스트4: 0x{0:X}, {0:E}, {0:N}", 12345678);
        }
    }
}
