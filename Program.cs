using System;

namespace Home11
{
    class Student
    {

        public string Name { get; set; }

        private string student_lastname;
        public string LastName
        {
            get
            {
                return student_lastname;
            }
            set
            {
                student_lastname = value;
            }
        }

        public Student(string last1name)
        {
            LastName = last1name;
        }

        private byte course;
        public byte Course_1
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        private int student_id;
        public int Student_id1
        {
            get
            {
                return student_id;
            }
            set
            {
                student_id = value;
            }
        }

        public static byte studentCount = 0;
        public Student[] data1;
        public Student()
        {
            studentCount++;
            data1 = new Student[studentCount];
        }
        public Student this[int a]
        {
            get
            {
                return data1[a];
            }
            set
            {
                data1[a] = value;
            }
        }
        public void ShowListStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Number of students: {studentCount}.");
            }
        }

    }



    class Aspirant : Student
    {

        public int Exam_result { get; set; }
        public Aspirant(string last1name, byte c0urse_1, int s1udent_id1)
            : base(last1name)
        {
            Course_1 = c0urse_1;
            Student_id1 = s1udent_id1;
        }
        public Aspirant()
        {

        }
        public void Print()
        {
            while (true)
            {
                Console.Write("Studen lastname: ");
                string LastName = Console.ReadLine();
                for (int i = 0; i < LastName.Length; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        if (LastName[i] == j.ToString()[0])
                        {
                            Console.WriteLine("Enter letters not number.");
                        }
                    }
                }
                break;
            }

            while (true)
            {
                Console.Write("Course: ");
                string n = Console.ReadLine();
                if (!byte.TryParse(n, out byte Course_1))
                {
                    Console.WriteLine("Enter number not letters.");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("Student ID: ");
                string n = Console.ReadLine();
                if (!int.TryParse(n, out int Student_id1))
                {
                    Console.WriteLine("Enter number not letters.");
                    continue;
                }
                break;
            }

        }
        public void Score()
        {
            while (true)
            {
                Console.Write("Enter exam result: ");
                string n = Console.ReadLine();
                if (!int.TryParse(n, out int score))
                {
                    Console.WriteLine("Enter number not letters.");
                    continue;
                }
                if (score < 0)
                {
                    Console.WriteLine("Enter not negativ number: ");
                    continue;
                }
                else
                {
                    if (score >= 0 && score <= 17)
                    {
                        Console.WriteLine("Unfortunately you are not passed :(");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you are passed :)");
                    }
                }
                break;
            }
        }
    }


    public class Scet
    {
        public Scet()
        {

        }
        public Scet(double sum, uint number_Scet, double open_Data)
        {
            Sum = sum;
            Number_Scet = number_Scet;
            Open_Data = open_Data;
        }
        private double sum;
        public double Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }
        public uint Number_Scet { get; set; }
        public double Open_Data { get; set; }
        public void Vidaca_Sum()
        {
            Console.WriteLine($"Summa: {Sum}, Number accaunt {Number_Scet}");
        }
        public void Vidaca_Open_Data()
        {
            Console.WriteLine($"Data : {Open_Data}");
        }
    }




    public class UridiceskoyeLico : Scet
    {
        public uint Vid_sceta_credit1 { get; set; }
        public UridiceskoyeLico(double sum, uint number_Scet, double open_Data, uint vid_sceta_credit1)
            : base(sum, number_Scet, open_Data)
        {
            Vid_sceta_credit1 = vid_sceta_credit1;
        }
        public void Nacisleniye_Procentov_1()
        {
            //byte.TryParse(n, out byte Course_1
            double Summa1 = Convert.ToDouble(Console.ReadLine());
            if (Summa1 >= 100000.0)
            {
                Console.WriteLine($"You have 15% {Summa1 * 15 / 100} per years on your balance");
            }
            else if (Summa1 < 100000.0 && Summa1 >= 5000.0)
            {
                Console.WriteLine($"You have 10% {Summa1 * 10 / 100} per years on your balance");
            }
            else
            {
                Console.WriteLine("Unfortunately you have not enought money for take procent");
            }
            Console.WriteLine("Would you like new operation? y/n");
            char b1 = Convert.ToChar(Console.ReadLine());
            while (b1 != 'N' && b1 != 'n' && b1 != 'y' && b1 != 'Y')
            {
                if (b1 == 'Y' || b1 == 'y')
                {
                    continue;
                }
                else if (b1 == 'N' || b1 == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter y(Y) or n(N)");
                }
            }
        }
    }


    public class FiziceskoyeLico : Scet
    {
        public uint Vid_sceta_credit { get; set; }
        public FiziceskoyeLico(double sum, uint number_Scet, double open_Data, uint vid_sceta_credit)
        : base(sum, number_Scet, open_Data)
        {
            Vid_sceta_credit = vid_sceta_credit;
        }
        public void Procent()
        {
            Console.Write("Enter how many dollar you want to give for depozit: ");
            double Summa = Convert.ToDouble(Console.ReadLine());
            if (Summa <= Sum)
            {
                Console.WriteLine($"You have 5% {Summa * 5 / 100} dollar per years on your balance");
            }
        }
        public void Withdraw()
        {
            while (true)
            {
                Console.Write("Enter how many money do you want to take:");
                uint a = Convert.ToUInt32(Console.ReadLine());
                if (Sum >= a)
                {
                    Console.WriteLine($"Please it's your {a} money");
                    Console.WriteLine("Would you like new operation ? y/n");
                    char b = Convert.ToChar(Console.ReadLine());
                    while (b != 'N' && b != 'n' && b != 'y' && b != 'Y')
                    {
                        if (b == 'Y' || b == 'y')
                        {
                            continue;
                        }
                        else if (b == 'N' || b == 'n')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter y or n");
                        }
                    }
                }
                else if (Sum < a)
                {
                    Console.WriteLine($"Sorry u have only {Sum} money");
                }
                break;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question №1");
            while (true)
            {
                Aspirant Ali1 = new Aspirant();
                Student Ali = new Student();
                Ali[0] = new Student();
                Ali1[0] = new Aspirant("Dovrushov", 2, 8626665);

                Ali1.Print();
                Ali1.Score();

                Console.WriteLine("Do you want enter new student ? y/n");

                string choice = Console.ReadLine();

                if (choice == "y" || choice == "Y")
                {
                    Ali.ShowListStudent();
                    continue;
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("Have a good day! :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Y/y or N/n ");
                    choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y")
                    {
                        continue;
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("Have a good day! :)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Y/y or N/n ");
                        choice = Console.ReadLine();
                        if (choice == "y" || choice == "Y")
                        {
                            continue;
                        }
                        else if (choice == "n" || choice == "N")
                        {
                            Console.WriteLine("Have a good day! :)");
                            break;
                        }
                    }
                }

            }
            Console.WriteLine("Press any button...");
            Console.ReadKey();
            Console.WriteLine("Hello welcome to online banking");
            Console.WriteLine("Please choose type of Face 1 or 2");
            Console.WriteLine("1) Individual");
            Console.WriteLine("2) Entity");
            byte switch_on = Convert.ToByte(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    Console.WriteLine("Individual");
                    FiziceskoyeLico Fiz = new FiziceskoyeLico(100000.0, 13, 14.6, 2);
                    Console.WriteLine("1) Accrual of interest(%)");
                    Console.WriteLine("2) Withdraw");
                    byte choice = Convert.ToByte(Console.ReadLine());
                    if (choice == 1)
                    {
                        Fiz.Procent();
                    }
                    if (choice == 2)
                    {
                        Fiz.Withdraw();
                    }
                    break;
                case 2:
                    Console.WriteLine("Entity");
                    UridiceskoyeLico Uri = new UridiceskoyeLico(100000.0, 13, 14.6, 2);
                    Console.WriteLine("Enter how many money do you want give depozit");
                    Uri.Nacisleniye_Procentov_1();
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2 please.");
                    break;
            }

        }
    }
}
