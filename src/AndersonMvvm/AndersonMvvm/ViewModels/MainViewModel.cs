
namespace AndersonMvvm.ViewModels;
public sealed class MainViewModel : ViewModelBase
{
    private string _aAALabelText = "AAA";
    public string AAALabelText
    {
        get => _aAALabelText;
        set => SetProperty(ref _aAALabelText, value);
    }

    internal void Update()
    {
        AAALabelText = "aaa updated!!";
    }
}
