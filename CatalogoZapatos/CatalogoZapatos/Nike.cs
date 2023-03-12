using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoZapatos
{
    abstract class Nike
    {
        public abstract string nombre();
        public abstract string marca();
        public abstract string color();
        public abstract double precio();
        public abstract string descuento();

    }

    //-----------------------------------------------------------------------------------------------------
    //Hmombre 


    class Nike_Air_Jordan : Nike
    {
        public override string color()
        {
            return "Blanco y Rojo";
        }

        public override string descuento()
        {
            return "30%";
        }

        public override string marca()
        {
    
            return "Nike";
        }

        public override string nombre()
        {
            return "Nike_Air_Jorda";
        }
        public override double precio()
        {
            return 180;
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.30);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }


    }
    class Nike_Air_Force_1 : Nike
    {
        public override string color()
        {
            return "Blancos";
        }

        public override string descuento()
        {
            return "20%";
        }

        public override string marca()
        {
            return "Nike";
        }

        public override string nombre()
        {
            return " Nike_Air_Force_1 ";
        }

        public override double precio()
        {
            return 100;
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.20);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Air_Max : Nike
    {

        public override string color()
        {
            return "Blanco y Azul";
        }

        public override string descuento()
        {
            return "30%";
        }

        public override double precio()
        {
            return 140;

        }

        public override string marca()
        {
            return " Nike ";
        }

        public override string nombre()
        {
            return " Nike_Air_Max ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.30);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Blazer : Nike
    {

        public override string color()
        {
            return "Blanco ";
        }

        public override string descuento()
        {
            return "20%";
        }

        public override double precio()
        {
            return 80;

        }

        public override string marca()
        {
            return " Nike ";
        }

        public override string nombre()
        {
            return " Nike_Blazer ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.20);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Cortez : Nike
    {

        public override string color()
        {
            return "Blanco";
        }

        public override string descuento()
        {
            return "25%";
        }

        public override double precio()
        {
            return 80;

        }

        public override string marca()
        {
            return "Nike";
        }

        public override string nombre()
        {
            return " Nike_Cortez";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.25);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Dunk : Nike
    {

        public override string color()
        {
            return "Blanco y Negro ";
        }

        public override string descuento()
        {
            return "30%";
        }

        public override double precio()
        {
            return 120;

        }

        public override string marca()
        {
            return " Nike ";
        }

        public override string nombre()
        {
            return "  Nike_Dunk ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.30);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Free : Nike
    {

        public override string color()
        {
            return "Blanco";
        }

        public override string descuento()
        {
            return "40%";
        }

        public override double precio()
        {
            return 100;

        }

        public override string marca()
        {
            return "Nike";
        }

        public override string nombre()
        {
            return " Nike_Free ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.40);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Huarache : Nike
    {

        public override string color()
        {
            return " Celeste ";
        }

        public override string descuento()
        {
            return "25%";
        }

        public override double precio()
        {
            return 70;

        }

        public override string marca()
        {
            return "Nike";
        }

        public override string nombre()
        {
            return " Nike Huarache ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.25);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Presto : Nike
    {

        public override string color()
        {
            return "Blanco";
        }

        public override string descuento()
        {
            return "20%";
        }

        public override double precio()
        {
            return 90;

        }

        public override string marca()
        {
            return " Nike";
        }

        public override string nombre()
        {
            return " Nike_Presto ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.20);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }
    }
    class Nike_Roshe_Run : Nike
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "10%";
        }

        public override double precio()
        {
            return 90;

        }

        public override string marca()
        {
            return " Nike ";
        }

        public override string nombre()
        {
            return "Nike_Roshe_Run ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = precio() - (precio() * 0.10);
            double total = pagar - proceso;
            if (total < 0)
            {
                Console.WriteLine("Resultado: debe la cantidad de $" + total);
            }
            else
            {
                Console.WriteLine("Resultado: su vuelto es de $" + total);
            }
        }

    }
}
