using AndersonMvvm.ViewModels;
using Microsoft.AspNetCore.Components;
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
public partial class MainView : ViewBase
{
    private MainViewModel _viewModel = new();

    public MainView()
    {
        InitializeComponent();

        //_viewModel.PropertyChanged += ViewModel_PropertyChanged();

        base.Bind(_viewModel);

        AAALabel.DataBindings.Add("Text", _viewModel, nameof(MainViewModel.AAALabelText));
        BBBTextBox.DataBindings.Add("Text", _viewModel, nameof(MainViewModel.BBBTextBoxText));
        CCCDateTimePicker.DataBindings.Add("Value", _viewModel, nameof(MainViewModel.CCCDateTimePickerValue));
        DDDCheckBox.DataBindings.Add(nameof(DDDCheckBox.Checked), _viewModel, nameof(MainViewModel.DDDCheckBoxChecked));

        // ラジオボタンのバインディング
        ARadioButton.DataBindings.Add(
            nameof(ARadioButton.Checked),
            _viewModel,
            nameof(MainViewModel.ARadioButtonChecked),
            false,
            DataSourceUpdateMode.OnPropertyChanged);
        BRadioButton.DataBindings.Add(
            nameof(ARadioButton.Checked),
            _viewModel,
            nameof(MainViewModel.BRadioButtonChecked),
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        // コンボボックスのバインディング
        EEEComboBox.DataBindings.Add("DataSource", _viewModel, nameof(MainViewModel.ComboSource));
        EEEComboBox.ValueMember = nameof(MainViewModelCombo.Value);
        EEEComboBox.DisplayMember = nameof(MainViewModelCombo.DisplayValue);
        EEEComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        EEEComboBox.DataBindings.Add(
            "SelectedValue",
            _viewModel,
            nameof(_viewModel.EEEComboBoxSelectedValue),
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        //MyDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.MyDataGridSource));

        MyDataGrid.DataSource = _viewModel.MyDataGridSource;
        MyDataGrid.DoubleClick += (s, e) => _viewModel.MyDataGridDoubleClick(MyDataGrid.CurrentRow.DataBoundItem as MainViewModelGrid);

        MyDataGrid.Columns[nameof(MainViewModelGrid.Id)].HeaderText = "ID";
        MyDataGrid.Columns[nameof(MainViewModelGrid.Name)].HeaderText = "名前";
        MyDataGrid.Columns[nameof(MainViewModelGrid.Id)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        UpdateButton.Click += (s, e) => _viewModel.Update();
        CheckButton.Click += (s, e) => _viewModel.Check();
        SaveButton.Click += (s, e) => _viewModel.Save();
        SubViewShowButton.Click += (s, e) => _viewModel.ShowSubView();
        ProgressManualButton.Click += (s, e) => _viewModel.ClickProgressManualButton();
        ProgressAutoButton.Click += (s, e) => _viewModel.ClickProgressAutoButton();

        EEEComboBox.SelectedIndexChanged += (s, e) => _viewModel.EEEComboBoxSelectedIndexChanged(e);
    }

    //private void ViewModel_PropertyChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    //{
    //    if(e.PropertyName == )
    //}
}
