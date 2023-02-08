using System;
using System.Collections.Generic;

namespace BotigaLlistes
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Botiga botiga = new Botiga();
            botiga.ExempleAfegirProducte();
            if (botiga.PrimerProducte()==null)
            {
                Console.WriteLine("No hi ha productes");
            }

            else 
            Console.WriteLine(botiga.PrimerProducte().Nom);

            if (botiga.DarrerProducte() == null)
            {
                Console.WriteLine("No hi ha productes");
            }

            else
                Console.WriteLine(botiga.DarrerProducte().Nom);

            botiga.ExempleAfegirProducte();

            //botiga.EsborrarProductesPerPreu(3);

            //Console.WriteLine( botiga.RetornaLlistatEstoc2());

        }

    }
}
