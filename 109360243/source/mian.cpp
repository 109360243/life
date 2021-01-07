private void button3_Click(object sender, EventArgs e)
{
	start = 0;
}
private void button5_Click(object sender, EventArgs e)
{
	for (int j = 0; j < 30; j++)
	{
		for (int k = 0; k < 30; k++)
		{
			buttons[j, k].BackColor = Color.White;
			newboard[j, k] = 0;
			board[j, k] = 0;
		}
	}
}

private void 結束遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
{
	this.Close();
}

private void 規則說明ToolStripMenuItem_Click(object sender, EventArgs e)
{
	MessageBox.Show("每個細胞有兩種狀態 - 存活或死亡，每個細胞與以自身為中心的周圍八格細胞產生互動（如圖，黑色為存活，白色為死亡）\n當前細胞為存活狀態時，當周圍的存活細胞低於2個時（不包含2個），該細胞變成死亡狀態。（模擬生命數量稀少）\n當前細胞為存活狀態時，當周圍有2個或3個存活細胞時，該細胞保持原樣。\n當前細胞為存活狀態時，當周圍有超過3個存活細胞時，該細胞變成死亡狀態。（模擬生命數量過多）\n當前細胞為死亡狀態時，當周圍有3個存活細胞時，該細胞變成存活狀態。（模擬繁殖）");
}