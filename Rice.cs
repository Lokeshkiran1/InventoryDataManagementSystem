using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class Rice
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfPulse> typeOfPulse;
        public List<TypeOfWheat> typeOfWheat ;
    }
    public class TypeOfRice
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string price { get; set; }
    }
    public class TypeOfPulse
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string price { get; set; }
    }
    public class TypeOfWheat
    {
        public string name { get; set; }
        public string weight { get; set; }
        public string price { get; set; }
    }
}
