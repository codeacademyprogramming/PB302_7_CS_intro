using System;
using System.Xml;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int student_count = 45;
            //int StudentCount = 45;
            int studentCount = 45;

            if (studentCount > 20)
            {
                Console.WriteLine("iveride cox telebe var");
                Console.WriteLine("Telebe limiti asilib");
            }
            else if (studentCount == 20)
                Console.WriteLine("Telebe limiti dolub");
            else
                Console.WriteLine("Yeni telebe yeri var");

            int weekDay = 6;

            if (weekDay == 1)
                Console.WriteLine("Bazar ertesi");
            else if (weekDay == 2)
                Console.WriteLine("Versenbe axsami");
            else if (weekDay == 3)
                Console.WriteLine("Cersenbe");
            else if (weekDay == 4)
                Console.WriteLine("Cume axsami");
            else if (weekDay == 5)
                Console.WriteLine("Cume");
            else if (weekDay == 6 || weekDay==7)
                Console.WriteLine("Heftesonu");
            else Console.WriteLine("Gun yanlisdir!");

            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Versenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                //case 6:
                //case 7:
                //    Console.WriteLine("Heftesonu");
                case 6:
                    Console.WriteLine("Heftesonu");
                    break;
                case 7:
                    goto case 6;
                default:
                    Console.WriteLine("Gun yanlisdir!");
                    break;
            }

            int number = 45;
            Console.WriteLine(number);

         

            Console.WriteLine("M ededini daxil edin:");
            string mStr = Console.ReadLine();
            int m = Convert.ToInt32(mStr);

            Console.WriteLine("N ededini daxil edin:");
            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);

            int sum = 0;
            //for (int i = m; i < n; i++)
            //{
            //    sum += i;
            //}

            while (m < n)
            {
                sum += m;
                m++;
            }
            Console.WriteLine(sum);


            Console.WriteLine("Heftenin gununu daxil et:");
            string dayStr = Console.ReadLine();
            int day = Convert.ToInt32(dayStr);

            if (day >= 1 && day <= 5)
                Console.WriteLine("hefte ici");
            else if (day == 6 || day == 7)
                Console.WriteLine("heftesonu");
            else
                Console.WriteLine("yanlisdir!");

            Console.WriteLine("Musbet eded daxil edin!");

            int positivNum;
            do
            {
                string positivNumStr = Console.ReadLine();
                positivNum = Convert.ToInt32(positivNumStr);
            }
            while (positivNum <= 0);

            Console.WriteLine(positivNum);


            //int[] nums = { 34, 4, 76, 8 };
            //int[] nums = new int[] { 34, 5, 6, 7 };
            //int[] nums = new int[5];
            int[] nums = new int[5] { 34,5,7,23,45};

            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            //string output = "En boyuk eded: " + max;
            string output = $"En boyuk eded: {max}";
            Console.WriteLine(output);


            string name = "Hikmet";
            string surname = "Abbasov";
            string fullname = name + " " + surname + 56 ;
            Console.WriteLine(fullname);

            char[] letters = { 'A', 'b', 'b', 'a', 's', 'o', 'v' };
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }
            for (int i = 0; i < surname.Length; i++)
            {
                Console.WriteLine(surname[i]);
            }
                
        }
    }
}
