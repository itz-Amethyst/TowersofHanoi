namespace TowersofHanoi
{
    public class TowerOfHanoi
    {
         int M_Numdiscs;

         public TowerOfHanoi()
         {
             numdiscs = 0;
         }

         public TowerOfHanoi(int newVal)
         {
            numdiscs = newVal;
         }

         public int numdiscs
         {
             get
             {
                 return M_Numdiscs;
             }

             set
             {
                 if (value > 0)
                 {
                     M_Numdiscs = value;
                 }
             }
         }

         public void MoveTower(int n, int from, int to, int other)
         {
             if (n > 0)
             {
                 MoveTower(n - 1 , from , other , to);

                 Console.WriteLine($"Move disk {n} From tower {from} to tower {to}" , n , from , to);

                 MoveTower(n-1 , other , to , from);
             }
         }
    }
}
