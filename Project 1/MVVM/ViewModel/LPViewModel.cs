using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.MVVM.Model;
using PropertyChanged;


namespace Project_1.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class LPViewModel
    {
        public LPViewModel()
        {

        }
        #region Dairy
        
        public ObservableCollection<LPModel> Dairy { get; set; } = new()
        {
           new(){
               Products = "Milk",
                Price = 1.50,
                Quantity = 10
           }, new()
            {
               Products = "Cheese",
                Price = 2.50,
                Quantity = 5
           },
            new()
            {
               Products = "Yogurt",
                Price = 1.20,
                Quantity = 8
           },
            new()
            {
               Products = "Butter",
                Price = 3.00,
                Quantity = 4
           },
           


        };
        #endregion

        #region Bakery
        public ObservableCollection<LPModel> Bakery { get; set; } = new()
        {
            new() { Products = "Bread", Price = 2.00, Quantity = 12 },
            new() { Products = "Croissant", Price = 1.80, Quantity = 6 },
            new() { Products = "Muffin", Price = 2.50, Quantity = 8 },
            new() { Products = "Bagel", Price = 1.70, Quantity = 10 }
        };
        #endregion

        #region Fruits
        public ObservableCollection<LPModel> Fruits { get; set; } = new()
        {
            new() { Products = "Apple", Price = 0.90, Quantity = 20 },
            new() { Products = "Banana", Price = 0.50, Quantity = 15 },
            new() { Products = "Carrot", Price = 1.20, Quantity = 25 },
            new() { Products = "Lettuce", Price = 1.00, Quantity = 10 }
        };
        #endregion

        #region Meat
        public ObservableCollection<LPModel> Meat { get; set; } = new()
        {
            new() { Products = "Chicken Breast", Price = 5.00, Quantity = 5 },
            new() { Products = "Beef Steak", Price = 8.00, Quantity = 3 },
            new() { Products = "Pork Chop", Price = 6.50, Quantity = 4 },
            new() { Products = "Ground Beef", Price = 7.00, Quantity = 6 }
        };
        #endregion

        #region Snacks
        public ObservableCollection<LPModel> Snacks { get; set; } = new()
        {
            new() { Products = "Chips", Price = 1.50, Quantity = 15 },
            new() { Products = "Chocolate Bar", Price = 2.00, Quantity = 10 },
            new() { Products = "Popcorn", Price = 1.80, Quantity = 8 },
            new() { Products = "Granola Bar", Price = 2.50, Quantity = 12 }
        };
        #endregion



        #region logic methods

        #endregion



    }

}
