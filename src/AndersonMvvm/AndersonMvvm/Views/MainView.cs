﻿using AndersonMvvm.ViewModels;
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

    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        _viewModel.Update();
    }

    private void CheckButton_Click(object sender, EventArgs e)
    {
        _viewModel.Check();
    }
}
