using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoZapatos
{
    
    abstract class Amazon
    {
        public abstract string nombre();
        public abstract string marca();
        public abstract string color();
        public abstract double precio();
        public abstract string descuento();
       
    }

    //-----------------------------------------------------------------------------------------------------
    //Hombres
    class NikeAir : Amazon
    {
        public override string color()
        {
            return "Negro";
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
            return "Nike Air Max 270";
        }

        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.30);
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

        public override double precio()
        {
            return 120;
        }
    }
    class AdidasUltraboost22 : Amazon
    {
        public override string color()
        {
            return "Azul";
        }

        public override string descuento()
        {
            return "20%";
        }

        public override string marca()
        {
            return "Adidas";
        }

        public override string nombre()
        {
            return "Adidas Ultraboost 22";
        }

        public override double precio()
        {
            return 200;
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.20);
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
    class TimberLand : Amazon
    {

        public override string color()
        {
            return "Morado";
        }

        public override string descuento()
        {
            return "50%";
        }

        public override double precio()
        {
            return 160;

        }

        public override string marca()
        {
            return "Tinderland";
        }

        public override string nombre()
        {
            return "Tinderland Earthkeepers";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.50);
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
    class ClarkasMen : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "35%";
        }

        public override double precio()
        {
            return 80;

        }

        public override string marca()
        {
            return "Clarks Men's";
        }

        public override string nombre()
        {
            return "Clarks Men's Tilden Walk Oxford Shoe ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.35);
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
    class Skechers : Amazon
    {

        public override string color()
        {
            return "Rojo";
        }

        public override string descuento()
        {
            return "5%";
        }

        public override double precio()
        {
            return 50;

        }

        public override string marca()
        {
            return "Skechers Men's";
        }

        public override string nombre()
        {
            return "Skechers Men's Equalizer 2.0 True Balance Sneaker ";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.05);
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
    class CrossClassic : Amazon
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
            return 20;

        }

        public override string marca()
        {
            return "Crocs";
        }

        public override string nombre()
        {
            return "Crocs Classic Clog";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.10);
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
    class NewBalance : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "70%";
        }

        public override double precio()
        {
            return 100;

        }

        public override string marca()
        {
            return "New Balance";
        }

        public override string nombre()
        {
            return "New Balance Men's 990v5";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.70);
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
    class ASICS : Amazon
    {

        public override string color()
        {
            return "Amarillo";
        }

        public override string descuento()
        {
            return "25%";
        }

        public override double precio()
        {
            return 160;

        }

        public override string marca()
        {
            return "ASICS";
        }

        public override string nombre()
        {
            return "ASICS Gel-Kayano 27";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.25);
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
    class Merrell : Amazon
    {

        public override string color()
        {
            return "Blanco";
        }

        public override string descuento()
        {
            return "10%";
        }

        public override double precio()
        {
            return 150;

        }

        public override string marca()
        {
            return "Merrell";
        }

        public override string nombre()
        {
            return "Merell Men's Moab 2 Waterproof Hiking Shoe";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.10);
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
    class ColeHaan : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "12%";
        }

        public override double precio()
        {
            return 50;

        }

        public override string marca()
        {
            return "Cole Haan";
        }

        public override string nombre()
        {
            return "Cole Haan Men's Grand Crosscourt II Sneaker";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.12);
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
    //-----------------------------------------------------------------------------------------------------
    //Mujeres
    class NikeAir200 : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "15%";
        }

        public override double precio()
        {
            return 120;

        }

        public override string marca()
        {
            return "Nike";
        }

        public override string nombre()
        {
            return "Nike Air Max woman";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.15);
            double total= pagar - proceso;
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
    class Adidas21 : Amazon
    {

        public override string color()
        {
            return "Rosa";
        }

        public override string descuento()
        {
            return "30%";
        }

        public override double precio()
        {
            return 200;

        }

        public override string marca()
        {
            return "Adidas";
        }

        public override string nombre()
        {
            return "Adidas Ultraboost 21";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.30);
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
    class Converse : Amazon
    {

        public override string color()
        {
            return "Verde oscuro";
        }

        public override string descuento()
        {
            return "40%";
        }

        public override double precio()
        {
            return 40;

        }

        public override string marca()
        {
            return "Converse";
        }

        public override string nombre()
        {
            return "Converse Chuck Taylor All Star High Top";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.40);
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
    class VansOld : Amazon
    {

        public override string color()
        {
            return "Celeste con blanco";
        }

        public override string descuento()
        {
            return "15%";
        }

        public override double precio()
        {
            return 50;

        }

        public override string marca()
        {
            return "Vans";
        }

        public override string nombre()
        {
            return "Vans Old Skool";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.15);
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
    class BirKenstock : Amazon
    {

        public override string color()
        {
            return "Anaranjado";
        }

        public override string descuento()
        {
            return "30%";
        }

        public override double precio()
        {
            return 135;

        }

        public override string marca()
        {
            return "Birkenstock";
        }

        public override string nombre()
        {
            return "Birkenstock Arizona Sandal";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.30);
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
    class DrMartens : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "60%";
        }

        public override double precio()
        {
            return 100;

        }

        public override string marca()
        {
            return "Dr. Martens";
        }

        public override string nombre()
        {
            return "Dr. Martens 1460";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.60);
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
    class TOMS : Amazon
    {

        public override string color()
        {
            return "Gris";
        }

        public override string descuento()
        {
            return "11%";
        }

        public override double precio()
        {
            return 25;

        }

        public override string marca()
        {
            return "TOMS";
        }

        public override string nombre()
        {
            return "TOMS Classic Alpargata";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.11);
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
    class SkechersMemory : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "5%";
        }

        public override double precio()
        {
            return 30;

        }

        public override string marca()
        {
            return "Skechers Women's";
        }

        public override string nombre()
        {
            return "Skechers Women's D'Lites Memory Foam Lace-up Sneaker";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.05);
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
    class NewBalanceWoman : Amazon
    {

        public override string color()
        {
            return "Marron";
        }

        public override string descuento()
        {
            return "50%";
        }

        public override double precio()
        {
            return 175;

        }

        public override string marca()
        {
            return "New Balance";
        }

        public override string nombre()
        {
            return "New Balance Women's 990v5";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.50);
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
    class ASICSwoman : Amazon
    {

        public override string color()
        {
            return "Azul";
        }

        public override string descuento()
        {
            return "10%";
        }

        public override double precio()
        {
            return 160;

        }

        public override string marca()
        {
            return "ASICS";
        }

        public override string nombre()
        {
            return "ASICS Gel-Kayano 111";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.10);
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
    //-----------------------------------------------------------------------------------------------------
    //Unisex
    class ConverseChuck : Amazon
    {

        public override string color()
        {
            return "Rojo";
        }

        public override string descuento()
        {
            return "20%";
        }

        public override double precio()
        {
            return 70;

        }

        public override string marca()
        {
            return "Converse";
        }

        public override string nombre()
        {
            return "Converse Chuck Taylor All Star Low Top";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.20);
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
    class VansAuthentic : Amazon
    {

        public override string color()
        {
            return "Negro y blanco";
        }

        public override string descuento()
        {
            return "10%";
        }

        public override double precio()
        {
            return 65;

        }

        public override string marca()
        {
            return "Vans";
        }

        public override string nombre()
        {
            return "Vans Authentic 2.3";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.10);
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
    class NikeAirForce : Amazon
    {

        public override string color()
        {
            return "Amarillo";
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
            return "Nike";
        }

        public override string nombre()
        {
            return "Nike Air Force";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.30);
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
    class ReebokClassic : Amazon
    {

        public override string color()
        {
            return "Negro";
        }

        public override string descuento()
        {
            return "80%";
        }

        public override double precio()
        {
            return 100;

        }

        public override string marca()
        {
            return "Reebok";
        }

        public override string nombre()
        {
            return "Reebok Classic Leather";
        }
        public void pagar()
        {
            double pagar = double.Parse(Console.ReadLine());
            double proceso = pagar - (precio() * 0.30);
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
