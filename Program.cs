namespace CheckEmp
{
    internal class Program
    {
        int Is_Part_Time = 1;
        int Is_Full_Time = 2;
        int Emp_Rate_Per_Hour = 20;
        int Num_Of_Working_Days = 2;
        int max_Hrs_In_Month = 10;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int totEmpHrs = 0;
            int totalworkingDays = 0;

            while(totalEmpHrs<=Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalworkingDays++;
                Random random = new Random();
                int Emp = random.Next(0, 3);
                switch (Emp)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                }
                totalEmpWage += empHrs;
                Console.WriteLine("Days : " + totalworkingDays + "Employee Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("total Emp Wage : " + totalEmpWage);
        }

    }
