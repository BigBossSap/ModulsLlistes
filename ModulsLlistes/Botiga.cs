using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotigaLlistes
{
    class Botiga
    {
        public String NomBotiga { set; get; }
        List<Producte> productes;

        public Botiga() {
            productes = new List<Producte>();

        }

        public void Buidar()
        {
            productes.Clear();
        }

        public void ExempleAfegirProducte() {

            Producte producte1 = new Producte("Gelat", 2, 7);
            productes.Add(producte1);

            Producte producte2 = new Producte("pinya", 3, 21);
            productes.Add(producte2);

            productes.Add(new Producte("poma", 3, 21));

            RetornaLlistatEstoc();
        }


        public Producte BuscarProducte(Producte p)
        {
            Producte producte = null;

            for (int i = 0; i < productes.Count; i++)
            {
                if (productes[i].Nom == p.Nom)
                {
                    producte = productes[i];
                }
            }

            return (producte);
        }

        public Producte BuscarProducte2(Producte p)
        {
            Producte producte = null;
            producte = productes.Find(a => a.Nom.Equals(p.Nom));
            return (producte);
        }

        /// <summary>
        /// Busca tots els productes que tenen el mateix preu que el producte del parametre
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<Producte> BuscarProductesMateixPreu(Producte p)
        {
            List<Producte> productes = null;
            productes = productes.FindAll(a => a.Preu_sense_iva.Equals(p.Preu_sense_iva));
            return (productes);
        }

        public void EsborrarProducte(Producte p)
        {
            Producte a;
            a = BuscarProducte(p);
            productes.Remove(a);
        }

        public String RetornaLlistatEstoc()
        {
            String estoc = "";
            for (int i = 0; i < productes.Count; i++)
            {
                Producte p = productes.ElementAt(i);
                //O bé amb Producte a = productes.[i];

                estoc = estoc + p.toString();
            }
            return (estoc);
        }

        /// <summary>
        /// Exemple amb un altre iterador
        /// </summary>
        /// <returns></returns>
        public String RetornaLlistatEstoc2()
        {
            String estoc = "";
            foreach (Producte p in productes)
            {
                estoc = estoc + p.toString();
            }
            return (estoc);
        }

        /* Altres mètodes de List
           productes.Remove 
           productes.Exists
           productes.Insert
           productes.First
           productes.Sort
           productes.Find
           productes.FindAll*/

        ///Exercicis:
        ///Completa el següents mètodes utilitzant els mètodes de List 
        ///i sense utilitzar l'accés directe a l'array
        /// 
        /// <summary>
        /// Mostra el numero total de productes
        /// </summary>
        public int TotalExistencies()
        {
            int result = 0;

            result = productes.Count();

            return (result);

        }

        /// <summary>
        /// Mostrar el primer element de la llista
        /// S'ha de portar el control si la llista està buida
        /// </summary>
        public Producte PrimerProducte()
        {
            Producte producte = null;

            if (productes.Any())
                producte = productes.First();


            return (producte);
        }


        /// <summary>
        /// Mostrar el darrer element  de la llista
        /// S'ha de portar el control si la llista està buida
        /// </summary>
        public Producte DarrerProducte()
        {
            Producte producte = null;

            if (productes.Any())
                producte = productes.Last();

            return (producte);
        }

        /// <summary>
        /// Insereix un element al principi de la llista
        /// </summary>
        public void InserirProductePrincipiLlista(Producte producte)
        {
            productes.Insert(0, producte);


        }

        /// <summary>
        /// Esborra tots els elements segons un preu
        /// </summary>        
        public void EsborrarProductesPerPreu(double preu)
        {


            productes.RemoveAll(a => a.Preu_sense_iva == preu);

        }

    }  

    
}
