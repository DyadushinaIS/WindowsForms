namespace Clock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
            this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(321, 61);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkBoxShowDate
            // 
            this.checkBoxShowDate.AutoSize = true;
            this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowDate.Location = new System.Drawing.Point(23, 251);
            this.checkBoxShowDate.Name = "checkBoxShowDate";
            this.checkBoxShowDate.Size = new System.Drawing.Size(170, 36);
            this.checkBoxShowDate.TabIndex = 1;
            this.checkBoxShowDate.Text = "Show date";
            this.checkBoxShowDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowWeekday
            // 
            this.checkBoxShowWeekday.AutoSize = true;
            this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowWeekday.Location = new System.Drawing.Point(23, 320);
            this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
            this.checkBoxShowWeekday.Size = new System.Drawing.Size(226, 36);
            this.checkBoxShowWeekday.TabIndex = 2;
            this.checkBoxShowWeekday.Text = "Show weekday";
            this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.checkBoxShowWeekday);
            this.Controls.Add(this.checkBoxShowDate);
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock PV522";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBoxShowDate;
        private System.Windows.Forms.CheckBox checkBoxShowWeekday;
    }
}

