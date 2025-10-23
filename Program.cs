namespace ES
{
    internal class Program
    {
        //funzione MEDIA DISPARI
        static double media(int a, int b)
        {

            int c = 0;
            int S = 0;
            for (int i = a; i < b; i++)
            {

                if (i % 2 == 0)
                {
                    S = S + i;
                    c++;
                }


            }
            return S / c;

        }

        //funzione FATTORIALE
        static int Fattoriale(int n)
        {
            int p = 1;
            for (int i = n; i >= 1; i--)
            {
                p = p * i;



            }


            return p;

        }
        // funzione NUMERO PERFETTO

        static bool NP(int np)
        {
            int som=0;
            for (int i = 2; i != np; i++)
            {
                if (np % i == 0)
                {
                    som=som + i;
                }
            }
            if(som == np)
            {
                return true;
            }
            return false;
        }

       
        static void Main(string[] args)
        {
            // Main MEDIA dispari

            Console.WriteLine("dimmi il primo numero dell intervallo ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dimmi il primo numero dell intervallo ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            double risultato = media(n1, n2);
            Console.WriteLine("la media dell intervallo e " + risultato);

            // main FATTORIALE

            Console.WriteLine("dimmi il  numero ");
            int n = Convert.ToInt32(Console.ReadLine());

            int risultato2 = Fattoriale(n);

            Console.WriteLine("il fattoriale e " + risultato2);

            // main NUMERO PERFETTO

            int contatore=0;

            for (int Y = 2; Y < 50; Y++)
            {
                if (NP(Y) == true)
                {
                    Console.WriteLine(" il numero  " + np + " e perfetto");
                    contatore++;
                }
                else
                {
                    Console.WriteLine("il numero" + np + "non e perfetto");
                }
            }
            Console.WriteLine("i numeri da 1 a 50 sono" + contatore);
        }
    }
}
