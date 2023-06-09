using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class M4 : Gun
    {

        public M4(int TotalBulletCount) : base(30) { }

        public override void Shoot()

        {
            if (TotalBulletCount > 0)

            {
                CurrentBulletCount--;
                Console.WriteLine(" M4 Shooting..");
                Console.WriteLine(" Bullet left: " + CurrentBulletCount);
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

            Console.WriteLine("M4 Reloading..");
            Console.WriteLine("Reloaded : " + CurrentBulletCount);
        }

    }
}
