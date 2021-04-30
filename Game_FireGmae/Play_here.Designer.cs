
namespace Game_FireGmae
{
    partial class Play_here
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
            this.First_btn = new System.Windows.Forms.Button();
            this.load_game = new System.Windows.Forms.Button();
            this.spin_gun = new System.Windows.Forms.Button();
            this.fire_gun = new System.Windows.Forms.Button();
            this.fire_away = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pbFireBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFireBox)).BeginInit();
            this.SuspendLayout();
            // 
            // First_btn
            // 
            this.First_btn.BackColor = System.Drawing.Color.White;
            this.First_btn.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_btn.ForeColor = System.Drawing.Color.Black;
            this.First_btn.Location = new System.Drawing.Point(684, 31);
            this.First_btn.Name = "First_btn";
            this.First_btn.Size = new System.Drawing.Size(197, 49);
            this.First_btn.TabIndex = 0;
            this.First_btn.Text = "Game Start";
            this.First_btn.UseVisualStyleBackColor = false;
            this.First_btn.Click += new System.EventHandler(this.First_btn_Click);
            // 
            // load_game
            // 
            this.load_game.BackColor = System.Drawing.Color.White;
            this.load_game.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_game.ForeColor = System.Drawing.Color.Black;
            this.load_game.Location = new System.Drawing.Point(704, 86);
            this.load_game.Name = "load_game";
            this.load_game.Size = new System.Drawing.Size(164, 47);
            this.load_game.TabIndex = 1;
            this.load_game.Text = "Game Load";
            this.load_game.UseVisualStyleBackColor = false;
            this.load_game.Click += new System.EventHandler(this.load_game_Click);
            // 
            // spin_gun
            // 
            this.spin_gun.BackColor = System.Drawing.Color.White;
            this.spin_gun.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_gun.ForeColor = System.Drawing.Color.Black;
            this.spin_gun.Location = new System.Drawing.Point(704, 139);
            this.spin_gun.Name = "spin_gun";
            this.spin_gun.Size = new System.Drawing.Size(164, 47);
            this.spin_gun.TabIndex = 2;
            this.spin_gun.Text = "Gun Spin";
            this.spin_gun.UseVisualStyleBackColor = false;
            this.spin_gun.Click += new System.EventHandler(this.spin_gun_Click);
            // 
            // fire_gun
            // 
            this.fire_gun.BackColor = System.Drawing.Color.White;
            this.fire_gun.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire_gun.ForeColor = System.Drawing.Color.Black;
            this.fire_gun.Location = new System.Drawing.Point(704, 192);
            this.fire_gun.Name = "fire_gun";
            this.fire_gun.Size = new System.Drawing.Size(164, 47);
            this.fire_gun.TabIndex = 3;
            this.fire_gun.Text = "Fire Gun";
            this.fire_gun.UseVisualStyleBackColor = false;
            this.fire_gun.Click += new System.EventHandler(this.fire_gun_Click);
            // 
            // fire_away
            // 
            this.fire_away.BackColor = System.Drawing.Color.White;
            this.fire_away.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire_away.ForeColor = System.Drawing.Color.Black;
            this.fire_away.Location = new System.Drawing.Point(704, 245);
            this.fire_away.Name = "fire_away";
            this.fire_away.Size = new System.Drawing.Size(164, 47);
            this.fire_away.TabIndex = 4;
            this.fire_away.Text = "Fire Away";
            this.fire_away.UseVisualStyleBackColor = false;
            this.fire_away.Click += new System.EventHandler(this.fire_away_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(704, 298);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(164, 47);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit |||";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pbFireBox
            // 
            this.pbFireBox.Location = new System.Drawing.Point(26, 112);
            this.pbFireBox.Name = "pbFireBox";
            this.pbFireBox.Size = new System.Drawing.Size(584, 306);
            this.pbFireBox.TabIndex = 6;
            this.pbFireBox.TabStop = false;
            // 
            // Play_here
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(964, 480);
            this.Controls.Add(this.pbFireBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.fire_away);
            this.Controls.Add(this.fire_gun);
            this.Controls.Add(this.spin_gun);
            this.Controls.Add(this.load_game);
            this.Controls.Add(this.First_btn);
            this.Name = "Play_here";
            this.Text = "Play_here";
            this.Load += new System.EventHandler(this.Play_here_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFireBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button First_btn;
        private System.Windows.Forms.Button load_game;
        private System.Windows.Forms.Button spin_gun;
        private System.Windows.Forms.Button fire_gun;
        private System.Windows.Forms.Button fire_away;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pbFireBox;
    }
}