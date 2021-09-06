<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658041/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T520287)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [DialogViewModel.cs](./CS/ViewModels/DialogViewModel.cs) (VB: [DialogViewModel.vb](./VB/ViewModels/DialogViewModel.vb))
* [MainViewModel.cs](./CS/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ViewModels/MainViewModel.vb))
* [DialogView.xaml](./CS/Views/DialogView.xaml) (VB: [DialogView.xaml](./VB/Views/DialogView.xaml))
* **[MainView.xaml](./CS/Views/MainView.xaml) (VB: [MainView.xaml](./VB/Views/MainView.xaml))**
<!-- default file list end -->
# How to: customize the dialog's footer buttons


This example demonstrates how to customize the dialog's footer buttons.


<h3>Description</h3>

<p>This is done by using the&nbsp;<strong>ThemedWindowDialogButtonsControl</strong> control with <strong>ThemedWindowDialogButton</strong> objects with the <strong>DialogResult</strong> and <strong>Command</strong> properties specified inside it. The first property (<strong>DialogResult</strong>) specifies the value returned by the <strong>ShowDialog</strong> method when the dialog is closed using the corresponding dialog button. The second property (<strong>Command</strong>) specifies the command invoked before closing the dialog.</p>

<br/>


