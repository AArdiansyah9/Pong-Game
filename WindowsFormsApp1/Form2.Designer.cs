namespace WindowsFormsApp1
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.mogCharacter = new System.Windows.Forms.PictureBox();
            this.trollFaceCharacter = new System.Windows.Forms.PictureBox();
            this.noCharacter = new System.Windows.Forms.PictureBox();
            this.foreverAloneCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollFaceCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAloneCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Comic Book", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(85, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(599, 72);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Click A Character";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mogCharacter
            // 
            this.mogCharacter.Image = ((System.Drawing.Image)(resources.GetObject("mogCharacter.Image")));
            this.mogCharacter.Location = new System.Drawing.Point(243, 169);
            this.mogCharacter.Name = "mogCharacter";
            this.mogCharacter.Size = new System.Drawing.Size(128, 128);
            this.mogCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mogCharacter.TabIndex = 2;
            this.mogCharacter.TabStop = false;
            this.mogCharacter.Click += new System.EventHandler(this.mogCharacter_Click);
            // 
            // trollFaceCharacter
            // 
            this.trollFaceCharacter.Image = ((System.Drawing.Image)(resources.GetObject("trollFaceCharacter.Image")));
            this.trollFaceCharacter.Location = new System.Drawing.Point(78, 169);
            this.trollFaceCharacter.Name = "trollFaceCharacter";
            this.trollFaceCharacter.Size = new System.Drawing.Size(128, 128);
            this.trollFaceCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trollFaceCharacter.TabIndex = 1;
            this.trollFaceCharacter.TabStop = false;
            this.trollFaceCharacter.Click += new System.EventHandler(this.trollFaceCharacter_Click);
            // 
            // noCharacter
            // 
            this.noCharacter.Image = ((System.Drawing.Image)(resources.GetObject("noCharacter.Image")));
            this.noCharacter.Location = new System.Drawing.Point(407, 169);
            this.noCharacter.Name = "noCharacter";
            this.noCharacter.Size = new System.Drawing.Size(128, 128);
            this.noCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noCharacter.TabIndex = 3;
            this.noCharacter.TabStop = false;
            this.noCharacter.Click += new System.EventHandler(this.noCharacter_Click);
            // 
            // foreverAloneCharacter
            // 
            this.foreverAloneCharacter.Image = ((System.Drawing.Image)(resources.GetObject("foreverAloneCharacter.Image")));
            this.foreverAloneCharacter.Location = new System.Drawing.Point(565, 169);
            this.foreverAloneCharacter.Name = "foreverAloneCharacter";
            this.foreverAloneCharacter.Size = new System.Drawing.Size(128, 128);
            this.foreverAloneCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foreverAloneCharacter.TabIndex = 4;
            this.foreverAloneCharacter.TabStop = false;
            this.foreverAloneCharacter.Click += new System.EventHandler(this.foreverAloneCharacter_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreverAloneCharacter);
            this.Controls.Add(this.noCharacter);
            this.Controls.Add(this.mogCharacter);
            this.Controls.Add(this.trollFaceCharacter);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CharacterForm";
            this.Text = "Choose A Character";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trollFaceCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAloneCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox trollFaceCharacter;
        private System.Windows.Forms.PictureBox mogCharacter;
        private System.Windows.Forms.PictureBox noCharacter;
        private System.Windows.Forms.PictureBox foreverAloneCharacter;
    }
}