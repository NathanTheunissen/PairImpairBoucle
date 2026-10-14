namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */

        int testedNumber = 0;
        string continueTesting;
        do
        {
            Console.WriteLine(">Veuillez entrer un nombre : ");
            testedNumber = Convert.ToInt32(Console.ReadLine());

            if (testedNumber % 2 == 0)
            {
                Console.WriteLine("Le nombre donné est pair");
            }
            else
            {
                Console.WriteLine("Le nombre donné est impair");
            }

            Console.WriteLine(">Voulez-vous proposer un autre nombre ? (y/n)");
            continueTesting = Console.ReadLine();
        } while (continueTesting == "y");


    }
}
