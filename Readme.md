<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658041/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T520287)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF DialogService - Customize Dialog Buttons

Our [WPF DialogService](https://docs.devexpress.com/WPF/17467/mvvm-framework/services/predefined-set/dialog-services/dialogservice) allows you to invoke a dialog window from the View Model code. The service's [ShowDialog](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.DialogServiceExtensions.ShowDialog.overloads) method accepts parameters that specify the window title, buttons, and so on. You can select buttons from the `MessageButton` enumeration or create a collection of [UICommand](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.UICommand) objects. This example demonstrates how to change the position of buttons generated from [UICommand](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.UICommand) objects.

![image](https://user-images.githubusercontent.com/65009440/231432257-9d5fc368-efd0-4c37-907a-a52af1175702.png)

## Implementation Details

Dialog buttons are objects of the [ThemedWindowDialogButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton) class. You can explicitly add these buttons to the dialog View:

1. Create [ThemedWindowDialogButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton) objects and define their properties.
2. Add these objects to the `ThemedWindowDialogButtonsControl` container and specify its position.
3. Set the [ThemedWindowOptions.UseCustomDialogFooter](http://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Native.ThemedWindowOptions.UseCustomDialogFooter) attached property to `true` to hide auto-generated buttons.

The [ThemedWindowDialogButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton) class contains [UICommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton.UICommand) and [DialogResult](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton.DialogResult) properties. These properties allow you to specify the value returned by the `ShowDialog` method when a user clicks the button.

If you use dialog buttons from the `MessageButton` enumeration, you can use the approach from the following example instead: [WPF DialogService - Close an Opened Dialog and Specify the Dialog Result](https://github.com/DevExpress-Examples/wpf-dialogservice-close-opened-dialog-and-specify-dialog-result). This example demonstrates how to create a command that uses the [CurrentDialogService](https://docs.devexpress.com/WPF/401018/mvvm-framework/services/predefined-set/currentdialogservice) to close the dialog with the specified result.

## Files to Review

* [MainView.xaml](./CS/Views/MainView.xaml) (VB: [MainView.xaml](./VB/Views/MainView.xaml))
* [MainViewModel.cs](./CS/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ViewModels/MainViewModel.vb))
* [DialogView.xaml](./CS/Views/DialogView.xaml) (VB: [DialogView.xaml](./VB/Views/DialogView.xaml))
* [DialogViewModel.cs](./CS/ViewModels/DialogViewModel.cs) (VB: [DialogViewModel.vb](./VB/ViewModels/DialogViewModel.vb))

## Documentation

* [DialogService](https://docs.devexpress.com/WPF/17467/mvvm-framework/services/predefined-set/dialog-services/dialogservice)
* [ThemedWindowDialogButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ThemedWindowDialogButton)
* [UICommand](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.UICommand)
* [Services in ViewModelBase Descendants](https://docs.devexpress.com/WPF/17446/mvvm-framework/services/services-in-viewmodelbase-descendants)
* [CurrentDialogService](https://docs.devexpress.com/WPF/401018/mvvm-framework/services/predefined-set/currentdialogservice)

## More Examples

* [Use DialogService to Show a Modal Dialog Window](https://github.com/DevExpress-Examples/wpf-mvvm-framework-ui-services-dialogservice)
* [WPF DialogService - Close an Opened Dialog and Specify the Dialog Result](https://github.com/DevExpress-Examples/wpf-dialogservice-close-opened-dialog-and-specify-dialog-result)
