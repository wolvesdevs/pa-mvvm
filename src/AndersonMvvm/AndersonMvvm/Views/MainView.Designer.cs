namespace AndersonMvvm.Views;

partial class MainView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        AAALabel = new Label();
        UpdateButton = new Button();
        BBBTextBox = new TextBox();
        CheckButton = new Button();
        CCCDateTimePicker = new DateTimePicker();
        DDDCheckBox = new CheckBox();
        ARadioButton = new BindHelper.BindableRadioButton();
        BRadioButton = new BindHelper.BindableRadioButton();
        EEEComboBox = new ComboBox();
        MyDataGrid = new DataGridView();
        SaveButton = new Button();
        SubViewShowButton = new Button();
        statusStrip1 = new StatusStrip();
        StatusProgressBar = new BindHelpers.BindableToolStripProgressBar();
        StatusLabel = new BindHelpers.BindableToolStripStatusLabel();
        ProgressManualButton = new Button();
        ProgressAutoButton = new Button();
        ((System.ComponentModel.ISupportInitialize)MyDataGrid).BeginInit();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // AAALabel
        // 
        AAALabel.AutoSize = true;
        AAALabel.Location = new Point(12, 9);
        AAALabel.Name = "AAALabel";
        AAALabel.Size = new Size(59, 25);
        AAALabel.TabIndex = 0;
        AAALabel.Text = "label1";
        // 
        // UpdateButton
        // 
        UpdateButton.Location = new Point(182, 9);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new Size(112, 34);
        UpdateButton.TabIndex = 1;
        UpdateButton.Text = "update";
        UpdateButton.UseVisualStyleBackColor = true;
        UpdateButton.Click += UpdateButton_Click;
        // 
        // BBBTextBox
        // 
        BBBTextBox.Location = new Point(12, 75);
        BBBTextBox.Name = "BBBTextBox";
        BBBTextBox.Size = new Size(150, 31);
        BBBTextBox.TabIndex = 2;
        // 
        // CheckButton
        // 
        CheckButton.Location = new Point(365, 9);
        CheckButton.Name = "CheckButton";
        CheckButton.Size = new Size(112, 34);
        CheckButton.TabIndex = 3;
        CheckButton.Text = "check";
        CheckButton.UseVisualStyleBackColor = true;
        CheckButton.Click += CheckButton_Click;
        // 
        // CCCDateTimePicker
        // 
        CCCDateTimePicker.Location = new Point(12, 136);
        CCCDateTimePicker.Name = "CCCDateTimePicker";
        CCCDateTimePicker.Size = new Size(300, 31);
        CCCDateTimePicker.TabIndex = 4;
        // 
        // DDDCheckBox
        // 
        DDDCheckBox.AutoSize = true;
        DDDCheckBox.Location = new Point(12, 201);
        DDDCheckBox.Name = "DDDCheckBox";
        DDDCheckBox.Size = new Size(121, 29);
        DDDCheckBox.TabIndex = 5;
        DDDCheckBox.Text = "checkBox1";
        DDDCheckBox.UseVisualStyleBackColor = true;
        // 
        // ARadioButton
        // 
        ARadioButton.AutoCheck = false;
        ARadioButton.AutoSize = true;
        ARadioButton.Location = new Point(12, 246);
        ARadioButton.Name = "ARadioButton";
        ARadioButton.Size = new Size(215, 29);
        ARadioButton.TabIndex = 7;
        ARadioButton.TabStop = true;
        ARadioButton.Text = "bindableRadioButton1";
        ARadioButton.UseVisualStyleBackColor = true;
        // 
        // BRadioButton
        // 
        BRadioButton.AutoCheck = false;
        BRadioButton.AutoSize = true;
        BRadioButton.Location = new Point(12, 290);
        BRadioButton.Name = "BRadioButton";
        BRadioButton.Size = new Size(215, 29);
        BRadioButton.TabIndex = 7;
        BRadioButton.TabStop = true;
        BRadioButton.Text = "bindableRadioButton2";
        BRadioButton.UseVisualStyleBackColor = true;
        // 
        // EEEComboBox
        // 
        EEEComboBox.FormattingEnabled = true;
        EEEComboBox.Location = new Point(12, 340);
        EEEComboBox.Name = "EEEComboBox";
        EEEComboBox.Size = new Size(182, 33);
        EEEComboBox.TabIndex = 8;
        // 
        // MyDataGrid
        // 
        MyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        MyDataGrid.Location = new Point(365, 75);
        MyDataGrid.Name = "MyDataGrid";
        MyDataGrid.RowHeadersWidth = 62;
        MyDataGrid.Size = new Size(360, 225);
        MyDataGrid.TabIndex = 9;
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(12, 388);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(112, 34);
        SaveButton.TabIndex = 10;
        SaveButton.Text = "save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // SubViewShowButton
        // 
        SubViewShowButton.Location = new Point(365, 388);
        SubViewShowButton.Name = "SubViewShowButton";
        SubViewShowButton.Size = new Size(112, 34);
        SubViewShowButton.TabIndex = 11;
        SubViewShowButton.Text = "show";
        SubViewShowButton.UseVisualStyleBackColor = true;
        SubViewShowButton.Click += SubViewShowButton_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(24, 24);
        statusStrip1.Items.AddRange(new ToolStripItem[] { StatusProgressBar, StatusLabel });
        statusStrip1.Location = new Point(0, 437);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(800, 32);
        statusStrip1.TabIndex = 12;
        statusStrip1.Text = "statusStrip1";
        // 
        // StatusProgressBar
        // 
        StatusProgressBar.Name = "StatusProgressBar";
        StatusProgressBar.Size = new Size(100, 24);
        // 
        // StatusLabel
        // 
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(251, 25);
        StatusLabel.Text = "bindableToolStripStatusLabel1";
        // 
        // ProgressManualButton
        // 
        ProgressManualButton.Location = new Point(515, 316);
        ProgressManualButton.Name = "ProgressManualButton";
        ProgressManualButton.Size = new Size(135, 34);
        ProgressManualButton.TabIndex = 13;
        ProgressManualButton.Text = "Progress手動";
        ProgressManualButton.UseVisualStyleBackColor = true;
        ProgressManualButton.Click += ProgressManualButton_Click;
        // 
        // ProgressAutoButton
        // 
        ProgressAutoButton.Location = new Point(515, 356);
        ProgressAutoButton.Name = "ProgressAutoButton";
        ProgressAutoButton.Size = new Size(135, 34);
        ProgressAutoButton.TabIndex = 14;
        ProgressAutoButton.Text = "Progress自動";
        ProgressAutoButton.UseVisualStyleBackColor = true;
        ProgressAutoButton.Click += ProgressAutoButton_Click;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 469);
        Controls.Add(ProgressAutoButton);
        Controls.Add(ProgressManualButton);
        Controls.Add(statusStrip1);
        Controls.Add(SubViewShowButton);
        Controls.Add(SaveButton);
        Controls.Add(MyDataGrid);
        Controls.Add(EEEComboBox);
        Controls.Add(BRadioButton);
        Controls.Add(ARadioButton);
        Controls.Add(DDDCheckBox);
        Controls.Add(CCCDateTimePicker);
        Controls.Add(CheckButton);
        Controls.Add(BBBTextBox);
        Controls.Add(UpdateButton);
        Controls.Add(AAALabel);
        Name = "MainView";
        Text = "MainView";
        ((System.ComponentModel.ISupportInitialize)MyDataGrid).EndInit();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label AAALabel;
    private Button UpdateButton;
    private TextBox BBBTextBox;
    private Button CheckButton;
    private DateTimePicker CCCDateTimePicker;
    private CheckBox DDDCheckBox;
    private BindHelper.BindableRadioButton ARadioButton;
    private BindHelper.BindableRadioButton BRadioButton;
    private ComboBox EEEComboBox;
    private DataGridView MyDataGrid;
    private Button SaveButton;
    private Button SubViewShowButton;
    private StatusStrip statusStrip1;
    private BindHelpers.BindableToolStripStatusLabel StatusLabel;
    private BindHelpers.BindableToolStripProgressBar StatusProgressBar;
    private Button ProgressManualButton;
    private Button ProgressAutoButton;
}
