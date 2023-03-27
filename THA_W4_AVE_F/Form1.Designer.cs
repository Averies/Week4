namespace THA_W4_AVE_F
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox_player = new System.Windows.Forms.ListBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.textBox_nameP = new System.Windows.Forms.TextBox();
            this.textBox_nmbrP = new System.Windows.Forms.TextBox();
            this.textBox_nameT = new System.Windows.Forms.TextBox();
            this.textBox_countryT = new System.Windows.Forms.TextBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.btn_AddPlayer = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adding Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adding Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Team:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Player Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Player Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Player Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Team Country:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Team Name:";
            // 
            // listBox_player
            // 
            this.listBox_player.FormattingEnabled = true;
            this.listBox_player.ItemHeight = 20;
            this.listBox_player.Location = new System.Drawing.Point(16, 205);
            this.listBox_player.Name = "listBox_player";
            this.listBox_player.Size = new System.Drawing.Size(280, 184);
            this.listBox_player.TabIndex = 11;
            this.listBox_player.SelectedIndexChanged += new System.EventHandler(this.listBox_player_SelectedIndexChanged);
            // 
            // comboBox_country
            // 
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(145, 90);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(151, 28);
            this.comboBox_country.TabIndex = 12;
            this.comboBox_country.SelectedIndexChanged += new System.EventHandler(this.comboBox_country_SelectedIndexChanged);
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(754, 189);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(174, 28);
            this.comboBox_position.TabIndex = 13;
            this.comboBox_position.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_SelectedIndexChanged);
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(145, 140);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(151, 28);
            this.comboBox_team.TabIndex = 14;
            this.comboBox_team.SelectedIndexChanged += new System.EventHandler(this.comboBox_team_SelectedIndexChanged);
            // 
            // textBox_nameP
            // 
            this.textBox_nameP.Location = new System.Drawing.Point(754, 90);
            this.textBox_nameP.Name = "textBox_nameP";
            this.textBox_nameP.Size = new System.Drawing.Size(174, 26);
            this.textBox_nameP.TabIndex = 16;
            // 
            // textBox_nmbrP
            // 
            this.textBox_nmbrP.Location = new System.Drawing.Point(754, 140);
            this.textBox_nmbrP.Name = "textBox_nmbrP";
            this.textBox_nmbrP.Size = new System.Drawing.Size(174, 26);
            this.textBox_nmbrP.TabIndex = 17;
            // 
            // textBox_nameT
            // 
            this.textBox_nameT.Location = new System.Drawing.Point(429, 90);
            this.textBox_nameT.Name = "textBox_nameT";
            this.textBox_nameT.Size = new System.Drawing.Size(174, 26);
            this.textBox_nameT.TabIndex = 19;
            // 
            // textBox_countryT
            // 
            this.textBox_countryT.Location = new System.Drawing.Point(429, 140);
            this.textBox_countryT.Name = "textBox_countryT";
            this.textBox_countryT.Size = new System.Drawing.Size(174, 26);
            this.textBox_countryT.TabIndex = 20;
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.Location = new System.Drawing.Point(412, 192);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(82, 32);
            this.btn_AddTeam.TabIndex = 21;
            this.btn_AddTeam.Text = "Add";
            this.btn_AddTeam.UseVisualStyleBackColor = true;
            this.btn_AddTeam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AddPlayer
            // 
            this.btn_AddPlayer.Location = new System.Drawing.Point(742, 242);
            this.btn_AddPlayer.Name = "btn_AddPlayer";
            this.btn_AddPlayer.Size = new System.Drawing.Size(81, 32);
            this.btn_AddPlayer.TabIndex = 22;
            this.btn_AddPlayer.Text = "Add";
            this.btn_AddPlayer.UseVisualStyleBackColor = true;
            this.btn_AddPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(28, 405);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(96, 33);
            this.btn_remove.TabIndex = 23;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_AddPlayer);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.textBox_countryT);
            this.Controls.Add(this.textBox_nameT);
            this.Controls.Add(this.textBox_nmbrP);
            this.Controls.Add(this.textBox_nameP);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.listBox_player);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox_player;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.TextBox textBox_nameP;
        private System.Windows.Forms.TextBox textBox_nmbrP;
        private System.Windows.Forms.TextBox textBox_nameT;
        private System.Windows.Forms.TextBox textBox_countryT;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Button btn_AddPlayer;
        private System.Windows.Forms.Button btn_remove;
    }
}

