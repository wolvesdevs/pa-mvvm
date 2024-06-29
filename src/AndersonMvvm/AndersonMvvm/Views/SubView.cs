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
public partial class SubView : Form
{
    private SubViewModel _viewModel = new();

    public SubView()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
    }
}
