using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGallery.WinApp.Data
{
    public partial class Product
    {
        public int Avaiable { get {
                return TotalItem - (TotalSold+TotalRented);
            } }

        public int RentPrice { get { return 20; } }
        public int AllowedRentDays { get { return 7; } }

    }
}
