namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Emp = random.Next(0, 3);
            int Is_Part_Time = 1;
            int Is_Full_Time = 2;
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;

            if (Emp == Is_Part_Time)
            {
                empHrs = 4;
            }
            else if (Emp == Is_Full_Time) { 
                empHrs = 8;
            }
            else{
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage : " + empWage);

        }
    }
}
