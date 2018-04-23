using System.Windows.Input;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ICommand ShowDialogCommand { get; private set; }
        public ICommand ShowMessageBoxCommand { get; private set; }
        protected IMessageBoxService MessageService { get { return GetService<IMessageBoxService>(); } }
        protected IDialogService DialogService { get { return GetService<IDialogService>(); } }
        protected DialogViewModel DialogViewModel { get; private set; }

        public MainViewModel() {
            ShowMessageBoxCommand = new DelegateCommand(OnShowMessageBoxCommandExecute);
            ShowDialogCommand = new DelegateCommand(OnShowDialogCommandExecute);
            DialogViewModel = new DialogViewModel();
        }

        void OnShowDialogCommandExecute() {
            MessageResult dialogResult = DialogService.ShowDialog(MessageButton.OKCancel, "DialogWindow", DialogViewModel);
            MessageService.Show("Dialog Clicked Button: " + dialogResult);
        }
        void OnShowMessageBoxCommandExecute() {
            MessageService.Show("This is a message box", "DXMessageBoxService", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }     
    }
}