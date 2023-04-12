using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core;
using System.ComponentModel;

namespace DXSample.ViewModels {
    public class DialogViewModel : ViewModelBase {
        public string FirstName { get { return GetValue<string>(); } set { SetValue(value); } }
        public string LastName { get { return GetValue<string>(); } set { SetValue(value); } }
        public UICommand UICommandApply { get { return GetValue<UICommand>(); } set { SetValue(value); } }
        public UICommand UICommandCancel { get { return GetValue<UICommand>(); } set { SetValue(value); } }
        protected ICurrentDialogService CurrentDialogService { get { return GetService<ICurrentDialogService>(); } }
        protected IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(); } }

        [Command]
        public void DialogClosing(CancelEventArgs args) {
            var dialogResult = (CurrentDialogService as CurrentDialogService).ActualWindow.DialogResult;
            if (dialogResult != null) return;
            var result = MessageBoxService.ShowMessage(
                caption: "Close",
                messageBoxText: "Do you want to discard changes?",
                button: MessageButton.YesNo,
                defaultResult: MessageResult.No,
                icon: MessageIcon.Question
            );
            if (result == MessageResult.Yes) {
                CurrentDialogService.Close(MessageResult.Cancel);
            } else {
                args.Cancel = true;
            }
        }
    }
}
