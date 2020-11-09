namespace Action_game
{
    partial class Actiongame
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.Image_gif = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Shoot = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            this.btn_PA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(107, 350);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(147, 73);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackgroundImage = global::Action_game.Properties.Resources.giphy;
            this.btn_spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_spin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.Color.Red;
            this.btn_spin.Location = new System.Drawing.Point(335, 350);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(147, 73);
            this.btn_spin.TabIndex = 2;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // Image_gif
            // 
            this.Image_gif.BackgroundImage = global::Action_game.Properties.Resources.giphy__1_1;
            this.Image_gif.Location = new System.Drawing.Point(107, 35);
            this.Image_gif.Name = "Image_gif";
            this.Image_gif.Size = new System.Drawing.Size(412, 258);
            this.Image_gif.TabIndex = 3;
            this.Image_gif.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(713, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 45);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Btn_Shoot
            // 
            this.Btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Shoot.Location = new System.Drawing.Point(561, 144);
            this.Btn_Shoot.Name = "Btn_Shoot";
            this.Btn_Shoot.Size = new System.Drawing.Size(105, 49);
            this.Btn_Shoot.TabIndex = 5;
            this.Btn_Shoot.Text = "Shoot";
            this.Btn_Shoot.UseVisualStyleBackColor = true;
            this.Btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShootAway.Location = new System.Drawing.Point(561, 227);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(105, 52);
            this.btn_ShootAway.TabIndex = 6;
            this.btn_ShootAway.Text = "Shoot Away";
            this.btn_ShootAway.UseVisualStyleBackColor = true;
            this.btn_ShootAway.Click += new System.EventHandler(this.btn_ShootAway_Click);
            // 
            // btn_PA
            // 
            this.btn_PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PA.Location = new System.Drawing.Point(587, 350);
            this.btn_PA.Name = "btn_PA";
            this.btn_PA.Size = new System.Drawing.Size(137, 73);
            this.btn_PA.TabIndex = 7;
            this.btn_PA.Text = "Play Again";
            this.btn_PA.UseVisualStyleBackColor = true;
            this.btn_PA.Click += new System.EventHandler(this.btn_PA_Click);
            // 
            // Actiongame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Action_game.Properties.Resources.istockphoto_1150477705_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PA);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.Btn_Shoot);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Image_gif);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_Load);
            this.Name = "Actiongame";
            this.Text = "Action game";
            this.Load += new System.EventHandler(this.Actiongame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.PictureBox Image_gif;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button Btn_Shoot;
        private System.Windows.Forms.Button btn_ShootAway;
        private System.Windows.Forms.Button btn_PA;
    }
}

