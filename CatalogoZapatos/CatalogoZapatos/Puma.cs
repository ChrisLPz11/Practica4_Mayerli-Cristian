using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CatalogoZapatos
{
    abstract class Puma
    {
        public abstract string Nombre();
        public abstract string Marca();
        public abstract string Color();
        public abstract double Precio();
        public abstract string Descuento();

    }

    //-----------------------------------------------------------------------------------------------------
    //Mujer


    class Puma_Calibrate_Runne : Puma
    {
        public override string Color()
        {
            return "Negro y gris";
        }

        public override string Descuento()
        {
            return "30%";
        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return "Puma Calibrate Runne";
        }
        public override double Precio()
        {
            return 180;
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.30);
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
    class   PumaRS_XCubed : Puma
    {
        public override string Color()
        {
            return "Rojo y Negro";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return "  Puma RS-X Cubed ";
        }

        public override double Precio()
        {
            return 80;
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.20);
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
    class Puma_Future_Rider :Puma
    {

        public override string Color()
        {
            return "Negro";
        }

        public override string Descuento()
        {
            return "30%";
        }

        public override double Precio()
        {
            return 110;

        }

        public override string Marca()
        {
            return " Puma ";
        }

        public override string Nombre()
        {
            return " Puma Future Rider ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.30);
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
    class Puma_Suede_Classic : Puma
    {

        public override string Color()
        {
            return "Blanco ";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override double Precio()
        {
            return 95;

        }

        public override string Marca()
        {
            return " Puma";
        }

        public override string Nombre()
        {
            return " Puma Suede Classic ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.20);
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
    class Puma_Ralph_Sampson: Puma
    {

        public override string Color()
        {
            return "Blanco";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 80;

        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return " Puma Ralph Sampson ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.25);
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
    class Puma_Sky_Modern : Puma
    {

        public override string Color()
        {
            return "Blanco y verde ";
        }

        public override string Descuento()
        {
            return "30%";
        }

        public override double Precio()
        {
            return 100;

        }

        public override string Marca()
        {
            return " Puma ";
        }

        public override string Nombre()
        {
            return " Puma_Sky_Modern ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.30);
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
    class PumaMirageSport : Puma
    {

        public override string Color()
        {
            return "Negro";
        }

        public override string Descuento()
        {
            return "40%";
        }

        public override double Precio()
        {
            return 100;

        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return "Puma Mirage Sport";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.40);
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
    class PumaCaliSport : Puma
    {

        public override string Color()
        {
            return "Rojo";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 70;

        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return " Puma Cali Sport ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.25);
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
    class Puma_Enzo_2 : Puma
    {

        public override string Color()
        {
            return "Blanco";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override double Precio()
        {
            return 80;

        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return " Puma Enzo 2 ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.20);
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
    class PumaAnzarunLite: Puma
    {

        public override string Color()
        {
            return "Negro";
        }

        public override string Descuento()
        {
            return "10%";
        }

        public override double Precio()
        {
            return 90;

        }

        public override string Marca()
        {
            return "Puma";
        }

        public override string Nombre()
        {
            return " Puma Anzarun Lite ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = Precio() - (Precio() * 0.10);
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



   

