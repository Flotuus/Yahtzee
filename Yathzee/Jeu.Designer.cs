
namespace Yathzepsi
{
    partial class Jeu
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
            this.btLancer = new System.Windows.Forms.Button();
            this.ImgDe1 = new System.Windows.Forms.PictureBox();
            this.ImgDe4 = new System.Windows.Forms.PictureBox();
            this.ImgDe3 = new System.Windows.Forms.PictureBox();
            this.ImgDe2 = new System.Windows.Forms.PictureBox();
            this.ImgDe5 = new System.Windows.Forms.PictureBox();
            this.tableauScore = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joueurEnCours = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btLancer
            // 
            this.btLancer.Location = new System.Drawing.Point(1074, 392);
            this.btLancer.Name = "btLancer";
            this.btLancer.Size = new System.Drawing.Size(110, 23);
            this.btLancer.TabIndex = 5;
            this.btLancer.Text = "Lancer 1";
            this.btLancer.UseVisualStyleBackColor = true;
            this.btLancer.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImgDe1
            // 
            this.ImgDe1.Location = new System.Drawing.Point(944, 155);
            this.ImgDe1.Name = "ImgDe1";
            this.ImgDe1.Size = new System.Drawing.Size(100, 100);
            this.ImgDe1.TabIndex = 6;
            this.ImgDe1.TabStop = false;
            this.ImgDe1.Click += new System.EventHandler(this.ImgDe1_Click);
            // 
            // ImgDe4
            // 
            this.ImgDe4.Location = new System.Drawing.Point(1011, 261);
            this.ImgDe4.Name = "ImgDe4";
            this.ImgDe4.Size = new System.Drawing.Size(100, 100);
            this.ImgDe4.TabIndex = 7;
            this.ImgDe4.TabStop = false;
            this.ImgDe4.Click += new System.EventHandler(this.ImgDe4_Click);
            // 
            // ImgDe3
            // 
            this.ImgDe3.Location = new System.Drawing.Point(1201, 155);
            this.ImgDe3.Name = "ImgDe3";
            this.ImgDe3.Size = new System.Drawing.Size(100, 100);
            this.ImgDe3.TabIndex = 8;
            this.ImgDe3.TabStop = false;
            this.ImgDe3.Click += new System.EventHandler(this.ImgDe3_Click);
            // 
            // ImgDe2
            // 
            this.ImgDe2.Location = new System.Drawing.Point(1074, 155);
            this.ImgDe2.Name = "ImgDe2";
            this.ImgDe2.Size = new System.Drawing.Size(100, 100);
            this.ImgDe2.TabIndex = 9;
            this.ImgDe2.TabStop = false;
            this.ImgDe2.Click += new System.EventHandler(this.ImgDe2_Click);
            // 
            // ImgDe5
            // 
            this.ImgDe5.Location = new System.Drawing.Point(1139, 261);
            this.ImgDe5.Name = "ImgDe5";
            this.ImgDe5.Size = new System.Drawing.Size(100, 100);
            this.ImgDe5.TabIndex = 10;
            this.ImgDe5.TabStop = false;
            this.ImgDe5.Click += new System.EventHandler(this.ImgDe5_Click);
            // 
            // tableauScore
            // 
            this.tableauScore.AllowUserToOrderColumns = true;
            this.tableauScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.tableauScore.Location = new System.Drawing.Point(40, 31);
            this.tableauScore.Name = "tableauScore";
            this.tableauScore.RowTemplate.Height = 25;
            this.tableauScore.Size = new System.Drawing.Size(696, 571);
            this.tableauScore.TabIndex = 11;
            this.tableauScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauScore_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 81;
            // 
            // joueurEnCours
            // 
            this.joueurEnCours.AutoSize = true;
            this.joueurEnCours.Location = new System.Drawing.Point(1031, 69);
            this.joueurEnCours.Name = "joueurEnCours";
            this.joueurEnCours.Size = new System.Drawing.Size(13, 15);
            this.joueurEnCours.TabIndex = 12;
            this.joueurEnCours.Text = "1";
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(1090, 456);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 13;
            this.restart.Text = "Recommencer";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 647);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.joueurEnCours);
            this.Controls.Add(this.tableauScore);
            this.Controls.Add(this.ImgDe5);
            this.Controls.Add(this.ImgDe2);
            this.Controls.Add(this.ImgDe3);
            this.Controls.Add(this.ImgDe4);
            this.Controls.Add(this.ImgDe1);
            this.Controls.Add(this.btLancer);
            this.Name = "Jeu";
            this.Text = "Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLancer;
        private System.Windows.Forms.PictureBox ImgDe1;
        private System.Windows.Forms.PictureBox ImgDe4;
        private System.Windows.Forms.PictureBox ImgDe3;
        private System.Windows.Forms.PictureBox ImgDe2;
        private System.Windows.Forms.PictureBox ImgDe5;
        private System.Windows.Forms.DataGridView tableauScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label joueurEnCours;
        private System.Windows.Forms.Button restart;
    }
}