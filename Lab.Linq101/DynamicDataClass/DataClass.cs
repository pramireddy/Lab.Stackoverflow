using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic.Core;

// references :
// https://github.com/zzzprojects/System.Linq.Dynamic/wiki/Dynamic-Expressions
// https://stackoverflow.com/questions/3862226/how-to-dynamically-create-a-class

namespace Lab.Linq101.DynamicDataClass
{
    public class DataClass
    {
        public IEnumerable<dynamic> CreateDataClass()
        {
            IList<dynamic> objects = new List<dynamic>();

            var list = new Dictionary<string, string> {
                    { "EmployeeID","System.Int32"},
                    { "EmployeeName","System.String"},
                    {"Service","Lab.Linq101.DynamicDataClass.OpticalService" } };

            var props = list.Select(property => new DynamicProperty(property.Key, Type.GetType(property.Value))).ToList();

            Type Empoyee = DynamicClassFactory.CreateType(props);

            

            int n = 0;
            while(n < 5)
            {
                dynamic obj = Activator.CreateInstance(Empoyee);
                Empoyee.GetProperty("EmployeeID").SetValue(obj, n, null);
                Empoyee.GetProperty("EmployeeName").SetValue(obj, "Albert"+n, null);
                Empoyee.GetProperty("Service").SetValue(obj, new OpticalService {Status = "Spare" } , null);
                objects.Add(obj);
                n++;

            }

            return objects;
        }

        public IEnumerable<object> CreateDataClass1()
        {
            IList<dynamic> objects = new List<object>();




            var list = new Dictionary<string, string> {
                    { "EmployeeID","System.Int32"},
                    { "EmployeeName","System.String"},
                    {"Service","Lab.Linq101.DynamicDataClass.OpticalService" } };

            var props = list.Select(property => new DynamicProperty(property.Key, Type.GetType(property.Value))).ToList();

            Type type = DynamicClassFactory.CreateType(props);


            int n = 0;
            while (n < 5)
            {
                dynamic employee = new TestDynamicObject();
                employee.n = n;

                //object obj = Activator.CreateInstance(type);
                //type.GetProperty("EmployeeID").SetValue(obj, n, null);
                //type.GetProperty("EmployeeName").SetValue(obj, "Albert" + n, null);
                //type.GetProperty("Service").SetValue(obj, new OpticalService { Status = "Spare" }, null);

                objects.Add(employee);
                n++;

            }

            return objects;
        }
    }
}