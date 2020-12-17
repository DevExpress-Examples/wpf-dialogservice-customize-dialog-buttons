Imports System.ComponentModel
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
	Public Class DialogViewModel
		Inherits ViewModelBase

		Private privateRegisterCommand As ICommand(Of CancelEventArgs)
		Public Property RegisterCommand() As ICommand(Of CancelEventArgs)
			Get
				Return privateRegisterCommand
			End Get
			Private Set(ByVal value As ICommand(Of CancelEventArgs))
				privateRegisterCommand = value
			End Set
		End Property
		Private privateCancelCommand As ICommand(Of CancelEventArgs)
		Public Property CancelCommand() As ICommand(Of CancelEventArgs)
			Get
				Return privateCancelCommand
			End Get
			Private Set(ByVal value As ICommand(Of CancelEventArgs))
				privateCancelCommand = value
			End Set
		End Property
		Public Property AllowCloseDialog() As Boolean
			Get
				Return GetProperty(Function() AllowCloseDialog)
			End Get
			Set(ByVal value As Boolean)
				SetProperty(Function() AllowCloseDialog, value)
			End Set
		End Property
		Public Property UserName() As String
			Get
				Return GetProperty(Function() UserName)
			End Get
			Set(ByVal value As String)
				SetProperty(Function() UserName, value)
			End Set
		End Property
		Public Sub New()
			AllowCloseDialog = True
			RegisterCommand = New DelegateCommand(Of CancelEventArgs)(AddressOf OnRegisterCommandExecute, AddressOf OnRegisterCommandCanExecute)
			CancelCommand = New DelegateCommand(Of CancelEventArgs)(AddressOf OnCancelCommandExecute, AddressOf OnCancelCommandCanExecute)
		End Sub
		Private Sub OnRegisterCommandExecute(ByVal parameter As CancelEventArgs)
			If Not AllowCloseDialog Then
				parameter.Cancel = True
			End If
		End Sub
		Private Function OnRegisterCommandCanExecute(ByVal parameter As CancelEventArgs) As Boolean
			Return Not String.IsNullOrEmpty(UserName)
		End Function
		Private Sub OnCancelCommandExecute(ByVal parameter As CancelEventArgs)
			If Not AllowCloseDialog Then
				parameter.Cancel = True
			End If
		End Sub
		Private Function OnCancelCommandCanExecute(ByVal parameter As CancelEventArgs) As Boolean
			Return True
		End Function
	End Class
End Namespace