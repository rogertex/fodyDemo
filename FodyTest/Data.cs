
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FodyTest
{

    //public class Data:INotifyPropertyChanged
    //{
    //    private string name;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; OnPropertyChanged("Name"); }
    //    }

    //    public int Age { get; set; }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void OnPropertyChanged(string propertyName = "")
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}\

    [AddINotifyPropertyChangedInterface]
    public class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
