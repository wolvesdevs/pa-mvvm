
namespace AndersonMvvm.ViewModels;
public class SubViewModel : ViewModelBase
{
    #region フィールド＆プロパティ

    private string _idTextBoxText = string.Empty;
    public string IdTextBoxText
    {
        get => _idTextBoxText;
        set => SetProperty(ref _idTextBoxText, value);
    }

    private string _nameTextBoxText = string.Empty;
    public string NameTextBoxText
    {
        get => _nameTextBoxText;
        set => SetProperty(ref _nameTextBoxText, value);
    }
    private bool _idTextBoxReadOnly = false;
    public bool IdTextBoxReadOnly
    {
        get => _idTextBoxReadOnly;
        set => SetProperty(ref _idTextBoxReadOnly, value);
    }

    #endregion

    #region コンストラクタ

    public SubViewModel(MainViewModelGrid row)
    {
        if (row == null)
        {
            IdTextBoxReadOnly = false;
            return;
        }

        IdTextBoxText = row.Id;
        NameTextBoxText = row.Name;
        IdTextBoxReadOnly = true;
    }

    #endregion

    #region メソッド

    internal void Check()
    {
    }

    #endregion
}
