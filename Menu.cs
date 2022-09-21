using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikExample
{
    internal class Menu
    {
        public void MenuGoster()//METHOT
        {
            Money money = new Money();//NESNE
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("Para çekmek için 1");
                Console.WriteLine("Para yatırmak için 2");
                Console.WriteLine("Bakiye sorgulamak için 3");
                Console.WriteLine("Çıkış için 4");

                int buton = Convert.ToInt16(Console.ReadLine());
                

                if (buton == 1)
                {
                    Console.WriteLine("çekmek istediğiniz tutar:");
                    int miktar = Convert.ToInt32(Console.ReadLine());
                    if (money.Amount - miktar >= 0)
                    {
                        money.Amount -= miktar;
                    }
                    else
                    { 
                        Console.WriteLine("Bakiyeniz yetersiz");
                    }
                }

                 if (buton == 2)
                {
                    Console.WriteLine("yatırmak istediğiniz tutar:");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    money.Amount += miktar;

                }
                if (buton == 3)
                {
                    Console.WriteLine("Bakiyeniz:");
                    Console.WriteLine(money.Amount);

                }
                 if (buton == 4)
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }
            }
        }
            
    }
}
