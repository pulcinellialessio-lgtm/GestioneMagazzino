namespace GestioneMagazzino
{
    internal class Program
    {
        static void InserimentoProdotti(int Nprodotti)   // input dati
        {
            string[] prodotti = new string[Nprodotti];

            for (int i = 0; i < Nprodotti; i++)
            {
                Console.WriteLine("Dimmi il " + (i + 1) + " prodotto");
                string NomeProdotti = Console.ReadLine();

                prodotti[i] = NomeProdotti;
            }



            int[] Quantità = new int[Nprodotti];

            for (int i = 0; i < Nprodotti; i++)
            {
                Console.WriteLine("Dimmi la quantita di " + prodotti[i]);
                int Q = Convert.ToInt32(Console.ReadLine());

                Quantità[i] = Q;
            }


            double[] prezzo = new double[Nprodotti];

            for (int i = 0; i < Nprodotti; i++)
            {
                Console.WriteLine("Dimmi il prezzo di " + prodotti[i]);
                double P = Convert.ToDouble(Console.ReadLine()); 

                prezzo[i] = P;
            }

            Console.WriteLine("Il valore del magazzino è: " + valoreMagazzino(Quantità, Nprodotti, prezzo));

            Console.WriteLine("Dimmi una soglia");
            int soglia = Convert.ToInt32(Console.ReadLine());

            Soglia(Quantità, Nprodotti, prodotti, soglia);
        }
        static double valoreMagazzino(int[] Quantità,  int Nprodotti, double[] prezzo)  // valore magazzino
        {
            double valore = 0;

            for(int i = 0; i < Nprodotti; i++)
            {
                valore = Quantità[i] * prezzo[i];
            }

            return valore;
        }
        static void Soglia(int[] Quantità, int Nprodotti, string[] prodotti, int soglia)  // soglia
        { 
            int a = 0;

            for(int i = 0; i < Nprodotti; i++)
            {
                if(soglia > Quantità[i])
                {
                    a++;
                    Console.WriteLine("I prodotti con quantità superiore alla soglia inserita sono " + prodotti[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi quanti prodotti vuoi inserire nel magazzino");
            int Nprodotti = Convert.ToInt32(Console.ReadLine());

            InserimentoProdotti(Nprodotti);

        }
    }
}
