namespace TinyEventBroker.WinFormDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPublish = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSubscribe = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPublish,
            this.ToolStripMenuItemSubscribe,
            this.ToolStripMenuItemOutput});
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemNew.Text = "新建";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // ToolStripMenuItemPublish
            // 
            this.ToolStripMenuItemPublish.Name = "ToolStripMenuItemPublish";
            this.ToolStripMenuItemPublish.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemPublish.Text = "发布者";
            this.ToolStripMenuItemPublish.Click += new System.EventHandler(this.ToolStripMenuItemPublish_Click);
            // 
            // ToolStripMenuItemSubscribe
            // 
            this.ToolStripMenuItemSubscribe.Name = "ToolStripMenuItemSubscribe";
            this.ToolStripMenuItemSubscribe.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemSubscribe.Text = "订阅者";
            this.ToolStripMenuItemSubscribe.Click += new System.EventHandler(this.ToolStripMenuItemSubscribe_Click);
            // 
            // ToolStripMenuItemOutput
            // 
            this.ToolStripMenuItemOutput.Name = "ToolStripMenuItemOutput";
            this.ToolStripMenuItemOutput.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemOutput.Text = "日志输出";
            this.ToolStripMenuItemOutput.Click += new System.EventHandler(this.ToolStripMenuItemOutput_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EventDemo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPublish;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSubscribe;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOutput;
    }
}

