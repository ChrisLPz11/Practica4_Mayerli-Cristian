using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoZapatos
{
    abstract class Adidas
    {
        public abstract string Nombre();
        public abstract string Marca();
        public abstract string Color();
        public abstract double Precio();
        public abstract string Descuento();

    }

    //-----------------------------------------------------------------------------------------------------
    //Hombres

    class AdidasUltraboost2 : Adidas
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
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Ultraboost 21";
        }
        public override double Precio()
        {
            return 180;
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.30);
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
    class AdidasOriginals_Superstar : Adidas
    {
        public override string Color()
        {
            return "Blanco y Negro";
        }

        public override string Descuento()
        {
            return "20%";
        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Ultraboost 22";
        }

        public override double Precio()
        {
            return 80;
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.20);
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
    class Adidas_NMD_R1 : Adidas
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
            return 140;

        }

        public override string Marca()
        {
            return " Adidas";
        }

        public override string Nombre()
        {
            return " Adidas NMD_R1 ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.40);
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
    class Adidas_Stan_Smith : Adidas
    {

        public override string Color()
        {
            return "Blanco y Verde";
        }

        public override string Descuento()
        {
            return "30%";
        }

        public override double Precio()
        {
            return 75;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Stan Smith ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.30);
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
    class AdidasSolarGlideST3 : Adidas
    {

        public override string Color()
        {
            return "Azul";
        }

        public override string Descuento()
        {
            return "15%";
        }

        public override double Precio()
        {
            return 140;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Solar Glide ST 3 ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.15);
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
    class AdidasHardenVol_5 : Adidas
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
            return 130;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Harden Vol. 5";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.30);
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
    class AdidasTerrexFreeHiker : Adidas
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
            return 200;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Terrex Free Hiker";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.40);
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
    class AdidasAdizeroAdiosPro_2 : Adidas
    {

        public override string Color()
        {
            return "Blancas con Rojo";
        }

        public override string Descuento()
        {
            return "25%";
        }

        public override double Precio()
        {
            return 200;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Adizero Adios Pro 2";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.25);
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
    class Adidas_Gazelle : Adidas
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
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Gazelle";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.20);
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
    class Adidas_Yeezy_Boost_350_V2  : Adidas
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
            return 220;

        }

        public override string Marca()
        {
            return "Adidas";
        }

        public override string Nombre()
        {
            return "Adidas Yeezy Boost 350 V2 ";
        }
        public void Pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (Precio() * 0.40);
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


