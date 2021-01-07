using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_of_game
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
        Button button;
        Button[,] buttons;
        int[,] board = new int[30, 30];
        int[,] newboard = new int[30, 30];
        int flag=0;
        int start=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, j,number=0;
            this.Width = 800;
            this.Height = 800;
           buttons= new Button[30, 30];
            for ( i = 0; i <30; i++)
            {
                for (j= 0; j < 30; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Name = i.ToString()+j.ToString(),
                        Location = new Point(23* i, 23* j),
                        BackColor = Color.White,
                        Size = new Size(23, 23),
                        
                    };
                    number++;
                    buttons[i, j].MouseClick +=buttonrecond ;
                    this.Controls.Add(buttons[i, j]);
                }            
            }
        }
        bool keydown = true;
        private void buttonrecond(object sender, EventArgs e)
        {
           
            button = (Button)sender;
            if (keydown == true)
            {
                button.BackColor = Color.Black;
                keydown = !keydown;
            }
            else
            {
                button.BackColor = Color.White;
                keydown = !keydown;
            }          
        }
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
               Application.DoEvents();

                Thread.Sleep(30);
            }
        }
        private void boardoperation()
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
                    newboard[j, k] =0;
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

        private void 圖形範例連結ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pansci.asia/archives/95148");
        }
    }
}
