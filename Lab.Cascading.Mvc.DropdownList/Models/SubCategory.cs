using System.ComponentModel.DataAnnotations;

namespace Lab.Cascading.Mvc.DropdownList.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string SubCategoryName { get; set; }
    }
}
