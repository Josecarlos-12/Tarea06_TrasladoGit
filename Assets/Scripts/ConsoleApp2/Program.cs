using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ConsoleApp2
{
    class Program
    {
        static  Utensilios utensilio;
        static void Main(string[] args)
        {

            utensilio = new Utensilios();


            ListaDeUtensilios();
        }

        private static void ListaDeUtensilios() 
        {

          Console.WriteLine("----------");
            
            Console.WriteLine("tipos de utensilios");

            Console.WriteLine(" r - Rallador");
            
            Console.WriteLine(" c - Colador");
            
            Console.WriteLine(" e - Exprimidor");

            Console.WriteLine("s - Salir");


            string opt = Console.ReadLine();
            switch (opt) 
            {
                case "r":
                    AddRallador();



                    break;


                case "c":
                    AddColador();
                    break;

                case "e":
                    AddExprimidor();
                    break;

                case "1":
                    FuncionRalladorGrueso();

                    break;


                case "2":
                    FuncionRalladorEstrella();
                   
                    break;

                case "3":
                    FuncionRalladorDoble();
                    
                    break;

                case "4":
                    FuncionColadorDeTela();

                    break;


                case "5":
                    FuncionColadorDePlastico();

                    break;

                case "6":
                    FuncionColadorChino();

                    break;

                case "7":
                    FuncionExprimidorManual();

                    break;


                case "8":
                    FuncionExprimidorAutomatico();

                    break;

                case "9":
                    FuncionExprimidorDePalanca();

                    break;
            }
        
     
        }
    private static void AddRallador() 
        {
            Console.WriteLine();

            {
                Debug.Log("Tipos de rallador");
                
                Console.WriteLine(" 1 - Grueso");
                Console.WriteLine(" 2 - De estrella");
                Console.WriteLine(" 3 - De doble rallado medio");
            }
            ListaDeUtensilios();
        }

        private static void AddColador()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Tipos de colador");
                
                Console.WriteLine(" 4 - De tela");
                Console.WriteLine(" 5 - De plastico");
                Console.WriteLine(" 6 - Chino");
            }
            ListaDeUtensilios();
        }

        private static void AddExprimidor()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Tipos de exprimidor");
                
                Console.WriteLine(" 7 - Manuales");
                Console.WriteLine(" 8 - Automaticos");
                Console.WriteLine(" 9 - De palanca");
            }
            ListaDeUtensilios();
        }

        private static void FuncionRalladorGrueso()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine("Rallador grueso: rallar alimentos  blandos.");
            
            }
            ListaDeUtensilios();
        }

        private static void FuncionRalladorEstrella()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine("Rallador de estrella: rallar muy finamente.");
             
            }
            ListaDeUtensilios();
        }

        private static void FuncionRalladorDoble()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Rallador de doble rallado medio: rallar los alimentos en dos direcciones, de arriba hacia abajo y viceversa. ");
              
            }
            ListaDeUtensilios();
        }

        private static void FuncionColadorDeTela()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Colador de tela:  filtrado de cafe o infuciones.");

            }
            ListaDeUtensilios();
        }

        private static void FuncionColadorDePlastico()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Colador de plastico: escurrir el agua de los alimentos.");

            }
            ListaDeUtensilios();
        }

        private static void FuncionColadorChino()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Colador chino: filtrado de salsas, cremas o purés. ");

            }
            ListaDeUtensilios();
        }
        private static void FuncionExprimidorManual()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Exprimidor manul: De uso manual para extraer la pulpa de las frutas.");

            }
            ListaDeUtensilios();
        }

        private static void FuncionExprimidorAutomatico()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Exprimidor automatico: Otorga potencia y fuerza necesaria para exprimir al máximo las frutas o verduras.");

            }
            ListaDeUtensilios();
        }

        private static void FuncionExprimidorDePalanca()
        {
            Console.WriteLine();

            {
                Console.WriteLine("Funcion");

                Console.WriteLine(" Exprimidor de palanca: Extrae el jugo usando un brazo palanca. ");

            }
            ListaDeUtensilios();
        }
    }


}
