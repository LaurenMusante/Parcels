using System.Collections.Generic;

namespace ParcelInput.Models
{
    public class Parcel
    {
        
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Cost { get; set; }
        public int TrueVolume { get; set; }
        private static List<Parcel> _orders = new List<Parcel> {};

        public Parcel (int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
            Cost = 0;
            TrueVolume = 0;
            _orders.Add(this);
        }

        public static List<Parcel> GetAll()
        {
            return _orders;
        }


        public int CostToShip()
        {
           return  Cost = TrueVolume/300;  
        }

    
        public int Volume()
        {
            TrueVolume = Length * Width * Height;
            return TrueVolume; 
        }

   }
}
