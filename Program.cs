namespace ConsoleApp2
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Wage_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 100;

        public static int computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0; 
            int totalEmpHrs = 0;
            
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays<Num_Of_Working_Days)
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
                Console.WriteLine("Total Emp Wage :" + totalWorkingDays + " Emp Hrs : " + empHrs);
                }
            int totalEmpWage = totalEmpHrs * Emp_Wage_Per_Hour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;
        }     
       static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}