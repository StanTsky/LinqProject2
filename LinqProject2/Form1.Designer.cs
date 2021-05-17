namespace LinqProject2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.playersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.defenseComboBox = new System.Windows.Forms.ComboBox();
            this.pokemonGridView = new System.Windows.Forms.DataGridView();
            this.attackLabel = new System.Windows.Forms.Label();
            this.attackComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ownerGridView = new System.Windows.Forms.DataGridView();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cityLabel);
            this.tabPage1.Controls.Add(this.cityComboBox);
            this.tabPage1.Controls.Add(this.playersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PLAYERS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(23, 121);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(26, 141);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(212, 24);
            this.cityComboBox.TabIndex = 1;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // playersGridView
            // 
            this.playersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.playersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGridView.Location = new System.Drawing.Point(260, 6);
            this.playersGridView.Name = "playersGridView";
            this.playersGridView.RowTemplate.Height = 24;
            this.playersGridView.Size = new System.Drawing.Size(851, 427);
            this.playersGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.defenseLabel);
            this.tabPage2.Controls.Add(this.defenseComboBox);
            this.tabPage2.Controls.Add(this.pokemonGridView);
            this.tabPage2.Controls.Add(this.attackLabel);
            this.tabPage2.Controls.Add(this.attackComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POKEMON";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(23, 189);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(101, 17);
            this.defenseLabel.TabIndex = 7;
            this.defenseLabel.Text = "Defense Value";
            // 
            // defenseComboBox
            // 
            this.defenseComboBox.FormattingEnabled = true;
            this.defenseComboBox.Location = new System.Drawing.Point(26, 209);
            this.defenseComboBox.Name = "defenseComboBox";
            this.defenseComboBox.Size = new System.Drawing.Size(212, 24);
            this.defenseComboBox.TabIndex = 6;
            this.defenseComboBox.SelectedIndexChanged += new System.EventHandler(this.defenseComboBox_SelectedIndexChanged);
            // 
            // pokemonGridView
            // 
            this.pokemonGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pokemonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokemonGridView.Location = new System.Drawing.Point(260, 6);
            this.pokemonGridView.Name = "pokemonGridView";
            this.pokemonGridView.RowTemplate.Height = 24;
            this.pokemonGridView.Size = new System.Drawing.Size(851, 427);
            this.pokemonGridView.TabIndex = 5;
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(23, 121);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(87, 17);
            this.attackLabel.TabIndex = 4;
            this.attackLabel.Text = "Attack Value";
            // 
            // attackComboBox
            // 
            this.attackComboBox.FormattingEnabled = true;
            this.attackComboBox.Location = new System.Drawing.Point(26, 141);
            this.attackComboBox.Name = "attackComboBox";
            this.attackComboBox.Size = new System.Drawing.Size(212, 24);
            this.attackComboBox.TabIndex = 3;
            this.attackComboBox.SelectedIndexChanged += new System.EventHandler(this.comboAttackValue_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ownerGridView);
            this.tabPage3.Controls.Add(this.labelPlayer);
            this.tabPage3.Controls.Add(this.playerComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1119, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OWNERSHIP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ownerGridView
            // 
            this.ownerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ownerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerGridView.Location = new System.Drawing.Point(252, 7);
            this.ownerGridView.Name = "ownerGridView";
            this.ownerGridView.RowTemplate.Height = 24;
            this.ownerGridView.Size = new System.Drawing.Size(851, 427);
            this.ownerGridView.TabIndex = 8;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(15, 122);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(48, 17);
            this.labelPlayer.TabIndex = 7;
            this.labelPlayer.Text = "Player";
            // 
            // playerComboBox
            // 
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(18, 142);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(212, 24);
            this.playerComboBox.TabIndex = 6;
            this.playerComboBox.SelectedIndexChanged += new System.EventHandler(this.playerComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "LINQ Project 2 by Stanislav Turovsky";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView playersGridView;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.DataGridView pokemonGridView;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.ComboBox attackComboBox;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.ComboBox defenseComboBox;
        private System.Windows.Forms.DataGridView ownerGridView;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.ComboBox playerComboBox;
    }
}

