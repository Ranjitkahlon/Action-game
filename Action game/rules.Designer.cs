namespace Action_game
{
    partial class rules
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
            this.lbl_Rule = new System.Windows.Forms.Label();
            this.lbl_rulenumberone = new System.Windows.Forms.Label();
            this.Lbl_rule2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Rule
            // 
            this.lbl_Rule.AutoSize = true;
            this.lbl_Rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rule.Location = new System.Drawing.Point(269, 25);
            this.lbl_Rule.Name = "lbl_Rule";
            this.lbl_Rule.Size = new System.Drawing.Size(232, 25);
            this.lbl_Rule.TabIndex = 0;
            this.lbl_Rule.Text = "Rule for Action game";
            this.lbl_Rule.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_rulenumberone
            // 
            this.lbl_rulenumberone.AutoSize = true;
            this.lbl_rulenumberone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rulenumberone.Location = new System.Drawing.Point(112, 83);
            this.lbl_rulenumberone.Name = "lbl_rulenumberone";
            this.lbl_rulenumberone.Size = new System.Drawing.Size(366, 20);
            this.lbl_rulenumberone.TabIndex = 1;
            this.lbl_rulenumberone.Text = "1. Firstly, You have to load and spin the gun.";
            // 
            // Lbl_rule2
            // 
            this.Lbl_rule2.AutoSize = true;
            this.Lbl_rule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_rule2.Location = new System.Drawing.Point(112, 141);
            this.Lbl_rule2.Name = "Lbl_rule2";
            this.Lbl_rule2.Size = new System.Drawing.Size(499, 20);
            this.Lbl_rule2.TabIndex = 2;
            this.Lbl_rule2.Text = "2. You have two chance for shoot the gun and win the game .";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(619, 364);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(134, 74);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Lbl_rule2);
            this.Controls.Add(this.lbl_rulenumberone);
            this.Controls.Add(this.lbl_Rule);
            this.Name = "rules";
            this.Text = "rules";
            this.Load += new System.EventHandler(this.rules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rule;
        private System.Windows.Forms.Label lbl_rulenumberone;
        private System.Windows.Forms.Label Lbl_rule2;
        private System.Windows.Forms.Button btn_back;
    }
}