namespace life_of_game
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.規則說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圖形範例連結ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 870);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 870);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(522, 869);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "清除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選單ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選單ToolStripMenuItem
            // 
            this.選單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.規則說明ToolStripMenuItem,
            this.結束遊戲ToolStripMenuItem,
            this.圖形範例連結ToolStripMenuItem});
            this.選單ToolStripMenuItem.Name = "選單ToolStripMenuItem";
            this.選單ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.選單ToolStripMenuItem.Text = "選單";
            // 
            // 規則說明ToolStripMenuItem
            // 
            this.規則說明ToolStripMenuItem.Name = "規則說明ToolStripMenuItem";
            this.規則說明ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.規則說明ToolStripMenuItem.Text = "規則說明";
            this.規則說明ToolStripMenuItem.Click += new System.EventHandler(this.規則說明ToolStripMenuItem_Click);
            // 
            // 結束遊戲ToolStripMenuItem
            // 
            this.結束遊戲ToolStripMenuItem.Name = "結束遊戲ToolStripMenuItem";
            this.結束遊戲ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.結束遊戲ToolStripMenuItem.Text = "結束遊戲";
            this.結束遊戲ToolStripMenuItem.Click += new System.EventHandler(this.結束遊戲ToolStripMenuItem_Click);
            // 
            // 圖形範例連結ToolStripMenuItem
            // 
            this.圖形範例連結ToolStripMenuItem.Name = "圖形範例連結ToolStripMenuItem";
            this.圖形範例連結ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.圖形範例連結ToolStripMenuItem.Text = "生命遊戲詳細介紹連結";
            this.圖形範例連結ToolStripMenuItem.Click += new System.EventHandler(this.圖形範例連結ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 961);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "康威生命遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 規則說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圖形範例連結ToolStripMenuItem;
    }
}

