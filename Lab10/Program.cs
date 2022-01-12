using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Angle ang = new Angle(5, 43, 46);

                Console.WriteLine("Введите градусы");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сукунды");
                int s = Convert.ToInt32(Console.ReadLine());

                Angle ang = new Angle(g, m, s);

                Console.WriteLine("Угол {0}°{1}\'{2}\" в радианах = {3}",ang.Gradus ,ang.Min,ang.Sec,ang.ToRadian());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }

    class Angle
    {
        private int _gradus;
        private int _min;
        private int _sec;

        public int Gradus
        {
            get { return _gradus; }
            set
            {
                if (value >= 0 && value <= 360)
                {
                    _gradus = value;
                }
                else
                {
                    throw new Exception("Градусы должны быть >=0 и <=360");
                }
            }
        }

        public int Min
        {
            get { return _min; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _min = value;
                }
                else
                {
                    throw new Exception("Минуты должны быть >=0 и <=60");
                }
            }
        }

        public int Sec
        {
            get { return _sec; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _sec = value;
                }
                else
                {
                    throw new Exception("Секунды должны быть >=0 и <=60");
                }
            }
        }
   
        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            if (gradus >= 0 && gradus <= 360)
            {
                _gradus = gradus;
            }
            else
            {
                throw new Exception("Градусы должны быть >=0 и <=360");
            }

            if (min >= 0 && min <= 60)
            {
                _min = min;
            }
            else
            {
                throw new Exception("Минуты должны быть >=0 и <=60");
            }

            if (sec >= 0 && sec <= 60)
            {
                _sec = sec;
            }
            else
            {
                throw new Exception("Секунды должны быть >=0 и <=60");
            }
        }

        public double ToRadian()
        {
            double result = (_gradus / (180 / Math.PI) )+ (_min / (10800 / Math.PI)) + (_sec / (648000 / Math.PI))  ; 

           return result;
        }

    }
}
