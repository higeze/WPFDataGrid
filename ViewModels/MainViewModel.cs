using Livet;
using Livet.Commands;
using Livet.Messaging;
using SampleWPFApplication.Models;
using System.Collections.ObjectModel;

namespace SampleWPFApplication.ViewModels {

    public class MainViewModel : ViewModel {

        public MainViewModel() {
            this.Persons = Models.Persons.Create();
        }

        #region Person変更通知プロパティ
        private Person _Person;

        public Person Person {
            get { return _Person; }
            set { 
                if (_Person == value)
                    return;
                _Person = value;
                RaisePropertyChanged("Person");
            }
        }
        #endregion

        #region Persons変更通知プロパティ
        private ObservableCollection<Person> _Persons;

        public ObservableCollection<Person> Persons {
            get { return _Persons; }
            set { 
                if (_Persons == value)
                    return;
                _Persons = value;
                RaisePropertyChanged("Persons");
            }
        }
        #endregion

        #region EditCommand
        private ViewModelCommand _EditCommand;

        public ViewModelCommand EditCommand {
            get {
                if (_EditCommand == null) {
                    _EditCommand = new ViewModelCommand(Edit, CanEdit);
                }
                return _EditCommand;
            }
        }

        public bool CanEdit() {
            return this.Person != null;
        }

        public void Edit() {
            using (var vm = new SubViewModel(this.Person)) {
                Messenger.Raise(new TransitionMessage(vm, "EditCommand"));
            }
        }
        #endregion
    }
}
