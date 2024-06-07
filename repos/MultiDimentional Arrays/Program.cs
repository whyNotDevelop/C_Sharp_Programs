using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[,] calories = { {100, 300, 1200},
                            {245, 456, 234 },
                            {1903, 1003,3452},
                            {2342, 234, 128},
                            {400, 233, 2321},
                            {1232, 305, 231},
                            {234, 2312, 1232}};

        string[] days = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
        double[] dailyAverage = CalculateAverageByDay(calories);

        Console.WriteLine(calories.GetUpperBound(0));//Return the highest row index
        Console.WriteLine("\tBreakfast\tLunch\t\tDinner");

        int rowsLen = calories.GetLength(0);
        int colLen = calories.GetLength(1);
        //Display all values i a tabular formate
        for (int row=0; row< rowsLen; row++ )
        {
            Console.Write(days[row]+"\t");
            for (int col=0; col< colLen; col++)
            {
                Console.Write(calories[row,col]+"\t\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i=0; i<dailyAverage.Length; i++)
        {
            Console.WriteLine("Average calos consumed on " + days[i] + ":" + dailyAverage[i]); 
        }
       
    }
    public static double[] CalculateAverageByDay(int[,] calos)
    {
        int sum = 0;
        double[] dailyAverage = new double[calos.GetLength(0)]; 
        for (int row=0;row< calos.GetLength(0); row++)
        {
            for(int col=0; col<calos.GetLength(1); col++)
            {
                sum = calos[row,col];
            }
            dailyAverage[row] = (double)sum/calos.GetLength(1);
            sum = 0;
        }
        return dailyAverage;
    }
}