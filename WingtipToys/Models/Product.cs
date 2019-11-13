using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    /// <summary>
    /// 产品实体类,实体类中的每一个属性指定数据表中的列
    /// </summary>
    public class Product
    {
        [ScaffoldColumn(false)]//数据批注
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}