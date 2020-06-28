namespace MyTaskCreater
{
    partial class myTaskMain
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
            this.taskPathTextBox = new System.Windows.Forms.TextBox();
            this.taskPathLable = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.taskTitleTextBox = new System.Windows.Forms.TextBox();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataPickerLabel = new System.Windows.Forms.Label();
            this.weekOfYearLabel = new System.Windows.Forms.Label();
            this.weeklyTextBox = new System.Windows.Forms.TextBox();
            this.useWeeklyCheckBox = new System.Windows.Forms.CheckBox();
            this.doIt_Butten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskPathTextBox
            // 
            this.taskPathTextBox.Enabled = false;
            this.taskPathTextBox.Location = new System.Drawing.Point(12, 35);
            this.taskPathTextBox.Name = "taskPathTextBox";
            this.taskPathTextBox.Size = new System.Drawing.Size(531, 26);
            this.taskPathTextBox.TabIndex = 0;
            // 
            // taskPathLable
            // 
            this.taskPathLable.AutoSize = true;
            this.taskPathLable.Location = new System.Drawing.Point(8, 9);
            this.taskPathLable.Name = "taskPathLable";
            this.taskPathLable.Size = new System.Drawing.Size(137, 20);
            this.taskPathLable.TabIndex = 1;
            this.taskPathLable.Text = "Current Task Path";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Location = new System.Drawing.Point(8, 75);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(76, 20);
            this.taskTitleLabel.TabIndex = 2;
            this.taskTitleLabel.Text = "Task Title";
            // 
            // taskTitleTextBox
            // 
            this.taskTitleTextBox.Location = new System.Drawing.Point(12, 100);
            this.taskTitleTextBox.Name = "taskTitleTextBox";
            this.taskTitleTextBox.Size = new System.Drawing.Size(531, 26);
            this.taskTitleTextBox.TabIndex = 3;
            this.taskTitleTextBox.TextChanged += new System.EventHandler(this.taskTitleTextBox_TextChanged);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(12, 163);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.currentDateTimePicker.TabIndex = 4;
            this.currentDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateTimePicker_ValueChanged);
            // 
            // dataPickerLabel
            // 
            this.dataPickerLabel.AutoSize = true;
            this.dataPickerLabel.Location = new System.Drawing.Point(8, 134);
            this.dataPickerLabel.Name = "dataPickerLabel";
            this.dataPickerLabel.Size = new System.Drawing.Size(44, 20);
            this.dataPickerLabel.TabIndex = 5;
            this.dataPickerLabel.Text = "Date";
            // 
            // weekOfYearLabel
            // 
            this.weekOfYearLabel.AutoSize = true;
            this.weekOfYearLabel.Location = new System.Drawing.Point(299, 134);
            this.weekOfYearLabel.Name = "weekOfYearLabel";
            this.weekOfYearLabel.Size = new System.Drawing.Size(145, 20);
            this.weekOfYearLabel.TabIndex = 5;
            this.weekOfYearLabel.Text = "Use Weekly + Date";
            // 
            // weeklyTextBox
            // 
            this.weeklyTextBox.Enabled = false;
            this.weeklyTextBox.Location = new System.Drawing.Point(375, 161);
            this.weeklyTextBox.Name = "weeklyTextBox";
            this.weeklyTextBox.Size = new System.Drawing.Size(58, 26);
            this.weeklyTextBox.TabIndex = 6;
            // 
            // useWeeklyCheckBox
            // 
            this.useWeeklyCheckBox.AutoSize = true;
            this.useWeeklyCheckBox.Location = new System.Drawing.Point(306, 163);
            this.useWeeklyCheckBox.Name = "useWeeklyCheckBox";
            this.useWeeklyCheckBox.Size = new System.Drawing.Size(64, 24);
            this.useWeeklyCheckBox.TabIndex = 7;
            this.useWeeklyCheckBox.Text = "Use";
            this.useWeeklyCheckBox.UseVisualStyleBackColor = true;
            this.useWeeklyCheckBox.CheckedChanged += new System.EventHandler(this.useWeeklyCheckBox_CheckedChanged);
            // 
            // doIt_Butten
            // 
            this.doIt_Butten.Location = new System.Drawing.Point(206, 207);
            this.doIt_Butten.Name = "doIt_Butten";
            this.doIt_Butten.Size = new System.Drawing.Size(128, 41);
            this.doIt_Butten.TabIndex = 8;
            this.doIt_Butten.Text = "Do It";
            this.doIt_Butten.UseVisualStyleBackColor = true;
            this.doIt_Butten.Click += new System.EventHandler(this.DoIt_Butten_Click);
            // 
            // myTaskMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 260);
            this.Controls.Add(this.doIt_Butten);
            this.Controls.Add(this.useWeeklyCheckBox);
            this.Controls.Add(this.weeklyTextBox);
            this.Controls.Add(this.weekOfYearLabel);
            this.Controls.Add(this.dataPickerLabel);
            this.Controls.Add(this.currentDateTimePicker);
            this.Controls.Add(this.taskTitleTextBox);
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.taskPathLable);
            this.Controls.Add(this.taskPathTextBox);
            this.Name = "myTaskMain";
            this.Text = "MyTaskCreater";
            this.Load += new System.EventHandler(this.MyTaskMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskPathTextBox;
        private System.Windows.Forms.Label taskPathLable;
        private System.Windows.Forms.Label taskTitleLabel;
        private System.Windows.Forms.TextBox taskTitleTextBox;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label dataPickerLabel;
        private System.Windows.Forms.Label weekOfYearLabel;
        private System.Windows.Forms.TextBox weeklyTextBox;
        private System.Windows.Forms.CheckBox useWeeklyCheckBox;
        private System.Windows.Forms.Button doIt_Butten;
    }
}

