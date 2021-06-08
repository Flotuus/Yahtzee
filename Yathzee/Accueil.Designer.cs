
namespace Yathzepsi
{
    partial class Accueil
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
            this.presentation = new System.Windows.Forms.Label();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.playerName4 = new System.Windows.Forms.TextBox();
            this.playerName3 = new System.Windows.Forms.TextBox();
            this.btLancerPartie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentation
            // 
            this.presentation.AutoSize = true;
            this.presentation.Location = new System.Drawing.Point(160, 77);
            this.presentation.Name = "presentation";
            this.presentation.Size = new System.Drawing.Size(453, 15);
            this.presentation.TabIndex = 0;
            this.presentation.Text = "Bienvenue au Yathzepsi, entrez vos noms et appuyez sur le bouton pour commencer ";
            // 
            // playerName1
            // 
            this.playerName1.Location = new System.Drawing.Point(339, 137);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(112, 23);
            this.playerName1.TabIndex = 1;
            this.playerName1.TextChanged += new System.EventHandler(this.playerName1_TextChanged);
            // 
            // playerName2
            // 
            this.playerName2.Location = new System.Drawing.Point(339, 182);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(112, 23);
            this.playerName2.TabIndex = 2;
            this.playerName2.TextChanged += new System.EventHandler(this.playerName2_TextChanged);
            // 
            // playerName4
            // 
            this.playerName4.Location = new System.Drawing.Point(339, 275);
            this.playerName4.Name = "playerName4";
            this.playerName4.Size = new System.Drawing.Size(112, 23);
            this.playerName4.TabIndex = 3;
            this.playerName4.TextChanged += new System.EventHandler(this.playerName4_TextChanged);
            // 
            // playerName3
            // 
            this.playerName3.Location = new System.Drawing.Point(339, 228);
            this.playerName3.Name = "playerName3";
            this.playerName3.Size = new System.Drawing.Size(112, 23);
            this.playerName3.TabIndex = 4;
            this.playerName3.TextChanged += new System.EventHandler(this.playerName3_TextChanged);
            // 
            // btLancerPartie
            // 
            this.btLancerPartie.Location = new System.Drawing.Point(339, 325);
            this.btLancerPartie.Name = "btLancerPartie";
            this.btLancerPartie.Size = new System.Drawing.Size(112, 23);
            this.btLancerPartie.TabIndex = 5;
            this.btLancerPartie.Text = "Lancer la partie !";
            this.btLancerPartie.UseVisualStyleBackColor = true;
            this.btLancerPartie.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLancerPartie);
            this.Controls.Add(this.playerName3);
            this.Controls.Add(this.playerName4);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.playerName1);
            this.Controls.Add(this.presentation);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentation;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.TextBox playerName2;
        private System.Windows.Forms.TextBox playerName4;
        private System.Windows.Forms.TextBox playerName3;
        private System.Windows.Forms.Button btLancerPartie;
    }
}

