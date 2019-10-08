using System.Collections.Generic;

namespace ParcelInput.Models
{
    public class Parcel
    {
        
        private int _Length;
        private int _Width; 
        private int _Height;
        private int _Cost;
        private int _TrueVolume;
        private static List<Parcel> _orders = new List<Parcel> {};

        public Parcel (int length, int width, int height)
        {
            _Length = length;
            _Width = width;
            _Height = height;
            _Cost = 0;
            _TrueVolume = 0;
            _orders.Add(this);
        }

        public static List<Parcel> GetAll()
        {
            return _orders;
        }


        public int CostToShip()
        {
           return  _Cost = _TrueVolume/300;  
        }

    
        public int Volume()
        {
            _TrueVolume = _Length * _Width * _Height;
            return _TrueVolume; 
        }

   }
}
