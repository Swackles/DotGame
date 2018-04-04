using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformerGame1
{
    public partial class Form1 : Form
    {
        List<Character> CharList = new List<Character>();
        private Timer ticks;

        public class Character
        {
            public int Xpos { set; get; }
            public int Ypos { set; get; }
            public int Xhead { set; get; }
            public int Yhead { set; get; }
            public bool AI { set; get; }
            public Graphics graphics { set; get; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        #region start game
        private void CreateCharacterBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CharList.Any(x => x.AI == false));
            if (CharList.Any(x => x.AI == false)) return;
            Character nobj = new Character();

            nobj.Xpos = this.Height / 2 - 50;
            nobj.Ypos = this.Width / 2 - 50;
            nobj.AI = false;
            nobj.graphics = this.CreateGraphics();

            SolidBrush Brush = new SolidBrush(Color.Red);

            nobj.graphics.FillRectangle(Brush, nobj.Xpos, nobj.Ypos, 50, 50);

            StartTick();
            CharList.Add(nobj);
        }
        #endregion

        #region draw characters
        public void DrawCharacter(Character obj, int xPos = 0, int yPos = 0)
        {
            if (obj.AI)
            {
                Character nobj = new Character();

                nobj.graphics.Clear(Color.White);

                nobj.Xpos = obj.Xpos + obj.Xhead;
                nobj.Ypos = obj.Ypos + obj.Yhead;

                SolidBrush Brush = new SolidBrush(Color.Red);
                nobj.graphics = this.CreateGraphics();
                nobj.graphics.FillRectangle(Brush, nobj.Xpos, nobj.Ypos, 50, 50);

                nobj.AI = true;
                nobj.Xhead = obj.Xhead;
                nobj.Yhead = obj.Yhead;

                CharList.Remove(obj);
                CharList.Add(nobj);

            } else
            {
                if (obj.Xpos + xPos < 0 || !(obj.Xpos + xPos + 25 < this.Width)) return;
                if (obj.Ypos + yPos < 0) return;

                Character nobj = new Character();

                obj.graphics.Clear(Color.White);

                nobj.Xpos = obj.Xpos + xPos;
                nobj.Ypos = obj.Ypos + yPos;

                SolidBrush Brush = new SolidBrush(Color.Red);
                nobj.graphics = this.CreateGraphics();
                nobj.graphics.FillRectangle(Brush, nobj.Xpos, nobj.Ypos, 50, 50);

                nobj.AI = false;
                nobj.Xhead = xPos;
                nobj.Yhead = yPos;

                CharList.Remove(obj);
                CharList.Add(nobj);
            }
        }
        #endregion

        #region Main character controlls
        //move main character
        private void Form1_keyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(!(CharList.Any(x => x.AI == false)));
            if (!(CharList.Any(x => x.AI == false))) return;

            Character obj = CharList.Find(x => x.AI == false);

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                DrawCharacter(obj, -5, 0);
                Actions.Text += "You moved left";
                Actions.AppendText(Environment.NewLine);
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                DrawCharacter(obj, 0, -5);
                Actions.Text += "You moved up";
                Actions.AppendText(Environment.NewLine);
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                DrawCharacter(obj, 5, 0);
                Actions.Text += "You moved right";
                Actions.AppendText(Environment.NewLine);
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                DrawCharacter(obj, 0, 5);
                Actions.Text += "You moved down";
                Actions.AppendText(Environment.NewLine);
            }
        }
        #endregion

        #region create AI
        private void CreateAi()
        {

        }
        #endregion


        #region ticks
        private void StartTick()
        {
            ticks = new Timer();
            ticks.Tick += new EventHandler(Tick);
            ticks.Interval = 17;
            ticks.Start();

        }

        private void Tick(object sender, EventArgs e)
        {
            Actions.Text += "Tick";
            Actions.AppendText(Environment.NewLine);

            for (int i = 0; i < CharList.Count(); i++)
            {
                if (!(CharList[i].AI)) continue;
                DrawCharacter(CharList[i]);
            }
        }
        #endregion
    }
}