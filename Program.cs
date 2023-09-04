namespace ConsoleApp2
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0; 
            int totalEmpHrs = 0;
            
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# :" + totalWorkingDays + " Emp Hrs : " + empHrs);
                }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;
        }     
       static void Main(string[] args)
        {
            computeEmpWage("Vi", 20,30,100);
            computeEmpWage("Jio",20,20,30);
        }
    }
}