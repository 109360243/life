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

private void �����C��ToolStripMenuItem_Click(object sender, EventArgs e)
{
	this.Close();
}

private void �W�h����ToolStripMenuItem_Click(object sender, EventArgs e)
{
	MessageBox.Show("�C�ӲӭM����ت��A - �s���Φ��`�A�C�ӲӭM�P�H�ۨ������ߪ��P��K��ӭM���ͤ��ʡ]�p�ϡA�¦⬰�s���A�զ⬰���`�^\n��e�ӭM���s�����A�ɡA��P�򪺦s���ӭM�C��2�Ӯɡ]���]�t2�ӡ^�A�ӲӭM�ܦ����`���A�C�]�����ͩR�ƶq�}�֡^\n��e�ӭM���s�����A�ɡA��P��2�ө�3�Ӧs���ӭM�ɡA�ӲӭM�O����ˡC\n��e�ӭM���s�����A�ɡA��P�򦳶W�L3�Ӧs���ӭM�ɡA�ӲӭM�ܦ����`���A�C�]�����ͩR�ƶq�L�h�^\n��e�ӭM�����`���A�ɡA��P��3�Ӧs���ӭM�ɡA�ӲӭM�ܦ��s�����A�C�]�����c�ޡ^");
}