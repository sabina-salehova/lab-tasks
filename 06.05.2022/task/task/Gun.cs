using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class Gun
    {
        public string type;
        public int TotalBulletSize=90;
        public static int MagazineSize=10;
        public int BulletLeft=0;


        public void shoot()
        {
                      
            if (MagazineSize == BulletLeft)
            {
                Console.WriteLine(" Magazine Size is empty, please reload");
                return;
            }

            BulletLeft++;                     
        }

        public void reload()
        {
            if (TotalBulletSize <= 0)
            {
                Console.WriteLine(" Total Bullet Size is empty");
                return;
            }
            if (TotalBulletSize > BulletLeft)
            {
                TotalBulletSize = TotalBulletSize - BulletLeft;
                BulletLeft = 0;
            }
            else
            {
                BulletLeft -= TotalBulletSize;
                TotalBulletSize = 0;
            }
        }

        public void fullShoot()
        {
            if (BulletLeft == 0)
            {
                Console.WriteLine(" Total Bullet Size is empty, before reload");
                return;
            }
            TotalBulletSize -= BulletLeft;
            BulletLeft = MagazineSize;


        }

    }
}
