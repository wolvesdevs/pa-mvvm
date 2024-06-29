using AndersonMvvm.ViewModels;

namespace AndersonMvvm.BindHelper;
public interface IDialogService
{
    DialogResult ShowDialog(ViewModelBase vm);
}
