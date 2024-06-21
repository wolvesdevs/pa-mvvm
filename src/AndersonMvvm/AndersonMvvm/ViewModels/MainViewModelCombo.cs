namespace AndersonMvvm.ViewModels;
public sealed class MainViewModelCombo
{
    #region プロパティ

    public int Value { get; }
    public string DisplayValue { get; }

    #endregion

    #region コンストラクタ

    public MainViewModelCombo(int value, string displayValue)
    {
        Value = value;
        DisplayValue = displayValue;
    }

    #endregion
}
