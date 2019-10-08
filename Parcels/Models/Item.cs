using System.Collections.Generic;

namespace ParcelInput.Models
{
    public class Parcel
    {
        private int _Length { get; set;}
        private int _Width { get; set; }
        private int _Height { get; set; }
        private int _Weight { get; set; }
        private int _Cost { get; set; }
        private int _TrueVolume { get; set; }
        private static List<Parcel> _orders = new List<Parcel> {};

        public Parcel (int length, int width, int height, int weight)
        {
            _Length = length;
            _Width = width;
            _Height = height;
            _Weight = weight; 
            _Cost = 0;
            _TrueVolume = Volume();
        }

        public static List<Parcel> GetAll()
        {
            return _orders;
        }

        public int Volume()
        {
            int volume = _Length * _Width * _Height;
            return volume; 
        }

        public int CostToShip()
        {
           return  _Cost += _TrueVolume *2;  
        }
   }
}
