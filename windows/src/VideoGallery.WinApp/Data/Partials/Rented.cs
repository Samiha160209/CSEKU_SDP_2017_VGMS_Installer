using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGallery.WinApp.Data
{
    public partial class Rented
    {

        public string CName
        {
            get
            {
                if (Customer != null)
                {
                    return Customer.Name;
                }
                return "";
            }
        }
        public string PTitle
        {
            get
            {
                if (Product!=null)
                {
                    return Product.Title;
                }
                return "";
            }
        }

    }
}
