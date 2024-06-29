using AndersonMvvm.ViewModels;

namespace AndersonMvvm.BindHelper;
public class DialogService : IDialogService
{
    public DialogResult ShowDialog(ViewModelBase vm)
    {
        string viewName = vm.GetType().FullName.Replace("ViewModel", "View");
        Type type = Type.GetType(viewName);
        var view = (Form)Activator.CreateInstance(type);
        return view.ShowDialog();
    }
}
