using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Efcore.DatabaseFirst.Models
{
    [Table("customers", Schema = "sales")]
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
    }
}