//http://ehpbu.co.kr
//3. 정수와 소수점 이하 자릿수 결정하기
using System;

namespace _003_정수와_소수점_이하_자릿수_결정하기
{
    class Program
    {
        static void Main(string[] args)
        {
            double dv = 1234.123456789;
            int iv = 123;

            //0의 개수 = 정수 자릿수(빈 자리는 0출력)
            Console.WriteLine("{0:000000}", iv);
            Console.WriteLine("{0:000000}", dv);

            //"D정수" = 정수 자릿수(빈 자리는 0출력)
            Console.WriteLine("{0:D6}", iv);
            //Console.WriteLine("{0:D6}", dv); 실수 표현은 인자로 올 수 없다.

            //"." 뒤에 0의 갯수 = 소수점 이하 자릿수
            Console.WriteLine("{0:.000000}", dv);

            //"N정수", "F정수" = 소수점 이하 자릿수
            Console.WriteLine("{0:N}", dv);
            Console.WriteLine("{0:N4}", dv);
            Console.WriteLine("{0:F}", dv);
            Console.WriteLine("{0:F5}", dv);
        }
    }
}
