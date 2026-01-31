using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Location = new Point
                (
                    Screen.PrimaryScreen.Bounds.Width - this.Width - 50,
                    50
                );
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString
                (
                "hh:mm:ss tt",
                System.Globalization.CultureInfo.InvariantCulture
                );
            if (checkBoxShowDate.Checked)
                labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            if (checkBoxShowWeekday.Checked)
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            notifyIcon.Text=labelTime.Text ;
        }

       void SetVisibility(bool visible)
        {
            checkBoxShowDate.Visible = visible;
            checkBoxShowWeekday.Visible = visible;
            buttonHideControls.Visible = visible;
            this.ShowInTaskbar = visible;       
            this.FormBorderStyle= visible?FormBorderStyle.FixedToolWindow: FormBorderStyle.None;
            this.TransparencyKey = visible? Color.Empty: this.BackColor;    
        }
        
        private void buttonHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(false);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            SetVisibility(true);
        }

        private void tsmiShowDate_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked) 
            labelTime.Text+= $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
        }

        private void tsmiShowWeekday_Click(object sender, EventArgs e)
        {
            labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
        }
        private void tsmiForegroundColor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            labelTime.ForeColor = item.Checked ? Color.Green : Color.Black;
        }

        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            labelTime.BackColor = item.Checked ? Color.Yellow : Color.Blue;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void tsmiTopmost_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            this.TopMost = item.Checked;
        }

    }
}
