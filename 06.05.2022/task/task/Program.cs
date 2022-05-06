using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gun gun1 = new Gun();
            Console.WriteLine(" Magazine size: " + Gun.MagazineSize + "\n Total Bullet Size: " + gun1.TotalBulletSize + "\n Bullet Left: " + gun1.BulletLeft);
            Console.WriteLine("\n 1. Shoot \n 2. Reload \n 3. FullShoot \n 4. Exit program");
            Console.Write("\n Please enter prosses: ");
            int answer = Convert.ToInt32(Console.ReadLine());      
            
            do
            {
                switch (answer)
                {
                    case 1:
                        gun1.shoot();
                        break;
                    case 2:
                        gun1.reload();
                        break;
                    case 3:
                        gun1.fullShoot();
                        break;
                }
                Console.Write("\n Please enter prosses: ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer != 4);

            Console.WriteLine("\n Magazine size: "+Gun.MagazineSize+ "\n Total Bullet Size: "+gun1.TotalBulletSize+ "\n Bullet Left: "+gun1.BulletLeft);
        }
    }
}
