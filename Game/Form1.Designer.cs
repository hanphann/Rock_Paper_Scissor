namespace Game
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
            this.playerChoicePictureBox = new System.Windows.Forms.PictureBox();
            this.computerChoicePictureBox = new System.Windows.Forms.PictureBox();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerChoicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer\'s Choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player\'s Choice";
            // 
            // playerChoicePictureBox
            // 
            this.playerChoicePictureBox.Image = global::Game.Properties.Resources._3;
            this.playerChoicePictureBox.Location = new System.Drawing.Point(426, 103);
            this.playerChoicePictureBox.Name = "playerChoicePictureBox";
            this.playerChoicePictureBox.Size = new System.Drawing.Size(211, 211);
            this.playerChoicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerChoicePictureBox.TabIndex = 1;
            this.playerChoicePictureBox.TabStop = false;
            // 
            // computerChoicePictureBox
            // 
            this.computerChoicePictureBox.Image = global::Game.Properties.Resources._3;
            this.computerChoicePictureBox.Location = new System.Drawing.Point(62, 103);
            this.computerChoicePictureBox.Name = "computerChoicePictureBox";
            this.computerChoicePictureBox.Size = new System.Drawing.Size(211, 211);
            this.computerChoicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerChoicePictureBox.TabIndex = 0;
            this.computerChoicePictureBox.TabStop = false;
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(98, 362);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(120, 39);
            this.rockButton.TabIndex = 4;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(286, 362);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(120, 39);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorButton.Location = new System.Drawing.Point(478, 362);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(120, 39);
            this.scissorButton.TabIndex = 6;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(295, 189);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(120, 25);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Let\'s play!";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerChoicePictureBox);
            this.Controls.Add(this.computerChoicePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerChoicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoicePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox computerChoicePictureBox;
        private System.Windows.Forms.PictureBox playerChoicePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

