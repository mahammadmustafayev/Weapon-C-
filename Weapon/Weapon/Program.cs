using System;
using Weapon.Models;

namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity;
            do
            {
                Console.WriteLine("Daraqin umumi tutumunu  Daxil Edin");
                bulletCapacity=Convert.ToInt32(Console.ReadLine());
            } while (bulletCapacity <= 0 || bulletCapacity>100);
            int bulletCount;
            do
            {
                Console.WriteLine("Gulle Sayi Daxil Edin");
                bulletCount=Convert.ToInt32(Console.ReadLine());
            } while (bulletCount<=0 || bulletCount>bulletCapacity);

            Silah weapon = new Silah(bulletCapacity,bulletCount);
            int choise;
                Console.WriteLine("0-Info ucun");
                Console.WriteLine("1-Shoot ucun");
                Console.WriteLine("2-Fire ucun");
                Console.WriteLine("3-GetRemainCount ucun");
                Console.WriteLine("4-Reload ucun ");
                Console.WriteLine("5-Atis modu ucun");
                Console.WriteLine("6-Edit");
                Console.WriteLine("7-Cixis");
            do
            {
                Console.WriteLine("Bir secim edin");
                choise=Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        Console.WriteLine("-------------------");
                        weapon.ShowInfo();
                        Console.WriteLine("-------------------");
                        break;
                    case 1:
                        Console.WriteLine("-------------------");
                        weapon.Shoot();
                        Console.WriteLine("-------------------");
                        break;
                    case 2:
                        Console.WriteLine("-------------------");
                        weapon.Fire();
                        Console.WriteLine("-------------------");
                        break;
                    case 3:
                        Console.WriteLine("-------------------");
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        Console.WriteLine("-------------------");
                        break;
                    case 4:
                        Console.WriteLine("-------------------");
                        weapon.Reload();
                        Console.WriteLine("-------------------");
                        break;
                    case 5:
                        Console.WriteLine("-------------------");
                        weapon.ChangeFireMode();
                        Console.WriteLine("-------------------");
                        break;
                    case 6:

                        Console.WriteLine("Cixi ucun Q secin");
                        Console.WriteLine("Tutumu deyismek ucun T secin");
                        char editchoise;
                        do
                        {
                            Console.WriteLine("Bir secim daxil edin");
                            editchoise=Convert.ToChar(Console.ReadLine());
                            switch (editchoise)
                            {
                                case 'T':
                                    int newBulletCapacity;
                                    do
                                    {
                                        Console.WriteLine("Yeniden daraq tutumunu daxil edin:");
                                        newBulletCapacity=Convert.ToInt32(Console.ReadLine());
                                    } while (newBulletCapacity<=0 || newBulletCapacity>120);
                                    weapon.ChangeBulletCapacity(newBulletCapacity);
                                    break;
                                default:
                                    Console.WriteLine("Bele bir secim yoxdur");
                                    break;
                            }
                        } while (editchoise != 'Q');
                        break; 
                    case 7:
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Saqolun");
                        Console.WriteLine("-------------------");

                        break;
                    default:
                        Console.WriteLine("Bele bir secim yoxdur");
                        break;
                }

            } while (choise != 7);
        }
    }
}