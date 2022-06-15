
namespace Juego
{
    partial class Juego
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCCartas1 = new System.Windows.Forms.Label();
            this.lblCCartas2 = new System.Windows.Forms.Label();
            this.lblNumeroJugador2 = new System.Windows.Forms.Label();
            this.lblNumeroJugador1 = new System.Windows.Forms.Label();
            this.lblNicknameJugador2 = new System.Windows.Forms.Label();
            this.lblNicknameJugador1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 151);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 151);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lanzar\r\n";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lanzar\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCCartas1
            // 
            this.lblCCartas1.AutoSize = true;
            this.lblCCartas1.Location = new System.Drawing.Point(65, 368);
            this.lblCCartas1.Name = "lblCCartas1";
            this.lblCCartas1.Size = new System.Drawing.Size(20, 13);
            this.lblCCartas1.TabIndex = 4;
            this.lblCCartas1.Text = "#1";
            // 
            // lblCCartas2
            // 
            this.lblCCartas2.AutoSize = true;
            this.lblCCartas2.Location = new System.Drawing.Point(716, 368);
            this.lblCCartas2.Name = "lblCCartas2";
            this.lblCCartas2.Size = new System.Drawing.Size(20, 13);
            this.lblCCartas2.TabIndex = 5;
            this.lblCCartas2.Text = "#2";
            // 
            // lblNumeroJugador2
            // 
            this.lblNumeroJugador2.AutoSize = true;
            this.lblNumeroJugador2.Location = new System.Drawing.Point(700, 395);
            this.lblNumeroJugador2.Name = "lblNumeroJugador2";
            this.lblNumeroJugador2.Size = new System.Drawing.Size(57, 13);
            this.lblNumeroJugador2.TabIndex = 6;
            this.lblNumeroJugador2.Text = "Nro Cartas\r\n";
            // 
            // lblNumeroJugador1
            // 
            this.lblNumeroJugador1.AutoSize = true;
            this.lblNumeroJugador1.Location = new System.Drawing.Point(47, 395);
            this.lblNumeroJugador1.Name = "lblNumeroJugador1";
            this.lblNumeroJugador1.Size = new System.Drawing.Size(57, 13);
            this.lblNumeroJugador1.TabIndex = 7;
            this.lblNumeroJugador1.Text = "Nro Cartas\r\n";
            // 
            // lblNicknameJugador2
            // 
            this.lblNicknameJugador2.AutoSize = true;
            this.lblNicknameJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNicknameJugador2.Location = new System.Drawing.Point(623, 50);
            this.lblNicknameJugador2.Name = "lblNicknameJugador2";
            this.lblNicknameJugador2.Size = new System.Drawing.Size(87, 29);
            this.lblNicknameJugador2.TabIndex = 8;
            this.lblNicknameJugador2.Text = "label5";
            // 
            // lblNicknameJugador1
            // 
            this.lblNicknameJugador1.AutoSize = true;
            this.lblNicknameJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNicknameJugador1.Location = new System.Drawing.Point(99, 50);
            this.lblNicknameJugador1.Name = "lblNicknameJugador1";
            this.lblNicknameJugador1.Size = new System.Drawing.Size(87, 29);
            this.lblNicknameJugador1.TabIndex = 9;
            this.lblNicknameJugador1.Text = "label6";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNicknameJugador1);
            this.Controls.Add(this.lblNicknameJugador2);
            this.Controls.Add(this.lblNumeroJugador1);
            this.Controls.Add(this.lblNumeroJugador2);
            this.Controls.Add(this.lblCCartas2);
            this.Controls.Add(this.lblCCartas1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Juego";
            this.Text = "Juego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblCCartas1;
        private System.Windows.Forms.Label lblCCartas2;
        private System.Windows.Forms.Label lblNumeroJugador2;
        private System.Windows.Forms.Label lblNumeroJugador1;
        private System.Windows.Forms.Label lblNicknameJugador2;
        private System.Windows.Forms.Label lblNicknameJugador1;
    }
}