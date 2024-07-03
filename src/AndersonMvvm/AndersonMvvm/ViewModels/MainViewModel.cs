using AndersonMvvm.BindHelper;
using AndersonMvvm.Exceptions;
using System.ComponentModel;

namespace AndersonMvvm.ViewModels;
public sealed class MainViewModel : ViewModelBase
{
    #region フィールド＆プロパティ

    IMessageService _messageService;
    IDialogService _dialogService;

    private string _aAALabelText = "AAA";
    public string AAALabelText
    {
        get => _aAALabelText;
        set => SetProperty(ref _aAALabelText, value);
    }

    private string _bBBTextBoxText = string.Empty;
    public string BBBTextBoxText
    {
        get => _bBBTextBoxText;
        set => SetProperty(ref _bBBTextBoxText, value);
    }

    private DateTime _cCCDateTimePickerValue = DateTime.Now;
    public DateTime CCCDateTimePickerValue
    {
        get => _cCCDateTimePickerValue;
        set => SetProperty(ref _cCCDateTimePickerValue, value);
    }

    private bool _dDDCheckBoxChecked = false;
    public bool DDDCheckBoxChecked
    {
        get => _dDDCheckBoxChecked;
        set => SetProperty(ref _dDDCheckBoxChecked, value);
    }

    private bool _aRadioButtonChecked = false;
    public bool ARadioButtonChecked
    {
        get => _aRadioButtonChecked;
        set
        {
            SetProperty(ref _aRadioButtonChecked, value);

            if (value)
            {
                SetProperty(ref _bRadioButtonChecked, false, nameof(BRadioButtonChecked));
            }
        }
    }

    private bool _bRadioButtonChecked = false;
    public bool BRadioButtonChecked
    {
        get => _bRadioButtonChecked;
        set
        {
            SetProperty(ref _bRadioButtonChecked, value);

            if (value)
            {
                SetProperty(ref _aRadioButtonChecked, false, nameof(ARadioButtonChecked));
            }
        }
    }

    public BindingList<MainViewModelCombo> ComboSource { get; set; } = new();

    private object _eEEComboBoxSelectedValue;
    public object EEEComboBoxSelectedValue
    {
        get => _eEEComboBoxSelectedValue;
        set
        {
            SetProperty(ref _eEEComboBoxSelectedValue, value);
            //EEEComboBoxSelectedItem = ComboSource.FirstOrDefault(x => x.Value == (int)value);
        }
    }

    public MainViewModelCombo EEEComboBoxSelectedItem { get; set; }

    public BindingList<MainViewModelGrid> MyDataGridSource { get; set; } = new();

    private string _statusLabelText = "AAA";
    public string StatusLabelText
    {
        get => _statusLabelText;
        set => SetProperty(ref _statusLabelText, value);
    }

    private int _statusProgressBarValue = 0;
    public int StatusProgressBarValue
    {
        get => _statusProgressBarValue;
        set => SetProperty(ref _statusProgressBarValue, value);
    }

    private int _statusProgressBarMinimum = 0;
    public int StatusProgressBarMinimum
    {
        get => _statusProgressBarMinimum;
        set => SetProperty(ref _statusProgressBarMinimum, value);
    }

    private int _statusProgressBarMaximum = 0;
    public int StatusProgressBarMaximum
    {
        get => _statusProgressBarMaximum;
        set => SetProperty(ref _statusProgressBarMaximum, value);
    }

    private ProgressBarStyle _statusProgressBarStyle = ProgressBarStyle.Blocks;
    public ProgressBarStyle StatusProgressBarStyle
    {
        get => _statusProgressBarStyle;
        set => SetProperty(ref _statusProgressBarStyle, value);
    }

    private bool _statusProgressBarVisible = false;
    public bool StatusProgressBarVisible
    {
        get => _statusProgressBarVisible;
        set => SetProperty(ref _statusProgressBarVisible, value);
    }

    #endregion

    #region コンストラクタ

    public MainViewModel() : this(new MessageService(), new DialogService()) { }

    public MainViewModel(IMessageService messageService, IDialogService dialogService)
    {
        _messageService = messageService;
        _dialogService = dialogService;

        ComboSource.Add(new MainViewModelCombo(1, "AAAAA"));
        ComboSource.Add(new MainViewModelCombo(2, "BBBBB"));
        ComboSource.Add(new MainViewModelCombo(3, "CCCCC"));

        MyDataGridSource.Add(new MainViewModelGrid("1", "Name1"));
        MyDataGridSource.Add(new MainViewModelGrid("2", "Name2"));
        MyDataGridSource.Add(new MainViewModelGrid("3", "Name3"));
        MyDataGridSource.Add(new MainViewModelGrid("4", "Name4"));
        MyDataGridSource.Add(new MainViewModelGrid("5", "Name5"));

        EEEComboBoxSelectedValue = 1;
    }

    #endregion

    #region メソッド

    public void Update()
    {
        AAALabelText = "aaa updated!!";
        BBBTextBoxText = "bbb updated!!";
        CCCDateTimePickerValue = DateTime.Now.AddDays(7);
        DDDCheckBoxChecked = true;
        MyDataGridSource.Add(new MainViewModelGrid("6", "Name6"));
        ComboSource.Add(new MainViewModelCombo(100, "ZZZZZ"));
    }

    public void Check()
    {
    }

    public void Save()
    {
        if (_messageService.QuestionOKCancel("保存しますか？") != DialogResult.OK)
        {
            return;
        }

        int intResult = 0;
        if (!int.TryParse(BBBTextBoxText, out intResult))
        {
            throw new InputException("数値を入力してください");
        }

        AAALabelText = "SAVE!!";

        StatusLabelText = "保存しました";
    }

    public void ShowSubView()
    {
        var vm = new SubViewModel(null);
        _dialogService.ShowDialog(vm);
    }

    internal void MyDataGridDoubleClick(MainViewModelGrid row)
    {
        var vm = new SubViewModel(row);
        _dialogService.ShowDialog(vm);
    }

    internal void ClickProgressManualButton()
    {
        StatusProgressBarVisible = true;
        StatusProgressBarStyle = ProgressBarStyle.Blocks;
        StatusProgressBarMinimum = 0;
        StatusProgressBarMaximum = 100;
        StatusProgressBarValue = 50;
    }

    internal void ClickProgressAutoButton()
    {
        StatusProgressBarVisible = true;
        StatusProgressBarStyle = ProgressBarStyle.Marquee;
    }

    #endregion
}
