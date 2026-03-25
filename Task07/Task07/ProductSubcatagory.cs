using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task07
{
    [Table("ProductSubcategory", Schema = "Production")]
    class ProductSubcategory
    {
        public int ProductSubcategoryID { get; set; }
        public string Name { get; set; }
    }
}
