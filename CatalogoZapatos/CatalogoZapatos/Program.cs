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
            Nike_Air_Jordan nike_Air_Jordan = new Nike_Air_Jordan();
            Nike_Air_Force_1 nike_Air_Force_1 = new Nike_Air_Force_1();
            Nike_Air_Max nike_Air_Max = new Nike_Air_Max();
            Nike_Blazer nike_Blazer = new Nike_Blazer();
            Nike_Cortez nike_Cortez = new Nike_Cortez();
            Nike_Dunk nike_Dunk = new Nike_Dunk();
            Nike_Free nike_Free = new Nike_Free();
            Nike_Huarache nike_Huarache = new Nike_Huarache();
            Nike_Presto nike_Presto = new Nike_Presto();
            Nike_Roshe_Run nike_Roshe_Run = new Nike_Roshe_Run();   

            //Puma
            PumaAnzarunLite pumaAnzarunLite = new PumaAnzarunLite();
            PumaCaliSport pumaCaliSport = new PumaCaliSport();
            PumaMirageSport pumaMirageSport = new PumaMirageSport();
            Puma_Enzo_2 puma_Enzo_2 = new Puma_Enzo_2();
            Puma_Future_Rider puma_Future_Rider = new Puma_Future_Rider();
            Puma_Ralph_Sampson puma_Ralph_Sampson = new Puma_Ralph_Sampson();
            PumaRS_XCubed pumaRS_XCubed = new PumaRS_XCubed();  
            Puma_Suede_Classic puma_Suede_Classic = new Puma_Suede_Classic();
            Puma_Sky_Modern puma_Sky_Modern = new Puma_Sky_Modern();
            Puma_Calibrate_Runne puma_Calibrate_Runne = new Puma_Calibrate_Runne();
            //Adidas
            AdidasUltraboost2 adidasUltraboost2 = new AdidasUltraboost2();
            AdidasHardenVol_5 adidasHardenVol_5 = new AdidasHardenVol_5();
            AdidasAdizeroAdiosPro_2 adidasAdizeroAdiosPro_2 = new AdidasAdizeroAdiosPro_2();
            AdidasOriginals_Superstar adidasOriginals_Superstar = new AdidasOriginals_Superstar();
            AdidasSolarGlideST3 adidasSolarGlideST3 = new AdidasSolarGlideST3();
            AdidasTerrexFreeHiker adidasTerrexFreeHiker = new AdidasTerrexFreeHiker();
            Adidas_Gazelle adidas_Gazelle = new Adidas_Gazelle();
            Adidas_NMD_R1 adidas_NMD_R1 = new Adidas_NMD_R1();
            Adidas_Stan_Smith adidas_Stan_Smith = new Adidas_Stan_Smith();
            Adidas_Yeezy_Boost_350_V2 adidas_Yeezy_Boost_350_V2 = new Adidas_Yeezy_Boost_350_V2();

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
                Console.WriteLine("2. Tiendas de zapatos deportivos\n");
                Console.WriteLine("3. Salir\n");


                Console.Write("Seleccione una opción (1-3): ");

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
                            Console.Write("Seleccione una opción (1-4): \n");

                            Option = Console.ReadLine();
                            switch (Option)
                            {
                                case "1":

                                    do
                                    {
                                        Console.Clear();
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
                                        Console.Clear();

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
                                        Console.Clear();
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
                        while (Option != "4");

                        break;

                    case "2":
                        
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" ____________________________  Menu de zapatos deportivos unisex  ____________________________\n");
                            Console.WriteLine("1.Nike");
                            Console.WriteLine("2.Adidas");
                            Console.WriteLine("3.Puma");
                            Console.WriteLine("4.Salir");
                            Console.Write("Seleccione una opción (1-4): ");

                            Option = Console.ReadLine();
                            switch (Option)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("*************** Bienvenido al catalogo de Nike ***************\n");
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo de zapatos deportivos_____________________________\n");
                                        List<string> TiendaNike = new List<string>() { "1. Nike Air Jordan - $180 USD", "2.Nike_Air_Force_1 - $100 USD", "3.Nike_Air_Max - $140 USD", "4. Nike_Blazer - $80 USD",
                                            "5. Nike_Cortez - $80 USD", "6.  Nike_Dunk - $120 USD", "7. Nike_Free - $100 USD", "8. Nike Huarache - $70 USD", "9. Nike_Presto - $90 USD",
                                            "10.Nike_Roshe_Run - $90 USD","11. Salir" };
                                        foreach (string mostrar in TiendaNike)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-11): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {

                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Air_Jordan.marca()} \n Modelo: {nike_Air_Jordan.nombre()} \n Color: {nike_Air_Jordan.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${nike_Air_Jordan.precio()} \n Descuento: {nike_Air_Jordan.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Air_Jordan.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Air_Force_1.marca()} \n Modelo: {nike_Air_Force_1.nombre()} \n Color: {nike_Air_Force_1.color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${nike_Air_Force_1.precio()} \n Descuento: {nike_Air_Force_1.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Air_Force_1.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Air_Max.marca()} \n Modelo: {nike_Air_Max.nombre()} \n Color: {nike_Air_Max.color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${nike_Air_Max.precio()} \n Descuento: {nike_Air_Max.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Air_Max.pagar();
                                                Console.ReadKey();
                                                break;
                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Blazer.marca()} \n Modelo: {nike_Blazer.nombre()} \n Color: {nike_Blazer.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${nike_Blazer.precio()} \n Descuento: {nike_Blazer.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Blazer.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "5":
                                                Console.WriteLine("________________________________________Opcion 5________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Cortez.marca()} \n Modelo: {nike_Cortez.nombre()} \n Color: {nike_Cortez.color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${nike_Cortez.precio()} \n Descuento: {nike_Cortez.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Cortez.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "6":
                                                Console.WriteLine("________________________________________Opcion 6________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Dunk.marca()} \n Modelo: {nike_Dunk.nombre()} \n Color: {nike_Dunk.color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${nike_Dunk.precio()} \n Descuento: {nike_Dunk.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Dunk.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "7":
                                                Console.WriteLine("________________________________________Opcion 7________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Free.marca()} \n Modelo: {nike_Free.nombre()} \n Color: {nike_Free.color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${nike_Free.precio()} \n Descuento: {nike_Free.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Free.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "8":
                                                Console.WriteLine("________________________________________Opcion 8________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Huarache.marca()} \n Modelo: {nike_Huarache.nombre()} \n Color: {nike_Huarache.color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${nike_Huarache.precio()} \n Descuento: {nike_Huarache.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Huarache.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "9":
                                                Console.WriteLine("________________________________________Opcion 9________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Presto.marca()} \n Modelo: {nike_Presto.nombre()} \n Color: {nike_Presto.color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${nike_Presto.precio()} \n Descuento: {nike_Presto.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Presto.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "10":
                                                Console.WriteLine("________________________________________Opcion 10________________________________________\n");
                                                Console.WriteLine($" Marca: {nike_Roshe_Run.marca()} \n Modelo: {nike_Presto.nombre()} \n Color: {nike_Presto.color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${nike_Presto.precio()} \n Descuento: {nike_Presto.descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                nike_Presto.pagar();
                                                Console.ReadKey();
                                                break;

                                            case "11":

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
                                    while (Option != "11");
                                    
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("*************** Bienvenido al catalogo de Adidas ***************\n");
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo de zapatos deportivos_____________________________\n");
                                        List<string> TiendaPuma = new List<string>() { "1. Adidas Ultraboost 2 - $180 USD", "2.Adidas Originals Superstar - $80 USD", "3. Adidas NMD_R1 - $140 USD", "4. Adidas Stan Smith - $75 USD",
                                            "5. Adidas Solar Glide ST 3 - $140 USD", "6. Adidas Harden Vol. 5 - $130 USD", "7. Adidas Terrex Free Hiker - $200 USD", "8. Adidas Adizero Adios Pro 2 - $200 USD", "9. Adidas Gazelle - $80 USD",
                                            "10. Adidas Yeezy Boost 350 V2 - $220 USD","11. Salir" };
                                        foreach (string mostrar in TiendaPuma)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-11): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {

                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasUltraboost2.Marca()} \n Modelo: {adidasUltraboost2.Nombre()} \n Color: {adidasUltraboost2.Color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${adidasUltraboost2.Precio()} \n Descuento: {adidasUltraboost2.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasUltraboost2.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasHardenVol_5.Marca()} \n Modelo: {adidasHardenVol_5.Nombre()} \n Color: {adidasHardenVol_5.Color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${adidasHardenVol_5.Precio()} \n Descuento: {adidasHardenVol_5.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasHardenVol_5.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasAdizeroAdiosPro_2.Marca()} \n Modelo: {adidasAdizeroAdiosPro_2.Nombre()} \n Color: {adidasAdizeroAdiosPro_2.Color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${adidasAdizeroAdiosPro_2.Precio()} \n Descuento: {adidasAdizeroAdiosPro_2.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasAdizeroAdiosPro_2.Pagar();
                                                Console.ReadKey();
                                                break;
                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasOriginals_Superstar.Marca()} \n Modelo: {adidasOriginals_Superstar.Nombre()} \n Color: {adidasOriginals_Superstar.Color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${adidasOriginals_Superstar.Precio()} \n Descuento: {adidasOriginals_Superstar.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasOriginals_Superstar.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "5":
                                                Console.WriteLine("________________________________________Opcion 5________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasSolarGlideST3.Marca()} \n Modelo: {adidasSolarGlideST3.Nombre()} \n Color: {adidasSolarGlideST3.Color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${adidasSolarGlideST3.Precio()} \n Descuento: {adidasSolarGlideST3.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasSolarGlideST3.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "6":
                                                Console.WriteLine("________________________________________Opcion 6________________________________________\n");
                                                Console.WriteLine($" Marca: {adidasTerrexFreeHiker.Marca()} \n Modelo: {adidasTerrexFreeHiker.Nombre()} \n Color: {adidasTerrexFreeHiker.Color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${adidasTerrexFreeHiker.Precio()} \n Descuento: {adidasTerrexFreeHiker.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidasTerrexFreeHiker.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "7":
                                                Console.WriteLine("________________________________________Opcion 7________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas_Gazelle.Marca()} \n Modelo: {adidas_Gazelle.Nombre()} \n Color: {adidas_Gazelle.Color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${adidas_Gazelle.Precio()} \n Descuento: {adidas_Gazelle.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas_Gazelle.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "8":
                                                Console.WriteLine("________________________________________Opcion 8________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas_NMD_R1.Marca()} \n Modelo: {adidas_NMD_R1.Nombre()} \n Color: {adidas_NMD_R1.Color()} \n Talla: {talla[9]} \n Calidad: {calidad[1]} \n Precio: ${adidas_NMD_R1.Precio()} \n Descuento: {adidas_NMD_R1.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas_NMD_R1.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "9":
                                                Console.WriteLine("________________________________________Opcion 9________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas_Stan_Smith.Marca()} \n Modelo: {adidas_Stan_Smith.Nombre()} \n Color: {adidas_Stan_Smith.Color()} \n Talla: {talla[10]} \n Calidad: {calidad[1]} \n Precio: ${adidas_Stan_Smith.Precio()} \n Descuento: {adidas_Stan_Smith.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas_Stan_Smith.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "10":
                                                Console.WriteLine("________________________________________Opcion 10________________________________________\n");
                                                Console.WriteLine($" Marca: {adidas_Yeezy_Boost_350_V2.Marca()} \n Modelo: {adidas_Yeezy_Boost_350_V2.Nombre()} \n Color: {adidas_Yeezy_Boost_350_V2.Color()} \n Talla: {talla[11]} \n Calidad: {calidad[1]} \n Precio: ${adidas_Yeezy_Boost_350_V2.Precio()} \n Descuento: {adidas_Yeezy_Boost_350_V2.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                adidas_Yeezy_Boost_350_V2.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "11":

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
                                    while (Option != "11");
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("*************** Bienvenido al catalogo de Puma ***************\n");
                                    do
                                    {
                                        Console.WriteLine("_____________________________Catalogo de zapatos deportivos_____________________________\n");
                                        List<string> TiendaAdidas = new List<string>() { "1. Puma Calibrate Runne - $180 USD", "2. Puma RS-X Cubed - $80 USD", "3. Puma Future Rider - $110 USD", "4. Puma Suede Classic - $95 USD",
                                            "5. Puma Ralph Sampson - $80 USD", "6.  Puma_Sky_Modern - $100 USD", "7. Puma Mirage Sport - $100 USD", "8. Puma Cali Sport - $70 USD", "9. Puma Enzo 2 - $80 USD",
                                            "10. Puma Anzarun Lite - $90 USD","11. Salir"};
                                        foreach (string mostrar in TiendaAdidas)
                                        {
                                            Console.WriteLine(mostrar);
                                        }
                                        Console.Write("Seleccione una opción (1-11): \n");

                                        Option = Console.ReadLine();

                                        switch (Option)
                                        {

                                            case "1":
                                                Console.WriteLine("________________________________________Opcion 1________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Calibrate_Runne.Marca()} \n Modelo: {puma_Calibrate_Runne.Nombre()} \n Color: {puma_Calibrate_Runne.Color()} \n Talla: {talla[8]} \n Calidad: {calidad[1]} \n Precio: ${puma_Calibrate_Runne.Precio()} \n Descuento: {puma_Calibrate_Runne.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Calibrate_Runne.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.WriteLine("________________________________________Opcion 2________________________________________\n");
                                                Console.WriteLine($" Marca: {pumaRS_XCubed.Marca()} \n Modelo: {pumaRS_XCubed.Nombre()} \n Color: {pumaRS_XCubed.Color()} \n Talla: {talla[7]} \n Calidad: {calidad[4]} \n Precio: ${pumaRS_XCubed.Precio()} \n Descuento: {pumaRS_XCubed.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                pumaRS_XCubed.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.WriteLine("________________________________________Opcion 3________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Future_Rider.Marca()} \n Modelo: {puma_Future_Rider.Nombre()} \n Color: {puma_Future_Rider.Color()} \n Talla: {talla[8]} \n Calidad: {calidad[3]} \n Precio: ${puma_Future_Rider.Precio()} \n Descuento: {puma_Future_Rider.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Future_Rider.Pagar();
                                                Console.ReadKey();
                                                break;
                                            case "4":
                                                Console.WriteLine("________________________________________Opcion 4________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Suede_Classic.Marca()} \n Modelo: {puma_Suede_Classic.Nombre()} \n Color: {puma_Suede_Classic.Color()} \n Talla: {talla[9]} \n Calidad: {calidad[4]} \n Precio: ${puma_Suede_Classic.Precio()} \n Descuento: {puma_Suede_Classic.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Suede_Classic.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "5":
                                                Console.WriteLine("________________________________________Opcion 5________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Ralph_Sampson.Marca()} \n Modelo: {puma_Ralph_Sampson.Nombre()} \n Color: {puma_Ralph_Sampson.Color()} \n Talla: {talla[6]} \n Calidad: {calidad[3]} \n Precio: ${puma_Ralph_Sampson.Precio()} \n Descuento: {puma_Ralph_Sampson.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Ralph_Sampson.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "6":
                                                Console.WriteLine("________________________________________Opcion 6________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Sky_Modern.Marca()} \n Modelo: {puma_Sky_Modern.Nombre()} \n Color: {puma_Sky_Modern.Color()} \n Talla: {talla[6]} \n Calidad: {calidad[1]} \n Precio: ${puma_Sky_Modern.Precio()} \n Descuento: {puma_Sky_Modern.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Sky_Modern.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "7":
                                                Console.WriteLine("________________________________________Opcion 7________________________________________\n");
                                                Console.WriteLine($" Marca: {pumaMirageSport.Marca()} \n Modelo: {pumaMirageSport.Nombre()} \n Color: {pumaMirageSport.Color()} \n Talla: {talla[6]} \n Calidad: {calidad[4]} \n Precio: ${pumaMirageSport.Precio()} \n Descuento: {pumaMirageSport.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                pumaMirageSport.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "8":
                                                Console.WriteLine("________________________________________Opcion 8________________________________________\n");
                                                Console.WriteLine($" Marca: {pumaCaliSport.Marca()} \n Modelo: {pumaCaliSport.Nombre()} \n Color: {pumaCaliSport.Color()} \n Talla: {talla[7]} \n Calidad: {calidad[2]} \n Precio: ${pumaCaliSport.Precio()} \n Descuento: {pumaCaliSport.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                pumaCaliSport.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "9":
                                                Console.WriteLine("________________________________________Opcion 9________________________________________\n");
                                                Console.WriteLine($" Marca: {puma_Enzo_2.Marca()} \n Modelo: {puma_Enzo_2.Nombre()} \n Color: {puma_Enzo_2.Color()} \n Talla: {talla[7]} \n Calidad: {calidad[3]} \n Precio: ${puma_Enzo_2.Precio()} \n Descuento: {puma_Enzo_2.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                puma_Enzo_2.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "10":
                                                Console.WriteLine("________________________________________Opcion 10________________________________________\n");
                                                Console.WriteLine($" Marca: {pumaAnzarunLite.Marca()} \n Modelo: {pumaAnzarunLite.Nombre()} \n Color: {pumaAnzarunLite.Color()} \n Talla: {talla[8]} \n Calidad: {calidad[1]} \n Precio: ${pumaAnzarunLite.Precio()} \n Descuento: {pumaAnzarunLite.Descuento()}");
                                                Console.WriteLine("\nIngrese la cantidad con la que pagara:");
                                                pumaAnzarunLite.Pagar();
                                                Console.ReadKey();
                                                break;

                                            case "11":

                                                Console.WriteLine("¡Eligio salir! fin de las consultas");
                                                Console.ReadKey();

                                                break;

                                            default:
                                                ;
                                                Console.WriteLine("Opción inválida");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                        }

                                    }
                                    while (Option != "11");
                                    break;
                                case "4":
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
                        while(Option != "4");
                        break;


                    case "3":
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
            while (Option != "3");


        }
    }
}
