﻿using System.Collections.Generic;

namespace Lab.Linq101.Groupby
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
                    {
                        new Student { ID = 1001, Name = "Preety", Gender = "Female",Branch = "CSE", Age = 20 },
                        new Student { ID = 1002, Name = "Snurag", Gender = "Male",Branch = "ETC", Age = 21  },
                        new Student { ID = 1003, Name = "Pranaya", Gender = "Male",Branch = "CSE", Age = 21  },
                        new Student { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
                        new Student { ID = 1005, Name = "Hina", Gender = "Female",Branch = "ETC", Age = 20 },
                        new Student { ID = 1006, Name = "Priyanka", Gender = "Female",Branch = "CSE", Age = 21 },
                        new Student { ID = 1007, Name = "santosh", Gender = "Male",Branch = "CSE", Age = 22  },
                        new Student { ID = 1008, Name = "Tina", Gender = "Female",Branch = "CSE", Age = 20  },
                        new Student { ID = 1009, Name = "Celina", Gender = "Female",Branch = "ETC", Age = 22 },
                        new Student { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 21 }
                    };
        }
    }
}