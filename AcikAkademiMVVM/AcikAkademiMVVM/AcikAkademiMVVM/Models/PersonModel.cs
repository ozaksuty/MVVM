using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AcikAkademiMVVM.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        private string _name;
        public string Surname { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}