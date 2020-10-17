using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateNordicWindowsForms.Classes
{
    class ReplaceDublicate//Sets Dublicate to correct value depending on whether or not a dublicate exist
    {
        public static bool? SelectedValue { get; set; }
        public static void replace(int _selectDublicate)
        {
            bool? dublicate;
            switch (_selectDublicate)
            {
                case 0:
                    dublicate = null;
                    break;
                case 1:
                    dublicate = true;
                    break;
                case 2:
                    dublicate = false;
                    break;
                default:
                    dublicate = null;
                    break;
            }

            ReplaceDublicate.SelectedValue = dublicate;
            
        }
    }
}
