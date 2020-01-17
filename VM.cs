/* ***Group 2***
    Amreinder Kaur
    DharaNarola
    Guanlin Li
    Sean Bowery
 */
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalData
{
    class VM : INotifyPropertyChanged
    {
        public ObservableCollection<Person> Persons { get; set; }
        public Person selectedPerson;

        public VM(string groupType)
        {
                if (groupType == "Group")
                 {
                    Persons = new ObservableCollection<Person>
                     {
                        new Person
                        {
                            Name = "Amrinder",
                            Address = "Victoria Street",
                            Age = 26,
                            Phone = 2453682489,
                        },
                        new Person
                        {
                            Name = "Dhara Narola",
                            Address = "BridgePort Road",
                            Age = 26,
                            Phone = 2543697854,
                        },
                        new Person
                        {
                            Name = "Guanlin Li",
                            Address = "King Street N",
                            Age = 22,
                            Phone = 2543652145,
                        },
                        new Person
                        {
                             Name = "Mitesh Ghevariya",
                            Address = "Cambridge",
                            Age = 23,
                            Phone = 2145632145,
                        },
                        new Person
                        {
                             Name = "Sean Bowery",
                            Address = "Brampton",
                            Age = 25,
                            Phone = 2453651452,
                        }
                     };
                }
                if (groupType == "Friends")
                 {
                     Persons = new ObservableCollection<Person>
                     {
                        new Person
                        {
                            Name = "Hiren Narola",
                            Address = "BridgePort Road",
                            Age = 24,
                            Phone = 2351264535,
                        },
                        new Person
                        {
                           Name = "Vivek Shah",
                           Address = "Old Mills Road",
                           Age = 25,
                           Phone = 2145632145,
                        },
                         new Person
                         {
                            Name = "Laxen",
                           Address = "BridgePort Road",
                           Age = 22,
                           Phone = 215346789,
                        },
                         new Person
                         {
                           Name = "Pratik Solanki",
                           Address = "King Street S",
                           Age = 24,
                           Phone = 2142354698,
                         },
                        new Person
                         {
                            Name = "Alisha Patel",
                           Address = "BridgePort Road",
                           Age = 26,
                           Phone = 2351564789,
                         }    

               };
          
            }
          
        }

        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value; OnPropertyChanged("SelectedPerson"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

