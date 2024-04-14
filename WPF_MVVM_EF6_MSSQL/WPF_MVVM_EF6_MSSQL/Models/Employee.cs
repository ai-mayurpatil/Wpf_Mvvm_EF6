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

        //public event PropertyChangedEventHandler PropertyChanged;

        //private int id;
        //public int Id
        //{
        //    get => id;
        //    set => SetProperty(ref id, value);
        //}

        //private string name;
        //public string Name
        //{
        //    get => name;
        //    set => SetProperty(ref name, value);
        //}

        //private int age;
        //public int Age
        //{
        //    get => age;
        //    set => SetProperty(ref age, value);
        //}

        //public Employee() { }  // Default constructor

        //public Employee(int id, string name, int age)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //}

        //private void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        //{
        //    if (EqualityComparer<T>.Default.Equals(field, value)) return;

        //    field = value;
        //    OnPropertyChanged(propertyName);
        //}

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
