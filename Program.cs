namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
                        
            Console.WriteLine("Welcome to the  Line Comparion Program.");

            Console.WriteLine("Enter the line co-ordinates as x1,y1,x2,y2: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            LineComputation.LengthOfLine(x1, y1, x2, y2);
        }
    }
}