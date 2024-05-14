namespace GameVT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oyun onamaq isdeyirsimi ? (y/n)");
            char game = char.Parse(Console.ReadLine());
            if (game =='y' || game == 'Y')
            {
                Console.WriteLine("Oyunlarin siyahisi?\n" +
                    "1.PUBG\n" +
                    "2.SUDOKU\n" +
                    "3.FIFA");
                Console.WriteLine("Oyun sec:");
                int chooseGame = int.Parse(Console.ReadLine());
                if (chooseGame ==1)
                {
                    Console.WriteLine("PUBG");
                }
                else if(chooseGame ==2)
                {
                    Console.WriteLine("SUDOKU");
                }
                else if (chooseGame ==3)
                {
                    Console.WriteLine("FIFA");
                }
                else
                {
                    Console.WriteLine("Bele bir oyun yoxdur.");
                }
                Console.WriteLine("oyun puanini daxil edin: (10 uzerinden)");
                int gameScore = int.Parse(Console.ReadLine());
                Console.WriteLine($"Oyun novu: {chooseGame}");
                Console.WriteLine($"Oyun puani: {gameScore}");
            }
            else
            {
                Console.WriteLine("FINISH");
            }
        }
    }
}
