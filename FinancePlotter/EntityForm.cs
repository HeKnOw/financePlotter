using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancePlotter
{
    public partial class EntityForm : Form
    {
        public EntityForm()
        {
            lines = System.IO.File.ReadAllLines(@"..\Resources\apple.txt").ToList<string>();
            RecordData();
            InitializeComponent();
        }
        
        Pen lightGrayPen = new Pen(Color.LightGray, 0.5f);
        Pen blackPen = new Pen(Color.Black, 1f);
        Pen redPen = new Pen(Color.Red, 1f);
        Font arialFont = new Font("Arial", 10);
        Font tnrFont = new Font("Times New Roman", 10);
        Font tnrFont20 = new Font("Times New Roman", 20);
        List<float> OpenV = new List<float>();
        List<float> CloseV = new List<float>();
        List<float> High = new List<float>();
        List<float> Low = new List<float>();
        List<float> Volume = new List<float>();
        static List<string> lines = new List<string>();
        //string[] lines = System.IO.File.ReadAllLines(FinancePlotter.Properties.Resources.apple);
        bool lastYear = true; 
        bool lastMonth = false;
        bool last6Months = false;
        bool last2years = false;
        bool lastWeek = false;
        

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void candlesticksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EntityForm_Paint(object sender, PaintEventArgs e)
        {
            SetGraphingTransform(e.Graphics);

            drawGrid(e.Graphics);
            drawAxes(e.Graphics);

            List<PointF> pointFL = new List<PointF>();

            for(float x = 0; x < myTransform.X2; x++)
            {
                float y = CloseV[(int)x];
                pointFL.Add(new PointF(x, y));
            }

            e.Graphics.DrawLines(blackPen, pointFL.ToArray());

        }

        MyTransform myTransform = new MyTransform();

        private void SetGraphingTransform(Graphics g)
        {
            Rectangle winRect = this.ClientRectangle;
            Rectangle subWinRect = winRect;

            float u1 = subWinRect.X + 100f;
            float v1 = subWinRect.Y;
            float u2 = subWinRect.X + subWinRect.Width;
            float v2 = (subWinRect.Y + subWinRect.Height) - 100f;

            float x1 = 0;
            float y2 = lowest_stock() - 5f;
            float y1 = y2 +(highest_stock() + 5f);
            float x2 = setX2();

            myTransform.setupBoundaries(u1, u2, v1, v2, x1, y1, x2, y2);
            myTransform.setupMatrix(aspectRatio);

            g.Transform = myTransform.matrix;
      }

        public float setX2()
        {
            float result = 0;

            if (last2years) { result = (365f * 2f); }
            else if (lastYear) { result = (365f); }
            else if (last6Months) { result = (365f / 2f); }
            else if (lastMonth) { result = 30f; }
            else if (lastWeek) { result = 7f; }
            else { }
            return result;
        }

        private void RecordData()
        {
            int size = lines.Count;
            List<string> day;
            OpenV.Clear();
            CloseV.Clear();
            High.Clear();
            Low.Clear();
            Volume.Clear();

            if (lines.Count < 365 * 2)
            {
                last2YearsToolStripMenuItem.Available = false;
                lastYear = true;
                last2years = false;
                lastMonth = false;
                last6Months = false;
                lastWeek = false;
            }
            if(lines.Count < 365)
            {
                lastYearToolStripMenuItem.Available = false;
                lastYear =false;
                last2years = false;
                lastMonth = false;
                last6Months = true;
                lastWeek = false;
            }
            if(lines.Count < 365/2)
            {
                last6monthsToolStripMenuItem.Available = false;
                lastYear = false;
                last2years = false;
                lastMonth = true;
                last6Months = false;
                lastWeek = false;
            }
            if(lines.Count < 30)
            {
                lastMonthToolStripMenuItem.Available = false;
                lastYear = false;
                last2years = false;
                lastMonth = false;
                last6Months = false;
                lastWeek = true;
            }

            for(int i=1;i<size;i++)
            {
                int j = 0;
                day = lines[i].Split(',').ToList<string>();
                float fopen,fclose,fhigh,flow,fvolume;
                fopen = Convert.ToSingle(day[j + 1]);
                fclose = Convert.ToSingle(day[j + 4]);
                fhigh = Convert.ToSingle(day[j + 2]);
                flow = Convert.ToSingle(day[j + 3]);
                fvolume = Convert.ToSingle(day[j + 5]);

                OpenV.Add(fopen);
                CloseV.Add(fclose);
                High.Add(fhigh);
                Low.Add(flow);
                Volume.Add(fvolume);
            }
           
        }

        private void drawGrid(Graphics g)
        {
            float yInc = (float)Math.Pow(10.0, Math.Floor(Math.Log10(myTransform.yRange)) - 1.0);

            for(float x = 0f; x < myTransform.X2 ; x++)
            {
                g.DrawLine(lightGrayPen, x, myTransform.Y1, x, myTransform.Y2);
            }
            for(float y = myTransform.Y2; y < myTransform.Y1 ; y += yInc)
            {
                g.DrawLine(lightGrayPen, myTransform.X1, y, myTransform.X2, y);
            }

        }

        private void drawAxes(Graphics g)
        {
            g.DrawLine(blackPen, 0f, myTransform.Y2, 0f, myTransform.Y1);
            g.DrawLine(blackPen, myTransform.X1, myTransform.Y2, myTransform.X2, myTransform.Y2);
        }

        private void appleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string resource_data = @"\Resources\apple.txt";
            //lines = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines = System.IO.File.ReadAllLines(@"..\Resources\apple.txt").ToList<string>();
            last2YearsToolStripMenuItem.Available = true;
            lastYearToolStripMenuItem.Available = true;
            last6monthsToolStripMenuItem.Available = true;
            RecordData();
            Invalidate();
        }

        private void microsoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string resource_data = @"\Resources\Microsoft.txt";
            //lines = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines = System.IO.File.ReadAllLines(@"..\Resources\Microsoft.txt").ToList<string>();
            last2YearsToolStripMenuItem.Available = true;
            lastYearToolStripMenuItem.Available = true;
            last6monthsToolStripMenuItem.Available = true;
            RecordData();
            Invalidate();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string resource_data = @"\Resources\Facebook.txt";
            //lines = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines = System.IO.File.ReadAllLines( @"..\Resources\Facebook.txt").ToList<string>();
            lastYearToolStripMenuItem.Available = true;
            last6monthsToolStripMenuItem.Available = true;
            RecordData();
            Invalidate();
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string resource_data = @"\Resources\Twitter.txt";
            //lines = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lines = System.IO.File.ReadAllLines(@"..\Resources\Twitter.txt").ToList<string>();
            RecordData();
            Invalidate();
        }

        public float highest_stock()
        {
            float high_var = High[0];
           

            for(int i =0;i<High.Count;i++)
            {
                high_var = Math.Max(high_var,High[i]);
            }
            return high_var;
        }

        public float lowest_stock()
        {
            float low_var = Low[0];


            for (int i = 0; i < Low.Count; i++)
            {
                low_var = Math.Min(low_var, Low[i]);
            }
            return low_var;
        }

        private void lastYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastYear = true;
            last2years = false;
            lastMonth = false;
            last6Months = false;
            lastWeek = false;

            Invalidate();
        }

        private void lastWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastYear = false;
            last2years = false;
            lastMonth = false;
            last6Months = false;
            lastWeek = true;

            Invalidate();
        }

        private void lastMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastYear = false;
            last2years = false;
            lastMonth = true;
            last6Months = false;
            lastWeek = false;

            Invalidate();
        }

        private void last2YearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastYear = false;
            last2years = true;
            lastMonth = false;
            last6Months = false;
            lastWeek = false;

            Invalidate();
        }

        private void last6monthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastYear = false;
            last2years = false;
            lastMonth = false;
            last6Months = true;
            lastWeek = false;

            Invalidate();
        }
        
        public bool aspectRatio
        {
            get { return aspectratio.Checked; }
        }

        private void EntityForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
