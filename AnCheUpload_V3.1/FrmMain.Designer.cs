namespace AnCheUpload_V3._1
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pDGV = new System.Windows.Forms.Panel();
            this.dgv_BdZjData = new System.Windows.Forms.DataGridView();
            this.dgv_SuccessData = new System.Windows.Forms.DataGridView();
            this.dgv_UploadingData = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.上传设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启停同步待检列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启停上传标定自检数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启停上传排放检测数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示当前上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示已上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示标定自检记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunStatus = new System.Windows.Forms.StatusStrip();
            this.pDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BdZjData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuccessData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UploadingData)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDGV
            // 
            this.pDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDGV.Controls.Add(this.dgv_BdZjData);
            this.pDGV.Controls.Add(this.dgv_SuccessData);
            this.pDGV.Controls.Add(this.dgv_UploadingData);
            this.pDGV.Location = new System.Drawing.Point(2, 28);
            this.pDGV.Name = "pDGV";
            this.pDGV.Size = new System.Drawing.Size(1180, 583);
            this.pDGV.TabIndex = 0;
            // 
            // dgv_BdZjData
            // 
            this.dgv_BdZjData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BdZjData.Location = new System.Drawing.Point(748, 3);
            this.dgv_BdZjData.Name = "dgv_BdZjData";
            this.dgv_BdZjData.RowTemplate.Height = 23;
            this.dgv_BdZjData.Size = new System.Drawing.Size(303, 522);
            this.dgv_BdZjData.TabIndex = 2;
            // 
            // dgv_SuccessData
            // 
            this.dgv_SuccessData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SuccessData.Location = new System.Drawing.Point(368, 3);
            this.dgv_SuccessData.Name = "dgv_SuccessData";
            this.dgv_SuccessData.RowTemplate.Height = 23;
            this.dgv_SuccessData.Size = new System.Drawing.Size(303, 522);
            this.dgv_SuccessData.TabIndex = 1;
            // 
            // dgv_UploadingData
            // 
            this.dgv_UploadingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UploadingData.Location = new System.Drawing.Point(3, 3);
            this.dgv_UploadingData.Name = "dgv_UploadingData";
            this.dgv_UploadingData.RowTemplate.Height = 23;
            this.dgv_UploadingData.Size = new System.Drawing.Size(303, 522);
            this.dgv_UploadingData.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传设置ToolStripMenuItem,
            this.显示当前上传ToolStripMenuItem,
            this.显示已上传ToolStripMenuItem,
            this.显示标定自检记录ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1184, 25);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 上传设置ToolStripMenuItem
            // 
            this.上传设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启停同步待检列表ToolStripMenuItem,
            this.启停上传标定自检数据ToolStripMenuItem,
            this.启停上传排放检测数据ToolStripMenuItem});
            this.上传设置ToolStripMenuItem.Name = "上传设置ToolStripMenuItem";
            this.上传设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.上传设置ToolStripMenuItem.Text = "上传设置";
            // 
            // 启停同步待检列表ToolStripMenuItem
            // 
            this.启停同步待检列表ToolStripMenuItem.Name = "启停同步待检列表ToolStripMenuItem";
            this.启停同步待检列表ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.启停同步待检列表ToolStripMenuItem.Text = "启停同步待检列表";
            // 
            // 启停上传标定自检数据ToolStripMenuItem
            // 
            this.启停上传标定自检数据ToolStripMenuItem.Name = "启停上传标定自检数据ToolStripMenuItem";
            this.启停上传标定自检数据ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.启停上传标定自检数据ToolStripMenuItem.Text = "启停上传标定自检数据";
            // 
            // 启停上传排放检测数据ToolStripMenuItem
            // 
            this.启停上传排放检测数据ToolStripMenuItem.Name = "启停上传排放检测数据ToolStripMenuItem";
            this.启停上传排放检测数据ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.启停上传排放检测数据ToolStripMenuItem.Text = "启停上传排放检测数据";
            // 
            // 显示当前上传ToolStripMenuItem
            // 
            this.显示当前上传ToolStripMenuItem.Name = "显示当前上传ToolStripMenuItem";
            this.显示当前上传ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.显示当前上传ToolStripMenuItem.Text = "显示当前上传";
            // 
            // 显示已上传ToolStripMenuItem
            // 
            this.显示已上传ToolStripMenuItem.Name = "显示已上传ToolStripMenuItem";
            this.显示已上传ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.显示已上传ToolStripMenuItem.Text = "显示已上传";
            // 
            // 显示标定自检记录ToolStripMenuItem
            // 
            this.显示标定自检记录ToolStripMenuItem.Name = "显示标定自检记录ToolStripMenuItem";
            this.显示标定自检记录ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.显示标定自检记录ToolStripMenuItem.Text = "显示标定自检记录";
            // 
            // RunStatus
            // 
            this.RunStatus.Location = new System.Drawing.Point(0, 614);
            this.RunStatus.Name = "RunStatus";
            this.RunStatus.Size = new System.Drawing.Size(1184, 22);
            this.RunStatus.TabIndex = 2;
            this.RunStatus.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.RunStatus);
            this.Controls.Add(this.pDGV);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "FrmMain";
            this.Text = "安车环保联网后台数据上传总控系统_V3.1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BdZjData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuccessData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UploadingData)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDGV;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 上传设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启停同步待检列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启停上传标定自检数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启停上传排放检测数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示当前上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示已上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示标定自检记录ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip RunStatus;
        private System.Windows.Forms.DataGridView dgv_BdZjData;
        private System.Windows.Forms.DataGridView dgv_SuccessData;
        private System.Windows.Forms.DataGridView dgv_UploadingData;
    }
}

