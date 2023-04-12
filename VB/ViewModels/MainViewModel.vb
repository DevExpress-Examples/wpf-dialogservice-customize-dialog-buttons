Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.ComponentModel

Namespace DXSample.ViewModels

    Public Class MainViewModel
        Inherits DevExpress.Mvvm.ViewModelBase

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

        Public Property DisplayName As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Protected ReadOnly Property DialogService As IDialogService
            Get
                Return GetService(Of DevExpress.Mvvm.IDialogService)()
            End Get
        End Property

        <DevExpress.Mvvm.DataAnnotations.CommandAttribute>
        Public Sub ShowDialog()
            Dim dialogViewModel = New DXSample.ViewModels.DialogViewModel() With {.FirstName = Me.FirstName, .LastName = Me.LastName}
            Dim buttonApply = New DevExpress.Mvvm.UICommand() With {.Id = "apply", .Caption = "Apply", .Command = New DevExpress.Mvvm.DelegateCommand(Of System.ComponentModel.CancelEventArgs)(Sub(cancelArgs)
                Try
                    Me.ApplyMethod(dialogViewModel.FirstName, dialogViewModel.LastName)
                Catch e As System.Exception
                    cancelArgs.Cancel = True
                End Try
            ' Disable the button if one of the fields is empty:
            End Sub, Function(cancelArgs) Not String.IsNullOrEmpty(dialogViewModel.FirstName) AndAlso Not String.IsNullOrEmpty(dialogViewModel.LastName)), .Glyph = New System.Uri("pack://application:,,,/DevExpress.Images.v22.2;component/SvgImages/Icon Builder/Actions_CheckCircled.svg"), .IsDefault = True, .IsCancel = False}
            Dim buttonCancel = New DevExpress.Mvvm.UICommand() With {.Id = "cancel", .Caption = "Cancel", .Command = Nothing, .Glyph = New System.Uri("pack://application:,,,/DevExpress.Images.v22.2;component/SvgImages/Icon Builder/Actions_DeleteCircled.svg"), .IsDefault = False, .IsCancel = True}
            dialogViewModel.UICommandApply = buttonApply
            dialogViewModel.UICommandCancel = buttonCancel
            Me.DialogService.ShowDialog(dialogCommands:=New DevExpress.Mvvm.UICommand() {}, title:="Edit Dialog", viewModel:=dialogViewModel)
        End Sub

        Public Sub ApplyMethod(ByVal firstName As String, ByVal lastName As String)
            Me.FirstName = firstName
            Me.LastName = lastName
            Me.DisplayName = Me.FirstName & " " & Me.LastName
        End Sub
    End Class
End Namespace
