

namespace AndersonMvvm.ViewModels;
public sealed class MainViewModel : ViewModelBase
{
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

    internal void Update()
    {
        AAALabelText = "aaa updated!!";
        BBBTextBoxText = "bbb updated!!";
        CCCDateTimePickerValue = DateTime.Now.AddDays(7);
        DDDCheckBoxChecked = true;
    }

    internal void Check()
    {
    }
}
