namespace CheckEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Emp = random.Next(0, 2);
            int Is_Full_Time = 0;
            if (Emp == Is_Full_Time)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is not Present");
            }
        }
    }
}