using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_MVVM_EF6_MSSQL.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertytyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertytyName));
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }



    }
}
