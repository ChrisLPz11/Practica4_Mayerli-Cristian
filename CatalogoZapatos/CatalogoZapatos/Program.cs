using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoZapatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar clases
            //Amazon hombres
            NikeAir nikeAir = new NikeAir();
            AdidasUltraboost22 adidas22 = new AdidasUltraboost22();
            TimberLand timberLand = new TimberLand();
            ClarkasMen clarkasMen = new ClarkasMen();
            Skechers skechers=new Skechers();
            CrossClassic crossClassic = new CrossClassic();
            NewBalance newBalance= new NewBalance();
            ASICS aSICS = new ASICS();
            Merrell merrell = new Merrell();
            ColeHaan coleHaan=new ColeHaan();
            //Amazon mujeres
            NikeAir200 nikeAir200 = new NikeAir200();
            Adidas21 adidas21 = new Adidas21();
            Converse converse = new Converse();
            VansOld vansOld = new VansOld();
            BirKenstock birKenstock = new BirKenstock();
            DrMartens drMartens = new DrMartens();
            TOMS tOMS = new TOMS();
            SkechersMemory skechersMemory= new SkechersMemory();
            NewBalanceWoman balanceWoman = new NewBalanceWoman();
            ASICSwoman sICSwoman = new ASICSwoman();
            //Amazon unisex
            ConverseChuck converseChuck = new ConverseChuck();
            VansAuthentic vansAuthentic = new VansAuthentic();
            NikeAirForce nikeAirForce = new NikeAirForce();
            ReebokClassic reebokClassic = new ReebokClassic();


            
            //Nike
            
            //Puma
            
            //Adidas
         

            string Option;
            //Lista de generos para zapatos
            List<string> genero = new List<string>() { "Hombre", "Mujer", "unisex" };
            List<string> calidad =new List<string>() { "Gama alta","Gama media","Gama baja" };
            // de 0 a 15
            List<int> talla = new List<int>() {35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50  };

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("____________________________Bienvenido ____________________________\n");

                Console.WriteLine(" ____________________________  Menu  ____________________________\n");

                Console.WriteLine("1. Tienda Amazon\n");
                Console.WriteLine("2. Tienda Nike\n");
                Console.WriteLine("3. Tienda Adidas\n");
                Console.WriteLine("4. Tienda Puma\n");
                Console.WriteLine("5. Salir\n");

                Console.Write("Seleccione una opción (1-5): ");

                Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                    Console.Clear();
                    Console.WriteLine("¡A seleccionado la opcion 1!\n");
                    Console.WriteLine("*************** Bienvenido al catalogo de Amazon ***************\n");
                    do 
                    {
                            Console.WriteLine("Ingrese el tipo de catalogo que quiere visualizar:\n");
                            Console.WriteLine("1." + genero[0] +
                                "\n2." + genero[1] +
                                "\n3." + genero[2] +
                                "\n4.Salir");
                            Console.Write("Seleccione una opción (1-3): \n");

                            Option = Console.ReadLine();
                            switch (Option)
                            {
                                case "1":
                                    
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo para " + genero[0] + "_____________________________\n");
                                        List<string> TiendaAmazon = new List<string>() { "1. Nike Air Max 270 - $120 USD", "2. Adidas Ultraboost 22 - $200 USD", "3. Timberland Earthkeepers Rugged 6 Boot - $160 USD", "4. Clarks Men's Tilden Walk Oxford Shoe - $80 USD",
                                            "5. Skechers Men's Equalizer 2.0 True Balance Sneaker - $50 USD", "6. Crocs Classic Clog - $20 USD", "7. New Balance Men's 990v5 - $100 USD", "8. ASICS Gel-Kayano 27 - $160 USD", "9. Merrell Men's Moab 2 Waterproof Hiking Shoe - $150 USD",
                                            "10. Cole Haan Men's Grand Crosscourt II Sneaker - $50 USD","11. Salir"};
                                        foreach (string mostrar in TiendaAmazon)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-11): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {
                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {nikeAir.marca()} \n Modelo: {nikeAir.nombre()} \n Color: {nikeAir.color()} \n Talla: {talla[5]} \n Calidad: {calidad[0]} \n Precio: ${nikeAir.precio()} \n Descuento: {nikeAir.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nikeAir.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas22.marca()} \n Modelo: {adidas22.nombre()} \n Color: {adidas22.color()} \n Talla: {talla[7]} \n Calidad: {calidad[2]} \n Precio: ${adidas22.precio()} \n Descuento: {adidas22.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas22.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {timberLand.marca()} \n Modelo: {timberLand.nombre()} \n Color: {timberLand.color()} \n Talla: {talla[8]} \n Calidad: {calidad[1]} \n Precio: ${timberLand.precio()} \n Descuento: {timberLand.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                timberLand.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {clarkasMen.marca()} \n Modelo: {clarkasMen.nombre()} \n Color: {clarkasMen.color()} \n Talla: {talla[9]} \n Calidad: {calidad[2]} \n Precio: ${clarkasMen.precio()} \n Descuento: {clarkasMen.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                clarkasMen.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "5":
                                                Console.WriteLine("________________________________________Opcion 5________________________________________\n");
                                                Console.WriteLine($" Marca: {skechers.marca()} \n Modelo: {skechers.nombre()} \n Color: {skechers.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${skechers.precio()} \n Descuento: {skechers.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                skechers.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "6":
                                                Console.WriteLine("________________________________________Opcion 6________________________________________\n");
                                                Console.WriteLine($" Marca: {crossClassic.marca()} \n Modelo: {crossClassic.nombre()} \n Color: {crossClassic.color()} \n Talla: {talla[11]} \n Calidad: {calidad[0]} \n Precio: ${crossClassic.precio()} \n Descuento: {crossClassic.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                crossClassic.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "7":
                                                Console.WriteLine("________________________________________Opcion 7________________________________________\n");
                                                Console.WriteLine($" Marca: {newBalance.marca()} \n Modelo: {newBalance.nombre()} \n Color: {newBalance.color()} \n Talla: {talla[12]} \n Calidad: {calidad[1]} \n Precio: ${newBalance.precio()} \n Descuento: {newBalance.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                newBalance.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "8":
                                                Console.WriteLine("________________________________________Opcion 8________________________________________\n");
                                                Console.WriteLine($" Marca: {aSICS.marca()} \n Modelo: {aSICS.nombre()} \n Color: {aSICS.color()} \n Talla: {talla[13]} \n Calidad: {calidad[2]} \n Precio: ${aSICS.precio()} \n Descuento: {aSICS.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                aSICS.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "9":
                                                Console.WriteLine("________________________________________Opcion 9________________________________________\n");
                                                Console.WriteLine($" Marca: {merrell.marca()} \n Modelo: {merrell.nombre()} \n Color: {merrell.color()}  \n Talla:  {talla[14]}  \n Calidad:  {calidad[0]}  \n Precio: $ {merrell.precio()}  \n Descuento: {merrell.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                merrell.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "10":
                                                Console.WriteLine("________________________________________Opcion 10________________________________________\n");
                                                Console.WriteLine($" Marca: {coleHaan.marca()} \n Modelo: {coleHaan.nombre()} \n Color: {coleHaan.color()} \n Talla: {talla[15]} \n Calidad: {calidad[2]} \n Precio: ${coleHaan.precio()} \n Descuento: {coleHaan.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                coleHaan.pagar();
                                                Console.ReadKey();
                                                break;
                                            case "11":
                                                
                                                Console.WriteLine("¡Eligio salir! fin de las consultas");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Opción inválida");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                        }

                                    }
                                    while (Option != "11");


                                    break;
                                case "2":
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo para " + genero[1] + "_____________________________\n");
                                        List<string> TiendaAmazon = new List<string>() { "1. Nike Air Max Woman - $120 USD", "2. Adidas Ultraboost 21 - $200 USD", "3. Converse Chuck Taylor All Star High Top - $40 USD", "4. Vans Old Skool - $50 USD",
                                            "5. Birkenstock Arizona Sandal - $135 USD", "6. Dr. Martens 1460 - $100 USD", "7. TOMS Classic Alpargata - $25 USD", "8. Skechers Women's D'Lites Memory Foam Lace-up Sneaker - $30 USD", "9. New Balance Women's 990v5 -  $175 USD",
                                            "10. ASICS Gel-Kayano 111 - $160 USD","11. Salir"};
                                        foreach (string mostrar in TiendaAmazon)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-11): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {
                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {nikeAir200.marca()} \n Modelo: {nikeAir200.nombre()} \n Color: {nikeAir200.color()} \n Talla: {talla[8]} \n Calidad: {calidad[1]} \n Precio: ${nikeAir200.precio()} \n Descuento: {nikeAir200.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nikeAir200.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas21.marca()} \n Modelo: {adidas21.nombre()} \n Color: {adidas21.color()} \n Talla: {talla[10]} \n Calidad: {calidad[0]} \n Precio: ${adidas21.precio()} \n Descuento: {adidas21.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas21.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {converse.marca()} \n Modelo: {converse.nombre()} \n Color: {converse.color()} \n Talla: {talla[3]} \n Calidad: {calidad[2]} \n Precio: ${converse.precio()} \n Descuento: {converse.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                converse.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {vansOld.marca()} \n Modelo: {vansOld.nombre()} \n Color: {vansOld.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${vansOld.precio()} \n Descuento: {vansOld.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                vansOld.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "5":
                                                Console.WriteLine("________________________________________Opcion 5________________________________________\n");
                                                Console.WriteLine($" Marca: {birKenstock.marca()} \n Modelo: {birKenstock.nombre()} \n Color: {birKenstock.color()} \n Talla: {talla[12]} \n Calidad: {calidad[0]} \n Precio: ${birKenstock.precio()} \n Descuento: {birKenstock.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                birKenstock.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "6":
                                                Console.WriteLine("________________________________________Opcion 6________________________________________\n");
                                                Console.WriteLine($" Marca: {drMartens.marca()} \n Modelo: {drMartens.nombre()} \n Color: {drMartens.color()} \n Talla: {talla[13]} \n Calidad: {calidad[0]} \n Precio: ${drMartens.precio()} \n Descuento: {drMartens.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                drMartens.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "7":
                                                Console.WriteLine("________________________________________Opcion 7________________________________________\n");
                                                Console.WriteLine($" Marca: {tOMS.marca()} \n Modelo: {tOMS.nombre()} \n Color: {tOMS.color()} \n Talla: {talla[15]} \n Calidad: {calidad[3]} \n Precio: ${tOMS.precio()} \n Descuento: {tOMS.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                tOMS.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "8":
                                                Console.WriteLine("________________________________________Opcion 8________________________________________\n");
                                                Console.WriteLine($" Marca: {skechersMemory.marca()} \n Modelo: {skechersMemory.nombre()} \n Color: {skechersMemory.color()} \n Talla: {talla[9]} \n Calidad: {calidad[3]} \n Precio: ${skechersMemory.precio()} \n Descuento: {skechersMemory.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                skechersMemory.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "9":
                                                Console.WriteLine("________________________________________Opcion 9________________________________________\n");
                                                Console.WriteLine($" Marca: {balanceWoman.marca()} \n Modelo: {balanceWoman.nombre()} \n Color: {balanceWoman.color()}  \n Talla:  {talla[7]}  \n Calidad:  {calidad[0]}  \n Precio: $ {balanceWoman.precio()}  \n Descuento: {balanceWoman.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                balanceWoman.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "10":
                                                Console.WriteLine("________________________________________Opcion 10________________________________________\n");
                                                Console.WriteLine($" Marca: {sICSwoman.marca()} \n Modelo: {sICSwoman.nombre()} \n Color: {sICSwoman.color()} \n Talla: {talla[3]} \n Calidad: {calidad[0]} \n Precio: ${sICSwoman.precio()} \n Descuento: {sICSwoman.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                sICSwoman.pagar();
                                                Console.ReadKey();
                                                break;
                                            case "11":
                                                
                                                Console.WriteLine("¡Eligio salir! fin de las consultas");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Opción inválida");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                        }

                                    }
                                    while (Option != "11");
                                    break;
                                case "3":
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo para " + genero[2] + "_____________________________\n");
                                        List<string> TiendaAmazon = new List<string>() { "1. Converse Chuck Taylor All Star Low Top - $70 USD", "2. Vans Authentic 2.3 - $65 USD", "3. Nike Air Force 1 '07 - $140 USD", "4. Reebok Classic Leather - $100 USD",
                                            "5. Salir"};
                                        foreach (string mostrar in TiendaAmazon)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-5): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {
                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {converseChuck.marca()} \n Modelo: {converseChuck.nombre()} \n Color: {converseChuck.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${converseChuck.precio()} \n Descuento: {converseChuck.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                converseChuck.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {vansAuthentic.marca()} \n Modelo: {vansAuthentic.nombre()} \n Color: {vansAuthentic.color()} \n Talla: {talla[1]} \n Calidad: {calidad[1]} \n Precio: ${vansAuthentic.precio()} \n Descuento: {vansAuthentic.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                vansAuthentic.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {nikeAirForce.marca()} \n Modelo: {nikeAirForce.nombre()} \n Color: {nikeAirForce.color()} \n Talla: {talla[7]} \n Calidad: {calidad[0]} \n Precio: ${nikeAirForce.precio()} \n Descuento: {nikeAirForce.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nikeAirForce.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {reebokClassic.marca()} \n Modelo: {reebokClassic.nombre()} \n Color: {reebokClassic.color()} \n Talla: {talla[7]} \n Calidad: {calidad[0]} \n Precio: ${reebokClassic.precio()} \n Descuento: {reebokClassic.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                reebokClassic.pagar();
                                                Console.ReadKey();
                                                break;

                                           
                                            case "5":
                                                Console.WriteLine("¡Eligio salir! fin de las consultas");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;

                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Opción inválida");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                        }

                                    }
                                    while (Option != "5");
                                    break;
                                case "4":
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("¡Eligio salir! fin de las consultas");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                default:

                                    Console.WriteLine("Opción inválida");
                                    Console.ReadLine();
                                    break;
                            }
                    }
                    while(Option != "4");

                        break;
                        
                       
                    case "2":
                        Console.Clear();
                        
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        //lista de zapatos adidas para hombre
                        List<string> TiedadAdidas = new List<string>() { "1.Adidas Ultraboost 21 - $180 USD","2.Adidas Originals Superstar - $80 USD","3.Adidas NMD_R1 - $140 USD","4.Adidas Stan Smith - $75 USD","5.Adidas Solar Glide ST 3 - $140 USD","6.Adidas Harden Vol. 5 - $130 USD","7.Adidas Terrex Free Hiker - $200 USD","8.Adidas Adizero Adios Pro 2 - $200 USD","9.Adidas Gazelle - $80 USD","10.Adidas Yeezy Boost 350 V2 - $220 USD" };

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ReadKey();
                        break;
                   

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Eligio salir! fin de las consultas");
                        Console.ReadKey();
                        break;
                   
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            }
            while (Option != "6");
        }    
    }
}
