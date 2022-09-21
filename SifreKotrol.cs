using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikExample
{
     class SifreKotrol
    {
       public void Password()//METHOT
        {
            string username = "admin";
            int password = 12345;
            int rights = 0;
            Menu menu = new Menu();

            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz");
                username = Console.ReadLine();

                Console.WriteLine("Kullanıcı Şifrenizi Giriniz");
                password = Convert.ToInt16(Console.ReadLine());

                if (username == "admin" && password == 12345)
                {
                    Console.WriteLine("Hoşgeldiniz");
                    menu.MenuGoster();
                    break;
                }
                else
                {
                    rights++;
                    Console.WriteLine("Tekrar deneyiniz");

                }


            }
            while (rights < 2);

            

        }


    }
}
