namespace TileGame
{
    partial class Fight
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
            this.pbFightScene = new System.Windows.Forms.PictureBox();
            this.pbHeroHealth = new System.Windows.Forms.PictureBox();
            this.pbMonsterHealth = new System.Windows.Forms.PictureBox();
            this.labHeroHealthValue = new System.Windows.Forms.Label();
            this.labMonsterHealthValue = new System.Windows.Forms.Label();
            this.tbMessages = new TileGame.FightMessageBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFightScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonsterHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFightScene
            // 
            this.pbFightScene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFightScene.Location = new System.Drawing.Point(12, 43);
            this.pbFightScene.Name = "pbFightScene";
            this.pbFightScene.Size = new System.Drawing.Size(650, 400);
            this.pbFightScene.TabIndex = 0;
            this.pbFightScene.TabStop = false;
            // 
            // pbHeroHealth
            // 
            this.pbHeroHealth.BackColor = System.Drawing.Color.DarkRed;
            this.pbHeroHealth.Location = new System.Drawing.Point(12, 8);
            this.pbHeroHealth.Name = "pbHeroHealth";
            this.pbHeroHealth.Size = new System.Drawing.Size(300, 30);
            this.pbHeroHealth.TabIndex = 6;
            this.pbHeroHealth.TabStop = false;
            // 
            // pbMonsterHealth
            // 
            this.pbMonsterHealth.BackColor = System.Drawing.Color.DarkRed;
            this.pbMonsterHealth.Location = new System.Drawing.Point(362, 7);
            this.pbMonsterHealth.Name = "pbMonsterHealth";
            this.pbMonsterHealth.Size = new System.Drawing.Size(300, 30);
            this.pbMonsterHealth.TabIndex = 7;
            this.pbMonsterHealth.TabStop = false;
            // 
            // labHeroHealthValue
            // 
            this.labHeroHealthValue.AutoSize = true;
            this.labHeroHealthValue.Location = new System.Drawing.Point(144, 8);
            this.labHeroHealthValue.Name = "labHeroHealthValue";
            this.labHeroHealthValue.Size = new System.Drawing.Size(35, 13);
            this.labHeroHealthValue.TabIndex = 8;
            this.labHeroHealthValue.Text = "label1";
            // 
            // labMonsterHealthValue
            // 
            this.labMonsterHealthValue.AutoSize = true;
            this.labMonsterHealthValue.Location = new System.Drawing.Point(494, 8);
            this.labMonsterHealthValue.Name = "labMonsterHealthValue";
            this.labMonsterHealthValue.Size = new System.Drawing.Size(35, 13);
            this.labMonsterHealthValue.TabIndex = 9;
            this.labMonsterHealthValue.Text = "label1";
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(668, 43);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(267, 400);
            this.tbMessages.TabIndex = 10;
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 490);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.labMonsterHealthValue);
            this.Controls.Add(this.labHeroHealthValue);
            this.Controls.Add(this.pbMonsterHealth);
            this.Controls.Add(this.pbHeroHealth);
            this.Controls.Add(this.pbFightScene);
            this.Name = "Fight";
            this.Text = "Fight";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fight_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFightScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonsterHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFightScene;
        private System.Windows.Forms.PictureBox pbHeroHealth;
        private System.Windows.Forms.PictureBox pbMonsterHealth;
        private System.Windows.Forms.Label labHeroHealthValue;
        private System.Windows.Forms.Label labMonsterHealthValue;
        private FightMessageBox tbMessages;
    }
}