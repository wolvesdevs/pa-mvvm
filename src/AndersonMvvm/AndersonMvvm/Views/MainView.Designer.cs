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
        // MainView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(UpdateButton);
        Controls.Add(AAALabel);
        Name = "MainView";
        Text = "MainView";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label AAALabel;
    private Button UpdateButton;
}