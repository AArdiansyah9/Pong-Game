using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void trollFaceCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\PC\Pictures\Saved Pictures\4354908");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void mogCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\PC\Pictures\Saved Pictures\5496293");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void noCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\PC\Pictures\Saved Pictures\Billiard-Download-Free-PNG-Ball-Transparent-Background");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void foreverAloneCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\PC\Pictures\Saved Pictures\soccer-ball-png-24");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
