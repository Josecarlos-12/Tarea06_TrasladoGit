using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyProgram : MonoBehaviour
{
    private Utensilios utensilio;

    // Start is called before the first frame update
    void Start()
    
    {
        utensilio = new Utensilios();


        ListaDeUtensilios();
    }

    private static void ListaDeUtensilios()
    {

        Debug.Log("----------");

        Debug.Log("tipos de utensilios");

        Debug.Log(" r - Rallador");

        Debug.Log(" c - Colador");

        Debug.Log(" e - Exprimidor");

        Debug.Log("s - Salir");


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

        {
            Debug.Log("Tipos de rallador");

            Debug.Log(" 1 - Grueso");
            Debug.Log(" 2 - De estrella");
            Debug.Log(" 3 - De doble rallado medio");
        }
        ListaDeUtensilios();
    }

    private static void AddColador()
    {


        {
            Debug.Log("Tipos de colador");

            Debug.Log(" 4 - De tela");
            Debug.Log(" 5 - De plastico");
            Debug.Log(" 6 - Chino");
        }
        ListaDeUtensilios();
    }

    private static void AddExprimidor()
    {


        {
            Debug.Log("Tipos de exprimidor");

            Debug.Log(" 7 - Manuales");
            Debug.Log(" 8 - Automaticos");
            Debug.Log(" 9 - De palanca");
        }
        ListaDeUtensilios();
    }

    private static void FuncionRalladorGrueso()
    {

        {
            Debug.Log("Funcion");

            Debug.Log("Rallador grueso: rallar alimentos  blandos.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionRalladorEstrella()
    {
        {
            Debug.Log("Funcion");

            Debug.Log("Rallador de estrella: rallar muy finamente.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionRalladorDoble()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Rallador de doble rallado medio: rallar los alimentos en dos direcciones, de arriba hacia abajo y viceversa. ");

        }
        ListaDeUtensilios();
    }

    private static void FuncionColadorDeTela()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Colador de tela:  filtrado de cafe o infuciones.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionColadorDePlastico()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Colador de plastico: escurrir el agua de los alimentos.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionColadorChino()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Colador chino: filtrado de salsas, cremas o purés. ");

        }
        ListaDeUtensilios();
    }
    private static void FuncionExprimidorManual()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Exprimidor manul: De uso manual para extraer la pulpa de las frutas.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionExprimidorAutomatico()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Exprimidor automatico: Otorga potencia y fuerza necesaria para exprimir al máximo las frutas o verduras.");

        }
        ListaDeUtensilios();
    }

    private static void FuncionExprimidorDePalanca()
    {
        {
            Debug.Log("Funcion");

            Debug.Log(" Exprimidor de palanca: Extrae el jugo usando un brazo palanca. ");

        }
        ListaDeUtensilios();
    }
}



