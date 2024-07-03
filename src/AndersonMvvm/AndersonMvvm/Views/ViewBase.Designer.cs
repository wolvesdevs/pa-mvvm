namespace AndersonMvvm.Views;

partial class ViewBase
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
        statusStrip1 = new StatusStrip();
        StatusProgressBar = new BindHelpers.BindableToolStripProgressBar();
        StatusLabel = new BindHelpers.BindableToolStripStatusLabel();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(24, 24);
        statusStrip1.Items.AddRange(new ToolStripItem[] { StatusProgressBar, StatusLabel });
        statusStrip1.Location = new Point(0, 418);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(800, 32);
        statusStrip1.TabIndex = 13;
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
        // ViewBase
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(statusStrip1);
        Name = "ViewBase";
        Text = "ViewBase";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private BindHelpers.BindableToolStripProgressBar StatusProgressBar;
    private BindHelpers.BindableToolStripStatusLabel StatusLabel;
}