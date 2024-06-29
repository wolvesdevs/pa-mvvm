namespace AndersonMvvm.BindHelper;
public sealed class BindableRadioButton : RadioButton
{
    public BindableRadioButton()
    {
        AutoCheck = false;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);

        this.Checked = !this.Checked;
    }
}
