namespace AndersonMvvm.BindHelper;
public interface IMessageService
{
    void OKOnly(string message);
    DialogResult QuestionOKCancel(string message);
}
