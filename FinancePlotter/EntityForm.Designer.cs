namespace FinancePlotter
{
    partial class EntityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.candlesticksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hLOCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeFrame = new System.Windows.Forms.ToolStripDropDownButton();
            this.lastMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last2YearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last6monthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset = new System.Windows.Forms.ToolStripButton();
            this.aspectratio = new System.Windows.Forms.CheckBox();
            this.Company = new System.Windows.Forms.ToolStripTextBox();
            this.textBoxFileName = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.TimeFrame,
            this.Reset,
            this.Company,
            this.textBoxFileName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(636, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candlesticksToolStripMenuItem,
            this.hLOCToolStripMenuItem,
            this.justCloseToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 29);
            this.toolStripDropDownButton1.Text = "Style";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // candlesticksToolStripMenuItem
            // 
            this.candlesticksToolStripMenuItem.Name = "candlesticksToolStripMenuItem";
            this.candlesticksToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.candlesticksToolStripMenuItem.Text = "Candlesticks";
            this.candlesticksToolStripMenuItem.Click += new System.EventHandler(this.candlesticksToolStripMenuItem_Click);
            // 
            // hLOCToolStripMenuItem
            // 
            this.hLOCToolStripMenuItem.Name = "hLOCToolStripMenuItem";
            this.hLOCToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.hLOCToolStripMenuItem.Text = "HLOC";
            // 
            // justCloseToolStripMenuItem
            // 
            this.justCloseToolStripMenuItem.Name = "justCloseToolStripMenuItem";
            this.justCloseToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.justCloseToolStripMenuItem.Text = "Just Close";
            // 
            // TimeFrame
            // 
            this.TimeFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TimeFrame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastMonthToolStripMenuItem,
            this.lastYearToolStripMenuItem,
            this.last2YearsToolStripMenuItem,
            this.last6monthsToolStripMenuItem,
            this.lastWeekToolStripMenuItem});
            this.TimeFrame.Image = ((System.Drawing.Image)(resources.GetObject("TimeFrame.Image")));
            this.TimeFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TimeFrame.Name = "TimeFrame";
            this.TimeFrame.Size = new System.Drawing.Size(117, 29);
            this.TimeFrame.Text = "Time Frame";
            // 
            // lastMonthToolStripMenuItem
            // 
            this.lastMonthToolStripMenuItem.Name = "lastMonthToolStripMenuItem";
            this.lastMonthToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.lastMonthToolStripMenuItem.Text = "Last Month";
            this.lastMonthToolStripMenuItem.Click += new System.EventHandler(this.lastMonthToolStripMenuItem_Click);
            // 
            // lastYearToolStripMenuItem
            // 
            this.lastYearToolStripMenuItem.Name = "lastYearToolStripMenuItem";
            this.lastYearToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.lastYearToolStripMenuItem.Text = "Last Year";
            this.lastYearToolStripMenuItem.Click += new System.EventHandler(this.lastYearToolStripMenuItem_Click);
            // 
            // last2YearsToolStripMenuItem
            // 
            this.last2YearsToolStripMenuItem.Name = "last2YearsToolStripMenuItem";
            this.last2YearsToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.last2YearsToolStripMenuItem.Text = "Last 2 Years";
            this.last2YearsToolStripMenuItem.Click += new System.EventHandler(this.last2YearsToolStripMenuItem_Click);
            // 
            // last6monthsToolStripMenuItem
            // 
            this.last6monthsToolStripMenuItem.Name = "last6monthsToolStripMenuItem";
            this.last6monthsToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.last6monthsToolStripMenuItem.Text = "Last 6 Months";
            this.last6monthsToolStripMenuItem.Click += new System.EventHandler(this.last6monthsToolStripMenuItem_Click);
            // 
            // lastWeekToolStripMenuItem
            // 
            this.lastWeekToolStripMenuItem.Name = "lastWeekToolStripMenuItem";
            this.lastWeekToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.lastWeekToolStripMenuItem.Text = "Last Week";
            this.lastWeekToolStripMenuItem.Click += new System.EventHandler(this.lastWeekToolStripMenuItem_Click);
            // 
            // Reset
            // 
            this.Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(59, 29);
            this.Reset.Text = "Reset";
            // 
            // aspectratio
            // 
            this.aspectratio.AutoSize = true;
            this.aspectratio.Location = new System.Drawing.Point(471, 0);
            this.aspectratio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aspectratio.Name = "aspectratio";
            this.aspectratio.Size = new System.Drawing.Size(165, 24);
            this.aspectratio.TabIndex = 1;
            this.aspectratio.Text = "Lock Aspect Ratio";
            this.aspectratio.UseVisualStyleBackColor = true;
            // 
            // Company
            // 
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(102, 32);
            this.Company.Text = "Company";
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.textBoxFileName.Image = ((System.Drawing.Image)(resources.GetObject("textBoxFileName.Image")));
            this.textBoxFileName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(74, 29);
            this.textBoxFileName.Text = "Get File";
            this.textBoxFileName.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 555);
            this.Controls.Add(this.aspectratio);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EntityForm";
            this.Text = "EntityForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EntityForm_Paint);
            this.Resize += new System.EventHandler(this.EntityForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem candlesticksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hLOCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton TimeFrame;
        private System.Windows.Forms.ToolStripMenuItem lastMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem last2YearsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem last6monthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Reset;
        private System.Windows.Forms.ToolStripMenuItem lastWeekToolStripMenuItem;
        private System.Windows.Forms.CheckBox aspectratio;
        private System.Windows.Forms.ToolStripTextBox Company;
        private System.Windows.Forms.ToolStripButton textBoxFileName;
    }
}