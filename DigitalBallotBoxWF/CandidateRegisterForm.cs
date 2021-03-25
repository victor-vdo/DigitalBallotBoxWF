using DigitalBallotBoxWF.enums;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DigitalBallotBoxWF
{
    public partial class CandidateRegisterForm : Form
    {
        public CandidateRegisterForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            VoteForm mainForm = new VoteForm();
            mainForm.Show();
            Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var connectionString =
                "Data Source=DESKTOP-8QPURBN;Initial Catalog=election;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            var sql = 
                "INSERT INTO CANDIDATE (id, name, number, politicalparty, type, state, city) " +
                "values (@id, @name,@number, @politicalparty, @type, @state, @city)";
            var newId = Guid.NewGuid();

            try
            {
                var type = (int)this.cbbType.SelectedValue;
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("id",newId));
                command.Parameters.Add(new SqlParameter("name", this.txbName.Text));
                command.Parameters.Add(new SqlParameter("number", this.txbNumer.Text));
                command.Parameters.Add(new SqlParameter("politicalparty", this.txbPoliticalParty.Text));
                command.Parameters.Add(new SqlParameter("type", type));
                command.Parameters.Add(new SqlParameter("state", this.cbbState.Text));
                command.Parameters.Add(new SqlParameter("city", this.txbCity.Text));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Presidente cadastrado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar o Candidato!");
            }
        }

        private void cbbType_DropDown(object sender, EventArgs e)
        {
            cbbType.DataSource = Enum.GetValues(typeof(ECandidateType));
        }

        private void cbbType_DropDownClosed(object sender, EventArgs e)
        {
            var selectedItem = cbbType.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Presidente":
                    lblState.Visible = false;
                    cbbState.Visible = false;
                    lblCity.Visible = false;
                    txbCity.Visible = false;
                    break;
                case "Governador":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                case "Prefeito":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                case "Senador":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                case "DeputadoFederal":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                case "DeputadoEstadual":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                case "Vereador":
                    lblState.Visible = true;
                    cbbState.Visible = true;
                    lblCity.Visible = true;
                    txbCity.Visible = true;
                    break;
                default:
                    lblState.Visible = false;
                    cbbState.Visible = false;
                    lblCity.Visible = false;
                    txbCity.Visible = false;
                    break;
            }
        }
    }
}
