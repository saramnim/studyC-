using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            // ctrl + K + C = 주석 추가
            // ctrl + K + U = 주석 삭제
            // ctrl + F5 = compile
            //if(args.Length == 0)
            //{
            //    Console.WriteLine("사용법: helloworld.exe");
            //    return;
            //}
            //Console.WriteLine("Hello, {0}", args[0]);
            //const int MAX = 100;
            //Console.WriteLine("Max value: {0}", MAX);

            //int kor = 90;
            //int math = 100;
            //int eng = 80;

            //int total = 0;
            //double avg = 0.0;
            //total = kor + math + eng;
            //avg = total / 3;

            //Console.WriteLine("총점: {0}", total);
            //Console.WriteLine("평균: {0:F1}", avg);

            //int x = 10;
            //if (x == 10)
            //{
            //    Console.WriteLine($"x = {x}");
            //    // Console.WriteLine("x = {0}", x);
            //}
            //if (x != 20)
            //{
            //    Console.WriteLine("x는 20이 아닙니다.");
            //}

            //Console.WriteLine("첫 번째 수: ");
            //int firstNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("두 번째 수: ");
            //int secondNum = Convert.ToInt32(Console.ReadLine());
            //if(firstNum >= secondNum)
            //{
            //    Console.WriteLine($"큰 값: {firstNum}");
            //}
            //else
            //{
            //    Console.WriteLine($"큰 값: {secondNum}");
            //}

            //int score = 0;
            //char grade = 'F';
            //Console.WriteLine("점수를 입력하시오.");
            //score = Convert.ToInt32((string) Console.ReadLine());
            //if (score >= 90)
            //{
            //    grade = 'A';
            //}
            //else if (score >= 80)
            //{
            //    grade = 'B';
            //}
            //else if (score >= 70)
            //{
            //    grade = 'C';
            //}
            //else if (score >= 60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}
            //Console.WriteLine($"점수: {score} 점");
            //Console.WriteLine($"학점: {grade}");

            //int n = 11;
            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"1부터 {n}까지 짝수의 합: {sum}");

            //for (int i = 0; i <= 5; i++){
            //    for(int j = 0;j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int firstNum = 0;
            //int secondNum = 1;
            //while(secondNum <= 20)
            //{
            //    Console.WriteLine(secondNum);
            //    int temp = firstNum + secondNum;
            //    firstNum = secondNum;
            //    secondNum = temp;
            //}

            //int count = 0;
            //do
            //{
            //    Console.WriteLine("예제");
            //    count++;
            //} while (count < 3);

            //string[] names = { "C#", "C++", "JavaScript", "ASP.NET" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine("3의 배수입니다.");
            //        continue;
            //    }
            //    Console.WriteLine("해당 i 값: {0}", i);
            //    sum += i;
            //}
            //Console.WriteLine("sum: {0}", sum);

            //    Console.WriteLine("시작");
            //Start:
            //    Console.WriteLine("0, 1, 2 중 하나를 입력해주세요. : +_\b");
            //    int chapter = Convert.ToInt32(Console.ReadLine());

            //    if(chapter == 1)
            //    {
            //        goto Chapter1;
            //    }
            //    if (chapter == 2)
            //    {
            //        goto Chapter2;
            //    }
            //    else
            //    {
            //        goto End;
            //    }
            //Chapter1:
            //    Console.WriteLine("1장입니다.");

            //Chapter2:
            //    Console.WriteLine("2장입니다.");
            //    goto Start;

            //End:
            //    Console.WriteLine("종료");
            //int Add(int x, int y)
            //    {
            //        int result = y;
            //        return result;
            //    }
            //    bool IsPositive(int number)
            //    {
            //        return number > 0;
            //    }
            //    void PrintMessage(string message)
            //    {
            //        Console.WriteLine(message);
            //        return;
            //    }
            //    int Sum = Add(10, 20);
            //    Console.WriteLine($"10 + 20 = {Sum}");
            //    bool isPositive = IsPositive(-5);
            //    Console.WriteLine($"is -5 Positive? {isPositive}");
            //    PrintMessage("Hello World");

            //int a = 20;
            //int b = 3;
            //int c;
            //int d;

            //Divide(a, b, out c, out d);
            //Console.WriteLine("Quotient: {0}, Remainder: {1}", c, d);

            int addvalue = Add(10, 20);
            int minusValue = Minus(100, 50);

            PrintValue("Hello");
            Console.WriteLine("addvalue: " + addvalue);
            Console.WriteLine("minusvalue: " + minusValue);

            void PrintValue(string value)
            {
                Console.WriteLine("value: " + value);
            }
            int Add(int x, int y)
            {
                return x + y;
            }
            int Minus(int x, int y)
            {
                return x - y;
            }
        }
        
    }
}