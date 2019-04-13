using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Player
    {
        public string Name { get; set; }


        public string BloodType { get; set; }  //o

        

        public string BloodImage
        {
            get
            {
                return string.Format("/images/{0}.jpg", BloodType);
            }
            
        }




        public override string ToString()
        {
            return Name;
        }
    }
}
