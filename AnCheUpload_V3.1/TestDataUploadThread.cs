using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnCheUpload_V3._1
{
    public class TestDataUploadThread
    {
        public string JCFF { get { return jcff; } set { jcff = value; } }
        public string JYLSH { get { return jylsh; } set { jylsh = value; } }
        public string JYCS { get { return jycs; } set { jycs = value; } }
        public string ZT { get { return zt; } set { zt = value; } }
        public string YCLZT { get { return yclzt; } set { yclzt = value; } }
        public string HPHM { get { return hphm; } set { hphm = value; } }
        public string HPZL { get { return hpzl; } set { hpzl = value; } }
        private string jcff = "";
        private string jylsh = "";
        private string jycs = "";
        private string zt = "";
        private string yclzt = "";
        private string hphm = "";
        private string hpzl = "";

        private bool StartUploadData()
        {
            Thread UploadThread = new Thread(new ParameterizedThreadStart(UploadTestData));//新建一个过程的上传线程
            AsmUploadThread.Start(dt_jczt);//开始上传线程
            carinfodb.UpdateCarTestStatusYCLZT(tempZT, jylsh, jycs);//临时更新已处理状态到当前状态
            update_dt_data(DgvModel.UploadTestData, dt_jczt.Rows[0], "备注", "ASM数据自动上传中...");
            FileOpreate.SaveLog("jylsh:" + jylsh + "|ASM数据自动上传线程已开始", "检测数据上传", 1);
        }
        private void UploadTestData(object obj)
        {
        }
    }
}
