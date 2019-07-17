using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2019
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool isAvaliable { get; set; }
        public DateTime DateCreate { get; set; }
        public string Description { get; set; }
        private string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                BitmapImage = new BitmapImage(new Uri(Environment.CurrentDirectory + "//Images//" + value));
                _image = value;
            }
        }
        public float Price { get; set; }

        public BitmapImage BitmapImage { get; set; }
    }
}
