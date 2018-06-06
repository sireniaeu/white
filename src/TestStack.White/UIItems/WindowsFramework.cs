namespace TestStack.White.UIItems
{
    public enum WindowsFramework
    {
        [FrameworkId("")]
        None,
        [FrameworkId("XAML")]
        Xaml,
        [FrameworkId("WPF")]
        Wpf,
        Win32,
        [FrameworkId("WinForm")]
        WinForms,
        Silverlight,
        [FrameworkId("SWT")]
        Swt
    }
}