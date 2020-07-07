//ehpub.co.kr
//실습으로 다지는 C#
//4. 조건문 if else 연습
//  1. 두 개의 정수를 입력받은 후에 큰 수를 출력하는 프로그램을 작성하시오.
//  2. 두 개의 정수를 입력받은 후에 작은 수가 큰 수의 약수인지 확인하는 프로그램을 작성하시오.
//  3. 세 개의 정수를 입력받은 후에 크기가 큰 순서부터 출력하는 프로그램을 작성하시오.
using System;


namespace _004_조건문_if_else_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();    
        }

        private static void Ex3()
        {
            //  3. 세 개의 정수를 입력받은 후에 크기가 큰 순서부터 출력하는 프로그램을 작성하시오.
            int num1, num2, num3;
            Console.WriteLine("입력한 세 개의 정수를 크기 순으로 출력합니다.");
            Console.Write("첫 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            Console.Write("두 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            Console.Write("세 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num3) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }

            //num1과 num2의 값 중에 큰 값을 num1으로 설정하기
            if(num1<num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            //num1과 num3의 값 중에 큰 값을 num1으로 설정하기
            if(num1<num3)
            {
                int temp = num1;
                num1 = num3;
                num3 = temp;
            }

            //num2와 num3의 값 중에 큰 값을 num2로 설정하기
            if(num2<num3)
            {
                int temp = num2;
                num2 = num3;
                num3 = temp;
            }
            Console.WriteLine("{0} {1} {2}", num1, num2, num3);
        }

        private static void Ex2()
        {
            //  2. 두 개의 정수를 입력받은 후에 작은 수가 큰 수의 약수인지 확인하는 프로그램을 작성하시오.
            int num1, num2;
            Console.WriteLine("입력한 두 개의 정수 중에 작은 수가 큰 수의 약수인지 판별합니다.");
            Console.Write("첫 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            Console.Write("두 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            if(num1%num2 == 0)
            {
                Console.WriteLine("{0}은 {1}의 약수입니다.", num2, num1);
            }
            else
            {
                Console.WriteLine("{0}은 {1}의 약수가 아닙니다.", num2, num1);
            }
        }

        private static void Ex1()
        {
            //  1. 두 개의 정수를 입력받은 후에 큰 수를 출력하는 프로그램을 작성하시오.
            int num1, num2;
            Console.WriteLine("입력한 두 개의 정수 중에 큰 수를 출력합니다.");
            Console.Write("첫 번째 정수:");
            if(int.TryParse(Console.ReadLine(),out num1) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            Console.Write("두 번째 정수:");
            if (int.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.WriteLine("에러 발생!!! 정수를 입력하지 않았습니다.");
                return;
            }
            if(num1>num2)
            {
                Console.WriteLine("{0}이 {1}보다 큰 정수입니다.", num1, num2);
            }
            else if(num1==num2)
            {
                Console.WriteLine("두 개의 정수는 모두 {0}로 같습니다.", num1);
            }
            else
            {
                Console.WriteLine("{1}이 {0}보다 큰 정수입니다.", num1, num2);
            }
        }
    }
}
