namespace DiceGame
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(324, 175);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(100, 41);
            this.btnRollDice.TabIndex = 5;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btn_rollDice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::DiceGame.Properties.Resources.square_ios_app_xxl;
            this.label1.Location = new System.Drawing.Point(99, 36);
            this.label1.MaximumSize = new System.Drawing.Size(150, 150);
            this.label1.MinimumSize = new System.Drawing.Size(90, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 90);
            this.label1.TabIndex = 6;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::DiceGame.Properties.Resources.square_ios_app_xxl;
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.MaximumSize = new System.Drawing.Size(150, 150);
            this.label2.MinimumSize = new System.Drawing.Size(90, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 90);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::DiceGame.Properties.Resources.square_ios_app_xxl;
            this.label3.Location = new System.Drawing.Point(340, 36);
            this.label3.MaximumSize = new System.Drawing.Size(150, 150);
            this.label3.MinimumSize = new System.Drawing.Size(90, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 90);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::DiceGame.Properties.Resources.square_ios_app_xxl;
            this.label4.Location = new System.Drawing.Point(464, 36);
            this.label4.MaximumSize = new System.Drawing.Size(150, 150);
            this.label4.MinimumSize = new System.Drawing.Size(90, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 90);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::DiceGame.Properties.Resources.square_ios_app_xxl;
            this.label5.Location = new System.Drawing.Point(602, 36);
            this.label5.MaximumSize = new System.Drawing.Size(150, 150);
            this.label5.MinimumSize = new System.Drawing.Size(90, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 90);
            this.label5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRollDice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

