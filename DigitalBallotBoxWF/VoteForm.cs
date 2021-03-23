using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalBallotBoxWF
{
    public partial class VoteForm : Form
    {
        public VoteForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void picbElectoralJustice_Click(object sender, EventArgs e)
        {

        }

        private void picbElectoralJustice_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            picbElectoralJustice.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
