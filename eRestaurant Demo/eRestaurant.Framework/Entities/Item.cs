using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required, StringLength(5)]
        public string Description { get; set; }

        [Range(0.01, 5.00)]
        public decimal CurrentPrice { get; set; }

        [Range(0.01, 30.00)]
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }

        [Range(0, int.MaxValue)]
        public int? Calories { get; set; }
        public string Comment { get; set; }
        public int MenuCategoryID { get; set; }
        
        //Navigation Properties
        public virtual MenuCategory MenuCategory { get; set; }

        public Item()
        {
            Active = true;
        }
    }
}
