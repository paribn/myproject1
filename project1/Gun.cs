using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
  public  abstract class Gun
    {
        public int TotalBulletCount { get;private set; }

        public int CurrentBulletCount { get;  set; }

        public Gun(int TotalBulletCount)
        {

            this.TotalBulletCount = TotalBulletCount;
            this.CurrentBulletCount = TotalBulletCount;
            
        }
       
       

        public abstract void Shoot();
        public abstract void Reload();
    }
  

}
