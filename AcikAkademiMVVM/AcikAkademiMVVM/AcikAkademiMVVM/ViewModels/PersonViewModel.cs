using AcikAkademiMVVM.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace AcikAkademiMVVM.ViewModels
{
    /// <summary>
    /// View ViewModel'i bilir, aksi söylenemez!
    /// ViewModel Model'i bilir, aksi söylenemez!
    /// </summary>
    public class PersonViewModel : INotifyPropertyChanged
    {
        private bool _isRefreshing;
        private void BindData()
        {
            this.IsRefreshing = true;
            //Service-Call
            Person.Clear();
            Person.Add(new PersonModel
            {
                Id = 1,
                Name = "Yiğit",
                Surname = "Özaksüt"
            });
            Person.Add(new PersonModel
            {
                Id = 2,
                Name = "İbrahim",
                Surname = "Kıvanç"
            });
            this.IsRefreshing = false;
        }
        public PersonViewModel()
        {
            BindData();
            deleteCommand = new Command(onDelete);
            updateCommand = new Command(onUpdate);
            refreshCommand = new Command(onRefresh);
        }
        ICommand deleteCommand, updateCommand, refreshCommand;
        private ObservableCollection<PersonModel> _person;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
            set
            {
                if (deleteCommand == null)
                    return;
                deleteCommand = value;
            }
        }
        public ICommand UpdateCommand
        {
            get
            {
                return updateCommand;
            }
            set
            {
                if (updateCommand == null)
                    return;
                updateCommand = value;
            }
        }
        public ICommand RefreshCommand
        {
            get
            {
                return refreshCommand;
            }
            set
            {
                if (refreshCommand == null)
                    return;
                refreshCommand = value;
            }
        }
        public ObservableCollection<PersonModel> Person
        {
            get
            {
                if (_person == null)
                    _person = new ObservableCollection<PersonModel>();
                return _person;
            }

            set
            {
                _person = value;
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }

            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private void onDelete(object param)
        {
            PersonModel selectedModel = (PersonModel)param;
            if (selectedModel != null)
                Person.Remove(selectedModel);
        }
        private void onUpdate(object param)
        {
            PersonModel selectedModel = (PersonModel)param;
            if (selectedModel != null)
                selectedModel.Name = selectedModel.Surname.Substring(0, 1)
                    + "." + selectedModel.Name;
        }
        private void onRefresh()
        {
            BindData();
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}