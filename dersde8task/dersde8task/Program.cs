using System;

namespace dersde8task
{
    internal class Program
    {
        static bool IsFullName(string input)
        {
            input= input.Trim();
            var result=input.Split(' ');
            string[] mainResult = new string[0];
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i]!="")
                {
                    Array.Resize(ref mainResult,mainResult.Length+1);
                    mainResult[mainResult.Length - 1] = result[i];
                }
            }
            for (int i = 0; i < mainResult.Length; i++)
            {
                if (char.IsUpper(mainResult[i][0]) == false)
                {
                    return false;
                }
                else
                {
                    for (int j = 1; j < mainResult[i].Length; j++)
                    {
                        if (char.IsLower(mainResult[i][j]) == false)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        static bool IsGroupNo(string groupNo) 
        {
            groupNo= groupNo.Trim();
            if (char.IsUpper(groupNo[0])==false||groupNo.Length!=4)
            {
                return false;
            }
            else
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (char.IsDigit(groupNo[i])==false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            #region Dersde olan hisse
            //Bycle firstBycle=new Bycle();
            //firstBycle.Drive(5);
            //firstBycle.Drive(10);
            //Console.WriteLine(firstBycle.Millage);


            //Bycle[] arr = new Bycle[3];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Brend:");
            //    string brend=Console.ReadLine();

            //    Console.WriteLine("Model:");
            //    string model = Console.ReadLine();

            //    Console.WriteLine("Mileage");
            //    int mile=Convert.ToInt32(Console.ReadLine());

            //    Bycle bc = new Bycle() {Brand=brend,Model=model,Millage=mile };
            //    arr[i] = bc;
            //}
            //Console.WriteLine("1. Butun velosipedler");
            //Console.WriteLine("2. Model axtarishi edin");

            //string input = Console.ReadLine();
            //if (input=="1")
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine($" Brend {arr[i].Brand} + Model {arr[i].Model} + Mileage {arr[i].Millage}");
            //    }
            //}
            //else if (input=="2")
            //{
            //    Console.WriteLine("Modeli daxil edin");
            //    string input2=Console.ReadLine();
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i].Model.IndexOf(input2)!=-1 )
            //        {
            //            Console.WriteLine($" Brend {arr[i].Brand} + Model {arr[i].Model} + Mileage {arr[i].Millage}");
            //        }
            //    }
            //}
            #endregion
            Student[] students=new Student[0];
            string input="Salam";
            do
            {
                Console.WriteLine("1. Butun telebelere bax.");
                Console.WriteLine("2. Telebeler uzre axtarish et.");
                Console.WriteLine("3. Telebe elave et.");
                Console.WriteLine("0. Menyudan chix");
                input= Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (students.Length == 0)
                        {
                            Console.WriteLine("\nHal hazirda qeydiyyatda telebe yoxdur.\n");
                            Console.WriteLine("Menyuya qayitmaq uchun ENTER duymesini basin");
                            Console.ReadLine();
                            break;
                        }
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine("\nTelebenin siyahi qeydiyyat nomresi: "+(i+1));
                            students[i].ShowInfo();
                        }
                        Console.WriteLine("Menyuya qayitmaq uchun ENTER duymesini basin");
                        Console.ReadLine();
                        break;
                    case "2":
                        if (students.Length==0)
                        {
                            Console.WriteLine("\nHal hazirda qeydiyyatda telebe yoxdur.\n");
                            Console.WriteLine("Menyuya qayitmaq uchun ENTER duymesini basin");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {

                        }
                        Console.WriteLine("\nZehmet olmasa axtarish etdiyiniz parametri daxil edin");
                        string input2=Console.ReadLine();
                        bool hasStudent = true;
                        foreach (var item in students)
                        {
                            if (item.FullName.IndexOf(input2)!=-1 || item.GroupNo.IndexOf(input2) != -1)
                            {
                                Console.WriteLine("\nNetice tapildi: ");
                                item.ShowInfo();
                            }
                            else
                            { 
                                hasStudent = false;
                            }
                        }
                        if (hasStudent ==false)
                        {
                            Console.WriteLine("\nNetice tapilmadi: ");
                            Console.WriteLine("Axtardiginiz telebe qeydiyyatimizda yoxdur\n");
                        }
                        do
                        {
                            Console.WriteLine("\n1. Axtarisha davam etmek uchun 1 daxil edin");
                            Console.WriteLine("Menyuya qayitmaq uchun Enter duymesine basin.");
                            input2= Console.ReadLine();
                            bool hasStudent2=true;
                            if (input2=="1")
                            {
                                Console.WriteLine("\nZehmet olmasa axtarish etdiyiniz parametri daxil edin");
                                input2 = Console.ReadLine();
                                foreach (var item in students)
                                {
                                    if (item.FullName.IndexOf(input2) != -1||item.GroupNo.IndexOf(input2)!=-1)
                                    {
                                        Console.WriteLine("\nNetice tapildi: ");
                                        item.ShowInfo();
                                    }
                                    else
                                    {
                                        hasStudent2 = false;
                                    }
                                }
                                if (hasStudent2==false)
                                {
                                    Console.WriteLine("\nNetice tapilmadi: ");
                                    Console.WriteLine("Axtardiginiz telebe qeydiyyatimizda yoxdur");
                                }
                            }

                        } while (input2=="1" );
                        break;
                    case "3":
                        string stFulllName;
                        string stGroupNom;
                        do
                        {
                            Console.WriteLine("\nZehmet olmasa telebenin adini ve soyadini daxil edin(Daxil etdiyiniz ad ve soyadlarda ilki boyuk ve digerleri kichik HERF-ler olmalidir) : ");
                            stFulllName = Console.ReadLine();
                        } while (IsFullName(stFulllName)==false);
                        do
                        {
                            Console.WriteLine("Zehmet olmasa telebenin group nomresini daxil edin(Qrup nomresi boyuk herf ve 3 reqemden ibaret olmalidir : ");
                            stGroupNom = Console.ReadLine();
                        } while (IsGroupNo(stGroupNom)==false);
                        Student student = new Student(stFulllName,stGroupNom);
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length-1]=student;
                        Console.WriteLine("Menyuya qayitmaq uchun ENTER duymesini basin");
                        Console.ReadLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("\nZehmet olmasa sechiminizi duzgun daxil edin. Siz 0,1,2 ve ya 3 seche bilersiz.\n");
                        break;
                }
            } while (input!="0");

        }
    }
}
