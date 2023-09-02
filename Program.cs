namespace ConsoleApp1
{
    internal class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        static void Main(string[] args)
        {
            
            int empHrs = 0;
            int empWage = 0;
            int Emp_Rate_Per_Hour = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 3);


            switch (empCheck)
            {
                case Is_Part_Time:
                    empHrs = 4;
                    break;

                case Is_Full_Time:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0; 
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}