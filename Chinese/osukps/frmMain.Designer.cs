﻿namespace osukps {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pnlKeys = new System.Windows.Forms.Panel();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblKps = new System.Windows.Forms.Label();
			this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.buttonCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.tmiEditKpsColors = new System.Windows.Forms.ToolStripMenuItem();
			this.tmiEditGlobalInactiveColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tmiEditGlobalActiveColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsiReset = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiResetKeys = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.startStopRecHotkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsStartStopRecording = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsPlaybackRecording = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveKeySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.loadKeySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noConfigurationsFoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tmrProcess = new System.Windows.Forms.Timer(this.components);
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.tmiEditBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tmiEditForeColor = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlInfo.SuspendLayout();
			this.cms.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlKeys
			// 
			this.pnlKeys.AutoSize = true;
			this.pnlKeys.BackColor = System.Drawing.Color.Black;
			this.pnlKeys.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlKeys.Location = new System.Drawing.Point(0, 0);
			this.pnlKeys.Name = "pnlKeys";
			this.pnlKeys.Size = new System.Drawing.Size(0, 36);
			this.pnlKeys.TabIndex = 0;
			// 
			// pnlInfo
			// 
			this.pnlInfo.AutoSize = true;
			this.pnlInfo.BackColor = System.Drawing.Color.Black;
			this.pnlInfo.Controls.Add(this.lblTotal);
			this.pnlInfo.Controls.Add(this.lblKps);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.MinimumSize = new System.Drawing.Size(55, 36);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(55, 36);
			this.pnlInfo.TabIndex = 1;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(0, 18);
			this.lblTotal.MinimumSize = new System.Drawing.Size(0, 18);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(16, 18);
			this.lblTotal.TabIndex = 1;
			this.lblTotal.Text = "0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblKps
			// 
			this.lblKps.AutoSize = true;
			this.lblKps.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKps.ForeColor = System.Drawing.Color.White;
			this.lblKps.Location = new System.Drawing.Point(0, 0);
			this.lblKps.MinimumSize = new System.Drawing.Size(0, 18);
			this.lblKps.Name = "lblKps";
			this.lblKps.Size = new System.Drawing.Size(42, 18);
			this.lblKps.TabIndex = 0;
			this.lblKps.Text = "0 kps";
			this.lblKps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cms
			// 
			this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCountToolStripMenuItem,
            this.hideButtonsToolStripMenuItem,
            this.toolStripSeparator7,
            this.tmiEditKpsColors,
            this.tmiEditBackColor,
            this.tmiEditForeColor,
            this.tmiEditGlobalInactiveColor,
            this.tmiEditGlobalActiveColor,
            this.toolStripSeparator2,
            this.tsiReset,
            this.toolStripSeparator1,
            this.startStopRecHotkeyToolStripMenuItem,
            this.cmsStartStopRecording,
            this.cmsPlaybackRecording,
            this.toolStripSeparator3,
            this.saveKeySettingsToolStripMenuItem,
            this.loadKeySetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.settingsToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.resetFontToolStripMenuItem,
            this.toolStripSeparator4,
            this.tsiAbout,
            this.tsiExit});
			this.cms.Name = "cms";
			this.cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.cms.ShowImageMargin = false;
			this.cms.Size = new System.Drawing.Size(165, 458);
			this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
			// 
			// buttonCountToolStripMenuItem
			// 
			this.buttonCountToolStripMenuItem.Name = "buttonCountToolStripMenuItem";
			this.buttonCountToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.buttonCountToolStripMenuItem.Text = "按键数量";
			// 
			// hideButtonsToolStripMenuItem
			// 
			this.hideButtonsToolStripMenuItem.Name = "hideButtonsToolStripMenuItem";
			this.hideButtonsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.hideButtonsToolStripMenuItem.Text = "隐藏按键";
			this.hideButtonsToolStripMenuItem.Click += new System.EventHandler(this.hideButtonsToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
			// 
			// tmiEditKpsColors
			// 
			this.tmiEditKpsColors.Name = "tmiEditKpsColors";
			this.tmiEditKpsColors.Size = new System.Drawing.Size(164, 22);
			this.tmiEditKpsColors.Text = "修改 KPS 颜色";
			this.tmiEditKpsColors.Click += new System.EventHandler(this.tmiEditKpsColors_Click);
			// 
			// tmiEditGlobalInactiveColor
			// 
			this.tmiEditGlobalInactiveColor.Name = "tmiEditGlobalInactiveColor";
			this.tmiEditGlobalInactiveColor.Size = new System.Drawing.Size(164, 22);
			this.tmiEditGlobalInactiveColor.Text = "修改全局未按下键时颜色";
			this.tmiEditGlobalInactiveColor.Click += new System.EventHandler(this.tmiEditGlobalInactiveColor_Click);
			// 
			// tmiEditGlobalActiveColor
			// 
			this.tmiEditGlobalActiveColor.Name = "tmiEditGlobalActiveColor";
			this.tmiEditGlobalActiveColor.Size = new System.Drawing.Size(164, 22);
			this.tmiEditGlobalActiveColor.Text = "修改全局按下键时颜色";
			this.tmiEditGlobalActiveColor.Click += new System.EventHandler(this.tmiEditGlobalActiveColor_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
			// 
			// tsiReset
			// 
			this.tsiReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiResetKeys,
            this.resetToolStripMenuItem,
            this.resetAllToolStripMenuItem});
			this.tsiReset.Name = "tsiReset";
			this.tsiReset.Size = new System.Drawing.Size(164, 22);
			this.tsiReset.Text = "重置";
			// 
			// tsiResetKeys
			// 
			this.tsiResetKeys.Name = "tsiResetKeys";
			this.tsiResetKeys.Size = new System.Drawing.Size(123, 22);
			this.tsiResetKeys.Text = "总按下次数";
			this.tsiResetKeys.Click += new System.EventHandler(this.tsiResetKeys_Click);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.resetToolStripMenuItem.Text = "最大 KPS";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.tsiResetMaxKPS_Click);
			// 
			// resetAllToolStripMenuItem
			// 
			this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
			this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.resetAllToolStripMenuItem.Text = "两者";
			this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.tsiResetBoth_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
			// 
			// startStopRecHotkeyToolStripMenuItem
			// 
			this.startStopRecHotkeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disabledToolStripMenuItem});
			this.startStopRecHotkeyToolStripMenuItem.Name = "startStopRecHotkeyToolStripMenuItem";
			this.startStopRecHotkeyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.startStopRecHotkeyToolStripMenuItem.Text = "开始/停止录制的热键";
			// 
			// disabledToolStripMenuItem
			// 
			this.disabledToolStripMenuItem.Checked = true;
			this.disabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
			this.disabledToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.disabledToolStripMenuItem.Tag = 0;
			this.disabledToolStripMenuItem.Text = "无";
			this.disabledToolStripMenuItem.Click += new System.EventHandler(this.SSRHotkey_Click);
			// 
			// cmsStartStopRecording
			// 
			this.cmsStartStopRecording.Name = "cmsStartStopRecording";
			this.cmsStartStopRecording.Size = new System.Drawing.Size(164, 22);
			this.cmsStartStopRecording.Text = "开始录制";
			this.cmsStartStopRecording.Click += new System.EventHandler(this.cmsStartStopRecording_Click);
			// 
			// cmsPlaybackRecording
			// 
			this.cmsPlaybackRecording.Name = "cmsPlaybackRecording";
			this.cmsPlaybackRecording.Size = new System.Drawing.Size(164, 22);
			this.cmsPlaybackRecording.Text = "播放录制";
			this.cmsPlaybackRecording.Click += new System.EventHandler(this.cmsPlaybackRecording_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
			// 
			// saveKeySettingsToolStripMenuItem
			// 
			this.saveKeySettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConfigurationToolStripMenuItem,
            this.currentConfigurationToolStripMenuItem,
            this.toolStripSeparator6});
			this.saveKeySettingsToolStripMenuItem.Name = "saveKeySettingsToolStripMenuItem";
			this.saveKeySettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.saveKeySettingsToolStripMenuItem.Text = "保存按键设置";
			this.saveKeySettingsToolStripMenuItem.Click += new System.EventHandler(this.saveKeySettingsToolStripMenuItem_Click);
			// 
			// newConfigurationToolStripMenuItem
			// 
			this.newConfigurationToolStripMenuItem.Name = "newConfigurationToolStripMenuItem";
			this.newConfigurationToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.newConfigurationToolStripMenuItem.Text = "(保存为一个新的配置文件)";
			this.newConfigurationToolStripMenuItem.Click += new System.EventHandler(this.newConfigurationToolStripMenuItem_Click);
			// 
			// currentConfigurationToolStripMenuItem
			// 
			this.currentConfigurationToolStripMenuItem.Name = "currentConfigurationToolStripMenuItem";
			this.currentConfigurationToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.currentConfigurationToolStripMenuItem.Text = "osukps.ini";// 默认
			this.currentConfigurationToolStripMenuItem.Click += new System.EventHandler(this.currentConfigurationToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(205, 6);
			// 
			// loadKeySetupToolStripMenuItem
			// 
			this.loadKeySetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noConfigurationsFoundToolStripMenuItem});
			this.loadKeySetupToolStripMenuItem.Name = "loadKeySetupToolStripMenuItem";
			this.loadKeySetupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.loadKeySetupToolStripMenuItem.Text = "加载按键设置";
			this.loadKeySetupToolStripMenuItem.Click += new System.EventHandler(this.loadKeySetupToolStripMenuItem_Click);
			// 
			// noConfigurationsFoundToolStripMenuItem
			// 
			this.noConfigurationsFoundToolStripMenuItem.Enabled = false;
			this.noConfigurationsFoundToolStripMenuItem.Name = "noConfigurationsFoundToolStripMenuItem";
			this.noConfigurationsFoundToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.noConfigurationsFoundToolStripMenuItem.Text = "(未找到配置文件)";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.settingsToolStripMenuItem.Text = "Settings(Not Working)";// 未找到用途
			this.settingsToolStripMenuItem.Visible = false;
			// 
			// changeFontToolStripMenuItem
			// 
			this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
			this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.changeFontToolStripMenuItem.Text = "修改字体";
			this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
			// 
			// resetFontToolStripMenuItem
			// 
			this.resetFontToolStripMenuItem.Name = "resetFontToolStripMenuItem";
			this.resetFontToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.resetFontToolStripMenuItem.Text = "重置字体";
			this.resetFontToolStripMenuItem.Click += new System.EventHandler(this.resetFontToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
			// 
			// tsiAbout
			// 
			this.tsiAbout.Name = "tsiAbout";
			this.tsiAbout.Size = new System.Drawing.Size(164, 22);
			this.tsiAbout.Text = "关于";
			this.tsiAbout.Click += new System.EventHandler(this.tsiAbout_Click);
			// 
			// tsiExit
			// 
			this.tsiExit.Name = "tsiExit";
			this.tsiExit.Size = new System.Drawing.Size(164, 22);
			this.tsiExit.Text = "&退出";
			this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
			// 
			// tmrProcess
			// 
			this.tmrProcess.Enabled = true;
			this.tmrProcess.Interval = 2;
			this.tmrProcess.Tick += new System.EventHandler(this.tmrProcess_Tick);
			// 
			// tmiEditBackColor
			// 
			this.tmiEditBackColor.Name = "tmiEditBackColor";
			this.tmiEditBackColor.Size = new System.Drawing.Size(164, 22);
			this.tmiEditBackColor.Text = "编辑背景颜色";
			this.tmiEditBackColor.Click += new System.EventHandler(this.tmiEditBackColor_Click);
			// 
			// tmiEditForeColor
			// 
			this.tmiEditForeColor.Name = "tmiEditForeColor";
			this.tmiEditForeColor.Size = new System.Drawing.Size(164, 22);
			this.tmiEditForeColor.Text = "编辑字体颜色";
			this.tmiEditForeColor.Click += new System.EventHandler(this.tmiEditForeColor_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Magenta;
			this.ClientSize = new System.Drawing.Size(139, 36);
			this.ContextMenuStrip = this.cms;
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pnlKeys);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(0, 36);
			this.Name = "frmMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "osukps";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.cms.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlKeys;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblKps;
		private System.Windows.Forms.ContextMenuStrip cms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsiExit;
		private System.Windows.Forms.ToolStripMenuItem tsiResetKeys;
		private System.Windows.Forms.Timer tmrProcess;
		private System.Windows.Forms.ToolStripMenuItem saveKeySettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadKeySetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tmiEditGlobalInactiveColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tmiEditGlobalActiveColor;
		private System.Windows.Forms.ToolStripMenuItem buttonCountToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cmsStartStopRecording;
		private System.Windows.Forms.ToolStripMenuItem cmsPlaybackRecording;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem startStopRecHotkeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsiAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem newConfigurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem currentConfigurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem noConfigurationsFoundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideButtonsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem tmiEditKpsColors;
		private System.Windows.Forms.ToolStripMenuItem tsiReset;
		private System.Windows.Forms.ToolStripMenuItem tmiEditBackColor;
		private System.Windows.Forms.ToolStripMenuItem tmiEditForeColor;
	}
}