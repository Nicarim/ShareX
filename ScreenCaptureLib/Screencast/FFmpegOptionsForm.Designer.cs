﻿namespace ScreenCaptureLib
{
    partial class FFmpegOptionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFmpegOptionsForm));
            this.lblExt = new System.Windows.Forms.Label();
            this.lblX264CRF = new System.Windows.Forms.Label();
            this.nudx264CRF = new System.Windows.Forms.NumericUpDown();
            this.tpFFmpeg = new System.Windows.Forms.ToolTip(this.components);
            this.nudQscale = new System.Windows.Forms.NumericUpDown();
            this.nudVPxCRF = new System.Windows.Forms.NumericUpDown();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.lblCodec = new System.Windows.Forms.Label();
            this.cboVideoCodec = new System.Windows.Forms.ComboBox();
            this.cbPreset = new System.Windows.Forms.ComboBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.lblQscale = new System.Windows.Forms.Label();
            this.gbFFmpegExe = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnFFmpegBrowse = new System.Windows.Forms.Button();
            this.tbFFmpegPath = new System.Windows.Forms.TextBox();
            this.gbCommandLinePreview = new System.Windows.Forms.GroupBox();
            this.tbCommandLinePreview = new System.Windows.Forms.TextBox();
            this.gbCommandLineArgs = new System.Windows.Forms.GroupBox();
            this.btnFFmpegHelp = new System.Windows.Forms.Button();
            this.tbUserArgs = new System.Windows.Forms.TextBox();
            this.tcFFmpegVideoCodecs = new System.Windows.Forms.TabControl();
            this.tpX264 = new System.Windows.Forms.TabPage();
            this.tpVpx = new System.Windows.Forms.TabPage();
            this.lblVpxCRF = new System.Windows.Forms.Label();
            this.tpXvid = new System.Windows.Forms.TabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCopyPreview = new System.Windows.Forms.Button();
            this.tcFFmpegAudioCodecs = new System.Windows.Forms.TabControl();
            this.tpVorbis = new System.Windows.Forms.TabPage();
            this.tpMP3 = new System.Windows.Forms.TabPage();
            this.cboVideoSource = new System.Windows.Forms.ComboBox();
            this.lblVideoSource = new System.Windows.Forms.Label();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboAudioCodec = new System.Windows.Forms.ComboBox();
            this.lblAudioCodec = new System.Windows.Forms.Label();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.gbCodecs = new System.Windows.Forms.GroupBox();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.btnRefreshSources = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudx264CRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVPxCRF)).BeginInit();
            this.gbFFmpegExe.SuspendLayout();
            this.gbCommandLinePreview.SuspendLayout();
            this.gbCommandLineArgs.SuspendLayout();
            this.tcFFmpegVideoCodecs.SuspendLayout();
            this.tpX264.SuspendLayout();
            this.tpVpx.SuspendLayout();
            this.tpXvid.SuspendLayout();
            this.tcFFmpegAudioCodecs.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbCodecs.SuspendLayout();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(8, 26);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(56, 13);
            this.lblExt.TabIndex = 2;
            this.lblExt.Text = "Extension:";
            // 
            // lblX264CRF
            // 
            this.lblX264CRF.AutoSize = true;
            this.lblX264CRF.Location = new System.Drawing.Point(16, 16);
            this.lblX264CRF.Name = "lblX264CRF";
            this.lblX264CRF.Size = new System.Drawing.Size(31, 13);
            this.lblX264CRF.TabIndex = 0;
            this.lblX264CRF.Text = "CRF:";
            // 
            // nudx264CRF
            // 
            this.nudx264CRF.Location = new System.Drawing.Point(56, 12);
            this.nudx264CRF.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.nudx264CRF.Name = "nudx264CRF";
            this.nudx264CRF.Size = new System.Drawing.Size(48, 20);
            this.nudx264CRF.TabIndex = 1;
            this.nudx264CRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpFFmpeg.SetToolTip(this.nudx264CRF, resources.GetString("nudx264CRF.ToolTip"));
            this.nudx264CRF.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudx264CRF.ValueChanged += new System.EventHandler(this.nudx264CRF_ValueChanged);
            // 
            // tpFFmpeg
            // 
            this.tpFFmpeg.AutoPopDelay = 30000;
            this.tpFFmpeg.InitialDelay = 500;
            this.tpFFmpeg.IsBalloon = true;
            this.tpFFmpeg.ReshowDelay = 100;
            this.tpFFmpeg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tpFFmpeg.ToolTipTitle = "FFmpeg";
            // 
            // nudQscale
            // 
            this.nudQscale.Location = new System.Drawing.Point(104, 12);
            this.nudQscale.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudQscale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQscale.Name = "nudQscale";
            this.nudQscale.Size = new System.Drawing.Size(48, 20);
            this.nudQscale.TabIndex = 1;
            this.nudQscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpFFmpeg.SetToolTip(this.nudQscale, "1 being highest quality/largest filesize and 31 being the lowest quality/smallest" +
        " filesize.");
            this.nudQscale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudQscale.ValueChanged += new System.EventHandler(this.nudQscale_ValueChanged);
            // 
            // nudVPxCRF
            // 
            this.nudVPxCRF.Location = new System.Drawing.Point(56, 12);
            this.nudVPxCRF.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudVPxCRF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVPxCRF.Name = "nudVPxCRF";
            this.nudVPxCRF.Size = new System.Drawing.Size(48, 20);
            this.nudVPxCRF.TabIndex = 1;
            this.nudVPxCRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpFFmpeg.SetToolTip(this.nudVPxCRF, "CRF value can be from 4–63, and 10 is a good starting point. Lower values mean be" +
        "tter quality. ");
            this.nudVPxCRF.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudVPxCRF.ValueChanged += new System.EventHandler(this.nudVPxCRF_ValueChanged);
            // 
            // cbExtension
            // 
            this.cbExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(72, 22);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(88, 21);
            this.cbExtension.TabIndex = 3;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // lblCodec
            // 
            this.lblCodec.AutoSize = true;
            this.lblCodec.Location = new System.Drawing.Point(8, 26);
            this.lblCodec.Name = "lblCodec";
            this.lblCodec.Size = new System.Drawing.Size(70, 13);
            this.lblCodec.TabIndex = 0;
            this.lblCodec.Text = "Video codec:";
            // 
            // cboVideoCodec
            // 
            this.cboVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoCodec.FormattingEnabled = true;
            this.cboVideoCodec.Location = new System.Drawing.Point(88, 22);
            this.cboVideoCodec.Name = "cboVideoCodec";
            this.cboVideoCodec.Size = new System.Drawing.Size(136, 21);
            this.cboVideoCodec.TabIndex = 1;
            this.cboVideoCodec.SelectedIndexChanged += new System.EventHandler(this.cboVideoCodec_SelectedIndexChanged);
            // 
            // cbPreset
            // 
            this.cbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreset.FormattingEnabled = true;
            this.cbPreset.Location = new System.Drawing.Point(168, 12);
            this.cbPreset.Name = "cbPreset";
            this.cbPreset.Size = new System.Drawing.Size(121, 21);
            this.cbPreset.TabIndex = 3;
            this.cbPreset.SelectedIndexChanged += new System.EventHandler(this.cbPreset_SelectedIndexChanged);
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(120, 16);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(40, 13);
            this.lblPreset.TabIndex = 2;
            this.lblPreset.Text = "Preset:";
            // 
            // lblQscale
            // 
            this.lblQscale.AutoSize = true;
            this.lblQscale.Location = new System.Drawing.Point(16, 16);
            this.lblQscale.Name = "lblQscale";
            this.lblQscale.Size = new System.Drawing.Size(83, 13);
            this.lblQscale.TabIndex = 0;
            this.lblQscale.Text = "Variable bit rate:";
            // 
            // gbFFmpegExe
            // 
            this.gbFFmpegExe.Controls.Add(this.btnDownload);
            this.gbFFmpegExe.Controls.Add(this.btnFFmpegBrowse);
            this.gbFFmpegExe.Controls.Add(this.tbFFmpegPath);
            this.gbFFmpegExe.Location = new System.Drawing.Point(8, 200);
            this.gbFFmpegExe.Name = "gbFFmpegExe";
            this.gbFFmpegExe.Size = new System.Drawing.Size(648, 56);
            this.gbFFmpegExe.TabIndex = 5;
            this.gbFFmpegExe.TabStop = false;
            this.gbFFmpegExe.Text = "ffmpeg.exe";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(568, 22);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(72, 24);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnFFmpegBrowse
            // 
            this.btnFFmpegBrowse.Location = new System.Drawing.Point(520, 22);
            this.btnFFmpegBrowse.Name = "btnFFmpegBrowse";
            this.btnFFmpegBrowse.Size = new System.Drawing.Size(40, 24);
            this.btnFFmpegBrowse.TabIndex = 1;
            this.btnFFmpegBrowse.Text = "...";
            this.btnFFmpegBrowse.UseVisualStyleBackColor = true;
            this.btnFFmpegBrowse.Click += new System.EventHandler(this.buttonFFmpegBrowse_Click);
            // 
            // tbFFmpegPath
            // 
            this.tbFFmpegPath.Location = new System.Drawing.Point(8, 24);
            this.tbFFmpegPath.Name = "tbFFmpegPath";
            this.tbFFmpegPath.Size = new System.Drawing.Size(504, 20);
            this.tbFFmpegPath.TabIndex = 0;
            this.tbFFmpegPath.TextChanged += new System.EventHandler(this.tbFFmpegPath_TextChanged);
            // 
            // gbCommandLinePreview
            // 
            this.gbCommandLinePreview.Controls.Add(this.tbCommandLinePreview);
            this.gbCommandLinePreview.Location = new System.Drawing.Point(8, 328);
            this.gbCommandLinePreview.Name = "gbCommandLinePreview";
            this.gbCommandLinePreview.Padding = new System.Windows.Forms.Padding(8);
            this.gbCommandLinePreview.Size = new System.Drawing.Size(648, 134);
            this.gbCommandLinePreview.TabIndex = 9;
            this.gbCommandLinePreview.TabStop = false;
            this.gbCommandLinePreview.Text = "Command line preview";
            // 
            // tbCommandLinePreview
            // 
            this.tbCommandLinePreview.BackColor = System.Drawing.Color.White;
            this.tbCommandLinePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCommandLinePreview.Location = new System.Drawing.Point(8, 21);
            this.tbCommandLinePreview.Multiline = true;
            this.tbCommandLinePreview.Name = "tbCommandLinePreview";
            this.tbCommandLinePreview.ReadOnly = true;
            this.tbCommandLinePreview.Size = new System.Drawing.Size(632, 105);
            this.tbCommandLinePreview.TabIndex = 0;
            // 
            // gbCommandLineArgs
            // 
            this.gbCommandLineArgs.Controls.Add(this.btnFFmpegHelp);
            this.gbCommandLineArgs.Controls.Add(this.tbUserArgs);
            this.gbCommandLineArgs.Location = new System.Drawing.Point(8, 264);
            this.gbCommandLineArgs.Name = "gbCommandLineArgs";
            this.gbCommandLineArgs.Size = new System.Drawing.Size(648, 56);
            this.gbCommandLineArgs.TabIndex = 6;
            this.gbCommandLineArgs.TabStop = false;
            this.gbCommandLineArgs.Text = "Additional command line arguments";
            // 
            // btnFFmpegHelp
            // 
            this.btnFFmpegHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFFmpegHelp.Location = new System.Drawing.Point(600, 22);
            this.btnFFmpegHelp.Name = "btnFFmpegHelp";
            this.btnFFmpegHelp.Size = new System.Drawing.Size(40, 24);
            this.btnFFmpegHelp.TabIndex = 1;
            this.btnFFmpegHelp.Text = "?";
            this.btnFFmpegHelp.UseVisualStyleBackColor = true;
            this.btnFFmpegHelp.Click += new System.EventHandler(this.buttonFFmpegHelp_Click);
            // 
            // tbUserArgs
            // 
            this.tbUserArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserArgs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbUserArgs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbUserArgs.Location = new System.Drawing.Point(8, 24);
            this.tbUserArgs.Name = "tbUserArgs";
            this.tbUserArgs.Size = new System.Drawing.Size(584, 20);
            this.tbUserArgs.TabIndex = 0;
            this.tbUserArgs.TextChanged += new System.EventHandler(this.tbUserArgs_TextChanged);
            // 
            // tcFFmpegVideoCodecs
            // 
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpX264);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpVpx);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpXvid);
            this.tcFFmpegVideoCodecs.Location = new System.Drawing.Point(8, 112);
            this.tcFFmpegVideoCodecs.Name = "tcFFmpegVideoCodecs";
            this.tcFFmpegVideoCodecs.SelectedIndex = 0;
            this.tcFFmpegVideoCodecs.Size = new System.Drawing.Size(320, 72);
            this.tcFFmpegVideoCodecs.TabIndex = 4;
            // 
            // tpX264
            // 
            this.tpX264.Controls.Add(this.nudx264CRF);
            this.tpX264.Controls.Add(this.lblX264CRF);
            this.tpX264.Controls.Add(this.cbPreset);
            this.tpX264.Controls.Add(this.lblPreset);
            this.tpX264.Location = new System.Drawing.Point(4, 22);
            this.tpX264.Name = "tpX264";
            this.tpX264.Padding = new System.Windows.Forms.Padding(3);
            this.tpX264.Size = new System.Drawing.Size(312, 46);
            this.tpX264.TabIndex = 1;
            this.tpX264.Text = "x264";
            this.tpX264.UseVisualStyleBackColor = true;
            // 
            // tpVpx
            // 
            this.tpVpx.Controls.Add(this.nudVPxCRF);
            this.tpVpx.Controls.Add(this.lblVpxCRF);
            this.tpVpx.Location = new System.Drawing.Point(4, 22);
            this.tpVpx.Name = "tpVpx";
            this.tpVpx.Size = new System.Drawing.Size(312, 46);
            this.tpVpx.TabIndex = 2;
            this.tpVpx.Text = "VP8";
            this.tpVpx.UseVisualStyleBackColor = true;
            // 
            // lblVpxCRF
            // 
            this.lblVpxCRF.AutoSize = true;
            this.lblVpxCRF.Location = new System.Drawing.Point(16, 16);
            this.lblVpxCRF.Name = "lblVpxCRF";
            this.lblVpxCRF.Size = new System.Drawing.Size(31, 13);
            this.lblVpxCRF.TabIndex = 0;
            this.lblVpxCRF.Text = "CRF:";
            // 
            // tpXvid
            // 
            this.tpXvid.Controls.Add(this.nudQscale);
            this.tpXvid.Controls.Add(this.lblQscale);
            this.tpXvid.Location = new System.Drawing.Point(4, 22);
            this.tpXvid.Name = "tpXvid";
            this.tpXvid.Size = new System.Drawing.Size(312, 46);
            this.tpXvid.TabIndex = 3;
            this.tpXvid.Text = "XviD";
            this.tpXvid.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(136, 323);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test with CMD";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCopyPreview
            // 
            this.btnCopyPreview.Location = new System.Drawing.Point(227, 323);
            this.btnCopyPreview.Name = "btnCopyPreview";
            this.btnCopyPreview.Size = new System.Drawing.Size(53, 23);
            this.btnCopyPreview.TabIndex = 8;
            this.btnCopyPreview.Text = "Copy";
            this.btnCopyPreview.UseVisualStyleBackColor = true;
            this.btnCopyPreview.Click += new System.EventHandler(this.btnCopyPreview_Click);
            // 
            // tcFFmpegAudioCodecs
            // 
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpVorbis);
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpMP3);
            this.tcFFmpegAudioCodecs.Location = new System.Drawing.Point(336, 112);
            this.tcFFmpegAudioCodecs.Name = "tcFFmpegAudioCodecs";
            this.tcFFmpegAudioCodecs.SelectedIndex = 0;
            this.tcFFmpegAudioCodecs.Size = new System.Drawing.Size(320, 72);
            this.tcFFmpegAudioCodecs.TabIndex = 10;
            // 
            // tpVorbis
            // 
            this.tpVorbis.Location = new System.Drawing.Point(4, 22);
            this.tpVorbis.Name = "tpVorbis";
            this.tpVorbis.Padding = new System.Windows.Forms.Padding(3);
            this.tpVorbis.Size = new System.Drawing.Size(312, 46);
            this.tpVorbis.TabIndex = 0;
            this.tpVorbis.Text = "Vorbis";
            this.tpVorbis.UseVisualStyleBackColor = true;
            // 
            // tpMP3
            // 
            this.tpMP3.Location = new System.Drawing.Point(4, 22);
            this.tpMP3.Name = "tpMP3";
            this.tpMP3.Size = new System.Drawing.Size(312, 46);
            this.tpMP3.TabIndex = 2;
            this.tpMP3.Text = "MP3";
            this.tpMP3.UseVisualStyleBackColor = true;
            // 
            // cboVideoSource
            // 
            this.cboVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoSource.FormattingEnabled = true;
            this.cboVideoSource.Location = new System.Drawing.Point(88, 22);
            this.cboVideoSource.Name = "cboVideoSource";
            this.cboVideoSource.Size = new System.Drawing.Size(136, 21);
            this.cboVideoSource.TabIndex = 12;
            this.cboVideoSource.SelectedIndexChanged += new System.EventHandler(this.cboVideoSource_SelectedIndexChanged);
            // 
            // lblVideoSource
            // 
            this.lblVideoSource.AutoSize = true;
            this.lblVideoSource.Location = new System.Drawing.Point(8, 26);
            this.lblVideoSource.Name = "lblVideoSource";
            this.lblVideoSource.Size = new System.Drawing.Size(72, 13);
            this.lblVideoSource.TabIndex = 11;
            this.lblVideoSource.Text = "Video source:";
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(88, 52);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(136, 21);
            this.cboAudioSource.TabIndex = 14;
            this.cboAudioSource.SelectedIndexChanged += new System.EventHandler(this.cboAudioSource_SelectedIndexChanged);
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Location = new System.Drawing.Point(8, 56);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(72, 13);
            this.lblAudioSource.TabIndex = 13;
            this.lblAudioSource.Text = "Audio source:";
            // 
            // cboAudioCodec
            // 
            this.cboAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioCodec.FormattingEnabled = true;
            this.cboAudioCodec.Location = new System.Drawing.Point(88, 52);
            this.cboAudioCodec.Name = "cboAudioCodec";
            this.cboAudioCodec.Size = new System.Drawing.Size(136, 21);
            this.cboAudioCodec.TabIndex = 16;
            this.cboAudioCodec.SelectedIndexChanged += new System.EventHandler(this.cboAudioCodec_SelectedIndexChanged);
            // 
            // lblAudioCodec
            // 
            this.lblAudioCodec.AutoSize = true;
            this.lblAudioCodec.Location = new System.Drawing.Point(8, 56);
            this.lblAudioCodec.Name = "lblAudioCodec";
            this.lblAudioCodec.Size = new System.Drawing.Size(70, 13);
            this.lblAudioCodec.TabIndex = 15;
            this.lblAudioCodec.Text = "Audio codec:";
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.cboVideoSource);
            this.gbSource.Controls.Add(this.lblVideoSource);
            this.gbSource.Controls.Add(this.cboAudioSource);
            this.gbSource.Controls.Add(this.lblAudioSource);
            this.gbSource.Location = new System.Drawing.Point(8, 8);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(232, 88);
            this.gbSource.TabIndex = 17;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Sources";
            // 
            // gbCodecs
            // 
            this.gbCodecs.Controls.Add(this.cboAudioCodec);
            this.gbCodecs.Controls.Add(this.lblAudioCodec);
            this.gbCodecs.Controls.Add(this.cboVideoCodec);
            this.gbCodecs.Controls.Add(this.lblCodec);
            this.gbCodecs.Location = new System.Drawing.Point(248, 8);
            this.gbCodecs.Name = "gbCodecs";
            this.gbCodecs.Size = new System.Drawing.Size(232, 88);
            this.gbCodecs.TabIndex = 18;
            this.gbCodecs.TabStop = false;
            this.gbCodecs.Text = "Codecs";
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.cbExtension);
            this.gbContainer.Controls.Add(this.lblExt);
            this.gbContainer.Location = new System.Drawing.Point(488, 8);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(168, 88);
            this.gbContainer.TabIndex = 19;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Container format";
            // 
            // btnRefreshSources
            // 
            this.btnRefreshSources.Location = new System.Drawing.Point(176, 4);
            this.btnRefreshSources.Name = "btnRefreshSources";
            this.btnRefreshSources.Size = new System.Drawing.Size(56, 23);
            this.btnRefreshSources.TabIndex = 20;
            this.btnRefreshSources.Text = "Refresh";
            this.btnRefreshSources.UseVisualStyleBackColor = true;
            this.btnRefreshSources.Click += new System.EventHandler(this.btnRefreshSources_Click);
            // 
            // FFmpegOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 474);
            this.Controls.Add(this.btnRefreshSources);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.gbCodecs);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.tcFFmpegAudioCodecs);
            this.Controls.Add(this.btnCopyPreview);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tcFFmpegVideoCodecs);
            this.Controls.Add(this.gbCommandLinePreview);
            this.Controls.Add(this.gbFFmpegExe);
            this.Controls.Add(this.gbCommandLineArgs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFmpegOptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpegGUI";
            ((System.ComponentModel.ISupportInitialize)(this.nudx264CRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVPxCRF)).EndInit();
            this.gbFFmpegExe.ResumeLayout(false);
            this.gbFFmpegExe.PerformLayout();
            this.gbCommandLinePreview.ResumeLayout(false);
            this.gbCommandLinePreview.PerformLayout();
            this.gbCommandLineArgs.ResumeLayout(false);
            this.gbCommandLineArgs.PerformLayout();
            this.tcFFmpegVideoCodecs.ResumeLayout(false);
            this.tpX264.ResumeLayout(false);
            this.tpX264.PerformLayout();
            this.tpVpx.ResumeLayout(false);
            this.tpVpx.PerformLayout();
            this.tpXvid.ResumeLayout(false);
            this.tpXvid.PerformLayout();
            this.tcFFmpegAudioCodecs.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbCodecs.ResumeLayout(false);
            this.gbCodecs.PerformLayout();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Label lblX264CRF;
        private System.Windows.Forms.NumericUpDown nudx264CRF;
        private System.Windows.Forms.ToolTip tpFFmpeg;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.ComboBox cboVideoCodec;
        private System.Windows.Forms.ComboBox cbPreset;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.NumericUpDown nudQscale;
        private System.Windows.Forms.Label lblQscale;
        private System.Windows.Forms.GroupBox gbFFmpegExe;
        private System.Windows.Forms.Button btnFFmpegBrowse;
        private System.Windows.Forms.TextBox tbFFmpegPath;
        private System.Windows.Forms.GroupBox gbCommandLinePreview;
        private System.Windows.Forms.TextBox tbCommandLinePreview;
        private System.Windows.Forms.GroupBox gbCommandLineArgs;
        private System.Windows.Forms.Button btnFFmpegHelp;
        private System.Windows.Forms.TextBox tbUserArgs;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TabControl tcFFmpegVideoCodecs;
        private System.Windows.Forms.TabPage tpX264;
        private System.Windows.Forms.TabPage tpVpx;
        private System.Windows.Forms.TabPage tpXvid;
        private System.Windows.Forms.NumericUpDown nudVPxCRF;
        private System.Windows.Forms.Label lblVpxCRF;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCopyPreview;
        private System.Windows.Forms.TabControl tcFFmpegAudioCodecs;
        private System.Windows.Forms.TabPage tpVorbis;
        private System.Windows.Forms.TabPage tpMP3;
        private System.Windows.Forms.ComboBox cboVideoSource;
        private System.Windows.Forms.Label lblVideoSource;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboAudioCodec;
        private System.Windows.Forms.Label lblAudioCodec;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.GroupBox gbCodecs;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Button btnRefreshSources;
    }
}