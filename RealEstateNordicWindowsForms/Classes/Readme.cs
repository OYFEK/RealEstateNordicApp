using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateNordicWindowsForms.Classes
{
    class Readme
    {
        public static string TextReader()
        {
            string text = "Welcome to the Tax Searcher.\n\nTo Search for taxes simply select Municipality and Date.\n\n" +
            "To Add new Tax rule select Tax Type, Start Date, and insert the \nTax(eg. 0, 25) and press 'Add new Tax'.\n\n" +
            "For Week, the system will automatically select Monday - Sunday even though ex.Friday has been selected in the applicable week.\n" +
            "For Month and Year the system will also automatically set first and last day of the Month(eg 01 - 01 - 2019 - 31 - 01 - 2019)\n" +
            "or Year(eg 01 - 01 - 2019 - 31 - 12 - 2019), even if a day in the middle of the year or month has been selected." +
            "\n\nTo add files via .CSV use the following format:\n" +
            "Municipality;DD-MM-YYYY;Type;TaxRate\nType could be: D(Day), W(Week), M(Month), Y(Year).\n\nExample of a valid line:\n" +
            "Copenhagen;19-10-2020;D;0,25\nThis will select a Day Tax of 0,25 to Copenhagen on 19-10-2020.\nAlso see TestImport.csv for reference.\n\n" +
            "Enjoy the program.";

            return text;
        }
    }
}
