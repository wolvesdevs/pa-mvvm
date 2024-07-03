using AndersonMvvm.ViewModels;

namespace AndersonMvvm.Views;
public partial class SubView : ViewBase
{
    private SubViewModel _viewModel;

    public SubView(SubViewModel viewModel)
    {
        InitializeComponent();

        base.Bind(_viewModel);

        _viewModel = viewModel;

        IdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.IdTextBoxText));
        NameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.NameTextBoxText));
        IdTextBox.DataBindings.Add(nameof(IdTextBox.ReadOnly), _viewModel, nameof(_viewModel.IdTextBoxReadOnly));
    }

    private void CheckButton_Click(object sender, EventArgs e)
    {
        _viewModel.Check();
    }
}
