using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AndersonMvvm.ViewModels;
public abstract class ViewModelBase : INotifyPropertyChanged
{
    /// <summary>
    /// プロパティの値が変更されたときに発生します。
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    public Dispatcher Dispatcher { get; set; }

    /// <summary>
    /// 指定した値でプロパティを設定し、新しい値が異なる場合は PropertyChanged イベントを発生させます。
    /// </summary>
    /// <typeparam name="T">プロパティの型</typeparam>
    /// <param name="field">設定対象のフィールド</param>
    /// <param name="value">新しい値</param>
    /// <param name="propertyName">プロパティ名。このオプションのパラメータはコンパイラによって自動的に設定されます。</param>
    /// <returns>値が変更された場合は true、値が同じ場合は false</returns>
    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);

        return true;
    }

    /// <summary>
    /// 現在の日時を取得します。
    /// </summary>
    /// <returns>現在の日時</returns>
    public virtual DateTime GetDateTime()
    {
        return DateTime.Now;
    }

    /// <summary>
    /// バインドされた指定プロパティに対して、PropertyChanged イベントを発生させます。
    /// </summary>
    /// <param name="propertyName">プロパティ名。このオプションのパラメータはコンパイラによって自動的に設定されます。</param>
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// バインドされたすべてのプロパティに対して、PropertyChanged イベントを発生させます。
    /// </summary>
    protected void OnAllPropertyChanged()
    {
        if (Dispatcher != null)
        {
            Dispatcher.InvokeAsync(() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("")));
        }
        else
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }

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

}
