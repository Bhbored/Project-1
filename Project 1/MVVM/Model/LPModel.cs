using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace Project_1.MVVM.Model
{
    
    public class LPModel
    {
        
        private string? products;
        private double? price;
        private int? quantity;
        public string? Products { get => products; set => products = value; }
        public double? Price { get => price; set => price = value; }
        public int? Quantity { get => quantity; set => quantity = value; }
        public string? Image { get; set; }
    }
}
