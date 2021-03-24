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

        private void picbElectoralJustice_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            picbElectoralJustice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text + "0";
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = "BRANCO";
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txbCandidateNumber.Text = txbCandidateNumber.Text.Remove(txbCandidateNumber.Text.Length - 1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
