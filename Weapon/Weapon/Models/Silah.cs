using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon.Models
{
    internal class Silah
    {
        private int _bulletcapacity;
        public int BulletCapacity { 
            get 
            {
               return _bulletcapacity;
            } 
            set 
            {
                if (value>0 && value<=100)
                {
                    _bulletcapacity = value;
                }
            } 
        }
        public int CurrentBulletCount { get; set; }
        public double DischargeSecond { get; set; }
        public bool FireMode { get; set; }

        public Silah()
        {

        }
        public Silah(int bulletCapacity,int bulletcount)
        {
            this.BulletCapacity = bulletCapacity;
            this.CurrentBulletCount = bulletcount;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Silahin daraq tutumu:{BulletCapacity},Daraqdaki cari gulle sayi:{CurrentBulletCount}" +
                $"Atis modu {FireMode}");
        }
        public void Shoot()
        {
            if (CurrentBulletCount>0)
            {
                --CurrentBulletCount;
                Console.WriteLine("1 gulle atildi");
                Console.WriteLine($"Silahdaki gulle sayi {CurrentBulletCount}");
            }
            else
            {
                Console.WriteLine("Sizin silahinizda gulle yoxdur");
            }
        }
        public void Fire()
        {
            if (CurrentBulletCount>0)
            {
                
                if (FireMode==true)
                {
                    //double fireTime=(CurrentBulletCount* DischargeSecond)/BulletCapacity;
                    double time = 0.1;
                    DischargeSecond = time * CurrentBulletCount;
                    CurrentBulletCount= 0;
                    Console.WriteLine($"Silahdaki butun gullelerin atilma vaxti {Math.Round(DischargeSecond,2)} saniye "); //
                }
                else
                {
                    --CurrentBulletCount;
                    Console.WriteLine("1 gulle atildi");
                    Console.WriteLine($"Silahdaki gulle sayi {CurrentBulletCount}");
                }
            }
            else
            {
                Console.WriteLine("Sizin silahinizda gulle yoxdur");
            }
        }
        public int GetRemainBulletCount()
        {
            return BulletCapacity - CurrentBulletCount; 
        }
        public void Reload()
        {
            if (BulletCapacity != CurrentBulletCount)
            {
                int needBulletCount = GetRemainBulletCount();
                CurrentBulletCount += needBulletCount;
                Console.WriteLine($"Daraqin yeniden doldurulduqdan sonraki gulle sayi {CurrentBulletCount}");
            }
            else
            {
                Console.WriteLine("Sizin daraqiniz artiq doludur");
            }
        }
        public void ChangeFireMode()
        {
             
            if (FireMode==true)
            {
                FireMode = false;
                Console.WriteLine("Silah tekli moddadir");
            }
            else
            {
                FireMode = true;
                Console.WriteLine("Silah avtomatik moddadir");
            }
        }
        public void ChangeBulletCapacity(int newBulletCapacity)
        {
            this.BulletCapacity = newBulletCapacity;
            this.CurrentBulletCount = _bulletcapacity;
            Console.WriteLine($"Sizin silahiniz yeni daraq tutumu {_bulletcapacity} -dir");
        }
    }
}
