using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task07
{
    [Table("ProductCategory", Schema ="Production")]
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
    }
}
