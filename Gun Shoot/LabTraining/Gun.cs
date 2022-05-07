using System;
using System.Collections.Generic;
using System.Text;

namespace LabTraining
{
    public class Gun
    {
        public int shoot;
        public int fullshoot;
        public string reload { get; set; }
        public string gunInformation { get; set; }


        public Gun(string Reload, int Shoot, int FullShoot, string GunInformation)
        {
            shoot = Shoot;
            fullshoot = FullShoot;
            reload = Reload;
            gunInformation = GunInformation;
        }


        public void Reload()
        {
            Console.WriteLine("Your bullet is full. Now you have 30 bullets ");
        }

        public void Shoaot()
        {

            
            shoot = 30;
            

        }

        public void Fullshoot()
        {
            int i;
            int j = 0;
            for (i = 30; i >= 0; i--)

            Console.WriteLine("Baaammm " +i);
            Console.WriteLine("***********");
            Console.WriteLine("Enemy down");
            Console.WriteLine("***********");
            Console.WriteLine("You are out of bullet. Please press the 1 number");
            
        }

        public void GunInformation()
        {
            Console.WriteLine(" Hit Damage-40 \n Rate of fire-700–900 rounds/min \n Effective firing range-A5 11″: 300 metres \n 3.120–3.850 kg (6.88–8.49 lb) ");
        }

        public void GetInfo()
        {
            Console.WriteLine("1-Reload");
            Console.WriteLine("2-Shoot");
            Console.WriteLine("3-Full shoot");
            Console.WriteLine("4-Gun Information");
            Console.WriteLine();

        }

    }
}
