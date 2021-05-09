using System;
using System.Diagnostics;

namespace Chapter3
{
    class Program
    {
        // 조건문(if, switch)
        // 반복문(for, while, do.. while, foreach,...)
        // 클래스
        // 접근 한정자.
        // 변수와 static변수
        static void Main(string[] args)
        {
            // 조건문 : if, switch
            {
                int i = 2;
                bool result = i > 10;
                // 예제1. 가장 단순한 형태.
                if (result)
                {
                    Debug.WriteLine("조건이 참일때 실행");
                }

                // 예제2. else추가
                if (i > 10)
                {
                    Debug.WriteLine("조건이 참일때 실행");
                }
                else
                {
                    Debug.WriteLine("조건이 거짓일때 실행");
                }


                // 예제2. else if추가
                if (i > 10)
                {
                    Debug.WriteLine("조건이 참일때 실행");
                }
                else if (i > 0)
                {
                    Debug.WriteLine("i(2) > 0 크다");
                }
                //else // 마지막에 else문도 추가 가능.
                //{
                //    Debug.WriteLine("모두 아닌 경우 최종적으로 실행");
                //}


                // 예제3. if문안에 다른 if, for, 변수/클래스 선언,... 가능
                if (i > 0)
                {
                    int k = 1;
                    if (i > k)
                    {
                        Debug.WriteLine("i(2) > k(1) 크다");
                    }
                }


                //switch
                {
                    //int를 switch 문에 사용
                    int i = 0;
                    switch (i)
                    {
                        case 0: Console.WriteLine("0 이다"); break;
                        case 1:
                            Console.WriteLine("1 이다");
                            break;
                        case 2:
                            {
                                Console.WriteLine("2 이다");
                            }
                            break;
                        case 4:
                        case 5:
                            Console.WriteLine("4나 5입력했다");
                            break;
                        case 3:
                            Console.WriteLine("순서대로 입력할 필요 없음");
                            break;
                        default:
                            Console.WriteLine(i + "입력했다");
                            break;
                    }

                    //스트링을 switch 문에 사용
                    string operatorString = "+";
                    switch (operatorString)
                    {
                        case "+":
                            Console.WriteLine("더하기 연산자");
                            break;
                        default:
                            Console.WriteLine(operatorString + " 알수없는 연산자입니다");
                            break;
                    }

                    // enum을 switch문에 사용
                    DayOfWeek dayOfWeek = DayOfWeek.Monday;
                    switch (dayOfWeek)
                    {
                        case DayOfWeek.Monday: Console.WriteLine("월요일이다"); break;
                        case DayOfWeek.Tuesday: Console.WriteLine("화요일이다"); break;
                    }
                }
            }

            // 반복문
            {
                //for반복문
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    for (int dan = 2; dan < -9; dan++)// i말고 다른 변수이름 해도 상관없음.
                    {
                        Console.WriteLine($"구구단 {dan}단");
                        for (int k = 1; k <= 9; k++) // 시작값 0말고 다른값 입력가능
                        {
                            Console.WriteLine($"{dan} * {k} = {dan * k}");
                        }
                    }
                }
            }

            // 클래스(생성자,...)
            // 접근 한정자(Access Modifier)
            // 멤버 변수/함수
            // static 변수/함수
            var myClass = new MyClass();
            myClass.MyFunc();


        }
    }

    internal class MyClass
    {
        public int x;
        int id;

        static int _ID;

        public MyClass()
        {
            id = _ID++;

            //Ctrl + . 혹은 Alt + Enter
            Debug.WriteLine("MyClass 생성자 호출 되었다");
        }

        public void MyFunc()
        {
            Debug.WriteLine("MyFunc 함수 호출 했다");
        }
    }
}
