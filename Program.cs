namespace ConsoleApp1
{
    internal class Program
    {
        public const int Is_part_Time = 1;
        public const int Is_Full_Time = 2;
        

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorlingDays, int maxHourPerMonth)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorlingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_part_Time:
                        empCheck = 4;
                        break;

                    case Is_Full_Time:
                        empCheck = 8;
                        break;

                    default:
                        empCheck = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("days: " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage For company : " + company+ "is: "+ totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart",20,2,10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}