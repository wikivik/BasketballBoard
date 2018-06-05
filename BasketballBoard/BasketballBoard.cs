using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballBoard
{
    public partial class BasketballBoard : UserControl
    {
        public string Team1Name
        {
            get
            {
                return team1Label.Text;
            }
            set
            {
                team1Label.Text = value;
            }
        }
        public Color Team1Color
        {
            get
            {
                return team1Label.ForeColor;
            }
            set
            {
                team1Label.ForeColor = value;
            }
        }
        public string Team2Name
        {
            get
            {
                return team2Label.Text;
            }
            set
            {
                team2Label.Text = value;
            }
        }
        public Color Team2Color
        {
            get
            {
                return team2Label.ForeColor;
            }
            set
            {
                team2Label.ForeColor = value;
            }
        }

        public int PointsTeam1
        {
            get
            {
                try
                {
                return int.Parse(pkt1Label.Text);
                }catch(Exception)
                {
                    return 0;
                }
            }
            set
            {
                if (value / 10 == 0)
                {
                    pkt1Label.Text = "00" + value;
                }
                else if (value / 100 == 0)
                {
                    pkt1Label.Text = "0" + value;
                }
                else if (value / 1000 == 0)
                {
                    pkt1Label.Text = value.ToString();
                }
                else
                {
                    pkt1Label.Text = "ERR";
                }

            }
        }
        public Color Points1Color
        {
            get
            {
                return pkt1Label.ForeColor;
            }
            set
            {
                pkt1Label.ForeColor = value;
            }
        }
        public int PointsTeam2
        {
            get
            {
                try
                {
                    return int.Parse(pkt2Label.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set
            {
                if (value / 10 == 0)
                {
                    pkt2Label.Text = "00" + value;
                }
                else if (value / 100 == 0)
                {
                    pkt2Label.Text = "0" + value;
                }
                else if (value / 1000 == 0)
                {
                    pkt2Label.Text = value.ToString();
                }
                else
                {
                    pkt2Label.Text = "ERR";
                }
            }
        }
        public Color Point2Color
        {
            get
            {
                return pkt2Label.ForeColor;
            }
            set
            {
                pkt2Label.ForeColor = value;
            }
        }
        public TimeSpan Time
        {
            get
            {
                return TimeSpan.Parse(timeLabel.Text);
            }
            set
            {
                timeLabel.Text = value.ToString();
            }
        }
        public Color TimeColor
        {
            get
            {
                return timeLabel.ForeColor;
            }
            set
            {
                timeLabel.ForeColor = value;
            }
        }
        public Color L1Color
        {
            get
            {
                return l1.ForeColor;
            }
            set
            {
                l1.ForeColor = value;
            }
        }
        public Color L2Color
        {
            get
            {
                return l2.ForeColor;
            }
            set
            {
                l2.ForeColor = value;
            }
        }
        public Color L3Color
        {
            get
            {
                return l3.ForeColor;
            }
            set
            {
                l3.ForeColor = value;
            }
        }
        public Color L4Color
        {
            get
            {
                return l4.ForeColor;
            }
            set
            {
                l4.ForeColor = value;
            }
        }
        public Color L5Color
        {
            get
            {
                return l5.ForeColor;
            }
            set
            {
                l5.ForeColor = value;
            }
        }

        public BasketballBoard()
        {
            InitializeComponent();
        }

        
    }
}
