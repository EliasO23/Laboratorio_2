// See https://aka.ms/new-console-template for more information
using Laboratorio2.DAO;
using Laboratorio2.Models;
using System;

//Console.WriteLine("Hello, World!");

CrudNota CrudNota = new CrudNota();
Notum Nota = new Notum();

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("                    BIENVENIDO AL PORTAL                  ");
Console.WriteLine("---------------------------------------------------------\n");

bool comprobar = true;
while (comprobar)
{
    Console.WriteLine("\n               MENU                 ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Pulse para:                         ");
    Console.WriteLine("      1. Calcular Notas        ");
    Console.WriteLine("      2. Listas Notas          ");
    Console.WriteLine("      3. Salir                 ");
    Console.WriteLine("------------------------------------");
    Console.Write("- ¿Que desea hacer? ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            Console.WriteLine("\n\n  NUEVO REGISTRO DE NOTAS:");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("- Ingrese el nombre de la materia");
            Nota.Materia = Console.ReadLine();
            Console.WriteLine("- Ingrese el nombre del estudiante");
            Nota.NombreEstudiante = Console.ReadLine();
            Console.WriteLine("- Ingrese la nota del laboratorio 1");
            Nota.Lab1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("- Ingrese la nota del Parcial 1");
            Nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio 2");
            Nota.Lab2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("- Ingrese la nota del Parcial 2");
            Nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("- Ingrese la nota del laboratorio 3");
            Nota.Lab3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("- Ingrese la nota del Parcial 3");
            Nota.Parcial3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"\nNota Periodo 1:   {CrudNota.CalcularPeriodo1(Nota)}");
            Console.WriteLine($"Nota Periodo 2:   {CrudNota.CalcularPeriodo2(Nota)}");
            Console.WriteLine($"Nota Periodo 3:   {CrudNota.CalcularPeriodo3(Nota)}\n");

            Console.WriteLine(CrudNota.Resultado(Nota));

            CrudNota.AgregarNotas(Nota);

            Console.WriteLine("\n- Su nota fue ingresada correctamente");

            break;

        case 2:
            Console.WriteLine("\n\n  LISTADO DE NOTAS:");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine(" Id   Materia  Estudiante   L1     P1     L2     P2     L3     P3   Nota Final");
            Console.WriteLine("------------------------------------------------------------------------------");


            var ListarNotas = CrudNota.ListarNotas();
            foreach (var iteracionNota in ListarNotas)
            {
                Console.WriteLine($"  {iteracionNota.IdNotas}  {iteracionNota.Materia}    {iteracionNota.NombreEstudiante}   {iteracionNota.Lab1}    {iteracionNota.Parcial1}    {iteracionNota.Lab2}    {iteracionNota.Parcial2}  {iteracionNota.Lab3}   {iteracionNota.Parcial3}   |  {iteracionNota.Resultado}");

            }
            Console.Write("\nPulse ENTER para continuar: ");
            var cont = Console.ReadLine();

            break;

        case 3:
            Console.WriteLine("\n\n----------------------------------------------------------");
            Console.WriteLine("           ¡GRACIAS POR VISITARNOS VUELVA PRONTO!           ");
            Console.WriteLine("----------------------------------------------------------");
            
            comprobar = false;

            break;
    }
}
