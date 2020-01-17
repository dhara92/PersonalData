/* ***Group 2***
    Amreinder Kaur
    DharaNarola
    Guanlin Li
    Sean Bowery
 */
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalData
{
    class Person : INotifyPropertyChanged
    {
        private string name;
        private string address;
        private int age;
        private long phone;
 
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name");}
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value; OnPropertyChanged("Address");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value; OnPropertyChanged("Age");
            }
        }
        public long Phone
        {
            get { return phone; }
            set
            {
                phone = value; OnPropertyChanged("Phone");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
