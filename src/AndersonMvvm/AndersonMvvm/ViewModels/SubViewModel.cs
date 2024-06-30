
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

    #endregion

    #region コンストラクタ

    public SubViewModel(MainViewModelGrid row)
    {
        IdTextBoxText = row.Id;
        NameTextBoxText = row.Name;
    }

    #endregion

    #region メソッド

    internal void Check()
    {
    }

    #endregion
}
