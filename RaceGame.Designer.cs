﻿namespace Race
{
	partial class RaceGame
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
			timerRoad = new System.Windows.Forms.Timer(components);
			panelGame = new Panel();
			panelMenu = new Panel();
			buttonHelp = new Button();
			buttonMenuExit = new Button();
			buttonStart = new Button();
			label3 = new Label();
			CarMenu1 = new PictureBox();
			CarMenu3 = new PictureBox();
			CarMenu2 = new PictureBox();
			MenuTwoLane5 = new Label();
			MenuTwoLane4 = new Label();
			MenuTwoLane3 = new Label();
			MenuTwoLane2 = new Label();
			MenuTwoLane1 = new Label();
			MenuOneLane5 = new Label();
			MenuOneLane4 = new Label();
			MenuOneLane3 = new Label();
			MenuOneLane2 = new Label();
			MenuOneLane1 = new Label();
			label12 = new Label();
			panelPause = new Panel();
			buttonExit = new Button();
			buttonResume = new Button();
			pictureFlag = new PictureBox();
			labelPause = new Label();
			labelScore = new Label();
			labelCoins = new Label();
			label = new Label();
			towardCar2 = new PictureBox();
			towardCar1 = new PictureBox();
			towardCar3 = new PictureBox();
			Coin3 = new PictureBox();
			Coin2 = new PictureBox();
			Coin1 = new PictureBox();
			buttonPause = new Button();
			mainCar = new PictureBox();
			LaneTwo5 = new Label();
			LaneTwo4 = new Label();
			LaneTwo3 = new Label();
			LaneTwo2 = new Label();
			LaneTwo1 = new Label();
			LaneOne5 = new Label();
			LaneOne4 = new Label();
			LaneOne3 = new Label();
			LaneOne2 = new Label();
			LaneOne1 = new Label();
			MiddleLane = new Label();
			timerTowardCars = new System.Windows.Forms.Timer(components);
			timerMenu = new System.Windows.Forms.Timer(components);
			panelGame.SuspendLayout();
			panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CarMenu1).BeginInit();
			((System.ComponentModel.ISupportInitialize)CarMenu3).BeginInit();
			((System.ComponentModel.ISupportInitialize)CarMenu2).BeginInit();
			panelPause.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
			((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
			((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
			((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
			((System.ComponentModel.ISupportInitialize)Coin3).BeginInit();
			((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
			((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
			((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
			SuspendLayout();
			// 
			// timerRoad
			// 
			timerRoad.Enabled = true;
			timerRoad.Interval = 1;
			timerRoad.Tick += timerRoad_Tick;
			// 
			// panelGame
			// 
			panelGame.BackColor = SystemColors.ControlDarkDark;
			panelGame.Controls.Add(panelPause);
			panelGame.Controls.Add(labelScore);
			panelGame.Controls.Add(labelCoins);
			panelGame.Controls.Add(label);
			panelGame.Controls.Add(towardCar2);
			panelGame.Controls.Add(towardCar1);
			panelGame.Controls.Add(towardCar3);
			panelGame.Controls.Add(Coin3);
			panelGame.Controls.Add(Coin2);
			panelGame.Controls.Add(Coin1);
			panelGame.Controls.Add(buttonPause);
			panelGame.Controls.Add(mainCar);
			panelGame.Controls.Add(LaneTwo5);
			panelGame.Controls.Add(LaneTwo4);
			panelGame.Controls.Add(LaneTwo3);
			panelGame.Controls.Add(LaneTwo2);
			panelGame.Controls.Add(LaneTwo1);
			panelGame.Controls.Add(LaneOne5);
			panelGame.Controls.Add(LaneOne4);
			panelGame.Controls.Add(LaneOne3);
			panelGame.Controls.Add(LaneOne2);
			panelGame.Controls.Add(LaneOne1);
			panelGame.Controls.Add(MiddleLane);
			panelGame.Location = new Point(0, 0);
			panelGame.Margin = new Padding(4, 5, 4, 5);
			panelGame.Name = "panelGame";
			panelGame.Size = new Size(512, 866);
			panelGame.TabIndex = 0;
			// 
			// panelMenu
			// 
			panelMenu.BackColor = SystemColors.ControlDarkDark;
			panelMenu.Controls.Add(buttonHelp);
			panelMenu.Controls.Add(buttonMenuExit);
			panelMenu.Controls.Add(buttonStart);
			panelMenu.Controls.Add(label3);
			panelMenu.Controls.Add(CarMenu1);
			panelMenu.Controls.Add(CarMenu3);
			panelMenu.Controls.Add(CarMenu2);
			panelMenu.Controls.Add(MenuTwoLane5);
			panelMenu.Controls.Add(MenuTwoLane4);
			panelMenu.Controls.Add(MenuTwoLane3);
			panelMenu.Controls.Add(MenuTwoLane2);
			panelMenu.Controls.Add(MenuTwoLane1);
			panelMenu.Controls.Add(MenuOneLane5);
			panelMenu.Controls.Add(MenuOneLane4);
			panelMenu.Controls.Add(MenuOneLane3);
			panelMenu.Controls.Add(MenuOneLane2);
			panelMenu.Controls.Add(MenuOneLane1);
			panelMenu.Controls.Add(label12);
			panelMenu.Location = new Point(0, 0);
			panelMenu.Margin = new Padding(4, 5, 4, 5);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(515, 867);
			panelMenu.TabIndex = 57;
			// 
			// buttonHelp
			// 
			buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
			buttonHelp.Location = new Point(413, 812);
			buttonHelp.Margin = new Padding(4, 5, 4, 5);
			buttonHelp.Name = "buttonHelp";
			buttonHelp.Size = new Size(93, 49);
			buttonHelp.TabIndex = 82;
			buttonHelp.Text = "Help";
			buttonHelp.UseVisualStyleBackColor = true;
			buttonHelp.Click += buttonHelp_Click;
			// 
			// buttonMenuExit
			// 
			buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			buttonMenuExit.Location = new Point(167, 506);
			buttonMenuExit.Margin = new Padding(4, 5, 4, 5);
			buttonMenuExit.Name = "buttonMenuExit";
			buttonMenuExit.Size = new Size(176, 72);
			buttonMenuExit.TabIndex = 67;
			buttonMenuExit.Text = "Exit";
			buttonMenuExit.UseVisualStyleBackColor = true;
			buttonMenuExit.Click += buttonMenuExit_Click;
			// 
			// buttonStart
			// 
			buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			buttonStart.Location = new Point(148, 405);
			buttonStart.Margin = new Padding(4, 5, 4, 5);
			buttonStart.Name = "buttonStart";
			buttonStart.Size = new Size(213, 91);
			buttonStart.TabIndex = 65;
			buttonStart.Text = "Start";
			buttonStart.UseVisualStyleBackColor = true;
			buttonStart.Click += buttonStart_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(64, 64, 64);
			label3.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.Control;
			label3.Location = new Point(0, 0);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(481, 223);
			label3.TabIndex = 66;
			label3.Text = "Race";
			// 
			// CarMenu1
			// 
			CarMenu1.BackColor = Color.Transparent;
			CarMenu1.Image = (Image)resources.GetObject("CarMenu1.Image");
			CarMenu1.Location = new Point(16, 20);
			CarMenu1.Margin = new Padding(4, 5, 4, 5);
			CarMenu1.Name = "CarMenu1";
			CarMenu1.Size = new Size(67, 169);
			CarMenu1.SizeMode = PictureBoxSizeMode.Zoom;
			CarMenu1.TabIndex = 80;
			CarMenu1.TabStop = false;
			// 
			// CarMenu3
			// 
			CarMenu3.BackColor = Color.Transparent;
			CarMenu3.Image = (Image)resources.GetObject("CarMenu3.Image");
			CarMenu3.Location = new Point(429, 40);
			CarMenu3.Margin = new Padding(4, 5, 4, 5);
			CarMenu3.Name = "CarMenu3";
			CarMenu3.Size = new Size(67, 169);
			CarMenu3.SizeMode = PictureBoxSizeMode.Zoom;
			CarMenu3.TabIndex = 81;
			CarMenu3.TabStop = false;
			// 
			// CarMenu2
			// 
			CarMenu2.BackColor = Color.Transparent;
			CarMenu2.Image = (Image)resources.GetObject("CarMenu2.Image");
			CarMenu2.Location = new Point(172, 5);
			CarMenu2.Margin = new Padding(4, 5, 4, 5);
			CarMenu2.Name = "CarMenu2";
			CarMenu2.Size = new Size(67, 169);
			CarMenu2.SizeMode = PictureBoxSizeMode.Zoom;
			CarMenu2.TabIndex = 79;
			CarMenu2.TabStop = false;
			// 
			// MenuTwoLane5
			// 
			MenuTwoLane5.BackColor = Color.White;
			MenuTwoLane5.ForeColor = SystemColors.Control;
			MenuTwoLane5.Location = new Point(385, 797);
			MenuTwoLane5.Margin = new Padding(4, 0, 4, 0);
			MenuTwoLane5.Name = "MenuTwoLane5";
			MenuTwoLane5.Size = new Size(20, 138);
			MenuTwoLane5.TabIndex = 78;
			MenuTwoLane5.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuTwoLane4
			// 
			MenuTwoLane4.BackColor = Color.White;
			MenuTwoLane4.ForeColor = SystemColors.Control;
			MenuTwoLane4.Location = new Point(385, 582);
			MenuTwoLane4.Margin = new Padding(4, 0, 4, 0);
			MenuTwoLane4.Name = "MenuTwoLane4";
			MenuTwoLane4.Size = new Size(20, 138);
			MenuTwoLane4.TabIndex = 77;
			MenuTwoLane4.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuTwoLane3
			// 
			MenuTwoLane3.BackColor = Color.White;
			MenuTwoLane3.ForeColor = SystemColors.Control;
			MenuTwoLane3.Location = new Point(385, 366);
			MenuTwoLane3.Margin = new Padding(4, 0, 4, 0);
			MenuTwoLane3.Name = "MenuTwoLane3";
			MenuTwoLane3.Size = new Size(20, 138);
			MenuTwoLane3.TabIndex = 76;
			MenuTwoLane3.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuTwoLane2
			// 
			MenuTwoLane2.BackColor = Color.White;
			MenuTwoLane2.ForeColor = SystemColors.Control;
			MenuTwoLane2.Location = new Point(385, 151);
			MenuTwoLane2.Margin = new Padding(4, 0, 4, 0);
			MenuTwoLane2.Name = "MenuTwoLane2";
			MenuTwoLane2.Size = new Size(20, 138);
			MenuTwoLane2.TabIndex = 75;
			MenuTwoLane2.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuTwoLane1
			// 
			MenuTwoLane1.BackColor = Color.White;
			MenuTwoLane1.ForeColor = SystemColors.Control;
			MenuTwoLane1.Location = new Point(385, -65);
			MenuTwoLane1.Margin = new Padding(4, 0, 4, 0);
			MenuTwoLane1.Name = "MenuTwoLane1";
			MenuTwoLane1.Size = new Size(20, 138);
			MenuTwoLane1.TabIndex = 74;
			MenuTwoLane1.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuOneLane5
			// 
			MenuOneLane5.BackColor = Color.White;
			MenuOneLane5.ForeColor = SystemColors.Control;
			MenuOneLane5.Location = new Point(119, 797);
			MenuOneLane5.Margin = new Padding(4, 0, 4, 0);
			MenuOneLane5.Name = "MenuOneLane5";
			MenuOneLane5.Size = new Size(20, 138);
			MenuOneLane5.TabIndex = 73;
			MenuOneLane5.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuOneLane4
			// 
			MenuOneLane4.BackColor = Color.White;
			MenuOneLane4.ForeColor = SystemColors.Control;
			MenuOneLane4.Location = new Point(119, 582);
			MenuOneLane4.Margin = new Padding(4, 0, 4, 0);
			MenuOneLane4.Name = "MenuOneLane4";
			MenuOneLane4.Size = new Size(20, 138);
			MenuOneLane4.TabIndex = 72;
			MenuOneLane4.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuOneLane3
			// 
			MenuOneLane3.BackColor = Color.White;
			MenuOneLane3.ForeColor = SystemColors.Control;
			MenuOneLane3.Location = new Point(119, 366);
			MenuOneLane3.Margin = new Padding(4, 0, 4, 0);
			MenuOneLane3.Name = "MenuOneLane3";
			MenuOneLane3.Size = new Size(20, 138);
			MenuOneLane3.TabIndex = 71;
			MenuOneLane3.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuOneLane2
			// 
			MenuOneLane2.BackColor = Color.White;
			MenuOneLane2.ForeColor = SystemColors.Control;
			MenuOneLane2.Location = new Point(119, 151);
			MenuOneLane2.Margin = new Padding(4, 0, 4, 0);
			MenuOneLane2.Name = "MenuOneLane2";
			MenuOneLane2.Size = new Size(20, 138);
			MenuOneLane2.TabIndex = 70;
			MenuOneLane2.TextAlign = ContentAlignment.TopCenter;
			// 
			// MenuOneLane1
			// 
			MenuOneLane1.BackColor = Color.White;
			MenuOneLane1.ForeColor = SystemColors.Control;
			MenuOneLane1.Location = new Point(119, -65);
			MenuOneLane1.Margin = new Padding(4, 0, 4, 0);
			MenuOneLane1.Name = "MenuOneLane1";
			MenuOneLane1.Size = new Size(20, 138);
			MenuOneLane1.TabIndex = 69;
			MenuOneLane1.TextAlign = ContentAlignment.TopCenter;
			// 
			// label12
			// 
			label12.BackColor = Color.White;
			label12.ForeColor = SystemColors.Control;
			label12.Location = new Point(245, -6);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(23, 872);
			label12.TabIndex = 68;
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelPause
			// 
			panelPause.BackColor = SystemColors.ControlDarkDark;
			panelPause.Controls.Add(panelMenu);
			panelPause.Controls.Add(buttonExit);
			panelPause.Controls.Add(buttonResume);
			panelPause.Controls.Add(pictureFlag);
			panelPause.Controls.Add(labelPause);
			panelPause.Location = new Point(0, 0);
			panelPause.Margin = new Padding(4, 5, 4, 5);
			panelPause.Name = "panelPause";
			panelPause.Size = new Size(515, 872);
			panelPause.TabIndex = 57;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(159, 740);
			buttonExit.Margin = new Padding(4, 5, 4, 5);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(203, 62);
			buttonExit.TabIndex = 53;
			buttonExit.Text = "Exit";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// buttonResume
			// 
			buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
			buttonResume.Location = new Point(159, 625);
			buttonResume.Margin = new Padding(4, 5, 4, 5);
			buttonResume.Name = "buttonResume";
			buttonResume.Size = new Size(203, 89);
			buttonResume.TabIndex = 52;
			buttonResume.Text = "Resume";
			buttonResume.UseVisualStyleBackColor = true;
			buttonResume.Click += buttonResume_Click;
			// 
			// pictureFlag
			// 
			pictureFlag.BackColor = SystemColors.ControlDarkDark;
			pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
			pictureFlag.Location = new Point(-3, 166);
			pictureFlag.Margin = new Padding(4, 5, 4, 5);
			pictureFlag.Name = "pictureFlag";
			pictureFlag.Size = new Size(515, 485);
			pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
			pictureFlag.TabIndex = 55;
			pictureFlag.TabStop = false;
			// 
			// labelPause
			// 
			labelPause.AutoSize = true;
			labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
			labelPause.Location = new Point(0, 0);
			labelPause.Margin = new Padding(4, 0, 4, 0);
			labelPause.Name = "labelPause";
			labelPause.Size = new Size(528, 199);
			labelPause.TabIndex = 54;
			labelPause.Text = "Pause";
			// 
			// labelScore
			// 
			labelScore.AutoSize = true;
			labelScore.BackColor = Color.Black;
			labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
			labelScore.ForeColor = SystemColors.ButtonHighlight;
			labelScore.Location = new Point(16, 14);
			labelScore.Margin = new Padding(4, 0, 4, 0);
			labelScore.Name = "labelScore";
			labelScore.Size = new Size(136, 50);
			labelScore.TabIndex = 56;
			labelScore.Text = "Score:";
			// 
			// labelCoins
			// 
			labelCoins.AutoSize = true;
			labelCoins.BackColor = Color.Black;
			labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
			labelCoins.ForeColor = SystemColors.ButtonHighlight;
			labelCoins.Location = new Point(276, 14);
			labelCoins.Margin = new Padding(4, 0, 4, 0);
			labelCoins.Name = "labelCoins";
			labelCoins.Size = new Size(135, 50);
			labelCoins.TabIndex = 57;
			labelCoins.Text = "Coins:";
			// 
			// label
			// 
			label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label.BackColor = SystemColors.ActiveCaptionText;
			label.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
			label.ForeColor = SystemColors.ControlText;
			label.Location = new Point(-3, 0);
			label.Margin = new Padding(4, 0, 4, 0);
			label.Name = "label";
			label.Size = new Size(515, 91);
			label.TabIndex = 55;
			// 
			// towardCar2
			// 
			towardCar2.BackColor = Color.Transparent;
			towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
			towardCar2.Location = new Point(16, 35);
			towardCar2.Margin = new Padding(4, 5, 4, 5);
			towardCar2.Name = "towardCar2";
			towardCar2.Size = new Size(67, 169);
			towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
			towardCar2.TabIndex = 49;
			towardCar2.TabStop = false;
			// 
			// towardCar1
			// 
			towardCar1.BackColor = Color.Transparent;
			towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
			towardCar1.Location = new Point(172, 20);
			towardCar1.Margin = new Padding(4, 5, 4, 5);
			towardCar1.Name = "towardCar1";
			towardCar1.Size = new Size(67, 169);
			towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
			towardCar1.TabIndex = 48;
			towardCar1.TabStop = false;
			// 
			// towardCar3
			// 
			towardCar3.BackColor = Color.Transparent;
			towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
			towardCar3.Location = new Point(429, 55);
			towardCar3.Margin = new Padding(4, 5, 4, 5);
			towardCar3.Name = "towardCar3";
			towardCar3.Size = new Size(67, 169);
			towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
			towardCar3.TabIndex = 50;
			towardCar3.TabStop = false;
			// 
			// Coin3
			// 
			Coin3.BackColor = Color.Transparent;
			Coin3.Image = (Image)resources.GetObject("Coin3.Image");
			Coin3.Location = new Point(429, 343);
			Coin3.Margin = new Padding(4, 5, 4, 5);
			Coin3.Name = "Coin3";
			Coin3.Size = new Size(45, 49);
			Coin3.SizeMode = PictureBoxSizeMode.Zoom;
			Coin3.TabIndex = 54;
			Coin3.TabStop = false;
			// 
			// Coin2
			// 
			Coin2.BackColor = Color.Transparent;
			Coin2.Image = (Image)resources.GetObject("Coin2.Image");
			Coin2.Location = new Point(295, 240);
			Coin2.Margin = new Padding(4, 5, 4, 5);
			Coin2.Name = "Coin2";
			Coin2.Size = new Size(45, 49);
			Coin2.SizeMode = PictureBoxSizeMode.Zoom;
			Coin2.TabIndex = 53;
			Coin2.TabStop = false;
			// 
			// Coin1
			// 
			Coin1.BackColor = Color.Transparent;
			Coin1.Image = (Image)resources.GetObject("Coin1.Image");
			Coin1.Location = new Point(147, 388);
			Coin1.Margin = new Padding(4, 5, 4, 5);
			Coin1.Name = "Coin1";
			Coin1.Size = new Size(45, 49);
			Coin1.SizeMode = PictureBoxSizeMode.Zoom;
			Coin1.TabIndex = 52;
			Coin1.TabStop = false;
			// 
			// buttonPause
			// 
			buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonPause.Location = new Point(0, 803);
			buttonPause.Margin = new Padding(4, 5, 4, 5);
			buttonPause.Name = "buttonPause";
			buttonPause.Size = new Size(109, 58);
			buttonPause.TabIndex = 1;
			buttonPause.Text = "Pause";
			buttonPause.UseVisualStyleBackColor = true;
			buttonPause.Click += buttonPause_Click;
			// 
			// mainCar
			// 
			mainCar.BackColor = Color.Transparent;
			mainCar.BackgroundImageLayout = ImageLayout.None;
			mainCar.Image = (Image)resources.GetObject("mainCar.Image");
			mainCar.Location = new Point(295, 677);
			mainCar.Margin = new Padding(4, 5, 4, 5);
			mainCar.Name = "mainCar";
			mainCar.Size = new Size(67, 169);
			mainCar.SizeMode = PictureBoxSizeMode.Zoom;
			mainCar.TabIndex = 47;
			mainCar.TabStop = false;
			// 
			// LaneTwo5
			// 
			LaneTwo5.BackColor = Color.White;
			LaneTwo5.ForeColor = SystemColors.Control;
			LaneTwo5.Location = new Point(385, 812);
			LaneTwo5.Margin = new Padding(4, 0, 4, 0);
			LaneTwo5.Name = "LaneTwo5";
			LaneTwo5.Size = new Size(20, 138);
			LaneTwo5.TabIndex = 43;
			LaneTwo5.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneTwo4
			// 
			LaneTwo4.BackColor = Color.White;
			LaneTwo4.ForeColor = SystemColors.Control;
			LaneTwo4.Location = new Point(385, 596);
			LaneTwo4.Margin = new Padding(4, 0, 4, 0);
			LaneTwo4.Name = "LaneTwo4";
			LaneTwo4.Size = new Size(20, 138);
			LaneTwo4.TabIndex = 42;
			LaneTwo4.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneTwo3
			// 
			LaneTwo3.BackColor = Color.White;
			LaneTwo3.ForeColor = SystemColors.Control;
			LaneTwo3.Location = new Point(385, 382);
			LaneTwo3.Margin = new Padding(4, 0, 4, 0);
			LaneTwo3.Name = "LaneTwo3";
			LaneTwo3.Size = new Size(20, 138);
			LaneTwo3.TabIndex = 41;
			LaneTwo3.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneTwo2
			// 
			LaneTwo2.BackColor = Color.White;
			LaneTwo2.ForeColor = SystemColors.Control;
			LaneTwo2.Location = new Point(385, 166);
			LaneTwo2.Margin = new Padding(4, 0, 4, 0);
			LaneTwo2.Name = "LaneTwo2";
			LaneTwo2.Size = new Size(20, 138);
			LaneTwo2.TabIndex = 40;
			LaneTwo2.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneTwo1
			// 
			LaneTwo1.BackColor = Color.White;
			LaneTwo1.ForeColor = SystemColors.Control;
			LaneTwo1.Location = new Point(385, -49);
			LaneTwo1.Margin = new Padding(4, 0, 4, 0);
			LaneTwo1.Name = "LaneTwo1";
			LaneTwo1.Size = new Size(20, 138);
			LaneTwo1.TabIndex = 39;
			LaneTwo1.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneOne5
			// 
			LaneOne5.BackColor = Color.White;
			LaneOne5.ForeColor = SystemColors.Control;
			LaneOne5.Location = new Point(119, 812);
			LaneOne5.Margin = new Padding(4, 0, 4, 0);
			LaneOne5.Name = "LaneOne5";
			LaneOne5.Size = new Size(20, 138);
			LaneOne5.TabIndex = 38;
			LaneOne5.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneOne4
			// 
			LaneOne4.BackColor = Color.White;
			LaneOne4.ForeColor = SystemColors.Control;
			LaneOne4.Location = new Point(119, 597);
			LaneOne4.Margin = new Padding(4, 0, 4, 0);
			LaneOne4.Name = "LaneOne4";
			LaneOne4.Size = new Size(20, 138);
			LaneOne4.TabIndex = 37;
			LaneOne4.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneOne3
			// 
			LaneOne3.BackColor = Color.White;
			LaneOne3.ForeColor = SystemColors.Control;
			LaneOne3.Location = new Point(119, 382);
			LaneOne3.Margin = new Padding(4, 0, 4, 0);
			LaneOne3.Name = "LaneOne3";
			LaneOne3.Size = new Size(20, 138);
			LaneOne3.TabIndex = 36;
			LaneOne3.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneOne2
			// 
			LaneOne2.BackColor = Color.White;
			LaneOne2.ForeColor = SystemColors.Control;
			LaneOne2.Location = new Point(119, 166);
			LaneOne2.Margin = new Padding(4, 0, 4, 0);
			LaneOne2.Name = "LaneOne2";
			LaneOne2.Size = new Size(20, 138);
			LaneOne2.TabIndex = 35;
			LaneOne2.TextAlign = ContentAlignment.TopCenter;
			// 
			// LaneOne1
			// 
			LaneOne1.BackColor = Color.White;
			LaneOne1.ForeColor = SystemColors.Control;
			LaneOne1.Location = new Point(119, -49);
			LaneOne1.Margin = new Padding(4, 0, 4, 0);
			LaneOne1.Name = "LaneOne1";
			LaneOne1.Size = new Size(20, 138);
			LaneOne1.TabIndex = 34;
			LaneOne1.TextAlign = ContentAlignment.TopCenter;
			// 
			// MiddleLane
			// 
			MiddleLane.BackColor = Color.White;
			MiddleLane.ForeColor = SystemColors.Control;
			MiddleLane.Location = new Point(245, -6);
			MiddleLane.Margin = new Padding(4, 0, 4, 0);
			MiddleLane.Name = "MiddleLane";
			MiddleLane.Size = new Size(23, 872);
			MiddleLane.TabIndex = 33;
			MiddleLane.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timerTowardCars
			// 
			timerTowardCars.Enabled = true;
			timerTowardCars.Interval = 1;
			timerTowardCars.Tick += timerTowardCars_Tick;
			// 
			// timerMenu
			// 
			timerMenu.Enabled = true;
			timerMenu.Interval = 1;
			timerMenu.Tick += timerMenu_Tick;
			// 
			// RaceGame
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(512, 865);
			Controls.Add(panelGame);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			KeyPreview = true;
			Margin = new Padding(4, 5, 4, 5);
			Name = "RaceGame";
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Race";
			Load += RaceGame_Load;
			KeyDown += RaceGame_KeyDown;
			panelGame.ResumeLayout(false);
			panelGame.PerformLayout();
			panelMenu.ResumeLayout(false);
			panelMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CarMenu1).EndInit();
			((System.ComponentModel.ISupportInitialize)CarMenu3).EndInit();
			((System.ComponentModel.ISupportInitialize)CarMenu2).EndInit();
			panelPause.ResumeLayout(false);
			panelPause.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
			((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
			((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
			((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
			((System.ComponentModel.ISupportInitialize)Coin3).EndInit();
			((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
			((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
			((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Timer timerRoad;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Label LaneTwo5;
		private System.Windows.Forms.Label LaneTwo4;
		private System.Windows.Forms.Label LaneTwo3;
		private System.Windows.Forms.Label LaneTwo2;
		private System.Windows.Forms.Label LaneTwo1;
		private System.Windows.Forms.Label LaneOne5;
		private System.Windows.Forms.Label LaneOne4;
		private System.Windows.Forms.Label LaneOne3;
		private System.Windows.Forms.Label LaneOne2;
		private System.Windows.Forms.Label LaneOne1;
		private System.Windows.Forms.Label MiddleLane;
		private System.Windows.Forms.PictureBox towardCar2;
		private System.Windows.Forms.PictureBox towardCar3;
		private System.Windows.Forms.PictureBox towardCar1;
		private System.Windows.Forms.PictureBox mainCar;
		private System.Windows.Forms.Timer timerTowardCars;
		private System.Windows.Forms.Timer timerMenu;
		private System.Windows.Forms.Label labelPause;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonResume;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.PictureBox Coin1;
		private System.Windows.Forms.PictureBox Coin3;
		private System.Windows.Forms.PictureBox Coin2;
		private System.Windows.Forms.Panel panelPause;
		private System.Windows.Forms.PictureBox pictureFlag;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label label;
		private Panel panelMenu;
		private Button buttonHelp;
		private Button buttonMenuExit;
		private Button buttonStart;
		private Label label3;
		private PictureBox CarMenu1;
		private PictureBox CarMenu3;
		private PictureBox CarMenu2;
		private Label MenuTwoLane5;
		private Label MenuTwoLane4;
		private Label MenuTwoLane3;
		private Label MenuTwoLane2;
		private Label MenuTwoLane1;
		private Label MenuOneLane5;
		private Label MenuOneLane4;
		private Label MenuOneLane3;
		private Label MenuOneLane2;
		private Label MenuOneLane1;
		private Label label12;
	}
}