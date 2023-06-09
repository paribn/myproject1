using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class AWP : Gun, IZoom
    {
        public AWP(int TotalBulletCount) : base(10) { }

        public void Zoom()
        {
            Console.WriteLine("Zoom activated!..");
        }

         public override void Shoot()

        {
            
            if (TotalBulletCount > 0)

            {

                CurrentBulletCount--;
                Console.WriteLine(" AWP Shooting..");
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

            CurrentBulletCount = TotalBulletCount;

            Console.WriteLine("AWP Reloading..");
            Console.WriteLine("Reloaded : " + CurrentBulletCount);
        }









    }
}
