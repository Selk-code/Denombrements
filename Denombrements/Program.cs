using System;

//Test de commit
namespace Denombrements
{
   class Program
    {

        /// <summary>
        /// Module Principal
        /// </summary>  
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) 
                { 
                    Environment.Exit(0); 
                }
                else if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre

                    // calcul de resultat
                    long resultat = 1;
                    for (int k = 1; k <= n; k++)
                    {
                        resultat *= k;
                    }

                    Console.WriteLine(n + "! = " + resultat);
                }
                else if (c == 2)
                {
                    // saisie d'éléments et sous ensemble
                    Console.Write("nombre total d'éléments à gérer = ");
                    int t = int.Parse(Console.ReadLine());
                    Console.Write("nombre d'éléments dans le sous ensemble = ");
                    int n = int.Parse(Console.ReadLine());

                    // calcul de r
                    long resultat = 1;
                    for (int k = (t - n + 1); k <= t; k++)
                    {
                        resultat *= k;
                    }
                    Console.WriteLine("A(" + t + "/" + n + ") = " + resultat);
                }
                else if (c == 3)
                {
                    // saisie d'éléments et sous ensemble
                    Console.Write("nombre total d'éléments à gérer = ");
                    int t = int.Parse(Console.ReadLine());
                    Console.Write("nombre d'éléments dans le sous ensemble = ");
                    int n = int.Parse(Console.ReadLine());

                    // calculs
                    long resultat1 = 1;
                    for (int k = (t - n + 1); k <= t; k++)
                    {
                        resultat1 *= k;
                    }
                    long resultat2 = 1;
                    for (int k = 1; k <= n; k++)
                    {
                        resultat2 *= k;
                    }

                    Console.WriteLine("C(" + t + "/" + n + ") = " + (resultat1 / resultat2));

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Veuillez saisir un choix valide !");
                }   
            }
            Console.ReadLine();
        }
    }
}
