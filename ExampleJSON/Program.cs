using System;
using Newtonsoft.Json;
using Models;

namespace ExampleJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Input JSON -");

            var json = SerializeJSON();

            Console.WriteLine(json);
            Console.WriteLine("- Output JSON -");

            var student = DeserializeJSON(json);

            Console.WriteLine(string.Format("Student.Name: {0}", student.Name));
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static string SerializeJSON()
        {
            var student = MockStudentData();
            return JsonConvert.SerializeObject(student);
        }

        private static Student DeserializeJSON(string jsonExample)
        {
            return JsonConvert.DeserializeObject<Student>(jsonExample);
        }

        #region Fake Data

        private static Student MockStudentData()
        {
            return new Student()
            {
                Name = "Eduardo Teste",
                Address = "Rua Teste",
                Email = "email@gmail.com",
                Age = 20
            };
        }

        #endregion 

    }
}