using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.ComponentModel;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public string FirstName { get { return GetValue<string>(); } set { SetValue(value); } }
        public string LastName { get { return GetValue<string>(); } set { SetValue(value); } }
        public string DisplayName { get { return GetValue<string>(); } set { SetValue(value); } }
        protected IDialogService DialogService { get { return GetService<IDialogService>(); } }

        [Command]
        public void ShowDialog() {
            var dialogViewModel = new DialogViewModel() {
                FirstName = this.FirstName,
                LastName = this.LastName
            };

            var buttonApply = new UICommand() {
                Id = "apply",
                Caption = "Apply",
                Command = new DelegateCommand<CancelEventArgs>(
                    cancelArgs => {
                        try {
                            ApplyMethod(dialogViewModel.FirstName, dialogViewModel.LastName);
                        }
                        catch (Exception e) {
                            cancelArgs.Cancel = true;
                        }
                    },
                    // Disable the button if one of the fields is empty:
                    cancelArgs => !string.IsNullOrEmpty(dialogViewModel.FirstName) && !string.IsNullOrEmpty(dialogViewModel.LastName)
                ),
                Glyph = new Uri("pack://application:,,,/DevExpress.Images.v22.2;component/SvgImages/Icon Builder/Actions_CheckCircled.svg"),
                IsDefault = true,
                IsCancel = false
            };

            var buttonCancel = new UICommand() {
                Id = "cancel",
                Caption = "Cancel",
                Command = null,
                Glyph = new Uri("pack://application:,,,/DevExpress.Images.v22.2;component/SvgImages/Icon Builder/Actions_DeleteCircled.svg"),
                IsDefault = false,
                IsCancel = true
            };

            dialogViewModel.UICommandApply = buttonApply;
            dialogViewModel.UICommandCancel = buttonCancel;

            DialogService.ShowDialog(
                dialogCommands: new UICommand[] {},
                title: "Edit Dialog",
                viewModel: dialogViewModel
            );
        }
        public void ApplyMethod(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
            DisplayName = FirstName + " " + LastName;
        }
    }
}
