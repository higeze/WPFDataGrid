using Livet;
using Livet.Commands;
using Livet.Messaging.Windows;
using SampleWPFApplication.Models;

namespace SampleWPFApplication.ViewModels {
    public class SubViewModel : ViewModel {

        public SubViewModel(Person person) {
            this.Person = person;
        }

        #region Person変更通知プロパティ
        private Person _Origin;
        private Person _Person;

        public Person Person {
            get { return _Person; }
            private set {
                if (_Origin == value)
                    return;
                _Origin = value;
                _Person = (Person)_Origin.Clone();
                RaisePropertyChanged("Person");
            }
        }
        #endregion

        #region CancelCommand
        private ViewModelCommand _CancelCommand;

        public ViewModelCommand CancelCommand {
            get {
                if (_CancelCommand == null) {
                    _CancelCommand = new ViewModelCommand(Cancel);
                }
                return _CancelCommand;
            }
        }

        public void Cancel() {
            Messenger.Raise(new WindowActionMessage(WindowAction.Close, "Close"));
        }
        #endregion

        #region UpdateCommand
        private ViewModelCommand _UpdateCommand;

        public ViewModelCommand UpdateCommand {
            get {
                if (_UpdateCommand == null) {
                    _UpdateCommand = new ViewModelCommand(Update);
                }
                return _UpdateCommand;
            }
        }

        public void Update() {
            _Origin.Address = _Person.Address;
            _Origin.Name = _Person.Name;
            Messenger.Raise(new WindowActionMessage(WindowAction.Close, "Close"));
        }
        #endregion
    }
}
