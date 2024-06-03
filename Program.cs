namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            string number = Console.ReadLine();
            int sum = 0; 
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i] - '0';
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }

        
    }
}
