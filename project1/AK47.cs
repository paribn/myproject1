using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class AK47 : Gun
    {
        public AK47(int TotalBulletCount) : base(32) { }

        public override void Shoot()

        {
            
            if (TotalBulletCount > 0)

            {
                CurrentBulletCount--;
                Console.WriteLine(" AK47 Shooting..");
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

            Console.WriteLine("AK47 Reloading..");
            Console.WriteLine("Reloaded!: " + CurrentBulletCount);
        }

    }


        
    
}
