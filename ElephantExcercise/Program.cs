namespace ElephantExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant laura = new Elephant() { Name = "Laura", EarSize = 80};
            Elephant lucek = new Elephant() { Name = "Lucek", EarSize = 100 };

            Console.WriteLine("Wciśnij [1] Lucek, [2] Laura, [3] przestawienie referencji, [4] Hear Message");

            while (true)
            { 
                char keyChar = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Wcisnąłeś [" +  keyChar + "]");
                if (keyChar == '1')
                {
                    Console.WriteLine("Wywołanie lucek.WhoAmI()");
                    lucek.WhoAmI();
                }
                else if (keyChar == '2')
                {
                    Console.WriteLine("Wywołanie laura.WhoAmI()");
                    laura.WhoAmI();
                }
                else if (keyChar == '3')
                {
                    Elephant holder;
                    holder = laura;
                    laura = lucek;
                    lucek = holder;

                    Console.WriteLine("Referencje zostały przestawione");
                }
                else if(keyChar == '4')
                {
                    laura.SpeakTo(lucek, "Cześć, Lucku!");
                }
                else
                    return;

                Console.WriteLine();
            }
        }
    }
}
