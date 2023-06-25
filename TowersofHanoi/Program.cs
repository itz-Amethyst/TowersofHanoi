namespace TowersofHanoi;

class Program
{
    static void Main(string[] args)
    {
        TowerOfHanoi T = new TowerOfHanoi();

        string cnumdiscs;

        Console.WriteLine("Enter the number of discs: ");

        cnumdiscs = Console.ReadLine();

        T.numdiscs = Convert.ToInt32(cnumdiscs);

        T.MoveTower(T.numdiscs, 1, 3, 2);

        Console.ReadLine();

    }
}