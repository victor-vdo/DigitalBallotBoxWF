
namespace DigitalBallotBoxWF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnToVote = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(63, 64);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Cadastrar candidato";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnToVote
            // 
            this.btnToVote.Location = new System.Drawing.Point(63, 93);
            this.btnToVote.Name = "btnToVote";
            this.btnToVote.Size = new System.Drawing.Size(147, 23);
            this.btnToVote.TabIndex = 1;
            this.btnToVote.Text = "Votar";
            this.btnToVote.UseVisualStyleBackColor = true;
            this.btnToVote.Click += new System.EventHandler(this.btnToVote_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(63, 123);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(147, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Resultado da Votação";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 192);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnToVote);
            this.Controls.Add(this.btnRegister);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Ballot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnToVote;
        private System.Windows.Forms.Button btnResult;
    }
}

