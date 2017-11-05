using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGallery.WinApp.Data
{
    public partial class Sold
    {


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
        public int PId
        {
            get
            {
                if (Product != null)
                {
                    return Product.Id;
                }
                return 0;
            }
        }
    }
}
