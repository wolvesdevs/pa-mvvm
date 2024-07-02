namespace AndersonMvvm.Views;

partial class SubView
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
        label1 = new Label();
        label2 = new Label();
        IdTextBox = new TextBox();
        NameTextBox = new TextBox();
        CheckButton = new Button();
        SaveButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(51, 53);
        label1.Name = "label1";
        label1.Size = new Size(28, 25);
        label1.TabIndex = 0;
        label1.Text = "Id";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(51, 116);
        label2.Name = "label2";
        label2.Size = new Size(59, 25);
        label2.TabIndex = 1;
        label2.Text = "Name";
        // 
        // IdTextBox
        // 
        IdTextBox.Location = new Point(150, 53);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.Size = new Size(150, 31);
        IdTextBox.TabIndex = 2;
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(150, 116);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(150, 31);
        NameTextBox.TabIndex = 3;
        // 
        // CheckButton
        // 
        CheckButton.Location = new Point(51, 286);
        CheckButton.Name = "CheckButton";
        CheckButton.Size = new Size(112, 34);
        CheckButton.TabIndex = 4;
        CheckButton.Text = "check";
        CheckButton.UseVisualStyleBackColor = true;
        CheckButton.Click += CheckButton_Click;
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(51, 177);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(249, 34);
        SaveButton.TabIndex = 5;
        SaveButton.Text = "save";
        SaveButton.UseVisualStyleBackColor = true;
        // 
        // SubView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(439, 389);
        Controls.Add(SaveButton);
        Controls.Add(CheckButton);
        Controls.Add(NameTextBox);
        Controls.Add(IdTextBox);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "SubView";
        Text = "SubView";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox IdTextBox;
    private TextBox NameTextBox;
    private Button CheckButton;
    private Button SaveButton;
}