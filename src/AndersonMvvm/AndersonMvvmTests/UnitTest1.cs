using AndersonMvvm.BindHelper;
using AndersonMvvm.ViewModels;
using Moq;
using System.Windows.Forms;

namespace AndersonMvvmTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var mock = new Mock<IMessageService>();
        mock.Setup(x => x.QuestionOKCancel("ï€ë∂ÇµÇ‹Ç∑Ç©ÅH")).Returns(DialogResult.Cancel);

        var vm = new MainViewModel(mock.Object, null);
        vm.Save();
        Assert.Equal("SAVE!!", vm.AAALabelText);
    }
}
