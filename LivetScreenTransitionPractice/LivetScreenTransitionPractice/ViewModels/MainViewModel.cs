using Livet;
using Livet.Commands;
using Livet.Messaging;
using LivetScreenTransitionPractice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivetScreenTransitionPractice.ViewModels
{
    public sealed class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            this.Persons = Models.Persons.Create();
        }

        #region Person変更通知プロパティ

        private Person _Person;

        public Person Person
        {
            get { return _Person; }
            set
            {
                if (_Person == value) return;
                _Person = value;
                RaisePropertyChanged(nameof(Person));
            }
        }

        #endregion Person変更通知プロパティ

        #region Persons変更通知プロパティ
        private ObservableCollection<Person> _Persons;

        public ObservableCollection<Person> Persons
        {
            get { return _Persons; }
            set
            {
                if (_Persons == value) return;
                _Persons = value;
                RaisePropertyChanged(nameof(Persons));
            }
        }
        #endregion Persons変更通知プロパティ

        #region EditCommand
        private ViewModelCommand _EditCommand;
        public ViewModelCommand EditCommand
        {
            get
            {
                if (_EditCommand == null)
                    _EditCommand = new ViewModelCommand(Edit, CanEdit);
                return _EditCommand;
            }
        }

        public bool CanEdit()
        {
            return this.Person != null;
        }

        public void Edit()
        {
            using (var vm = new SubViewModel(this.Person))
            {
                Messenger.Raise(new TransitionMessage(vm, nameof(EditCommand)));
            }
        }

        #endregion EditCommand
    }
}
