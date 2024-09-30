
namespace Interest_Calculator_SF_MASOKA_39069656
{
    partial class InterestConversion
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.InputListBox = new System.Windows.Forms.ListBox();
            this.InputPeriodTextBox = new System.Windows.Forms.TextBox();
            this.InputInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.InputInterestTypeLabel = new System.Windows.Forms.Label();
            this.InputCPeriodLabel = new System.Windows.Forms.Label();
            this.InputInterestRateLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputPeriodLabel = new System.Windows.Forms.Label();
            this.OutputInterestTypeLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.OutputPeriodTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultInterestlabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.InputListBox);
            this.InputPanel.Controls.Add(this.InputPeriodTextBox);
            this.InputPanel.Controls.Add(this.InputInterestRateTextBox);
            this.InputPanel.Controls.Add(this.InputInterestTypeLabel);
            this.InputPanel.Controls.Add(this.InputCPeriodLabel);
            this.InputPanel.Controls.Add(this.InputInterestRateLabel);
            this.InputPanel.Controls.Add(this.InputLabel);
            this.InputPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPanel.Location = new System.Drawing.Point(12, 12);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(337, 234);
            this.InputPanel.TabIndex = 0;
            // 
            // InputListBox
            // 
            this.InputListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputListBox.FormattingEnabled = true;
            this.InputListBox.ItemHeight = 16;
            this.InputListBox.Items.AddRange(new object[] {
            "Annual Effective",
            "Nominal",
            "Effective Per Period",
            "Continuous"});
            this.InputListBox.Location = new System.Drawing.Point(154, 62);
            this.InputListBox.Name = "InputListBox";
            this.InputListBox.Size = new System.Drawing.Size(139, 16);
            this.InputListBox.TabIndex = 11;
            // 
            // InputPeriodTextBox
            // 
            this.InputPeriodTextBox.Location = new System.Drawing.Point(210, 118);
            this.InputPeriodTextBox.Name = "InputPeriodTextBox";
            this.InputPeriodTextBox.Size = new System.Drawing.Size(117, 23);
            this.InputPeriodTextBox.TabIndex = 10;
            // 
            // InputInterestRateTextBox
            // 
            this.InputInterestRateTextBox.Location = new System.Drawing.Point(210, 177);
            this.InputInterestRateTextBox.Name = "InputInterestRateTextBox";
            this.InputInterestRateTextBox.Size = new System.Drawing.Size(117, 23);
            this.InputInterestRateTextBox.TabIndex = 8;
            // 
            // InputInterestTypeLabel
            // 
            this.InputInterestTypeLabel.AutoSize = true;
            this.InputInterestTypeLabel.Location = new System.Drawing.Point(34, 62);
            this.InputInterestTypeLabel.Name = "InputInterestTypeLabel";
            this.InputInterestTypeLabel.Size = new System.Drawing.Size(114, 17);
            this.InputInterestTypeLabel.TabIndex = 6;
            this.InputInterestTypeLabel.Text = "Type Of Interest:";
            // 
            // InputCPeriodLabel
            // 
            this.InputCPeriodLabel.AutoSize = true;
            this.InputCPeriodLabel.Location = new System.Drawing.Point(3, 121);
            this.InputCPeriodLabel.Name = "InputCPeriodLabel";
            this.InputCPeriodLabel.Size = new System.Drawing.Size(204, 17);
            this.InputCPeriodLabel.TabIndex = 5;
            this.InputCPeriodLabel.Text = "Compounding Period Per Year:";
            // 
            // InputInterestRateLabel
            // 
            this.InputInterestRateLabel.AutoSize = true;
            this.InputInterestRateLabel.Location = new System.Drawing.Point(65, 183);
            this.InputInterestRateLabel.Name = "InputInterestRateLabel";
            this.InputInterestRateLabel.Size = new System.Drawing.Size(119, 17);
            this.InputInterestRateLabel.TabIndex = 4;
            this.InputInterestRateLabel.Text = "Interest Rate (%):";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(98, 17);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(143, 17);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input Interest Rate";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Controls.Add(this.OutputPeriodLabel);
            this.OutputPanel.Controls.Add(this.OutputInterestTypeLabel);
            this.OutputPanel.Controls.Add(this.OutputListBox);
            this.OutputPanel.Controls.Add(this.OutputPeriodTextBox);
            this.OutputPanel.Controls.Add(this.OutputLabel);
            this.OutputPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPanel.Location = new System.Drawing.Point(371, 12);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(340, 234);
            this.OutputPanel.TabIndex = 1;
            // 
            // OutputPeriodLabel
            // 
            this.OutputPeriodLabel.AutoSize = true;
            this.OutputPeriodLabel.Location = new System.Drawing.Point(3, 101);
            this.OutputPeriodLabel.Name = "OutputPeriodLabel";
            this.OutputPeriodLabel.Size = new System.Drawing.Size(204, 17);
            this.OutputPeriodLabel.TabIndex = 16;
            this.OutputPeriodLabel.Text = "Compounding Period Per Year:";
            // 
            // OutputInterestTypeLabel
            // 
            this.OutputInterestTypeLabel.AutoSize = true;
            this.OutputInterestTypeLabel.Location = new System.Drawing.Point(22, 59);
            this.OutputInterestTypeLabel.Name = "OutputInterestTypeLabel";
            this.OutputInterestTypeLabel.Size = new System.Drawing.Size(114, 17);
            this.OutputInterestTypeLabel.TabIndex = 15;
            this.OutputInterestTypeLabel.Text = "Type Of Interest:";
            // 
            // OutputListBox
            // 
            this.OutputListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 16;
            this.OutputListBox.Items.AddRange(new object[] {
            "Annual Effective",
            "Nominal",
            "Effective Per Period",
            "Continuous"});
            this.OutputListBox.Location = new System.Drawing.Point(143, 59);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(137, 16);
            this.OutputListBox.TabIndex = 14;
            // 
            // OutputPeriodTextBox
            // 
            this.OutputPeriodTextBox.Location = new System.Drawing.Point(213, 98);
            this.OutputPeriodTextBox.Name = "OutputPeriodTextBox";
            this.OutputPeriodTextBox.Size = new System.Drawing.Size(115, 23);
            this.OutputPeriodTextBox.TabIndex = 12;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(95, 17);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(156, 17);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Output Interest Rate";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(408, 292);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 55);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(515, 292);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 55);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(625, 292);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 55);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPanel.Controls.Add(this.ResultTextBox);
            this.ResultPanel.Controls.Add(this.ResultInterestlabel);
            this.ResultPanel.Controls.Add(this.ResultLabel);
            this.ResultPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultPanel.Location = new System.Drawing.Point(81, 274);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(277, 107);
            this.ResultPanel.TabIndex = 6;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(146, 52);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(117, 23);
            this.ResultTextBox.TabIndex = 9;
            // 
            // ResultInterestlabel
            // 
            this.ResultInterestlabel.AutoSize = true;
            this.ResultInterestlabel.Location = new System.Drawing.Point(19, 55);
            this.ResultInterestlabel.Name = "ResultInterestlabel";
            this.ResultInterestlabel.Size = new System.Drawing.Size(119, 17);
            this.ResultInterestlabel.TabIndex = 5;
            this.ResultInterestlabel.Text = "Interest Rate (%):";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(118, 17);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(54, 17);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Result";
            // 
            // InterestConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 401);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.InputPanel);
            this.Name = "InterestConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Rate Converter";
            this.Load += new System.EventHandler(this.InterestConversion_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.TextBox InputPeriodTextBox;
        private System.Windows.Forms.TextBox InputInterestRateTextBox;
        private System.Windows.Forms.Label InputInterestTypeLabel;
        private System.Windows.Forms.Label InputCPeriodLabel;
        private System.Windows.Forms.Label InputInterestRateLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox OutputPeriodTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label OutputInterestTypeLabel;
        private System.Windows.Forms.Label OutputPeriodLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultInterestlabel;
    }
}