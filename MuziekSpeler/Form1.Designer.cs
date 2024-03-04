namespace MuziekSpeler
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
            pB1 = new System.Windows.Forms.PictureBox();
            PathTxtb = new System.Windows.Forms.TextBox();
            SizeTxtb = new System.Windows.Forms.TextBox();
            DateTxtb = new System.Windows.Forms.TextBox();
            RateTxtb = new System.Windows.Forms.TextBox();
            SampleTxtb = new System.Windows.Forms.TextBox();
            DurationTxtb = new System.Windows.Forms.TextBox();
            TitleTxtb = new System.Windows.Forms.TextBox();
            GenreTxtb = new System.Windows.Forms.TextBox();
            AlbumTxtb = new System.Windows.Forms.TextBox();
            YearTxtb = new System.Windows.Forms.TextBox();
            NumberTxtb = new System.Windows.Forms.TextBox();
            ArtistTxtb = new System.Windows.Forms.TextBox();
            BeatsTxtb = new System.Windows.Forms.TextBox();
            PlayBtn = new System.Windows.Forms.Button();
            RandomBtn = new System.Windows.Forms.Button();
            SkipBtn = new System.Windows.Forms.Button();
            PublisherTxtb = new System.Windows.Forms.TextBox();
            trackBar1 = new System.Windows.Forms.TrackBar();
            RightTxtb = new System.Windows.Forms.TextBox();
            LoopChb = new System.Windows.Forms.CheckBox();
            AutoChb = new System.Windows.Forms.CheckBox();
            VolumeBar = new System.Windows.Forms.TrackBar();
            FolderCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)pB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            SuspendLayout();
            // 
            // pB1
            // 
            pB1.Location = new System.Drawing.Point(14, 14);
            pB1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pB1.Name = "pB1";
            pB1.Size = new System.Drawing.Size(905, 492);
            pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pB1.TabIndex = 0;
            pB1.TabStop = false;
            pB1.DragDrop += pB1_DragDrop;
            // 
            // PathTxtb
            // 
            PathTxtb.Location = new System.Drawing.Point(14, 512);
            PathTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PathTxtb.Name = "PathTxtb";
            PathTxtb.Size = new System.Drawing.Size(905, 23);
            PathTxtb.TabIndex = 1;
            PathTxtb.Text = "Path";
            // 
            // SizeTxtb
            // 
            SizeTxtb.Location = new System.Drawing.Point(14, 542);
            SizeTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SizeTxtb.Name = "SizeTxtb";
            SizeTxtb.Size = new System.Drawing.Size(104, 23);
            SizeTxtb.TabIndex = 2;
            SizeTxtb.Text = "0,00 Mb";
            // 
            // DateTxtb
            // 
            DateTxtb.Location = new System.Drawing.Point(126, 542);
            DateTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DateTxtb.Name = "DateTxtb";
            DateTxtb.Size = new System.Drawing.Size(237, 23);
            DateTxtb.TabIndex = 3;
            DateTxtb.Text = "File Date";
            // 
            // RateTxtb
            // 
            RateTxtb.Location = new System.Drawing.Point(14, 572);
            RateTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RateTxtb.Name = "RateTxtb";
            RateTxtb.Size = new System.Drawing.Size(104, 23);
            RateTxtb.TabIndex = 4;
            RateTxtb.Text = "0000 kbps";
            // 
            // SampleTxtb
            // 
            SampleTxtb.Location = new System.Drawing.Point(14, 602);
            SampleTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SampleTxtb.Name = "SampleTxtb";
            SampleTxtb.Size = new System.Drawing.Size(104, 23);
            SampleTxtb.TabIndex = 5;
            SampleTxtb.Text = "00.000 kHz";
            // 
            // DurationTxtb
            // 
            DurationTxtb.Location = new System.Drawing.Point(14, 632);
            DurationTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DurationTxtb.Name = "DurationTxtb";
            DurationTxtb.Size = new System.Drawing.Size(104, 23);
            DurationTxtb.TabIndex = 6;
            DurationTxtb.Text = "00:00:00 H, M, S";
            // 
            // TitleTxtb
            // 
            TitleTxtb.Location = new System.Drawing.Point(371, 542);
            TitleTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TitleTxtb.Name = "TitleTxtb";
            TitleTxtb.Size = new System.Drawing.Size(548, 23);
            TitleTxtb.TabIndex = 7;
            TitleTxtb.Text = "Title";
            // 
            // GenreTxtb
            // 
            GenreTxtb.Location = new System.Drawing.Point(126, 572);
            GenreTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GenreTxtb.Name = "GenreTxtb";
            GenreTxtb.Size = new System.Drawing.Size(237, 23);
            GenreTxtb.TabIndex = 8;
            GenreTxtb.Text = "Genre";
            // 
            // AlbumTxtb
            // 
            AlbumTxtb.Location = new System.Drawing.Point(371, 572);
            AlbumTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AlbumTxtb.Name = "AlbumTxtb";
            AlbumTxtb.Size = new System.Drawing.Size(548, 23);
            AlbumTxtb.TabIndex = 9;
            AlbumTxtb.Text = "Album";
            // 
            // YearTxtb
            // 
            YearTxtb.Location = new System.Drawing.Point(14, 662);
            YearTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            YearTxtb.Name = "YearTxtb";
            YearTxtb.Size = new System.Drawing.Size(104, 23);
            YearTxtb.TabIndex = 10;
            YearTxtb.Text = "Year";
            // 
            // NumberTxtb
            // 
            NumberTxtb.Location = new System.Drawing.Point(14, 693);
            NumberTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumberTxtb.Name = "NumberTxtb";
            NumberTxtb.Size = new System.Drawing.Size(104, 23);
            NumberTxtb.TabIndex = 11;
            NumberTxtb.Text = "Song nbr.";
            // 
            // ArtistTxtb
            // 
            ArtistTxtb.Location = new System.Drawing.Point(126, 602);
            ArtistTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ArtistTxtb.Name = "ArtistTxtb";
            ArtistTxtb.Size = new System.Drawing.Size(237, 23);
            ArtistTxtb.TabIndex = 12;
            ArtistTxtb.Text = "Artist";
            // 
            // BeatsTxtb
            // 
            BeatsTxtb.Location = new System.Drawing.Point(14, 723);
            BeatsTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BeatsTxtb.Name = "BeatsTxtb";
            BeatsTxtb.Size = new System.Drawing.Size(104, 23);
            BeatsTxtb.TabIndex = 13;
            BeatsTxtb.Text = "Bpm";
            // 
            // PlayBtn
            // 
            PlayBtn.Location = new System.Drawing.Point(371, 602);
            PlayBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new System.Drawing.Size(181, 53);
            PlayBtn.TabIndex = 14;
            PlayBtn.Text = "Play / Pause";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // RandomBtn
            // 
            RandomBtn.Location = new System.Drawing.Point(559, 602);
            RandomBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Size = new System.Drawing.Size(170, 53);
            RandomBtn.TabIndex = 15;
            RandomBtn.Text = "Random Osu Song";
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // SkipBtn
            // 
            SkipBtn.Location = new System.Drawing.Point(736, 602);
            SkipBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SkipBtn.Name = "SkipBtn";
            SkipBtn.Size = new System.Drawing.Size(183, 53);
            SkipBtn.TabIndex = 16;
            SkipBtn.Text = "Skip / Next";
            SkipBtn.UseVisualStyleBackColor = true;
            SkipBtn.Click += SkipBtn_Click;
            // 
            // PublisherTxtb
            // 
            PublisherTxtb.Location = new System.Drawing.Point(126, 632);
            PublisherTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PublisherTxtb.Name = "PublisherTxtb";
            PublisherTxtb.Size = new System.Drawing.Size(237, 23);
            PublisherTxtb.TabIndex = 17;
            PublisherTxtb.Text = "Publisher";
            // 
            // trackBar1
            // 
            trackBar1.AllowDrop = true;
            trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            trackBar1.LargeChange = 15;
            trackBar1.Location = new System.Drawing.Point(126, 701);
            trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackBar1.Maximum = 180;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            trackBar1.Size = new System.Drawing.Size(793, 45);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 18;
            // 
            // RightTxtb
            // 
            RightTxtb.Location = new System.Drawing.Point(126, 662);
            RightTxtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RightTxtb.Name = "RightTxtb";
            RightTxtb.Size = new System.Drawing.Size(237, 23);
            RightTxtb.TabIndex = 19;
            RightTxtb.Text = "Copyright";
            // 
            // LoopChb
            // 
            LoopChb.AutoSize = true;
            LoopChb.Location = new System.Drawing.Point(371, 668);
            LoopChb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LoopChb.Name = "LoopChb";
            LoopChb.Size = new System.Drawing.Size(62, 19);
            LoopChb.TabIndex = 20;
            LoopChb.Text = "Repeat";
            LoopChb.UseVisualStyleBackColor = true;
            LoopChb.CheckStateChanged += LoopChb_CheckStateChanged;
            // 
            // AutoChb
            // 
            AutoChb.AutoSize = true;
            AutoChb.Checked = true;
            AutoChb.CheckState = System.Windows.Forms.CheckState.Checked;
            AutoChb.Location = new System.Drawing.Point(469, 668);
            AutoChb.Name = "AutoChb";
            AutoChb.Size = new System.Drawing.Size(74, 19);
            AutoChb.TabIndex = 21;
            AutoChb.Text = "Autoplay";
            AutoChb.UseVisualStyleBackColor = true;
            AutoChb.CheckStateChanged += AutoChb_CheckStateChanged;
            // 
            // VolumeBar
            // 
            VolumeBar.Location = new System.Drawing.Point(736, 661);
            VolumeBar.Maximum = 100;
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new System.Drawing.Size(183, 45);
            VolumeBar.TabIndex = 22;
            VolumeBar.Value = 75;
            VolumeBar.ValueChanged += VolumeBar_ValueChanged;
            // 
            // FolderCmb
            // 
            FolderCmb.AllowDrop = true;
            FolderCmb.DropDownHeight = 1;
            FolderCmb.DropDownWidth = 1;
            FolderCmb.FormattingEnabled = true;
            FolderCmb.IntegralHeight = false;
            FolderCmb.Location = new System.Drawing.Point(559, 664);
            FolderCmb.Name = "FolderCmb";
            FolderCmb.Size = new System.Drawing.Size(170, 23);
            FolderCmb.TabIndex = 23;
            FolderCmb.DropDown += comboBox1_DropDown;
            FolderCmb.DragDrop += FolderCmb_DragDrop;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 752);
            Controls.Add(FolderCmb);
            Controls.Add(VolumeBar);
            Controls.Add(AutoChb);
            Controls.Add(LoopChb);
            Controls.Add(RightTxtb);
            Controls.Add(trackBar1);
            Controls.Add(PublisherTxtb);
            Controls.Add(SkipBtn);
            Controls.Add(RandomBtn);
            Controls.Add(PlayBtn);
            Controls.Add(BeatsTxtb);
            Controls.Add(ArtistTxtb);
            Controls.Add(NumberTxtb);
            Controls.Add(YearTxtb);
            Controls.Add(AlbumTxtb);
            Controls.Add(GenreTxtb);
            Controls.Add(TitleTxtb);
            Controls.Add(DurationTxtb);
            Controls.Add(SampleTxtb);
            Controls.Add(RateTxtb);
            Controls.Add(DateTxtb);
            Controls.Add(SizeTxtb);
            Controls.Add(PathTxtb);
            Controls.Add(pB1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.TextBox PathTxtb;
        private System.Windows.Forms.TextBox SizeTxtb;
        private System.Windows.Forms.TextBox DateTxtb;
        private System.Windows.Forms.TextBox RateTxtb;
        private System.Windows.Forms.TextBox SampleTxtb;
        private System.Windows.Forms.TextBox DurationTxtb;
        private System.Windows.Forms.TextBox TitleTxtb;
        private System.Windows.Forms.TextBox GenreTxtb;
        private System.Windows.Forms.TextBox AlbumTxtb;
        private System.Windows.Forms.TextBox YearTxtb;
        private System.Windows.Forms.TextBox NumberTxtb;
        private System.Windows.Forms.TextBox ArtistTxtb;
        private System.Windows.Forms.TextBox BeatsTxtb;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.TextBox PublisherTxtb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox RightTxtb;
        private System.Windows.Forms.CheckBox LoopChb;
        private System.Windows.Forms.CheckBox AutoChb;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.ComboBox FolderCmb;
    }
}

