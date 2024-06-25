using AndersonMvvm.ViewModels;

namespace AndersonMvvmTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var vm = new MainViewModel(new MessageServiceMock());
        vm.Save();
        Assert.Equal("SAVE!!", vm.AAALabelText);
    }
}
