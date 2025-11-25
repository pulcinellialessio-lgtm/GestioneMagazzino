namespace GestioneMagazzino
{
    internal class Program
    {
        static void InserimentoProdotti(int Nprodotti)
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
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Dimmi quanti prodotti vuoi inserire nel magazzino");
            int Nprodotti = Convert.ToInt32(Console.ReadLine());

            InserimentoProdotti(Nprodotti);
        }
    }
}
