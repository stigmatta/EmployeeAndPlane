
using System.Xml.Linq;

namespace PlaneClass
{
    internal class Plane
    {
        private string planeName;
        private string planeProduction;
        private int year;
        private string type;

        public string PlaneName
        {
            get { return planeName; }
            set { planeName = value; }
        }

        public string PlaneProduction
        {
            get { return planeProduction; }
            set { planeProduction = value; }
        }

        public int Year
        {
            get { return year; }
            set { 
                if(value>=2000)
                    year = value; 
            }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Plane()
        {
            PlaneName = string.Empty;
            PlaneProduction = string.Empty;
            Year = 2000;
            Type = string.Empty;
        }

        public Plane(string planeName, string planeProduction, int year, string type)
        {
            PlaneName = planeName;
            PlaneProduction = planeProduction;
            Year = year;
            Type = type;
        }

        public void InputData()
        {
            Console.WriteLine("Имя самолета:");
            PlaneName = Console.ReadLine();

            Console.WriteLine("Производитель:");
            PlaneProduction = Console.ReadLine();

            Console.WriteLine("Год выпуска:");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Тип самолета:");
            Type = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Название самолета:{0}\nПроизводитель:{1}\nГод выпуска:{2}\nТип самолета:{3}\n", PlaneName, PlaneProduction, Year,Type);
        }
    }
}
