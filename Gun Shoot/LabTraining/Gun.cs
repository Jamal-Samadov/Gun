using System;
using System.Collections.Generic;
using System.Text;

namespace LabTraining
{
    internal class Gun
    {
        private int _totalBullletSize;
        public int TotalBulletSize
        {
            get 
            {
                return _totalBullletSize;
            }
            private set
            {
                if(value >= 0)
                {
                    _totalBullletSize = value;
                }
            }
        }

        private int _shoot;
        public int Shoot
        {
            get
            {
                return _shoot;
            }
            set
            {
                int select = 30;
                int count = 0;
                for(int i = 0; i < select; i--)
                {
                    if (i > 0)
                    {
                        count++;

                    }
                    else if(i == 0)
                    {
                        Console.WriteLine("Do reload");
                    }
                }
            }
        }


        public int _fullShoot;

        public int FullShoot
        {
            get
            {
                return  _fullShoot;
            }
            set
            {
                int i;

                for (i = 30; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }


            }
        }
        private string _gunShoot;
        public string Gunshoot
        {
            get
            {
                return _gunShoot;
            }
            set
            {
                string name = "My gun is M416. I have 30 bullet";
            }
        }
        




    }
}
