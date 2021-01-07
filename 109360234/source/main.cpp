private void boardoperation()//ºtºâªk
{
	int count = 0;
	int alive = 1, dead = 0;
	int n = 30, m = 30;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			count = 0;
			if (i > 0) count += board[i - 1, j];
			if (i < n - 1) count += board[i + 1, j];
			if (j > 0) count += board[i, j - 1];
			if (j < m - 1) count += board[i, j + 1];
			if (i > 0 && j > 0) count += board[i - 1, j - 1];
			if (i > 0 && j < m - 1) count += board[i - 1, j + 1];
			if (i < n - 1 && j > 0) count += board[i + 1, j - 1];
			if (i < n - 1 && j < m - 1) count += board[i + 1, j + 1];
			newboard[i, j] = board[i, j];
			if (board[i, j] == 1)
			{
				if (count < 2 || count > 3)
				{
					newboard[i, j] = dead;
				}
				else
				{
					newboard[i, j] = alive;
				}
			}
			else if (board[i, j] == 0)
			{
				if (count == 3)
				{
					newboard[i, j] = alive;
				}
			}
		}
	}
	flag = 1;
}