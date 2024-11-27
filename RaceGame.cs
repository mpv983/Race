﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
	public partial class RaceGame : Form
	{
		public RaceGame()
		{
			InitializeComponent();
		}

		Label[] LanesOne = new Label[5];
		Label[] LanesTwo = new Label[5];
		Label[] LanesMenuOne = new Label[5];
		Label[] LanesMenuTwo = new Label[5];
		Random r = new Random();
		int score = 0;
		int coins = 0;
		int carSpeed = 2;
		private void timerRoad_Tick(object sender, EventArgs e)
		{
			labelScore.Text = "Score: " + score / 10;
			for (int i = 0; i < LanesOne.Length; ++i)
			{
				LanesOne[i].Top += carSpeed;
				if (LanesOne[i].Top >= Height)
				{
					LanesOne[i].Top = -LanesOne[i].Height;
				}
				if (carSpeed != 0)
					score++;
			}
			for (int i = 0; i < LanesTwo.Length; ++i)
			{
				LanesTwo[i].Top += carSpeed;
				if (LanesTwo[i].Top >= Height)
					LanesTwo[i].Top = -LanesTwo[i].Height;
			}
			Coin1.Top += carSpeed;
			if (Coin1.Top > Height)
			{
				Coin1.Top = -Coin1.Height;
				Coin1.Left = r.Next(0, Width - Coin1.Width);
			}
			Coin2.Top += carSpeed;
			if (Coin2.Top > Height)
			{
				Coin2.Top = -Coin2.Height;
				Coin2.Left = r.Next(0, Width - Coin2.Width);
			}
			Coin3.Top += carSpeed;
			if (Coin3.Top > Height)
			{
				Coin3.Top = -Coin3.Height;
				Coin3.Left = r.Next(0, Width - Coin3.Width);
			}
			coinsCollect();
		}
		void coinsCollect()
		{
			if (mainCar.Bounds.IntersectsWith(Coin1.Bounds))
			{
				coins++;
				labelCoins.Text = "Coins: " + coins;
				Coin1.Top = -Coin1.Height;
				Coin1.Left = r.Next(0, 120);
			}
			if (mainCar.Bounds.IntersectsWith(Coin2.Bounds))
			{
				coins++;
				labelCoins.Text = "Coins: " + coins;
				Coin2.Top = -Coin2.Height;
				Coin2.Left = r.Next(120, 240);
			}
			if (mainCar.Bounds.IntersectsWith(Coin3.Bounds))
			{
				coins++;
				labelCoins.Text = "Coins: " + coins;
				Coin3.Top = -Coin3.Height;
				Coin3.Left = r.Next(240, 300);
			}
		}

		private void RaceGame_Load(object sender, EventArgs e)
		{
			LanesOne[0] = LaneOne1;
			LanesOne[1] = LaneOne2;
			LanesOne[2] = LaneOne3;
			LanesOne[3] = LaneOne4;
			LanesOne[4] = LaneOne5;

			LanesTwo[0] = LaneTwo1;
			LanesTwo[1] = LaneTwo2;
			LanesTwo[2] = LaneTwo3;
			LanesTwo[3] = LaneTwo4;
			LanesTwo[4] = LaneTwo5;

			LanesMenuOne[0] = MenuOneLane1;
			LanesMenuOne[1] = MenuOneLane2;
			LanesMenuOne[2] = MenuOneLane3;
			LanesMenuOne[3] = MenuOneLane4;
			LanesMenuOne[4] = MenuOneLane5;

			LanesMenuTwo[0] = MenuTwoLane1;
			LanesMenuTwo[1] = MenuTwoLane2;
			LanesMenuTwo[2] = MenuTwoLane3;
			LanesMenuTwo[3] = MenuTwoLane4;
			LanesMenuTwo[4] = MenuTwoLane5;

			timerRoad.Stop();
			timerTowardCars.Stop();
			panelMenu.Show();
		}

		private void RaceGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (carSpeed != 0)
			{
				if (e.KeyCode == Keys.Right)
				{
					//380
					if (mainCar.Right < 500)
						mainCar.Left += 9;
				}
				if (e.KeyCode == Keys.Left)
				{
					if (mainCar.Left > 0)
						mainCar.Left -= 9;
				}
			}
			if (e.KeyCode == Keys.Up)
			{
				if (carSpeed < 21)
					carSpeed++;
			}
			if (e.KeyCode == Keys.Down)
			{
				if (carSpeed > 0)
					carSpeed--;
			}
			if (e.KeyCode == Keys.Escape)
			{
				timerRoad.Enabled = false;
				timerTowardCars.Enabled = false;
				panelPause.Show();
			}
		}

		private void timerTowardCars_Tick(object sender, EventArgs e)
		{
			towardCar1.Top += carSpeed + 4;
			if (towardCar1.Top > Height)
			{
				towardCar1.Top = -towardCar1.Height;
				towardCar1.Left = r.Next(0, Width - towardCar1.Width);
			}

			towardCar2.Top += carSpeed + 2;
			if (towardCar2.Top > Height)
			{
				towardCar2.Top = -towardCar2.Height;
				towardCar2.Left = r.Next(0, Width - towardCar2.Width);
			}

			towardCar3.Top += carSpeed + 3;
			if (towardCar3.Top > Height)
			{
				towardCar3.Top = -towardCar3.Height;
				towardCar3.Left = r.Next(0, Width - towardCar3.Width);
			}

			if (mainCar.Bounds.IntersectsWith(towardCar1.Bounds))
				GameOver();
			if (mainCar.Bounds.IntersectsWith(towardCar2.Bounds))
				GameOver();
			if (mainCar.Bounds.IntersectsWith(towardCar3.Bounds))
				GameOver();
		}
		private void GameOver()
		{
			timerRoad.Stop();
			timerTowardCars.Stop();
			if (coins < 15)
			{
				DialogResult dd = MessageBox.Show("Game Over!", "Приехали!");
				panelPause.Show();
				panelMenu.Show();
			}
			else
			{
				DialogResult dr = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
					Restart();
				else if (dr == DialogResult.No)
				{
					panelPause.Show();
					panelMenu.Show();
				}
			}
		}

		private void Restart()
		{
			coins -= 15;
			labelCoins.Text = "Coins: " + coins;
			carSpeed = 2;
			timerRoad.Start();
			timerTowardCars.Start();
			towardCar1.Top = -towardCar1.Height;
			towardCar1.Left = r.Next(0, Width - towardCar1.Width);
			towardCar2.Top = -towardCar2.Height;
			towardCar2.Left = r.Next(0, Width - towardCar2.Width);
			towardCar3.Top = -towardCar3.Height;
			towardCar3.Left = r.Next(0, Width - towardCar3.Width);
		}
		private void StartGame()
		{
			score = 0;
			coins = 0;
			carSpeed = 2;
			timerRoad.Start();
			timerTowardCars.Start();
			towardCar1.Top = -towardCar1.Height;
			towardCar1.Left = r.Next(0, Width - towardCar1.Width);
			towardCar2.Top = -towardCar2.Height;
			towardCar2.Left = r.Next(0, Width - towardCar2.Width);
			towardCar3.Top = -towardCar3.Height;
			towardCar3.Left = r.Next(0, Width - towardCar3.Width);
			panelPause.Hide();
			panelGame.Show();
			panelMenu.Hide();
		}
		private void timerMenu_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < LanesMenuOne.Length; ++i)
			{
				LanesMenuOne[i].Top += carSpeed;
				if (LanesMenuOne[i].Top >= Height)
				{
					LanesMenuOne[i].Top = -LanesMenuOne[i].Height;
				}
			}
			for (int i = 0; i < LanesMenuTwo.Length; ++i)
			{
				LanesMenuTwo[i].Top += carSpeed;
				if (LanesMenuTwo[i].Top >= Height)
					LanesMenuTwo[i].Top = -LanesMenuTwo[i].Height;
			}
			CarMenu1.Top += 5;
			if (CarMenu1.Top > Height)
			{

				CarMenu1.Top = -CarMenu1.Height;
				CarMenu1.Left = r.Next(0, Width - CarMenu1.Width);
			}
			CarMenu2.Top += 3;
			if (CarMenu2.Top > Height)
			{
				CarMenu2.Top = -CarMenu2.Height;
				CarMenu2.Left = r.Next(0, Width - CarMenu2.Width);
			}
			CarMenu3.Top += 4;
			if (CarMenu3.Top > Height)
			{
				CarMenu3.Top = -CarMenu3.Height;
				CarMenu3.Left = r.Next(0, Width - CarMenu3.Width);
			}
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{

			timerRoad.Enabled = false;
			timerTowardCars.Enabled = false;
			panelPause.Show();
		}

		private void buttonResume_Click(object sender, EventArgs e)
		{
			timerRoad.Enabled = true;
			timerTowardCars.Enabled = true;
			panelPause.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			panelMenu.Show();
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, @"C:\Users\khha4\Race\help.chm", HelpNavigator.TableOfContents);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			StartGame();
			panelGame.Show();
			panelMenu.Hide();
		}

		private void buttonMenuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

