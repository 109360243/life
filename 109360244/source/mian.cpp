private void button1_Click(object sender, EventArgs e)
{
	string x, y;
	start = 1;
	while (start == 1)
	{
		if (flag == 0)
		{
			for (int ii = 0; ii < 30; ii++)
			{
				for (int jj = 0; jj < 30; jj++)
				{
					if (buttons[ii, jj].BackColor == Color.Black)
					{
						board[ii, jj] = 1;
					}
					else
					{
						board[ii, jj] = 0;
					}
				}
			}
			boardoperation();
		}
		else if (flag == 1)
		{
			for (int j = 0; j < 30; j++)
			{
				for (int k = 0; k < 30; k++)
				{
					if (newboard[j, k] == 1)
					{
						buttons[j, k].BackColor = Color.Black;
					}
					else
					{
						buttons[j, k].BackColor = Color.White;
					}

				}
			}
			flag = 0;
		}
		Application.DoEvents();//µøµ¡§ó·s
		Thread.Sleep(30);
	}
}