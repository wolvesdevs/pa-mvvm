using AndersonMvvm.ViewModels;

namespace AndersonMvvm.Views;
public partial class ViewBase : Form
{
    public ViewBase()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }

    protected void Bind(ViewModelBase vm)
    {
        StatusProgressBar.DataBindings.Add(nameof(StatusProgressBar.Value), vm, nameof(vm.StatusProgressBarValue));
        StatusProgressBar.DataBindings.Add(nameof(StatusProgressBar.Minimum), vm, nameof(vm.StatusProgressBarMinimum));
        StatusProgressBar.DataBindings.Add(nameof(StatusProgressBar.Maximum), vm, nameof(vm.StatusProgressBarMaximum));
        StatusProgressBar.DataBindings.Add(nameof(StatusProgressBar.Style), vm, nameof(vm.StatusProgressBarStyle));
        StatusProgressBar.DataBindings.Add(nameof(StatusProgressBar.Visible), vm, nameof(vm.StatusProgressBarVisible));

        StatusLabel.DataBindings.Add("Text", vm, nameof(vm.StatusLabelText));

    }
}
