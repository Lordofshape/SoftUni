using System;

namespace T05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FINE_TAB_FACEBOOK = 150;
            const int FINE_TAB_INSTAGRAM = 100;
            const int FINE_TAB_REDDIT = 50;
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());



            for (int i = 0; (i < tabs)&&(salary>0); i++)
            {
                string tab = Console.ReadLine();
                if (tab=="Facebook")
                {
                    salary -= FINE_TAB_FACEBOOK;
                }
                else if (tab=="Instagram")
                {
                    salary -= FINE_TAB_INSTAGRAM;
                }
                else if (tab=="Reddit")
                {
                    salary -= FINE_TAB_REDDIT;
                }
                if (salary==0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
