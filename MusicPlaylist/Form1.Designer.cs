namespace MusicPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.shuffle_btn = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AvailableTracks_label = new System.Windows.Forms.Label();
            this.AvailableTracks_cb = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.stop_btn);
            this.panel2.Controls.Add(this.pause_btn);
            this.panel2.Controls.Add(this.play_btn);
            this.panel2.Controls.Add(this.shuffle_btn);
            this.panel2.Location = new System.Drawing.Point(0, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 106);
            this.panel2.TabIndex = 1;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Image = global::MusicPlaylist.Properties.Resources.stop_button__1_;
            this.stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stop_btn.Location = new System.Drawing.Point(565, 36);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(50, 40);
            this.stop_btn.TabIndex = 12;
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click_1);
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.Transparent;
            this.pause_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_btn.Image = global::MusicPlaylist.Properties.Resources.pause__1_;
            this.pause_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pause_btn.Location = new System.Drawing.Point(525, 36);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(50, 40);
            this.pause_btn.TabIndex = 11;
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click_1);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Image = global::MusicPlaylist.Properties.Resources.play_button__1_;
            this.play_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.play_btn.Location = new System.Drawing.Point(477, 37);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(50, 40);
            this.play_btn.TabIndex = 9;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // shuffle_btn
            // 
            this.shuffle_btn.BackColor = System.Drawing.Color.Transparent;
            this.shuffle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.shuffle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffle_btn.Image = global::MusicPlaylist.Properties.Resources.shuffle_button__2_;
            this.shuffle_btn.Location = new System.Drawing.Point(437, 44);
            this.shuffle_btn.Name = "shuffle_btn";
            this.shuffle_btn.Size = new System.Drawing.Size(34, 26);
            this.shuffle_btn.TabIndex = 8;
            this.shuffle_btn.UseVisualStyleBackColor = false;
            this.shuffle_btn.Click += new System.EventHandler(this.shuffle_btn_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::MusicPlaylist.Properties.Resources.background2;
            this.panelHome.Controls.Add(this.label9);
            this.panelHome.Controls.Add(this.listBox1);
            this.panelHome.Controls.Add(this.Update_btn);
            this.panelHome.Controls.Add(this.mediaPlayer);
            this.panelHome.Controls.Add(this.Delete_btn);
            this.panelHome.Controls.Add(this.Clear_btn);
            this.panelHome.Controls.Add(this.label8);
            this.panelHome.Controls.Add(this.label7);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.textBox7);
            this.panelHome.Controls.Add(this.Insert_btn);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.textBox6);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.textBox5);
            this.panelHome.Controls.Add(this.textBox4);
            this.panelHome.Controls.Add(this.textBox3);
            this.panelHome.Controls.Add(this.textBox2);
            this.panelHome.Controls.Add(this.textBox1);
            this.panelHome.Controls.Add(this.AvailableTracks_label);
            this.panelHome.Controls.Add(this.AvailableTracks_cb);
            this.panelHome.Location = new System.Drawing.Point(0, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1107, 540);
            this.panelHome.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Favorite Tracks";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(391, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 316);
            this.listBox1.TabIndex = 23;
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(114, 470);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(100, 33);
            this.Update_btn.TabIndex = 22;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(877, 426);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(230, 114);
            this.mediaPlayer.TabIndex = 12;
            this.mediaPlayer.Visible = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(9, 504);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(100, 33);
            this.Delete_btn.TabIndex = 21;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(114, 504);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 33);
            this.Clear_btn.TabIndex = 20;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "MP3 path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Music Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Track Title";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 417);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 11;
            // 
            // Insert_btn
            // 
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(8, 470);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(100, 33);
            this.Insert_btn.TabIndex = 10;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(568, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 371);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playing Now";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 325);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 274);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 2;
            // 
            // AvailableTracks_label
            // 
            this.AvailableTracks_label.AutoSize = true;
            this.AvailableTracks_label.BackColor = System.Drawing.Color.Transparent;
            this.AvailableTracks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableTracks_label.Location = new System.Drawing.Point(7, 7);
            this.AvailableTracks_label.Name = "AvailableTracks_label";
            this.AvailableTracks_label.Size = new System.Drawing.Size(187, 25);
            this.AvailableTracks_label.TabIndex = 1;
            this.AvailableTracks_label.Text = "Available Tracks";
            // 
            // AvailableTracks_cb
            // 
            this.AvailableTracks_cb.FormattingEnabled = true;
            this.AvailableTracks_cb.Location = new System.Drawing.Point(9, 34);
            this.AvailableTracks_cb.Name = "AvailableTracks_cb";
            this.AvailableTracks_cb.Size = new System.Drawing.Size(182, 21);
            this.AvailableTracks_cb.TabIndex = 0;
            this.AvailableTracks_cb.SelectedIndexChanged += new System.EventHandler(this.AvailableTracks_cb_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 645);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Music Playlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button shuffle_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label AvailableTracks_label;
        private System.Windows.Forms.ComboBox AvailableTracks_cb;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.TextBox textBox7;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}

