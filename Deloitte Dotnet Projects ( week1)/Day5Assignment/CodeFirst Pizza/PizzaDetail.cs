using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Pizza
{
    class PizzaDetail
    {
        [Key]            
        public int PizzaID { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string Toppings { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Size { get; set; }
        [Range (minimum:100,maximum:1000,ErrorMessage ="Price should be between 100 and 1000")]
        public int Price { get; set; }


    }
}
