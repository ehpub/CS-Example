//http://ehpub.co.kr
//실습으로 다지는 C#
//5. 반복문 실습1
//두 개의 정수를 입력받은 후에 두 수 사이의 모든 정수의 합계 구하기
using System;

namespace _005_반복문_실습1___두_개의_정수를_입력받은_후에_두_수_사이의_모든_정수의_합계_구하기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 정수를 입력하세요.");
            string input = Console.ReadLine();//input:= 정수를 입력 받는다.
            int num1;
            if(int.TryParse(input,out num1)==false)//조건(정수로 변환(input, out num1)이 실패)
            {
                Console.WriteLine("정수가 아닙니다.");//    오류를 출력 후 알고리즘 종료
                return;
            }

            Console.WriteLine("두 번째 정수를 입력하세요.");
            input = Console.ReadLine();//input := 정수를 입력 받는다.
            int num2;
            if(int.TryParse(input,out num2) == false)//조건(정수로 변환(input, out num2)이 실패)
            {
                Console.WriteLine("정수가 아닙니다.");//    오류를 출력 후 알고리즘 종료
                return;
            }

            if(num1<num2)//조건(num1 < num2)
            {
                Swap(ref num1, ref num2);//    두 수를 교환(ref num1, ref num2)
            }

            int sum = CalSum(num2, num1);   //sum:= 두 정수 사이의 합계 구하기(num2, num1)
            Console.WriteLine("{0}에서 {1}사이의 합계는 {2}입니다.", num2, num1, sum);
        }

        //두 수를 교환(ref num1, ref num2)
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;//temp:= num1
            num1 = num2;//num1:= num2
            num2 = temp;//num2:= temp
        }
        //두 정수 사이의 합계 구하기(start, end):합계
        static int CalSum(int start, int end)
        {
            int sum = 0;//sum:= 0
            for (int value = start; value <= end; value++)//반복(value:= start->end)
            {
                sum += value;//    sum:= sum + value
            }
            return sum;//sum 반환            
        }
    }
}
