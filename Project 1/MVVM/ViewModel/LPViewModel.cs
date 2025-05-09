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
        new() { Products = "Milk", Price = 1.50, Quantity = 10, Image = "https://cdn.britannica.com/77/200377-050-4326767F/milk-splashing-glass.jpg" },
        new() { Products = "Cheese", Price = 2.50, Quantity = 5, Image = "https://blog.wisconsincheeseman.com/wp-content/uploads/2022/10/sharp-cheddar-baby-swiss-1-edited-768x697.jpg.webp" },
        new() { Products = "Yogurt", Price = 1.20, Quantity = 8, Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Turkish_strained_yogurt.jpg/250px-Turkish_strained_yogurt.jpg" },
        new() { Products = "Butter", Price = 3.00, Quantity = 4, Image = "https://media-cldnry.s-nbcnews.com/image/upload/t_fit-1500w,f_auto,q_auto:best/rockcms/2024-07/healthiest-butter-jp-240709-8ce75e.jpg" },
        new() { Products = "Sour Cream", Price = 2.20, Quantity = 7, Image = "https://www.biggerbolderbaking.com/wp-content/uploads/2016/09/1C5A7606-500x375.jpg" },
        new() { Products = "Cottage Cheese", Price = 2.00, Quantity = 9, Image = "https://staticcookist.akamaized.net/wp-content/uploads/sites/22/2022/05/How-to-make-cottage-cheese-10.jpg?im=Resize,width=712;" },
        new() { Products = "Whipped Cream", Price = 3.50, Quantity = 5, Image = "https://www.recipetineats.com/tachyon/2022/11/Chantilly-cream_5.jpg" },
        new() { Products = "Ricotta", Price = 3.80, Quantity = 4, Image = "https://www.allrecipes.com/thmb/AP832Mty6ilpVOLYNSIIZz3EMVg=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/IMG_6092_chef-johns-homemade-ricotta-cheese_chef-john-3f1474351cb04c7ea196603794147eab.jpg" },
        new() { Products = "Ghee", Price = 4.50, Quantity = 3, Image = "https://downshiftology.com/wp-content/uploads/2024/07/Homemade-Ghee-main-500x500.jpg" }

};
        #endregion

        #region Bakery
        public ObservableCollection<LPModel> Bakery { get; set; } = new()
        {
        new() { Products = "Bread", Price = 2.00, Quantity = 12, Image = "https://assets.bonappetit.com/photos/5c62e4a3e81bbf522a9579ce/16:9/w_4000,h_2250,c_limit/milk-bread.jpg" },
        new() { Products = "Croissant", Price = 1.80, Quantity = 6, Image = "https://www.zojirushi.com/user/images/recipe/260.1.jpg" },
        new() { Products = "Muffin", Price = 2.50, Quantity = 8, Image = "https://i.pinimg.com/564x/f5/04/68/f5046807f22e9ac25f922379f68620e5.jpg" },
        new() { Products = "Bagel", Price = 1.70, Quantity = 10, Image = "https://images.arla.com/recordid/F412EBE9-850E-4704-A88277F66B5DD0FA/cream-cheese-bagel.jpg?width=768&height=400&mode=crop&format=webp" },
        new() { Products = "Baguette", Price = 2.20, Quantity = 7, Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/chorizo-and-halloumi-baguette-addaf63.jpg" },
        new() { Products = "Donut", Price = 1.50, Quantity = 10, Image = "https://omgkawaii.com/cdn/shop/files/omgkawaii-blue-10-cm-kawaii-donut-squeeze-squishy-food-toys-40866696265941.jpg?v=1726274681" },
        new() { Products = "Pretzel", Price = 2.80, Quantity = 5, Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/BrezelnSalz02_%28cropped%29.JPG/1200px-BrezelnSalz02_%28cropped%29.JPG" },
        new() { Products = "Scone", Price = 3.00, Quantity = 6, Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/recipe-image-legacy-id-1001500_10-16f94ee.jpg" },
        new() { Products = "Cake Slice", Price = 3.50, Quantity = 4, Image = "https://noevalleybakery.com/cdn/shop/files/Strawberry3_web_2048x.jpg?v=1722539021" },
        new() { Products = "Brownie", Price = 2.70, Quantity = 8, Image = "https://handletheheat.com/wp-content/uploads/2017/03/chewy-brownies-SQUARE.jpg"},

        };
        #endregion

        #region Fruits
        public ObservableCollection<LPModel> Fruits { get; set; } = new()
        {
            new() { Products = "Apple", Price = 0.90, Quantity = 20, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtkzZMTh_n9DE3CznuCnA8wVdQI7IQT9sDng&s" },
            new() { Products = "Banana", Price = 0.50, Quantity = 15, Image = "https://www.bigbasket.com/media/uploads/p/xl/10000025_32-fresho-banana-robusta.jpg" },
            new() { Products = "Carrot", Price = 1.20, Quantity = 25, Image = "https://www.hhs1.com/hubfs/carrots%20on%20wood-1.jpg" },
            new() { Products = "Lettuce", Price = 1.00, Quantity = 10, Image = "https://cdn.britannica.com/77/170677-050-F7333D51/lettuce.jpg" },
            new() { Products = "Orange", Price = 1.10, Quantity = 18, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTct4QnA6zwU4tyn9vq_ADJ8Ey6RfIWK-6V6g&s" },
            new() { Products = "Grapes", Price = 2.50, Quantity = 12, Image = "https://glycemic-index.net/images/gw8NS5HckZ.webp" },
            new() { Products = "Strawberry", Price = 3.00, Quantity = 8, Image = "https://amevafoods.com/wp-content/uploads/2019/12/p11.jpg" },
            new() { Products = "Watermelon", Price = 5.00, Quantity = 3, Image = "https://snaped.fns.usda.gov/sites/default/files/styles/crop_ratio_7_5/public/seasonal-produce/2018-05/watermelon.jpg.webp?itok=4TjwcpU9" },
            new() { Products = "Pineapple", Price = 4.20, Quantity = 5, Image = "https://www.healthxchange.sg/sites/hexassets/Assets/food-nutrition/pineapple-health-benefits-and-ways-to-enjoy.jpg" },
            new() { Products = "Peach", Price = 2.30, Quantity = 7, Image = "https://media.istockphoto.com/id/1151868959/photo/single-whole-peach-fruit-with-leaf-and-slice-isolated-on-white.jpg?s=612x612&w=0&k=20&c=RLTbnKnN6w85oXn4qA8y8WYN3OMpGxEDc1nI7VY0gWU=" }
        };

        #endregion

        #region Meat
        public ObservableCollection<LPModel> Meat { get; set; } = new()
        {
            new() { Products = "Chicken Breast", Price = 5.00, Quantity = 5 },
            new() { Products = "Beef Steak", Price = 8.00, Quantity = 3 },
            new() { Products = "Pork Chop", Price = 6.50, Quantity = 4 },
            new() { Products = "Ground Beef", Price = 7.00, Quantity = 6 },
            new() { Products = "Lamb Chops", Price = 9.00, Quantity = 4, Image = "" },
            new() { Products = "Turkey Breast", Price = 6.80, Quantity = 5, Image = "" },
            new() { Products = "Duck Breast", Price = 10.00, Quantity = 3, Image = "" },
            new() { Products = "Sausages", Price = 4.50, Quantity = 8, Image = "" },
            new() { Products = "Ribs", Price = 7.50, Quantity = 5, Image = "" },
            new() { Products = "Salami", Price = 3.80, Quantity = 7, Image = "" }

        };
        #endregion

        #region Snacks
        public ObservableCollection<LPModel> Snacks { get; set; } = new()
        {
            new() { Products = "Chips", Price = 1.50, Quantity = 15 },
            new() { Products = "Chocolate Bar", Price = 2.00, Quantity = 10 },
            new() { Products = "Popcorn", Price = 1.80, Quantity = 8 },
            new() { Products = "Granola Bar", Price = 2.50, Quantity = 12 },
            new() { Products = "Pretzels", Price = 1.70, Quantity = 10, Image = "" },
            new() { Products = "Trail Mix", Price = 3.20, Quantity = 7, Image = "" },
            new() { Products = "Fruit Snacks", Price = 2.80, Quantity = 9, Image = "" },
            new() { Products = "Protein Bar", Price = 3.50, Quantity = 6, Image = "" },
            new() { Products = "Gummy Candies", Price = 2.30, Quantity = 8, Image = "" },
            new() { Products = "Crackers", Price = 2.00, Quantity = 11, Image = "" }

        };
        #endregion



        #region logic methods

        #endregion



    }

}
