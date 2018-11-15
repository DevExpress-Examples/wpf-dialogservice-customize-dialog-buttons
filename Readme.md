<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [DialogViewModel.cs](./CS/ViewModels/DialogViewModel.cs) (VB: [DialogViewModel.vb](./VB/ViewModels/DialogViewModel.vb))
* [MainViewModel.cs](./CS/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ViewModels/MainViewModel.vb))
* [DialogView.xaml](./CS/Views/DialogView.xaml) (VB: [DialogView.xaml](./VB/Views/DialogView.xaml))
* **[MainView.xaml](./CS/Views/MainView.xaml) (VB: [MainView.xaml](./VB/Views/MainView.xaml))**
<!-- default file list end -->
# How to: customize the dialog's footer buttons


This example demonstrates how to customize the dialog's footer buttons.


<h3>Description</h3>

<p>This is done by using the&nbsp;<strong>DialogFooter</strong> control with <strong>DialogButton</strong> objects with the <strong>DialogResult</strong> and <strong>Command</strong> properties specified inside it. The first property (<strong>DialogResult</strong>) specifies the value returned by the <strong>ShowDialog</strong> method when the dialog is closed using the corresponding dialog button. The second property (<strong>Command</strong>) specifies the command invoked before closing the dialog.</p>

<br/>


