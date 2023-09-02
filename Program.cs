namespace Cal_EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Emp = random.Next(0, 2);
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;

            if (Emp == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage are: " + empWage);
        }
    }
}