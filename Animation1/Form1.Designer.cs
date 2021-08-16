namespace Animation1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangePlayer = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Label();
            this.rolledValue = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.TotalCars = new System.Windows.Forms.PictureBox();
            this.DiceRoll = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 1000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePlayer
            // 
            this.ChangePlayer.BackColor = System.Drawing.Color.Teal;
            this.ChangePlayer.FlatAppearance.BorderSize = 0;
            this.ChangePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePlayer.ForeColor = System.Drawing.Color.White;
            this.ChangePlayer.Location = new System.Drawing.Point(1293, 256);
            this.ChangePlayer.Name = "ChangePlayer";
            this.ChangePlayer.Padding = new System.Windows.Forms.Padding(5);
            this.ChangePlayer.Size = new System.Drawing.Size(148, 50);
            this.ChangePlayer.TabIndex = 2;
            this.ChangePlayer.Text = "Change player";
            this.ChangePlayer.UseVisualStyleBackColor = false;
            this.ChangePlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangePlayer_MouseClick);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.ForeColor = System.Drawing.Color.DarkOrange;
            this.Player.Location = new System.Drawing.Point(1289, 320);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(5);
            this.Player.Size = new System.Drawing.Size(51, 30);
            this.Player.TabIndex = 4;
            this.Player.Text = "test";
            // 
            // rolledValue
            // 
            this.rolledValue.AutoSize = true;
            this.rolledValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolledValue.ForeColor = System.Drawing.Color.DarkOrange;
            this.rolledValue.Location = new System.Drawing.Point(1289, 513);
            this.rolledValue.Name = "rolledValue";
            this.rolledValue.Padding = new System.Windows.Forms.Padding(5);
            this.rolledValue.Size = new System.Drawing.Size(104, 30);
            this.rolledValue.TabIndex = 7;
            this.rolledValue.Text = "test rolled";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.ErrorMessage.Location = new System.Drawing.Point(1539, 743);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(66, 17);
            this.ErrorMessage.TabIndex = 8;
            this.ErrorMessage.Text = "error test";
            // 
            // TotalCars
            // 
            this.TotalCars.Location = new System.Drawing.Point(1458, 42);
            this.TotalCars.Name = "TotalCars";
            this.TotalCars.Size = new System.Drawing.Size(147, 476);
            this.TotalCars.TabIndex = 9;
            this.TotalCars.TabStop = false;
            // 
            // DiceRoll
            // 
            this.DiceRoll.Location = new System.Drawing.Point(1293, 374);
            this.DiceRoll.Name = "DiceRoll";
            this.DiceRoll.Size = new System.Drawing.Size(125, 125);
            this.DiceRoll.TabIndex = 10;
            this.DiceRoll.TabStop = false;
            this.DiceRoll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiceRoll_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.DiceRoll);
            this.Controls.Add(this.TotalCars);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.rolledValue);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ChangePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Monopoly";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChangePlayer;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label rolledValue;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.PictureBox TotalCars;
        private System.Windows.Forms.PictureBox DiceRoll;
    }
}

