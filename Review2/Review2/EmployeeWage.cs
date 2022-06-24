using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review2
{
    abstract class EmployeeWage
    {
        public abstract void EmpWageCalculation();
        
    }
    
    class Employee : EmployeeWage
    {
        public const float empwageperhour = 20;
        public const int fulltime_working_hours_perday = 8;
        public const int parttime_working_hours_perday = 4;
        public const int is_full_time = 1;
        public const int is_part_time = 2;
        public const int is_absent = 0;
        public const int num_workingdays_per_month = 20;
        public float empmonthlywage = 0;
        float empdailywage = 0;
        public override void EmpWageCalculation()
        {
            Random random = new Random();
            int isemployeepresent = random.Next(0, 3);



            int daynumber = 1;
            int empworkinghours = 0;
            while (daynumber <= num_workingdays_per_month)
            {

                switch (isemployeepresent)
                {
                    case is_absent:
                        empworkinghours = 0;
                        break;

                    case is_part_time:
                        empworkinghours = parttime_working_hours_perday;
                        break;

                    case is_full_time:
                        empworkinghours = fulltime_working_hours_perday;
                        break;
                }
                empdailywage = empworkinghours * empwageperhour;

                empmonthlywage += empdailywage;
                daynumber++;
            }
            Console.WriteLine("employee monthly{0} employedaily wage {1} :",  empmonthlywage ,empdailywage);
        }
    }
}
    
