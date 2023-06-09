using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class P92 : Gun, IZoom
    {

        public P92(int TotalBulletCount) : base(60)
        {
        }
        public void Zoom()
        {
            Console.WriteLine("Zoom activated!..");
        }


        public override void Shoot()

        {
           
            if (TotalBulletCount > 0)

            {

                CurrentBulletCount -= 1;
                Console.WriteLine(" P92 Shooting..");
                Console.WriteLine("Current bullet is : " + CurrentBulletCount);
            }
            if (CurrentBulletCount == 0)
            {
                throw new InsufficientBulletCountException();
            }
            if (TotalBulletCount == 0)
            {
                throw new InsufficientBulletCountException();
            }
        }

        public override void Reload()
        {

            {
                CurrentBulletCount = TotalBulletCount;

                Console.WriteLine("P92 Reloading..");
                Console.WriteLine("Reloaded: " + CurrentBulletCount);
            }




        }
    }
}