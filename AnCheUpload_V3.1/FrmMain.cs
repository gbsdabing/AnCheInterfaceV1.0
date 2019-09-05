using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnCheUpload_V3._1
{
    public partial class FrmMain : Form
    {
        #region 界面显示表缓存定义
        /*
         * 说明：（界面刷新：检测数据上传只同步车辆检测状态，已完成由检测数据）
         * 1、标定、自检表由程序初始化时创建，不新增、不删除、只更新
         * 2、上传成功表只插入新的数据，不删除、不更新
         * 3、检测数据显示表要进行插入、更新及删除操作
         * 4、检测数据显示表数据删除由刷新timer在刷新开始时进行（判断已处理状态是否为“上传已完成——9”，再插入数据到已完成表，再删除检测表）
         * 5、检测数据显示表数据新增、更新由界面timer在刷新时判定刷新还是插入（同步的车辆检测状态表中jylsh、jycs是否已存在于当前显示缓存表中）
         * 6、每次刷新都在一次timer中进行
         */
        private DataTable dt_ShowTestUploadData = null;//检测数据上传显示缓存表
        private DataTable dt_ShowUploadSuccessData = null;//上传完成数据显示缓存表
        private DataTable dt_ShowBdZjdLog = null;//标定自检记录显示缓存表
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region 初始化DGV控件
            //初始化DGV控件位置及显示属性
            dgv_UploadingData.Location = new Point(3, 3);
            dgv_UploadingData.Size = new Size(1170, 577);
            dgv_UploadingData.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dgv_SuccessData.Location = new Point(3, 3);
            dgv_SuccessData.Size = new Size(1170, 577);
            dgv_SuccessData.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dgv_BdZjData.Location = new Point(3, 3);
            dgv_BdZjData.Size = new Size(1170, 577);
            dgv_BdZjData.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            //初始化控件内容
            #endregion

            #region 获取软件配置信息

            #endregion

            #region 显示登陆界面

            #endregion

            #region 获取软件配置信息

            #endregion

            #region 软件参数初始化

            #endregion

            #region 联网初始化

            #endregion

            #region 当天第一次启动清理待检信息、车辆检测状态信息

            #endregion

            #region 启动界面刷新计时器

            #endregion
        }
    }
}
