using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if(txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text != "BRANCO")
                txbCandidateNumber.Text = txbCandidateNumber.Text + "0";
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.txbCandidateNumber.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txbCandidateNumber.Text = "BRANCO";
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txbCandidateNumber.Text == "BRANCO")
                txbCandidateNumber.Text = "";
            if (txbCandidateNumber.Text.Length > 0)
                txbCandidateNumber.Text = txbCandidateNumber.Text.Remove(txbCandidateNumber.Text.Length - 1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void tsmiRegister_Click(object sender, EventArgs e)
        {
            CandidateRegisterForm registerForm = new CandidateRegisterForm();
            registerForm.Show();
            Hide();
        }

        private void tsmiResult_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
            Hide();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var txbNumber = txbCandidateNumber.Text;
            if (txbNumber == "BRANCO") txbNumber = "0";
            var connectionString =
                      "Data Source=DESKTOP-8QPURBN;Initial Catalog=election;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            var sql =
                "SELECT * FROM CANDIDATE " +
                $"WHERE number = '{txbNumber}' ";

            var sqlVote = "INSERT INTO VOTE (id, candidateid) " +
                "values (@id, @candidateid)";
            var newId = Guid.NewGuid();
            try{
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                //var teste = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    object id = new object();
                    while (reader.Read())
                    {
                        //var myString = reader.GetValue(1);
                        lblCandidateName.Text = reader[1] as string;
                        lblCandidatePoliticalParty.Text = reader[3] as string;
                        var type = reader[4];
                        id = reader[0];
                    }
                    conn.Close();

                    try
                    {
                        SqlCommand commandVote = new SqlCommand(sqlVote, conn);
                        commandVote.Parameters.Add(new SqlParameter("id", newId));
                        commandVote.Parameters.Add(new SqlParameter("candidateid", id.ToString()));

                        conn.Open();
                        commandVote.ExecuteNonQuery();
                        MessageBox.Show("Voto computado com sucesso!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao tentar computar o voto!");

                    }
                }
                else
                    MessageBox.Show("Candidato não encontrado!");
                conn.Close();
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar buscar o Candidato!");
            }
        }
    }
}
