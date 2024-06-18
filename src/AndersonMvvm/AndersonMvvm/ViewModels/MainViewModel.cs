

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

    internal void Update()
    {
        AAALabelText = "aaa updated!!";
        BBBTextBoxText = "bbb updated!!";
        CCCDateTimePickerValue = DateTime.Now.AddDays(7);
    }

    internal void Check()
    {
    }
}
