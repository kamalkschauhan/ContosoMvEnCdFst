using System.Collections.Generic;

namespace EdLern.Models
{
    public class City
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
        public List<City> Cities { get; set; }
    }
}