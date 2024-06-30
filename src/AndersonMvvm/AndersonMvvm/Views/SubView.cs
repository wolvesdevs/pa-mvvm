using AndersonMvvm.ViewModels;

namespace AndersonMvvm.Views;
public partial class SubView : Form
{
    private SubViewModel _viewModel;

    public SubView(SubViewModel viewModel)
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;

        _viewModel = viewModel;

        IdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.IdTextBoxText));
        NameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.NameTextBoxText));
    }

    private void CheckButton_Click(object sender, EventArgs e)
    {
        _viewModel.Check();
    }
}
