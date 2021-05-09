using System;
using System.Diagnostics;
using System.Text;

namespace Chapter2
{
    class Program
    {
        class MyClass 
        {
            public override string ToString()
            {
                return "나의 클래스를 스트링으로 변환";
            }
        }

        // string, 연산자(할당, 산술, 논리, 증감, 비교, 조건 ), enum
        static void Main(string[] args)
        {
            // 문자열.
            string str = " 자주쓰는 스트링 Example !!!  ";
            //str.
            MyClass myClass = new MyClass();
            //myClass.
            {
                // 문자열 결합
                string str1 = str + "어렵게 생각말자" + 'c' + (new MyClass()) ;
                int i = 1;
                string str2 = "나의 숫자는 : " + i;

                string str3 = string.Format("{2} 숫자는 {0} 입니다, {1}", 1, 2, "글자");
                //글자 숫자는 1 입니다, 2

                string str3_1 = string.Format("나의{2} 숫자는 {0} 입니다, {1}"
                    , i, 2, "11", "4번째 파라미터");
                string str4 = $"{i + 1}나의 숫자는 {i}입니다 {111 + 1}, {true}";
                string str5 = @"골뱅이는 무슨 의미일까요?
골뱅이 첫번째줄
            골뱅이 두번째줄";
                string str6 = "골뱅이는 무슨 의미일까요?\n" +
"골뱅이 첫번재줄\n" +
"           골배이 두번째줄"; //\a소리남

                // 숫자 서식 지정
                //https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/standard-numeric-format-strings
                // 이스케이프 문자. 
                //https://docs.microsoft.com/ko-kr/dotnet/standard/base-types/character-escapes-in-regular-expressions


                Console.WriteLine(str5);
                Console.WriteLine(str6);
            }

            // Trim : 문자열 앞뒤로 빈공간 짜르기.
            {
                string str1 = str.Trim();
                Console.WriteLine("str1:" + str1);
                Console.WriteLine("str:" + str);
            }

            { // 문자열 교체
                string str1 = str.Replace("스트링", "글자"); // 자주쓰는 글자 Example !!!  
                string str2 = str.Replace("스", "S");
                string str3 = str.Replace('스', 'S');
                string str4 = str.Replace(" ", ""); // 치환을 사용한 삭제
            }

            {
                string[] strs = str.Trim().Split(" "); // 문자열을 특정 글자 기준으로 나누기
                //foreach (var item in strs)
                //    Debug.WriteLine(item);
            }

            {
                //대소문자 바꾸기
                string str1 = str.ToLower();
                string str2 = str.ToUpper();
            }

            // 연산자.
            // 산술 연산자
            {
                ////+, -, *, /, %
                int i = 5 % 2; // 1
                i = 5 % 2;
            }

            // 할당 연산자
            {
                int a = 1;
                a = a + 2; 
                a += 2; // 같은 의미 a = a + 2; 
            }


            // 논리 연산자 && || !(Not)
            {
                //&& and 그리고 
                // || or 혹은, 둘중 하나라도 true 결과는 true
                // !true = false
                // !false = true

                bool isTrue = true;
                if (isTrue)
                {
                    Console.WriteLine("참일때 실행됨");
                }

                if (true && false)
                    Console.WriteLine("실행안됨");

                if (true || false)
                    Console.WriteLine("실행됨");

                if (!true)
                    Console.WriteLine("실행안됨");
            }

            // 증감 연산자. ++, --
            {
                int i = 0;      // 0
                int j = i++; //j : 0, i : 1
                int k = ++i; // k = 2, j = 0, i = 2

                if (++i > 0 || j++ > 0) // i = 3, j = 0
                    k = 0; // k = 0

                // 여기서 j는 무엇을까?
                Debug.WriteLine(j);
            }

            // 비교 연산자  >=, <, <=, ==, != 
            {
                //왼쪽거 기준으로 비교
                int i = 1;
                // > 크다.
                // < 작다
                // >= 크거나 같다
                // <= 작거나 같다

                // == 같다.
                // != 다르다.
                if (i >= 100) {
                   
                }
            }

            // 조건 연산자.
            {
                // 1 ? 2 : 3 -> 삼항 연산자.
                int val;
                int x = 0, y = 1;
                if (x > y)
                {
                    val = x;
                }
                else
                {
                    val = y;
                }

                val = (x > y) ? x : y;
                val = x > y ? x : y;  //()생략 가능.

                //// ??
                string s = null;
                //string ss = s ?? "스트링이 비어 있다";
                string ss;
                if (s == null)
                    ss = "스트링이 비어 있다";
                else
                    ss = s;
            }

            오늘의_할일출력(5);



            //열거형
            //DayOfWeek 
            //요일별 할일 프로그램.
            void 오늘의_할일출력(int dayOfWeek)
            {
                switch (dayOfWeek)
                {
                    case 0: // 월, 
                        Console.WriteLine("학원가는날");
                        break;
                    case 1: // 화
                            Console.WriteLine("화요일도 학원가는날");
                            Console.WriteLine("화요일도 학원가는날");
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("주말은 학생들 자습하는날, 강사는 노는날");
                        break;
                    default:
                        Console.WriteLine("입력한 값은 " + dayOfWeek +"입니다");
                        break;
                }


            }


            DayOfWeek dayOfWeek;
            dayOfWeek = DayOfWeek.Sunday;
            오늘의_할일출력_EnumVersion(dayOfWeek);

            void 오늘의_할일출력_EnumVersion(DayOfWeek dayOfWeek)
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Monday: Console.WriteLine("월요리 학원가는날"); break;
                    case DayOfWeek.Tuesday:
                        {
                            Console.WriteLine("화요일도 학원가는날");
                        }
                        break;
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        Console.WriteLine("주말은 자습하는날");
                        break;
                }
                DayOfWeek 요일 = DayOfWeek.Saturday | DayOfWeek.Sunday;// 토요일, 일요일;
                Console.WriteLine(요일.ToString());

                //////Flags 
                //bool 토요일포함되었나 = dayOfWeek.HasFlag(DayOfWeek.Saturday);
            }
        }

        //[Flags]
        enum DayOfWeek
        {
            Monday      = 0, // 0
            Tuesday     = 1,
            Wednesday    = 2,
            Thursday     = 4,
            Friday       = 8,
            Saturday = 16,
            Sunday = 21,
        }
    }
}
