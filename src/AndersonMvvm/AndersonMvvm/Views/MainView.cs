using AndersonMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonMvvm.Views;
public partial class MainView : Form
{
    private MainViewModel _viewModel = new();

    public MainView()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;

        AAALabel.DataBindings.Add("Text", _viewModel, nameof(MainViewModel.AAALabelText));
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        _viewModel.Update();
    }
}
