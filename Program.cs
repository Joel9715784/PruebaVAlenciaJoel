using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
namespace hilos_PruebA
{
    class program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Departamento");

            Console.WriteLine(" ejercicio ");
            for (var pisos = 12; pisos <13; pisos++) {
                for (var departamentos = 8; departamentos < 9; departamentos++)
                {  ///  departamentos 
                    Random aleatorio = new Random();
                    int personaas = aleatorio.Next(1,7);
                }
            }
        static void Create(Object data)
        {
            var tw = Stopwatch.StartNew();
         
            // creamos valor ramdomico 
            Random aleatorio = new Random();
            int num = aleatorio.Next(1,13);

            static void Main(string[] args)
        {
            Console.WriteLine("Joel valencia ");
            var suma = 0;
            for (var pisos = 12; pisos < 13; pisos++)
            {
                Console.WriteLine("me encuentro en el piso " + Thread.CurrentThread.ManagedThreadId);
                for (var departamentos = 8; departamentos < 9; departamentos++)
                {  ///  departamentos 
                    Console.WriteLine("me en el departamento  = " + Thread.CurrentThread.ManagedThreadId);
                    Random aleatorio = new Random();
                    int personaas = aleatorio.Next(1, 7);

                    suma = suma + personaas;

                }
            }
            Console.WriteLine("en el edificio existen alrededor de  = " + suma);
            Console.Read();
        }
            
            
          
            