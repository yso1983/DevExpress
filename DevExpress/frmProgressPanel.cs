using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class frmProgressPanel : DevExpress.XtraEditors.XtraForm
    {
        Timer timer = new Timer();
        int time = 5;

        public frmProgressPanel()
        {
            InitializeComponent();

            this.Shown += WaitForm_Shown;
            this.FormClosed += FormClosed_Event;
        }

        private void FormClosed_Event(object sender, FormClosedEventArgs e)
        {
            if (uiProg_Wait != null)
            {
                uiProg_Wait = null;
            }

        }

        private void WaitForm_Shown(object sender, EventArgs e)
        {
            InitProgressPanel(time);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            timer.Interval = 1000;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(uiProg_Wait != null)
            {
                InitProgressPanel(time);
                time--;
            }

            if(time < 0)
            {
                this.Close();
                uiProg_Wait = null;
            }
        }

        private void InitProgressPanel(int time)
        {
            this.uiProg_Wait.AutoHeight = true;
            this.uiProg_Wait.Caption = "잠시 로딩중..";
            this.uiProg_Wait.ShowCaption = true;
            this.uiProg_Wait.Description = string.Format("로딩 시간 : {0}", time);
            this.uiProg_Wait.ShowDescription = true;
            this.uiProg_Wait.ToolTip = "My Tooltip";
            this.uiProg_Wait.ShowToolTips = true;
            this.uiProg_Wait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            this.uiProg_Wait.CaptionToDescriptionDistance = 5;
        }
    }
}