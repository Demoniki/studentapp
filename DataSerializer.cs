using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
    

namespace StudentApplication1
{
    static class DataSerializer
    {
        public static void BinarySerialize(List<Student> student_list,string filePath)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();

            //delete the existing file 
            if (File.Exists(filePath))
                File.Delete(filePath);
            //create a new file 
            fileStream = File.Create(filePath);
            formatter.Serialize(fileStream,student_list);
            fileStream.Close();
        }
        public static void BinaryDeserialize(List<Student> student_list,string filepath)
        {
           
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream;

            if (File.Exists(filepath))
            {
                fileStream = File.OpenRead(filepath);
                object obj = formatter.Deserialize(fileStream);
                fileStream.Close();
              
              for(int i=0;i<student_list.Count;i++)
                {
                    Console.WriteLine(student_list[i].Name+ " "+ student_list[i].Id+" "+ student_list[i].Branch);
                    
                  
                }
             
            }
        }
    }
}
