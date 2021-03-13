using Lab.Stackoverflow.EfCodeFirst;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.ConsoleApp
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var  cdn = "https://dev-cdn.nationalcareersservice.org.uk/";
            var cdn1 = "https://dev-cdn.nationalcareersservice.org.uk";
            var testcdn = cdn.TrimEnd('/');
            var testcdn1 = cdn.TrimEnd('/');
            Console.WriteLine(cdn);
            Console.WriteLine(testcdn);
            Console.WriteLine(cdn1);
            Console.WriteLine(testcdn1);

            //var jsonString = "{\"Id\":\"6c6ecbd5-11d3-45c7-bbfd-b895c67cb6b7\",\"Subject\":\"/content/sharedcontent/c3209801-aaa7-4afa-8755-e8daefc29a03\",\"Data\":{\"Api\":\"http://localhost:7071/api/execute/sharedcontent/c3209801-aaa7-4afa-8755-e8daefc29a03\",\"ItemId\":\"c3209801-aaa7-4afa-8755-e8daefc29a03\",\"VersionId\":\"4mby65rkymj95330fjryf2qrdy\",\"DisplayText\":\"Test321\",\"ContentType\":\"SharedContent\",\"Author\":\"admin\",\"TraceId\":\"9d955cfcb93c9d4bb133a2db70cc8189\",\"ParentId\":\"90b8fffddc985442\"},\"EventType\":\"published\",\"EventTime\":\"2021-02-09T18:27:19.6220731Z\",\"MetadataVersion\":null,\"DataVersion\":\"1.0\"}";
            //var jsonString1 = "{\"Id\":\"514c6dce-1df7-413d-9e8c-04e943296a63\",\"Subject\":\"/content/sharedcontent/6e0ce4f1-721f-4440-aadc-6c62f0eb6625\",\"Data\":{\"Api\":\"http://localhost:7071/api/execute/sharedcontent/6e0ce4f1-721f-4440-aadc-6c62f0eb6625\",\"ItemId\":\"6e0ce4f1-721f-4440-aadc-6c62f0eb6625\",\"VersionId\":\"4byyxpw2nbskh75bmqca0y2x4x\",\"DisplayText\":\"Test App Pages Locally\",\"ContentType\":\"SharedContent\",\"Author\":\"admin\",\"TraceId\":\"a2acaea69ec7ec48a9d4938572408e93\",\"ParentId\":\"5cf38c771e814a4c\"},\"EventType\":\"published\",\"EventTime\":\"2021-02-09T18:44:45.0131976Z\",\"MetadataVersion\":null,\"DataVersion\":\"1.0\"}";
            //string output = JsonConvert.SerializeObject(jsonString);

            //JObject json = JObject.Parse(jsonString1);

            //TechnicalExerciseContext dbContext = new TechnicalExerciseContext();
            //var blogs = await dbContext.Blog.Include(x => x.Posts).ToListAsync();

            //var posts = await dbContext.Post.ToListAsync();

            //Weapon StartSword = new Weapon("My first Sword", 1);
            //Globals<Weapon>.PlayerInventory.Add(StartSword);
            //Console.WriteLine(StartSword.weaponName); // This works
            //Console.WriteLine(Globals<Weapon>.PlayerInventory[0]); // This prints "CSharp_Shell.Weapon", but I expected "StartSword"
            //Console.WriteLine(Globals<Weapon>.PlayerInventory[0].weaponName); // This results in an Error

            // M-N relatiopnships
            //TechnicalExerciseContext dbContext = new TechnicalExerciseContext();
            //var gd = new Gd
            //{
            //    Id = 1
            //};

            //var gdIds = new List<int> { 1, 2, 3 };

            //var gds = await dbContext.Gd.Where(x => gdIds.Contains(x.Id)).ToListAsync();

            //var br = new List<Br> {
            //    new Br
            //    {
            //        Name = "bearer3",
            //        //Gds = await dbContext.Gd.ToListAsync()
            //        Gds = gds
            //    } 
            //};

            //await dbContext.AddRangeAsync(br);
            //await dbContext.SaveChangesAsync();
        }

        internal static class Globals<T> where T : class
        {
            public static string Playername;
            public static IList<T> PlayerInventory = new List<T>();
        }

        public class Weapon
        {
            public string weaponName;
            public int weaponBaseDamage;

            public Weapon(string name, int baseDamage)
            {
                weaponName = name;
                weaponBaseDamage = baseDamage;
            }
        }
    }
}