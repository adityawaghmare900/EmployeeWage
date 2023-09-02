namespace CheckEmp
{
    internal class Program
    {
        int Is_Part_Time = 1;
        int Is_Full_Time = 2;
        int Emp_Rate_Per_Hour = 20;
        int Num_Of_Working_Days = 2;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; Num_Of_Working_Days; int++)
            {
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
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("total Emp Wage : " + totalEmpWage);
        }

    }
