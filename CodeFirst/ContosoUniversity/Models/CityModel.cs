using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class CityModel
    {
        //Value of checkbox 
        public int Value { get; set; }
        //description of checkbox 
        public string Text { get; set; }
        //whether the checkbox is selected or not
        public bool IsChecked { get; set; }
    }
    public class CityList
    {
        //use CheckBoxModel class as list 
        public List<CityModel> Cities { get; set; }
    }
}