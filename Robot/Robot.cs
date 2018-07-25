using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public delegate void BeyondLimitEventHandler(object sender, BeyondLimitEventArgs e);
    public partial class Robot : Form
    {
        RobotLog RoboLog = new RobotLog();
        public Robot()
        {
            InitializeComponent();
            PointerDirectionLabel.Location = new Point(0,0);
            PointerDirectionLabel.Text = Convert.ToChar(Direction.North).ToString();
            getPositionDisplayed();
        }

        public enum Direction { West = 231 , East = 232, North = 233, South = 234 };
        public event BeyondLimitEventHandler BeyondLimitEvent;
        
        protected void OnBeyondLimitEvent(BeyondLimitEventArgs e)
        {
            if(BeyondLimitEvent != null)
                BeyondLimitEvent(this, e);
        }

        private void NorthBtn_Click(object sender, EventArgs e)
        {
            PointerDirectionLabel.Text = Convert.ToChar(Direction.North).ToString();
        }

        private void SouthBtn_Click(object sender, EventArgs e)
        {
            PointerDirectionLabel.Text = Convert.ToChar(Direction.South).ToString();
        }

        private void WestBtn_Click(object sender, EventArgs e)
        {
            PointerDirectionLabel.Text = Convert.ToChar(Direction.West).ToString();
        }

        private void EastBtn_Click(object sender, EventArgs e)
        {
            PointerDirectionLabel.Text = Convert.ToChar(Direction.East).ToString();
        }

        private void Go1Btn_Click(object sender, EventArgs e)
        {
            move(1);   
        }

        private void Go10Btn_Click(object sender, EventArgs e)
        {
            move(10);
        }

        private void move(int steps)
        {   
            int currX = PointerDirectionLabel.Location.X;
            int currY = PointerDirectionLabel.Location.Y;
            if (PointerDirectionLabel.Text.Equals(Convert.ToChar(Direction.North).ToString()) == true)
            {
                if(!isBeyondRange(currX, currY - steps))
                {
                    PointerDirectionLabel.Location = new Point(currX, currY - steps);
                    RoboLog.LogDistance = steps;

                    RoboLog.LogDirections = "Direction : North | X = "+ Math.Abs(currX) + " | Y = " + Math.Abs(currY - steps)+ " | Distance : "+ RoboLog.LogDistance + " | Steps : "+ steps;
                }
            }
            else if (PointerDirectionLabel.Text.Equals(Convert.ToChar(Direction.West).ToString()) == true)
            {
                if (!isBeyondRange(currX - steps, currY))
                {
                    PointerDirectionLabel.Location = new Point(currX - steps, currY);
                    RoboLog.LogDistance = steps;

                    RoboLog.LogDirections = "Direction : West | X = " + Math.Abs(currX - steps) + " | Y = " + Math.Abs(currY) + " | Distance : " + RoboLog.LogDistance + " | Steps : " + steps;
                }
            }
            else if (PointerDirectionLabel.Text.Equals(Convert.ToChar(Direction.South).ToString()) == true)
            {
                if (!isBeyondRange(currX, currY + steps))
                {
                    PointerDirectionLabel.Location = new Point(currX, currY + steps);
                    RoboLog.LogDistance = steps;

                    RoboLog.LogDirections = "Direction : South | X = " + Math.Abs(currX) + " | Y = " + Math.Abs(currY + steps) + " | Distance : " + RoboLog.LogDistance + " | Steps : " + steps;
                }
            }
            else if (PointerDirectionLabel.Text.Equals(Convert.ToChar(Direction.East).ToString()) == true)
                {
                if (!isBeyondRange(currX + steps, currY))
                {
                    PointerDirectionLabel.Location = new Point(currX + steps, currY);
                    RoboLog.LogDistance = steps;

                    RoboLog.LogDirections = "Direction : East | X = " + Math.Abs(currX + steps) + " | Y = " + Math.Abs(currY) + " | Distance : " + RoboLog.LogDistance + " | Steps : " + steps;        
                }
            }
            PointerDirectionLabel.Refresh();
            getPositionDisplayed();
            DistanceLabel.Text = "Distance : " + RoboLog.LogDistance.ToString();
        }

        private void getPositionDisplayed()
        {   
            PointerLocationLabel.Text = "{X= "+getCurrPositionX()+", Y= "+getCurrPositionY()+"}";
        }

        private int getCurrPositionX()
        {
            if (PointerDirectionLabel.Location.X < 0)
                return -PointerDirectionLabel.Location.X;
            else
                return PointerDirectionLabel.Location.X;
        }
        private int getCurrPositionY()
        {
            if (PointerDirectionLabel.Location.Y < 0)
                return -PointerDirectionLabel.Location.Y;
            else
                return PointerDirectionLabel.Location.Y;
        }

        protected Boolean isBeyondRange(int X, int Y)
        {
            BeyondLimitEventArgs args = new BeyondLimitEventArgs(X, Y);
            OnBeyondLimitEvent(args);
            if (!args.getLimitReached())
            {
                return false;
            }
            else
            {
                MessageBox.Show("Limit Reached. Step Back !! Restricted Area.");
                return true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Robot_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.N: { NorthBtn.PerformClick(); break; }
                case Keys.S: { SouthBtn.PerformClick(); break; }
                case Keys.W: { WestBtn.PerformClick(); break; }
                case Keys.E: { EastBtn.PerformClick(); break; }
                case Keys.NumPad1: { Go1Btn.PerformClick(); break; }
                case Keys.NumPad0: { Go10Btn.PerformClick(); break; }
                case Keys.Back: { BtnExit.PerformClick(); break; }
                case Keys.Escape: { BtnExit.PerformClick(); break; }
            }
        }
    }
    public class BeyondLimitEventArgs : EventArgs
    {
        public static Boolean LimitReached = false;
        public BeyondLimitEventArgs(int X, int Y)
        {
            LimitReached = X > 100 || Y > 100 || X < -100 || Y < -100? true : false;
        }
        public bool getLimitReached()
        {
            return LimitReached;
        }
    }
}
