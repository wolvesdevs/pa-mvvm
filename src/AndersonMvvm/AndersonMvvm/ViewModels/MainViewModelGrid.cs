namespace AndersonMvvm.ViewModels;
public sealed class MainViewModelGrid
{
    #region プロパティ

    public string Id { get; }
    public string Name { get; set; }

    #endregion

    #region コンストラクタ

    public MainViewModelGrid(string id, string name)
    {
        Id = id;
        Name = name;
    }

    #endregion
}
