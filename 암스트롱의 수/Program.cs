//ehpub.co.kr
//실습으로 다지는 C#
//7. 암스트롱의 수
//ABC = A의 3승 + B의 3승 + C의 3승
using System;


namespace _007_암스트롱의_수
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("암스트롱의 수 구하기");
            Console.WriteLine("abc = a*a*a + b*b*b + c*c*c");
            for(int i=100;i<1000;i++)
            {
                if(IsAmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsAmstrong(int num)
        {
            if((num<100)||(num>999))//조건(num이 3자리 정수가 아니라면)
            {
                return false;//거짓 반환
            }
            int a = num / 100;//a:= num의 100의 자리의 수
            int b = (num % 100) / 10;//b := num의 10의 자리의 수
            int c = num % 10;//c:= num의 1의 자리의 수
            int num2 = a * a * a + b * b * b + c * c * c;//num2 = a의 3승 + b의 3승 + c의 3승
            return num == num2;//num과 num2가 같은지 판별 결과 반환            
        }
    }
}
