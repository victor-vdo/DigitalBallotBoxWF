
namespace DigitalBallotBoxWF
{
    partial class CandidateRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPoliticalParty = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txbPoliticalParty = new System.Windows.Forms.TextBox();
            this.txbNumer = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(89, 38);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(407, 23);
            this.txbName.TabIndex = 1;
            // 
            // lblPoliticalParty
            // 
            this.lblPoliticalParty.AutoSize = true;
            this.lblPoliticalParty.Location = new System.Drawing.Point(25, 80);
            this.lblPoliticalParty.Name = "lblPoliticalParty";
            this.lblPoliticalParty.Size = new System.Drawing.Size(48, 15);
            this.lblPoliticalParty.TabIndex = 2;
            this.lblPoliticalParty.Text = "Partido:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(25, 123);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(54, 15);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Número:";
            // 
            // txbPoliticalParty
            // 
            this.txbPoliticalParty.Location = new System.Drawing.Point(89, 77);
            this.txbPoliticalParty.Name = "txbPoliticalParty";
            this.txbPoliticalParty.Size = new System.Drawing.Size(407, 23);
            this.txbPoliticalParty.TabIndex = 4;
            // 
            // txbNumer
            // 
            this.txbNumer.Location = new System.Drawing.Point(89, 117);
            this.txbNumer.Name = "txbNumer";
            this.txbNumer.Size = new System.Drawing.Size(115, 23);
            this.txbNumer.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRegister.Location = new System.Drawing.Point(308, 164);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 29);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(417, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CandidateRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbNumer);
            this.Controls.Add(this.txbPoliticalParty);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPoliticalParty);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Name = "CandidateRegisterForm";
            this.Text = "Registro do candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblPoliticalParty;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txbPoliticalParty;
        private System.Windows.Forms.TextBox txbNumer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}