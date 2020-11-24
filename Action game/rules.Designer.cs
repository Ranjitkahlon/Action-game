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
            this.lbl_rule3 = new System.Windows.Forms.Label();
            this.lbl_rule4 = new System.Windows.Forms.Label();
            this.lbl_rule5 = new System.Windows.Forms.Label();
            this.lbl_rule6 = new System.Windows.Forms.Label();
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
            this.lbl_rulenumberone.Location = new System.Drawing.Point(116, 64);
            this.lbl_rulenumberone.Name = "lbl_rulenumberone";
            this.lbl_rulenumberone.Size = new System.Drawing.Size(293, 20);
            this.lbl_rulenumberone.TabIndex = 1;
            this.lbl_rulenumberone.Text = "1. Firstly, You have to load the gun.\r\n";
            this.lbl_rulenumberone.Click += new System.EventHandler(this.lbl_rulenumberone_Click);
            // 
            // Lbl_rule2
            // 
            this.Lbl_rule2.AutoSize = true;
            this.Lbl_rule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_rule2.Location = new System.Drawing.Point(116, 106);
            this.Lbl_rule2.Name = "Lbl_rule2";
            this.Lbl_rule2.Size = new System.Drawing.Size(379, 20);
            this.Lbl_rule2.TabIndex = 2;
            this.Lbl_rule2.Text = "2. Once load a gun, then have to spin the gun.";
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
            // lbl_rule3
            // 
            this.lbl_rule3.AutoSize = true;
            this.lbl_rule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule3.Location = new System.Drawing.Point(116, 144);
            this.lbl_rule3.Name = "lbl_rule3";
            this.lbl_rule3.Size = new System.Drawing.Size(327, 20);
            this.lbl_rule3.TabIndex = 4;
            this.lbl_rule3.Text = "3. The position of bullet is randomly set.";
            // 
            // lbl_rule4
            // 
            this.lbl_rule4.AutoSize = true;
            this.lbl_rule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule4.Location = new System.Drawing.Point(116, 188);
            this.lbl_rule4.Name = "lbl_rule4";
            this.lbl_rule4.Size = new System.Drawing.Size(311, 20);
            this.lbl_rule4.TabIndex = 5;
            this.lbl_rule4.Text = "4.  You have two chance to win game.";
            this.lbl_rule4.UseWaitCursor = true;
            // 
            // lbl_rule5
            // 
            this.lbl_rule5.AutoSize = true;
            this.lbl_rule5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rule5.Location = new System.Drawing.Point(116, 238);
            this.lbl_rule5.Name = "lbl_rule5";
            this.lbl_rule5.Size = new System.Drawing.Size(336, 20);
            this.lbl_rule5.TabIndex = 6;
            this.lbl_rule5.Text = "5. You can shoot on head or shoot away.";
            // 
            // lbl_rule6
            // 
            this.lbl_rule6.AutoSize = true;
            this.lbl_rule6.Location = new System.Drawing.Point(117, 327);
            this.lbl_rule6.Name = "lbl_rule6";
            this.lbl_rule6.Size = new System.Drawing.Size(0, 13);
            this.lbl_rule6.TabIndex = 7;
            // 
            // rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_rule6);
            this.Controls.Add(this.lbl_rule5);
            this.Controls.Add(this.lbl_rule4);
            this.Controls.Add(this.lbl_rule3);
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
        private System.Windows.Forms.Label lbl_rule3;
        private System.Windows.Forms.Label lbl_rule4;
        private System.Windows.Forms.Label lbl_rule5;
        private System.Windows.Forms.Label lbl_rule6;
    }
}