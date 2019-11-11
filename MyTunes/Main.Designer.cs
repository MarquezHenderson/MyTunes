namespace MyTunes
{
    partial class fm_Main
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
            this.lb_Filename = new System.Windows.Forms.Label();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.lab_song_count = new System.Windows.Forms.Label();
            this.labSongs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Filename
            // 
            this.lb_Filename.AutoSize = true;
            this.lb_Filename.Location = new System.Drawing.Point(12, 9);
            this.lb_Filename.Name = "lb_Filename";
            this.lb_Filename.Size = new System.Drawing.Size(0, 13);
            this.lb_Filename.TabIndex = 0;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(15, 218);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(96, 218);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(177, 218);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // list_playlist
            // 
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.Location = new System.Drawing.Point(15, 34);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(286, 160);
            this.list_playlist.TabIndex = 4;
            this.list_playlist.SelectedIndexChanged += new System.EventHandler(this.list_playlist_SelectedIndexChanged);
            // 
            // lab_song_count
            // 
            this.lab_song_count.AutoSize = true;
            this.lab_song_count.Location = new System.Drawing.Point(288, 201);
            this.lab_song_count.Name = "lab_song_count";
            this.lab_song_count.Size = new System.Drawing.Size(13, 13);
            this.lab_song_count.TabIndex = 5;
            this.lab_song_count.Text = "0";
            // 
            // labSongs
            // 
            this.labSongs.AutoSize = true;
            this.labSongs.Location = new System.Drawing.Point(245, 201);
            this.labSongs.Name = "labSongs";
            this.labSongs.Size = new System.Drawing.Size(37, 13);
            this.labSongs.TabIndex = 6;
            this.labSongs.Text = "Songs";
            // 
            // fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 264);
            this.Controls.Add(this.labSongs);
            this.Controls.Add(this.lab_song_count);
            this.Controls.Add(this.list_playlist);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.lb_Filename);
            this.Name = "fm_Main";
            this.Text = "MyTunes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Filename;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListBox list_playlist;
        private System.Windows.Forms.Label lab_song_count;
        private System.Windows.Forms.Label labSongs;
    }
}

