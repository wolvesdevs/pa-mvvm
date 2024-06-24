﻿

using System.ComponentModel;

namespace AndersonMvvm.ViewModels;
public sealed class MainViewModel : ViewModelBase
{
    #region フィールド＆プロパティ

    private string _aAALabelText = "AAA";
    public string AAALabelText
    {
        get => _aAALabelText;
        set => SetProperty(ref _aAALabelText, value);
    }

    private string _bBBTextBoxText = string.Empty;
    public string BBBTextBoxText
    {
        get => _bBBTextBoxText;
        set => SetProperty(ref _bBBTextBoxText, value);
    }

    private DateTime _cCCDateTimePickerValue = DateTime.Now;
    public DateTime CCCDateTimePickerValue
    {
        get => _cCCDateTimePickerValue;
        set => SetProperty(ref _cCCDateTimePickerValue, value);
    }

    private bool _dDDCheckBoxChecked = false;
    public bool DDDCheckBoxChecked
    {
        get => _dDDCheckBoxChecked;
        set => SetProperty(ref _dDDCheckBoxChecked, value);
    }

    private bool _aRadioButtonChecked = false;
    public bool ARadioButtonChecked
    {
        get => _aRadioButtonChecked;
        set
        {
            SetProperty(ref _aRadioButtonChecked, value);

            if (value)
            {
                SetProperty(ref _bRadioButtonChecked, false, nameof(BRadioButtonChecked));
            }
        }
    }

    private bool _bRadioButtonChecked = false;
    public bool BRadioButtonChecked
    {
        get => _bRadioButtonChecked;
        set
        {
            SetProperty(ref _bRadioButtonChecked, value);

            if (value)
            {
                SetProperty(ref _aRadioButtonChecked, false, nameof(ARadioButtonChecked));
            }
        }
    }

    public BindingList<MainViewModelCombo> ComboSource { get; set; } = new();

    private object _eEEComboBoxSelectedValue;
    public object EEEComboBoxSelectedValue
    {
        get => _eEEComboBoxSelectedValue;
        set
        {
            SetProperty(ref _eEEComboBoxSelectedValue, value);
            EEEComboBoxSelectedItem = ComboSource.FirstOrDefault(x => x.Value == (int)value);
        }
    }

    public MainViewModelCombo EEEComboBoxSelectedItem { get; set; }

    public BindingList<MainViewModelGrid> MyDataGridSource { get; set; } = new();

    #endregion

    #region コンストラクタ

    public MainViewModel()
    {
        ComboSource.Add(new MainViewModelCombo(1, "AAAAA"));
        ComboSource.Add(new MainViewModelCombo(2, "BBBBB"));
        ComboSource.Add(new MainViewModelCombo(3, "CCCCC"));

        MyDataGridSource.Add(new MainViewModelGrid("1", "Name1"));
        MyDataGridSource.Add(new MainViewModelGrid("2", "Name2"));
        MyDataGridSource.Add(new MainViewModelGrid("3", "Name3"));
        MyDataGridSource.Add(new MainViewModelGrid("4", "Name4"));
        MyDataGridSource.Add(new MainViewModelGrid("5", "Name5"));

        EEEComboBoxSelectedValue = 1;
    }

    #endregion

    #region メソッド

    internal void Update()
    {
        AAALabelText = "aaa updated!!";
        BBBTextBoxText = "bbb updated!!";
        CCCDateTimePickerValue = DateTime.Now.AddDays(7);
        DDDCheckBoxChecked = true;
        MyDataGridSource.Add(new MainViewModelGrid("6", "Name6"));
        ComboSource.Add(new MainViewModelCombo(100, "ZZZZZ"));
    }

    internal void Check()
    {
    }

    #endregion
}
