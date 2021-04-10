using Lab.Linq101.DynamicDataClass;
using Lab.Linq101.Groupby;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Linq;

// reference: Get Value from dynamic object: https://stackoverflow.com/questions/8631546/get-property-value-from-c-sharp-dynamic-object-by-string-reflection/14011692

namespace Lab.Linq101
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var rows = GetDataTable();

            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(GetDataTable());


            DataClass dataClass = new DataClass();

            var dynamicObject = dataClass.CreateDataClass();

            //TestGroupBy();
            foreach (var item in dynamicObject)
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void TestGroupBy()
        {
            // #1
            //var groupByResult = Student.GetStudents().GroupBy(x => x.Barnch);

            // #2
            //var groupByResult = Student.GetStudents().GroupBy(x => x.Barnch)
            //                    .Select(g=> new
            //                    {
            //                        Key = g.Key,
            //                        Students = g.OrderBy(s=>s.Name)
            //                    });

            // #3
            //var groupByResult = Student.GetStudents().GroupBy(x => x.Branch, (key, g) => new { Id = key, Students = g.ToList() });
            var groupByResult = Student.GetStudents()
                                       .GroupBy(x => x.Branch,
                                                (key, g) => new
                                                {
                                                    Id = key,
                                                    Students = g.Select(x =>
                                                    new Student { Name = x.Name, Age = x.Age, Branch = x.Branch, Gender = x.Gender, ID = x.ID })
                                                });

            foreach (var item in groupByResult)
            {
                Console.WriteLine($"Key: {item.Id}");

                foreach (var student in item.Students)
                {
                    Console.WriteLine($"    Student: {MapToString(student)}");
                }
            }
        }

        private static string MapToString(Student student)
        {
            return string.Join(":", student.ID, student.Name, student.Age, student.Branch);
        }

        private static DataTable GetDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Diagnosis", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Step 3: here we add rows.
            table.Rows.Add(25, "Drug A", "Disease A", DateTime.Now);
            table.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now);
            table.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now);
            table.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now);
            return table;
        }
    }
}