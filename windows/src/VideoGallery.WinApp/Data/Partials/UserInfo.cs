using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGallery.WinApp.Data
{
    public partial class UserInfo
    {
        public enum GenderEnum
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        public GenderEnum Gender
        {
            get{ return (GenderEnum)GenderEnumId;}
            set {  GenderEnumId=(int)value; }
        }
        public enum TypeEnum
        {
            Admin = 0,
            SubAdmin = 1,
            SalesMan = 2
        }
        public TypeEnum Type
        {
            get { return (TypeEnum)TypeEnumId; }
            set { TypeEnumId = (int)value; }
        }
    }
}
