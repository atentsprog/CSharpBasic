using System;
using System.Collections.Generic;
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
        class Unity
        {
            public void Run()
            {
                Goblin g1 = new Goblin();

                //슬라임과 고블린의 전투 진행.
                Slime s1 = new Slime();
                Console.WriteLine(Slime.SlimeCount); // 명확하게 클래스 이름을 통해서 접근하는 변수는 static변수다.
                //Console.WriteLine(s1.slimeCount);
                //s1.slimeCount //<-static도 캑체를 통해 변수에 접근 할수 있으면 static인지 아닌지 헷깔린다.

                Slime s2 = new Slime();
                Slime s3 = new Slime();


                s1.Attack(g1);
                g1.Attack(s1);
            }
        }

        static void Main(string[] args)
        {
            // 슬라임과 고블린을 전투 시키자.
            Unity unity = new Unity();
            unity.Run();


            // 조건문 : if, switch
            {
                int i = 2;
                i = 3;
                bool result = i > 10;
                // 예제1. 가장 단순한 형태.
                if (result)
                {
                    Debug.WriteLine("여기는 실행안됨");
                }

                // 예제2. else추가
                if (i > 10)
                {
                    Debug.WriteLine("조건이 참일때 실행, 여기도 실행안됨");
                }
                else
                {
                    Debug.WriteLine("조건이 거짓일때 실행, 위에 실행안되서 여기실행됨");
                }


                // 예제2. else if추가
                if (i > 10) // i == 2
                {
                    Debug.WriteLine("조건이 참일때 실행");
                }
                else if (i > 0)
                {
                    Debug.WriteLine("i(2) > 0 크다");
                }
                else // 마지막에 else문도 추가 가능.
                {
                    Debug.WriteLine("모두 아닌 경우 최종적으로 실행");
                }


                // 예제3. if문안에 다른 if, for, 변수/클래스 선언,... 가능
                if (i > 0)
                {
                    int k = 1;
                    if (i > k)
                    {
                        Debug.WriteLine("i(2) > k(1) 크다");
                    }
                }
            }

            //switch
            {
                //int를 switch 문에 사용
                int k = 0; //<- 세미콜론.
                int sum = 10;
                switch (k)
                {
                    case 1: // <- 콜론,줄바꿈 표시 아니에요 
                        {
                            int i = k * 2;
                            sum = i;
                            Console.WriteLine("1 이다");
                        }
                        break;
                    case 0:
                        {
                            int i = 0;
                            sum = i;
                            Console.WriteLine("0 이다");
                        }
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
                        Console.WriteLine(k + "입력했다");
                        break;
                }


                //스트링을 switch 문에 사용
                string operatorString = "Add";
                switch (operatorString)
                {
                    case "Add":
                        Console.WriteLine("더하기 연산자");
                        break;
                    case "Minus":
                        Console.WriteLine("빼기 연산자");
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

            // 반복문
            {
                //for반복문
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    for (int dan = 2; dan < 9; dan++)// i말고 다른 변수이름 해도 상관없음.
                    {
                        Console.WriteLine($"구구단 {dan}단");
                        for (int k = 1; k <= 9; k++) // 시작값 0말고 다른값 입력가능, for문안에 다른 for문도 넣을 수 있음.
                        {
                            Console.WriteLine($"{dan} * {k} = {dan * k}");
                        }
                    }
                }

                //while 반복문.
                {
                    int count = 10;
                    while (count > 0) // while(isPlayer == true) 와 같음
                    {
                        count--;
                        Console.WriteLine(count);
                    }

                    count = 10;
                    do // do while문 :while문과의 차이 최소 1회 실행한뒤 조건 검사.
                    {
                        count--;
                        Console.WriteLine(count);
                    } while (count > 0);


                    count = 10;
                    while (true)  // 무한 반복, 본문블락에서 break문을 사용해서 블락을 빠져나와야 한다.
                    {
                        count--;
                        if (count <= 0)
                            break; // while 반복 빠져나감.
                        Console.WriteLine(count);
                    }
                }
            } // 반복문 끝



            { // 클래스 
                // new 가 필요한 이유
                Monster monster0 = new Monster(); // 클래스 기본 생성자 호출

                Monster monster1 = new Monster("몬스터1", 1, 3); // 생성할때 파라미터 넣어서 생성자 호출
                Monster monster2 = new Monster("몬스터1", 2);
                Monster monster3 = new Monster("몬스터1", power: 2, 3);

                //new 를 하면 (인스턴스, 객체, 오브젝트)가 생긴다.
                monster1.hp -= 3; // 특정 객체의 값만 수정할 수 있다.


            } // 클래스 끝


            {
                //함수 오버라이드
                Monster monster = new Monster();
                string log = "몬스터를 스트링과 결합" + monster; // 스트링과 결합될때 자동으로 ToString함수가 호출된다.
                string log1 = monster.ToString(); // public virtual string? ToString();
            }

            // 함수 오버라이드를 사용해서 몬스터의 공격패턴을 다양하게 바꾸자.
            {
                //상속된 함수 사용 virtual과 override, -> 대표적인 override인 ToString을 사용해보자.
                Slime slime = new Slime();
                Goblin goblin = new Goblin();

                List<Monster> monsters = new List<Monster>();
                monsters.Add(slime);
                monsters.Add(goblin);

                // 실제로는 엄청 많은 몬스터들이 있다.
                // 일일이 어택 명령을 실행할 수 없으니 List에 담아서 한번에 Attack명령 실행한다.
                // Slime과 Goblin은 모두 Monster의 자식들이라서 monster에 담을 수 있다.
                // Monster에 담았으니깐 Monster에 있는 Attack명령을 사용할 수 있다.
                //foreach (var item in monsters)
                //    item.Attack();
            }

            // static 변수/함수.
            {
                // 언제나 사용가능한 변수와 함수.
                // static 변수/함수는 해당 클래스 안에서는 사용가능
                // 클래스 밖에서 호출 할때는 public 으로 설정되어야 하며, "클랙스이름.함수/변수"로 호출해야함.
                int totalID = Monster.TotalID;
                int totalID1 = Monster.GetCurrentID(); // public Static 함수라서 호출 가능.
            }


            // 0:사자, 1:호랑이, 2:토끼, 3:여우.
            {
                int animal = 0; // 

                if (animal == 0)  // 0: 사자
                    Console.WriteLine("어흥");
                else if (animal == 1)
                    Console.WriteLine("야홍");
                else if (animal == 2)
                    Console.WriteLine("깡총");
                else if (animal == 3)
                    Console.WriteLine("여우");
            }

            {
                Animal animal = Animal.토끼;
                if (animal == Animal.사자)
                    Console.WriteLine("어흥");
                else if (animal == Animal.호랑이)
                    Console.WriteLine("야홍");
                else if (animal == Animal.토끼)
                    Console.WriteLine("깡총");
                else if (animal == Animal.여우)
                    Console.WriteLine("여우");

                switch (animal)
                {
                    case Animal.사자:
                        Console.WriteLine("어흥");
                        break;
                    case Animal.호랑이:
                        Console.WriteLine("야홍");
                        break;
                    case Animal.토끼:
                        Console.WriteLine("깡총");
                        break;
                    case Animal.여우:
                        Console.WriteLine("여우");
                        break;
                }
            }

            //enum 과 리스트 사용
            {
                List<int> intList = new List<int>();
                intList.Add(1);
                intList.Add(2);
                int firstElement = intList[0];
                int secondElement = intList[1];

                Animal animal = Animal.호랑이;
                animal = (Animal)((int)animal + (int)Animal.토끼);
                Debug.WriteLine(animal);
            }




            // || or 연산
            // && and 연산
            // | <- 비트 연산 or
            // & <- 비트 연산 and
            // OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;

            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                //HasFlag()이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력
                    Console.WriteLine(b.ToString());
                }
            }
        }

        [Flags]
        enum Border
        {
            None    = 0b00000,     // 0
            Top     = 0b00001,     // 2^0
            Right   = 0b00010,     // 2^1
            Bottom  = 0b00100,     // 2^2  = 2* 2 = 4
            Left    = 0b01000,     // 2^3  = 2 * 2 * 2 = 8
        }

        enum Animal
        {
            // 아시아 동물.
            사자 , 
            호랑이,
            토끼,
            여우,
            거북이,

            // 아프리카 동물
            아프리카사자 = 100,
            아프리카호랑이,// 101
            아프리카토끼  // 102
        }
    }


    internal class Monster
    {
        static public int TotalID;

        public int id;
        public string name;
        public int power;
        public int hp;

        public Monster()
        {
            Random r = new Random();
            power = r.Next(1, 3);
            hp = r.Next(1, 3);
        }

        public Monster(string name, int power, int _hp = 3)
        {
            id = GetNextID(); // static함수 사용 <- 클래스 안에서 사용가능.
            //id = ++TotalID;   // static 변수도 사용가능.

            this.name = name;
            this.power = power;
            hp = _hp;
        }

        public override string ToString()
        {
            return $"ID:{id}, name:{name}, power:{power}, hp:{hp}";
        }

        static int GetNextID()      // static 
        {
            return ++TotalID;
        }
        public static int GetCurrentID() // public static 함수 설명
        {
            return TotalID;
        }
    }

    class Slime : Monster
    {
        public static int SlimeCount = 0;
        public Slime() : base()
        {
            name = "슬라임" + id;
            SlimeCount++;
        }

        public void Attack(Goblin goblin)
        {
            goblin.hp -= power;
        }
    }
    class Goblin : Monster
    {
        public Goblin()
        {
            name = "고블린" + id;
        }

        internal void Attack(Slime s1)
        {
            s1.hp -= power;
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
