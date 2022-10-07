using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentApplication1
{
    public static class Menu
    {
        public static void MainMenu(List<Student> student_list)
        {
            try
            {
                bool showMenu = true;
                string filePath = "data.save"; 
                do
                {
                    string option;
                    WriteLine("----------------choose an option to perform:------------------");
                    WriteLine("1) Add a student.");
                    WriteLine("2) Delete a student.");
                    WriteLine("3) update a student.");
                    WriteLine("4) display the student.");
                    WriteLine("5) exit .");
                    WriteLine("6) Serialization.");
                    WriteLine("7) Deserialization");
                    WriteLine("---------------------------------------------------------------");
                    option = ReadLine();

                    WriteLine("choice entered is : {0}", option);
                    switch (option)
                    {
                        case "1"://add 
                            WriteLine("Enter the number of student record which you want to add ---");
                            int numOfRecords = Convert.ToInt32(ReadLine());
                            CrudOperations.AddRecord(student_list, numOfRecords);

                            break;

                        case "2"://delete
                            int target = -1;
                            CrudOperations.deleteRecord(student_list, target);
                            break;

                        case "3"://update

                            CrudOperations.updateStudent(student_list);
                            break;

                        case "4"://display
                            CrudOperations.Display(student_list);
                            break;

                        case "5":
                            showMenu = false;
                            break;

                        case "6":
                            
                            DataSerializer.BinarySerialize(student_list, filePath);
                            break;
                        case "7":
                            DataSerializer.BinaryDeserialize(student_list,filePath);
                            break;
                        default:
                            WriteLine("Invalid option\n Please try again .......");
                            break;
                    }

                } while (showMenu);
            }
            catch (Exception message)
            {
                WriteLine(" ", message.Message);
            }
        }
    }
}

