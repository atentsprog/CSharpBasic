using System;
using System.Diagnostics;

namespace Chapter4
{
    class Program
    {
        // 상속과 인터페이스

        // 예외처리 Try, Catch, Finally
        static void Main(string[] args)
        {
            //예외처리 Try Catch
            for (int i = 0; i < 10; i++)
            {
                string 저녁메뉴 = SelectDinnerMenu();
                Debug.WriteLine(i + "번째 메뉴는 : " + 저녁메뉴);
            }
        }

        private static string SelectDinnerMenu()
        {
            try
            {
                string 랜덤하게고른메뉴 = GetRandomMenu();

                return 랜덤하게고른메뉴;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("예외발생 프로그래머에게 알려줍시다. 예외내용" + ex);
                return "에러 발생했으니 꿀밥먹자";
            }
        }

        private static string GetRandomMenu()
        {
            string[] menus = new string[] { "편의점", "달걀", "다이어트", "고기" };
            Random random = new Random();
            int selectIndex = random.Next() % 5;
            return menus[selectIndex];
        }
    }
}
