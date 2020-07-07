//http://ehpub.co.kr
//실습으로 다지는 C#
//5. 조건문 if else 실습2 - 두 개의 정수를 입력받아 작은 수가 큰 수의 약수인지 판별
using System;

namespace _005_조건문_실습2___두_개의_정수를_입력받아_작은_수가_큰_수의_약수인지_판별
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 정수를 입력하세요.");
            string input = Console.ReadLine();//input:= 정수를 입력 받는다.
            int num1 = 0;
            if (int.TryParse(input, out num1) == false)//조건(정수로 변환(input, out num1)이 실패)
            {
                Console.WriteLine("정수가 아닙니다.");//오류를 출력 후 알고리즘 종료
                return;
            }

            Console.WriteLine("두 번째 정수를 입력하세요.");
            input = Console.ReadLine();//input := 정수를 입력 받는다.
            int num2;
            if (int.TryParse(input, out num2) == false)//조건(정수로 변환(input, out num2)이 실패)
            {
                Console.WriteLine("정수가 아닙니다.");//오류를 출력 후 알고리즘 종료
                return;
            }

            //큰 수를 num1에 작은 수를 num2로 설정
            if (num1 < num2)
            {
                Swap(ref num1, ref num2);
            }

            if(num1% num2 == 0)//조건(num1을 num2로 나누었을 때 몫이 0)
            {
                Console.WriteLine("{0}은 {1}의 약수", num2, num1);//num2는 num1의 약수
            }
            else//아니면
            {
                Console.WriteLine("{0}은 {1}의 약수가 아닙니다.", num2, num1);//num2는 num1의 약수가 아님
            }
        }

        //두 수를 교환(ref num1, ref num2)
        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;//temp:= num1 
            num1 = num2;// num1:= num2
            num2 = temp;//num2:= temp
        }
    }
}
