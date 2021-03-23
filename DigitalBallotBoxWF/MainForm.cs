using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalBallotBoxWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CandidateRegisterForm registerForm = new CandidateRegisterForm();
            registerForm.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }

        private void btnToVote_Click(object sender, EventArgs e)
        {
            VoteForm voteForm = new VoteForm();
            voteForm.Show();
            Hide();
        }
    }
}
