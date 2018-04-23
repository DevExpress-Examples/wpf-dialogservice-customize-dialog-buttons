Imports System.Windows.Input
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
    Public Class MainViewModel
        Inherits ViewModelBase

        Private privateShowDialogCommand As ICommand
        Public Property ShowDialogCommand() As ICommand
            Get
                Return privateShowDialogCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowDialogCommand = value
            End Set
        End Property
        Private privateShowMessageBoxCommand As ICommand
        Public Property ShowMessageBoxCommand() As ICommand
            Get
                Return privateShowMessageBoxCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateShowMessageBoxCommand = value
            End Set
        End Property
        Protected ReadOnly Property MessageService() As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property
        Protected ReadOnly Property DialogService() As IDialogService
            Get
                Return GetService(Of IDialogService)()
            End Get
        End Property
        Private privateDialogViewModel As DialogViewModel
        Protected Property DialogViewModel() As DialogViewModel
            Get
                Return privateDialogViewModel
            End Get
            Private Set(ByVal value As DialogViewModel)
                privateDialogViewModel = value
            End Set
        End Property

        Public Sub New()
            ShowMessageBoxCommand = New DelegateCommand(AddressOf OnShowMessageBoxCommandExecute)
            ShowDialogCommand = New DelegateCommand(AddressOf OnShowDialogCommandExecute)
            DialogViewModel = New DialogViewModel()
        End Sub

        Private Sub OnShowDialogCommandExecute()
            Dim dialogResult As MessageResult = DialogService.ShowDialog(MessageButton.OKCancel, "DialogWindow", DialogViewModel)
            MessageService.Show("Dialog Clicked Button: " & dialogResult)
        End Sub
        Private Sub OnShowMessageBoxCommandExecute()
            MessageService.Show("This is a message box", "DXMessageBoxService", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information)
        End Sub
    End Class
End Namespace