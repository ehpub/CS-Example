//ehpub.co.kr
//실습으로 다지는 C#
//8. 랜던 값 맞추기
using System;

namespace _008_랜덤_값_맞추기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("0~99 사이의 정수 중에 컴퓨터가 생각한 수를 맞춰보세요.");
            Console.WriteLine("*** 10회 안에 맞춰야 성공입니다.");

            int rnum = random.Next(100);//rnum:= 랜덤 값
            int tcnt;
            int guess;
            for(tcnt=1; tcnt<=10; tcnt++)//반복(tcnt: 1->10)
            {
                Console.Write("{0}번째 시도, 예상값:", tcnt);
                int.TryParse(Console.ReadLine(), out guess);//guess:= 추측값 입력
                if(guess == rnum)//조건(guess is equals rnum)
                {
                    break;//반복문 탈출
                }
                if(guess>rnum)//조건(guess > rnum)
                {
                    Console.WriteLine("더 작습니다.");//더 작다고 알려준다.
                }
                else//아니면
                {
                    Console.WriteLine("더 큽니다.");//더 크다고 알려준다.
                }
            }

            if(tcnt<=10)//조건(시도 횟수가 10보다 작거나 같으면)
            {
                Console.WriteLine("{0}번 시도하여 정답을 맞추셨군요", tcnt);//시도 횟수와 성공하였음을 알려준다.
            }
            else//아니면
            {
                Console.WriteLine("실패하였습니다.");//실패하였다고 알려준다.
            }
            Console.WriteLine("컴퓨터가 생각한 정수는 {0}", rnum);
        }
    }
}
