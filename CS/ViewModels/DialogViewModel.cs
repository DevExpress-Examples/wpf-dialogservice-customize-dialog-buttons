using System.ComponentModel;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class DialogViewModel : ViewModelBase {
        public ICommand<CancelEventArgs> RegisterCommand { get; private set; }
        public ICommand<CancelEventArgs> CancelCommand { get; private set; }
        public bool AllowCloseDialog {
            get { return GetProperty(() => AllowCloseDialog); }
            set { SetProperty(() => AllowCloseDialog, value); }
        }
        public string UserName {
            get { return GetProperty(() => UserName); }
            set { SetProperty(() => UserName, value); }
        }
        public DialogViewModel() {
            AllowCloseDialog = true;
            RegisterCommand = new DelegateCommand<CancelEventArgs>(OnRegisterCommandExecute, OnRegisterCommandCanExecute);
            CancelCommand = new DelegateCommand<CancelEventArgs>(OnCancelCommandExecute, OnCancelCommandCanExecute);
        }
        void OnRegisterCommandExecute(CancelEventArgs parameter) {
            if (!AllowCloseDialog) {
                parameter.Cancel = true;
            }
        }
        bool OnRegisterCommandCanExecute(CancelEventArgs parameter) {
            return !string.IsNullOrEmpty(UserName);
        }
        void OnCancelCommandExecute(CancelEventArgs parameter) {
            if (!AllowCloseDialog) {
                parameter.Cancel = true;
            }
        }
        bool OnCancelCommandCanExecute(CancelEventArgs parameter) {
            return true;
        }
    }
}