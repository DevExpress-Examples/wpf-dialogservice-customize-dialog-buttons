Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Core
Imports System.ComponentModel

Namespace DXSample.ViewModels

    Public Class DialogViewModel
        Inherits ViewModelBase

        Public Property FirstName As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property LastName As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property UICommandApply As UICommand
            Get
                Return GetValue(Of UICommand)()
            End Get

            Set(ByVal value As UICommand)
                SetValue(value)
            End Set
        End Property

        Public Property UICommandCancel As UICommand
            Get
                Return GetValue(Of UICommand)()
            End Get

            Set(ByVal value As UICommand)
                SetValue(value)
            End Set
        End Property

        Protected ReadOnly Property CurrentDialogService As ICurrentDialogService
            Get
                Return GetService(Of ICurrentDialogService)()
            End Get
        End Property

        Protected ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        <Command>
        Public Sub DialogClosing(ByVal args As CancelEventArgs)
            Dim dialogResult = TryCast(CurrentDialogService, CurrentDialogService).ActualWindow.DialogResult
            If dialogResult IsNot Nothing Then Return
            Dim result = MessageBoxService.ShowMessage(caption:="Close", messageBoxText:="Do you want to discard changes?", button:=MessageButton.YesNo, defaultResult:=MessageResult.No, icon:=MessageIcon.Question)
            If result = MessageResult.Yes Then
                CurrentDialogService.Close(MessageResult.Cancel)
            Else
                args.Cancel = True
            End If
        End Sub
    End Class
End Namespace
