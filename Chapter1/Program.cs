using System;
using System.Diagnostics;

namespace chapter1
{
    internal class Program
    {
        private static void Main(string[] args) //argument:전달값
        {
            Console.WriteLine("2헬로 월드" );
            // 콘솔 프로그램 실행, 실행파일 위치. 디버그, 릴리즈, 디버깅?
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("입력한 argument[아규먼트]" + args[i]);
            }

            Debug.Print("출력 창에 표시");

            ////출력창에 표시 Debug 클래스 활용.
            ////Debug 타이핑후 Ctrl + . 혹은 Alt + Enter -> using System.Diagnostics; 추가.
            //Debug.WriteLine("출력창에 남아서 편리해요.");


            // 자료형
            {
                // 1 Byte = 8bit
                // 2 Byte = 1 * 8 = 16bit
                // 4 byte = 32bit
                // 8 byte = 64bit

                int i = -1;     // 4byte
                uint ui = 1;    // 4byte unsigned(부호 없는 -> 부호 넣을 수없음 -> 음수 불가)
                double d = 1.1; // 8Byte
                float f = 1.1f; // 4Byte
            }

            // 자료(리터별)의 기본 타입.
            // var : 자동으로 유추된 타입.
            {
                var 소수점없는숫자 = 1;
                var 소수점 = 1.1;
                var 문자열 = "문자열";
                var 한글자 = '가';

                var 소수점없는숫자D = 1d;
                var 소수점F = 1.1f;
            }


            // 배열
            {
                int i = 1;

                //10진수 : 0 ~ 9 : 10가지의 숫자로 나타낸 숫자 체계
                // 16 진수 : 0 ~ 9 + abcdef : 16개의 문자로 나타낸 숫자 체계
                //16 진수 10  -> a, 11:b, 12:c,13:d, 14:e: 15:f ,16:10

                int[] intArray = new int[10];
                intArray[0] = 1; // 인덱스는 0부터 시작.
                intArray[1] = 3;
                intArray[2] = 5;
                //...
                intArray[9] = 99;
                // 메모리 뷰 Ctrl + Alt + M, 1
                // &intArray[0] 첫번째 요소의 주소
            }


            // 자료형별 크기.
            {
                // 1 Byte = 8bit
                // 2 Byte = 16bit
                // 4 Byte = 32bit
                // 8 Byte = 64bit

                short s;// 2Byte    Int16
                int i;  // 4Byte    Int32
                long l; // 8Byte    Int64
                byte by; // 1Byte
                char c; // 2Byte , c, c++ 1Byte : 256개, -> 한글 표시 x, 
                bool bo; // 1Byte
                char[] boArray = new char[2];
                boArray[0] = 'a';
                boArray[1] = 'b';
                boArray[3] = 'a';
            }

            // 값 타입과 참조타입
            {
                // 값타입. : string을 제외한 기본 타입.
                int i = 0;
                bool b = true;

                MyStruct myStruct;
                myStruct.i = 1;

                // 참조타입 : string -> 주소만 가진다. 주소의 크기 : 32비트 프로그램 -> 4Byte, 64비트 프로그램 8Byte
                string str;
                MyClass myClass;
                myClass = new MyClass();
                myClass.i = 1;  // 숫자1인 메모리상에서 1
                str = "1";      // 글자1은 메모리상에서 16진수 31 (아스키 코드표 참고) https://namu.wiki/w/아스키코드
            }

            // 자료형별 기본값 -> 메모리에 값이 0일때의 값.
            {
                int i;
                bool b;
                string str1;
                str1 = "abc";   // 메모리뷰에서 str1에 글자를 할당해서
                                // &str1, str1값이 어떻게 변하는지 확인
                                // 스트링은 immutable 타입이라서
                                // 글자를 할당할때마다 새로운 메모리 주소에 글자를 할당한다
                                //* mutable(변하기 쉬운)은 변경이 가능하고 immutable은 변경이 불가능합니다.
                                // 많은 글자를 더해야할때는 StringBuilder를 사용
            }
        }

        private static void Fun(int[] iArray)
        {
            //iArray[0];
        }

        struct MyStruct
        {
            public int i;
            public int x;
            public char c;
        }

        class MyClass
        {
            public int i;
        }
    }
}