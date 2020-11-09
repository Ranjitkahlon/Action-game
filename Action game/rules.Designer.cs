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
            this.lb_Rule = new System.Windows.Forms.Label();
            this.lb_rulenumberone = new System.Windows.Forms.Label();
            this.lb_rule2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Rule
            // 
            this.lb_Rule.AutoSize = true;
            this.lb_Rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rule.Location = new System.Drawing.Point(269, 25);
            this.lb_Rule.Name = "lb_Rule";
            this.lb_Rule.Size = new System.Drawing.Size(232, 25);
            this.lb_Rule.TabIndex = 0;
            this.lb_Rule.Text = "Rule for Action game";
            this.lb_Rule.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_rulenumberone
            // 
            this.lb_rulenumberone.AutoSize = true;
            this.lb_rulenumberone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rulenumberone.Location = new System.Drawing.Point(112, 83);
            this.lb_rulenumberone.Name = "lb_rulenumberone";
            this.lb_rulenumberone.Size = new System.Drawing.Size(366, 20);
            this.lb_rulenumberone.TabIndex = 1;
            this.lb_rulenumberone.Text = "1. Firstly, You have to load and spin the gun.";
            // 
            // lb_rule2
            // 
            this.lb_rule2.AutoSize = true;
            this.lb_rule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rule2.Location = new System.Drawing.Point(112, 141);
            this.lb_rule2.Name = "lb_rule2";
            this.lb_rule2.Size = new System.Drawing.Size(499, 20);
            this.lb_rule2.TabIndex = 2;
            this.lb_rule2.Text = "2. You have two chance for shoot the gun and win the game .";
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_rule2);
            this.Controls.Add(this.lb_rulenumberone);
            this.Controls.Add(this.lb_Rule);
            this.Name = "rules";
            this.Text = "rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Rule;
        private System.Windows.Forms.Label lb_rulenumberone;
        private System.Windows.Forms.Label lb_rule2;
    }
}