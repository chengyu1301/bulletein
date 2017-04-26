
namespace bulletein
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bulletinBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.紅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黃色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.標楷體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新細明體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.一般ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.斜體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗斜體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelPromptString = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulletinBoardToolStripMenuItem,
            this.timerModeToolStripMenuItem,
            this.toolStripSeparator3,
            this.lockToolStripMenuItem,
            this.設定文字ToolStripMenuItem,
            this.toolStripSeparator4,
            this.紅色ToolStripMenuItem,
            this.黃色ToolStripMenuItem,
            this.綠色ToolStripMenuItem,
            this.藍色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.白色ToolStripMenuItem,
            this.字型ToolStripMenuItem,
            this.大小ToolStripMenuItem,
            this.toolStripSeparator5,
            this.離開ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 360);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // bulletinBoardToolStripMenuItem
            // 
            this.bulletinBoardToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletinBoardToolStripMenuItem.Name = "bulletinBoardToolStripMenuItem";
            this.bulletinBoardToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.bulletinBoardToolStripMenuItem.Text = "Bulletin Board";
            this.bulletinBoardToolStripMenuItem.Click += new System.EventHandler(this.bulletinBoardToolStripMenuItem_Click);
            // 
            // timerModeToolStripMenuItem
            // 
            this.timerModeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerModeToolStripMenuItem.Name = "timerModeToolStripMenuItem";
            this.timerModeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.timerModeToolStripMenuItem.Text = "Timer Mode";
            this.timerModeToolStripMenuItem.Click += new System.EventHandler(this.timerModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // 設定文字ToolStripMenuItem
            // 
            this.設定文字ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.設定文字ToolStripMenuItem.Name = "設定文字ToolStripMenuItem";
            this.設定文字ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.設定文字ToolStripMenuItem.Text = "Set message";
            this.設定文字ToolStripMenuItem.Click += new System.EventHandler(this.設定文字ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // 紅色ToolStripMenuItem
            // 
            this.紅色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            this.紅色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.紅色ToolStripMenuItem.Text = "Red";
            this.紅色ToolStripMenuItem.Click += new System.EventHandler(this.紅色ToolStripMenuItem_Click);
            // 
            // 黃色ToolStripMenuItem
            // 
            this.黃色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.黃色ToolStripMenuItem.Name = "黃色ToolStripMenuItem";
            this.黃色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.黃色ToolStripMenuItem.Text = "Yellow";
            this.黃色ToolStripMenuItem.Click += new System.EventHandler(this.黃色ToolStripMenuItem_Click);
            // 
            // 綠色ToolStripMenuItem
            // 
            this.綠色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            this.綠色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.綠色ToolStripMenuItem.Text = "Green";
            this.綠色ToolStripMenuItem.Click += new System.EventHandler(this.綠色ToolStripMenuItem_Click);
            // 
            // 藍色ToolStripMenuItem
            // 
            this.藍色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            this.藍色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.藍色ToolStripMenuItem.Text = "Blue";
            this.藍色ToolStripMenuItem.Click += new System.EventHandler(this.藍色ToolStripMenuItem_Click);
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.黑色ToolStripMenuItem.Text = "Black";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 白色ToolStripMenuItem
            // 
            this.白色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.白色ToolStripMenuItem.Name = "白色ToolStripMenuItem";
            this.白色ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.白色ToolStripMenuItem.Text = "White";
            this.白色ToolStripMenuItem.Click += new System.EventHandler(this.白色ToolStripMenuItem_Click);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.標楷體ToolStripMenuItem,
            this.新細明體ToolStripMenuItem,
            this.calibriToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem,
            this.toolStripSeparator1,
            this.一般ToolStripMenuItem,
            this.粗體ToolStripMenuItem,
            this.斜體ToolStripMenuItem,
            this.粗斜體ToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripTextBox2});
            this.字型ToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.字型ToolStripMenuItem.Text = "Font";
            // 
            // 標楷體ToolStripMenuItem
            // 
            this.標楷體ToolStripMenuItem.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.標楷體ToolStripMenuItem.Name = "標楷體ToolStripMenuItem";
            this.標楷體ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.標楷體ToolStripMenuItem.Text = "標楷體";
            this.標楷體ToolStripMenuItem.Click += new System.EventHandler(this.標楷體ToolStripMenuItem_Click);
            // 
            // 新細明體ToolStripMenuItem
            // 
            this.新細明體ToolStripMenuItem.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.新細明體ToolStripMenuItem.Name = "新細明體ToolStripMenuItem";
            this.新細明體ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.新細明體ToolStripMenuItem.Text = "新細明體";
            this.新細明體ToolStripMenuItem.Click += new System.EventHandler(this.新細明體ToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // 一般ToolStripMenuItem
            // 
            this.一般ToolStripMenuItem.Name = "一般ToolStripMenuItem";
            this.一般ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.一般ToolStripMenuItem.Text = "一般";
            this.一般ToolStripMenuItem.Click += new System.EventHandler(this.一般ToolStripMenuItem_Click);
            // 
            // 粗體ToolStripMenuItem
            // 
            this.粗體ToolStripMenuItem.Name = "粗體ToolStripMenuItem";
            this.粗體ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.粗體ToolStripMenuItem.Text = "粗體";
            this.粗體ToolStripMenuItem.Click += new System.EventHandler(this.粗體ToolStripMenuItem_Click);
            // 
            // 斜體ToolStripMenuItem
            // 
            this.斜體ToolStripMenuItem.Name = "斜體ToolStripMenuItem";
            this.斜體ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.斜體ToolStripMenuItem.Text = "斜體";
            this.斜體ToolStripMenuItem.Click += new System.EventHandler(this.斜體ToolStripMenuItem_Click);
            // 
            // 粗斜體ToolStripMenuItem
            // 
            this.粗斜體ToolStripMenuItem.Name = "粗斜體ToolStripMenuItem";
            this.粗斜體ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.粗斜體ToolStripMenuItem.Text = "粗斜體";
            this.粗斜體ToolStripMenuItem.Click += new System.EventHandler(this.粗斜體ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AcceptsReturn = true;
            this.toolStripTextBox2.Font = new System.Drawing.Font("新細明體", 10F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // 大小ToolStripMenuItem
            // 
            this.大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.大小ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.大小ToolStripMenuItem.Name = "大小ToolStripMenuItem";
            this.大小ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.大小ToolStripMenuItem.Text = "Size";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsReturn = true;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.離開ToolStripMenuItem.Text = "Exit";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "設定";
            this.notifyIcon1.Visible = true;
            // 
            // labelPromptString
            // 
            this.labelPromptString.AutoSize = true;
            this.labelPromptString.Font = new System.Drawing.Font("華康魏碑體", 50F);
            this.labelPromptString.ForeColor = System.Drawing.Color.Red;
            this.labelPromptString.Location = new System.Drawing.Point(21, 19);
            this.labelPromptString.Name = "labelPromptString";
            this.labelPromptString.Size = new System.Drawing.Size(1463, 84);
            this.labelPromptString.TabIndex = 1;
            this.labelPromptString.Text = "Welcome to use the bulletin board!";
            this.labelPromptString.FontChanged += new System.EventHandler(this.labelPromptString_FontChanged_1);
            this.labelPromptString.TextChanged += new System.EventHandler(this.labelPromptString_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 60F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 106);
            this.Controls.Add(this.labelPromptString);
            this.Font = new System.Drawing.Font("華康魏碑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Bulletin";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 紅色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 黃色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.Label labelPromptString;
        private System.Windows.Forms.ToolStripMenuItem 設定文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 標楷體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新細明體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 斜體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗斜體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem bulletinBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

