using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab.Stackoverflow.WebApplication.Controllers
{
    public class CDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string descrption { get; set; }
        //[Required]
        //public KeyValuePair<string, string>[] data { get; set; }
        public List<string> data { get; set; }
    }

    public class CDTO1
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string descrption { get; set; }
        [Required]
        public KeyValuePair<string, string> data { get; set; }
    }
}