using System;
/*
 * 
 * 
 * 
 * 
 */

namespace Denombrements
{
    class Program
    {
        static long Facto(int valDepart, int valArrive)
        {
            long r = 1;
            for (int k = valDepart; k <= valArrive; k++)
            {
                r *= k;
            }
            return r;
        }
        static void Main(string[] args)
        {
            
                
            string rep = "1";
            while (rep != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                rep = (Console.ReadLine());

                if (rep == "1" || rep == "2" || rep  == "3")
                {
                    try
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbElem = int.Parse(Console.ReadLine());
                    
                        if (rep == "1")
                        {
                            Console.WriteLine(nbElem + "! = " + Facto(1, nbElem));
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            int nbEns = int.Parse(Console.ReadLine()); // saisir le nombre   
                            if (rep == "2")
                            {
                                Console.WriteLine("A(" + nbElem + "/" + nbEns + ") = " + Facto(nbElem - nbEns + 1, nbElem));
                            }
                            else
                            {
                                Console.WriteLine("C(" + nbElem + "/" + nbEns + ") = " + (Facto(nbElem - nbEns + 1, nbElem) / Facto(1, nbEns)));
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("La saisie est incorect ou le nombre est trop grand");
                    }
                }

            }
        }
    }
}
