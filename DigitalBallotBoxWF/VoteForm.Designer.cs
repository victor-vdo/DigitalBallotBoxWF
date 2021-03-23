
namespace DigitalBallotBoxWF
{
    partial class VoteForm
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
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.picbElectoralJustice = new System.Windows.Forms.PictureBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.labelDateNow = new System.Windows.Forms.Label();
            this.lblTitleElection = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlPresident = new System.Windows.Forms.Panel();
            this.lblCandidatePoliticalParty = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.txbCandidateNumber = new System.Windows.Forms.TextBox();
            this.lblPoliticalParty = new System.Windows.Forms.Label();
            this.picbCandidatePhoto = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblYourVoteTo = new System.Windows.Forms.Label();
            this.lblCandidateType = new System.Windows.Forms.Label();
            this.pnlScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbElectoralJustice)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPresident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCandidatePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.White;
            this.pnlScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScreen.Controls.Add(this.picbElectoralJustice);
            this.pnlScreen.Controls.Add(this.lblCity);
            this.pnlScreen.Controls.Add(this.lblTurn);
            this.pnlScreen.Controls.Add(this.labelDateNow);
            this.pnlScreen.Controls.Add(this.lblTitleElection);
            this.pnlScreen.Location = new System.Drawing.Point(28, 43);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(460, 300);
            this.pnlScreen.TabIndex = 0;
            // 
            // picbElectoralJustice
            // 
            this.picbElectoralJustice.Image = global::DigitalBallotBoxWF.Properties.Resources.electoral_justice;
            this.picbElectoralJustice.Location = new System.Drawing.Point(124, 129);
            this.picbElectoralJustice.Name = "picbElectoralJustice";
            this.picbElectoralJustice.Size = new System.Drawing.Size(162, 147);
            this.picbElectoralJustice.TabIndex = 4;
            this.picbElectoralJustice.TabStop = false;
            this.picbElectoralJustice.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picbElectoralJustice_LoadCompleted);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(154, 108);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(95, 18);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "LONDRINA";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurn.Location = new System.Drawing.Point(163, 86);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(77, 18);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "1º Turno";
            // 
            // labelDateNow
            // 
            this.labelDateNow.AutoSize = true;
            this.labelDateNow.Location = new System.Drawing.Point(5, 9);
            this.labelDateNow.Name = "labelDateNow";
            this.labelDateNow.Size = new System.Drawing.Size(175, 15);
            this.labelDateNow.TabIndex = 1;
            this.labelDateNow.Text = "terça-feira, 23 de março de 2021";
            // 
            // lblTitleElection
            // 
            this.lblTitleElection.AutoSize = true;
            this.lblTitleElection.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleElection.Location = new System.Drawing.Point(96, 32);
            this.lblTitleElection.Name = "lblTitleElection";
            this.lblTitleElection.Size = new System.Drawing.Size(253, 25);
            this.lblTitleElection.TabIndex = 0;
            this.lblTitleElection.Text = "Eleições Federais 2021";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnFix);
            this.panel1.Controls.Add(this.btnWhite);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(500, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 327);
            this.panel1.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(189, 269);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(68, 49);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirma";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.Orange;
            this.btnFix.Location = new System.Drawing.Point(107, 278);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(60, 40);
            this.btnFix.TabIndex = 11;
            this.btnFix.Text = "Corrige";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(18, 278);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(60, 40);
            this.btnWhite.TabIndex = 10;
            this.btnWhite.Text = "Branco";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.Location = new System.Drawing.Point(107, 226);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 40);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.Location = new System.Drawing.Point(197, 158);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 40);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.Location = new System.Drawing.Point(107, 158);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 40);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.Location = new System.Drawing.Point(18, 158);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 40);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.Location = new System.Drawing.Point(197, 88);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 40);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.Location = new System.Drawing.Point(107, 88);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.Location = new System.Drawing.Point(18, 88);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.Location = new System.Drawing.Point(197, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.Location = new System.Drawing.Point(107, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.Location = new System.Drawing.Point(18, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnlPresident
            // 
            this.pnlPresident.BackColor = System.Drawing.Color.White;
            this.pnlPresident.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPresident.Controls.Add(this.lblCandidatePoliticalParty);
            this.pnlPresident.Controls.Add(this.lblCandidateName);
            this.pnlPresident.Controls.Add(this.txbCandidateNumber);
            this.pnlPresident.Controls.Add(this.lblPoliticalParty);
            this.pnlPresident.Controls.Add(this.picbCandidatePhoto);
            this.pnlPresident.Controls.Add(this.lblName);
            this.pnlPresident.Controls.Add(this.lblNumber);
            this.pnlPresident.Controls.Add(this.lblYourVoteTo);
            this.pnlPresident.Controls.Add(this.lblCandidateType);
            this.pnlPresident.Location = new System.Drawing.Point(28, 43);
            this.pnlPresident.Name = "pnlPresident";
            this.pnlPresident.Size = new System.Drawing.Size(460, 300);
            this.pnlPresident.TabIndex = 5;
            // 
            // lblCandidatePoliticalParty
            // 
            this.lblCandidatePoliticalParty.AutoSize = true;
            this.lblCandidatePoliticalParty.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCandidatePoliticalParty.Location = new System.Drawing.Point(69, 202);
            this.lblCandidatePoliticalParty.Name = "lblCandidatePoliticalParty";
            this.lblCandidatePoliticalParty.Size = new System.Drawing.Size(311, 17);
            this.lblCandidatePoliticalParty.TabIndex = 9;
            this.lblCandidatePoliticalParty.Text = "Partido político a qual o candidato pertence";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCandidateName.Location = new System.Drawing.Point(69, 174);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(219, 17);
            this.lblCandidateName.TabIndex = 8;
            this.lblCandidateName.Text = "Nome Completo do Candidato";
            // 
            // txbCandidateNumber
            // 
            this.txbCandidateNumber.Enabled = false;
            this.txbCandidateNumber.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCandidateNumber.Location = new System.Drawing.Point(81, 92);
            this.txbCandidateNumber.Name = "txbCandidateNumber";
            this.txbCandidateNumber.Size = new System.Drawing.Size(189, 72);
            this.txbCandidateNumber.TabIndex = 6;
            // 
            // lblPoliticalParty
            // 
            this.lblPoliticalParty.AutoSize = true;
            this.lblPoliticalParty.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoliticalParty.Location = new System.Drawing.Point(10, 201);
            this.lblPoliticalParty.Name = "lblPoliticalParty";
            this.lblPoliticalParty.Size = new System.Drawing.Size(63, 17);
            this.lblPoliticalParty.TabIndex = 5;
            this.lblPoliticalParty.Text = "Partido:";
            // 
            // picbCandidatePhoto
            // 
            this.picbCandidatePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbCandidatePhoto.Image = global::DigitalBallotBoxWF.Properties.Resources.person_logo;
            this.picbCandidatePhoto.Location = new System.Drawing.Point(276, 17);
            this.picbCandidatePhoto.Name = "picbCandidatePhoto";
            this.picbCandidatePhoto.Size = new System.Drawing.Size(162, 147);
            this.picbCandidatePhoto.TabIndex = 4;
            this.picbCandidatePhoto.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(10, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(10, 147);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(69, 17);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Número:";
            // 
            // lblYourVoteTo
            // 
            this.lblYourVoteTo.AutoSize = true;
            this.lblYourVoteTo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYourVoteTo.Location = new System.Drawing.Point(10, 17);
            this.lblYourVoteTo.Name = "lblYourVoteTo";
            this.lblYourVoteTo.Size = new System.Drawing.Size(126, 17);
            this.lblYourVoteTo.TabIndex = 1;
            this.lblYourVoteTo.Text = "SEU VOTO PARA";
            // 
            // lblCandidateType
            // 
            this.lblCandidateType.AutoSize = true;
            this.lblCandidateType.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCandidateType.Location = new System.Drawing.Point(25, 37);
            this.lblCandidateType.Name = "lblCandidateType";
            this.lblCandidateType.Size = new System.Drawing.Size(233, 25);
            this.lblCandidateType.TabIndex = 0;
            this.lblCandidateType.Text = "TIPO DE CANDIDATO";
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPresident);
            this.Controls.Add(this.pnlScreen);
            this.Name = "VoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleições 2021";
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbElectoralJustice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlPresident.ResumeLayout(false);
            this.pnlPresident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbCandidatePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label labelDateNow;
        private System.Windows.Forms.Label lblTitleElection;
        private System.Windows.Forms.PictureBox picbElectoralJustice;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Panel pnlPresident;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPresidentPoliticalParty;
        private System.Windows.Forms.Label lblPresidentName;
        private System.Windows.Forms.TextBox txbPresidentNumber;
        private System.Windows.Forms.Label lblPoliticalParty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblYourVoteTo;
        private System.Windows.Forms.Label lblPresident;
        private System.Windows.Forms.Label lblCandidatePoliticalParty;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Label lblCandidateType;
        private System.Windows.Forms.PictureBox picbCandidatePhoto;
        private System.Windows.Forms.TextBox txbCandidateNumber;
    }
}