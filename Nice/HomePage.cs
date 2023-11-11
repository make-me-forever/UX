using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Windows.Themes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Nice.Properties;

namespace Nice
{

    public partial class HomePage : Form
    {

        /***************************************************************/
        // 全局变量区

        File g_f = new File();
        Feature g_e = new Feature();

        string g_rootPath = Directory.GetCurrentDirectory();
        string g_openFolderPath = null;
        string g_tipsPathEditArea = @"请输入文件路径,如：E:\config.txt";
        string g_dropStr = null;
        string g_version = "V0.01";
        string g_defaultPath = null;

        Color ThemeColor = Color.FromArgb(242, 118, 53);
        //Color ThemeColor = Color.FromArgb(255, 80, 0);
        /***************************************************************/


        public HomePage()
        {
            InitOwner();
            InitLog();
            InitStr();
            InitVersion();
            
            InitializeComponent();
            InitImage();
        }

        bool InitOwner()
        {
            //g_f.Log("Starting to use the nice tool.");
            return g_e.IsMe();
        }

        void Show(string str, string tittle)
        {
            if(InitOwner()) {
                MessageBox.Show(str, tittle);
            }
        }

        void InitVersion()
        {
            g_f.Log(g_version);
        }

        void Show(string str)
        {
            if(InitOwner()) {
                MessageBox.Show(str);
            }
        }

        void InitLog()
        {
            if(g_e.InitLog(30)) {
                if(g_e.IsMe()) {
                    Show("Having clear log.", "InitLog");
                }
            }
        }

        void InitStr()
        {
            if(!g_f.IsSupportLib()) {
                return;
            }

            g_f.g_dairyPath = g_f.g_currentPath + @"\Libcore\log";
            if (!System.IO.Directory.Exists(g_f.g_dairyPath)) {
                Show("Log文件夹不存在，即将创建Log文件夹。\r\n新建：" + g_f.g_dairyPath, "InitStr");
                System.IO.Directory.CreateDirectory(g_f.g_dairyPath);
            }

            if (g_f.IsSupportErr()) {
                g_f.g_errorLogPath = g_f.g_dairyPath + @"\error.log";
                if (!System.IO.File.Exists(g_f.g_errorLogPath)) {
                    // Show("error.log文件不存在，即将创建error.log文件", "InitStr");
                    System.IO.File.Create(g_f.g_errorLogPath).Close();
                    g_f.Log(g_f.g_errorLogPath, "error.log文件不存在，已创建error.log文件");
                }
            }

            if (g_f.IsSupportLog()) {
                g_f.g_logPath = g_f.g_dairyPath + @"\note.log";
                if (!System.IO.File.Exists(g_f.g_logPath)) {
                    // Show("note.log文件不存在，即将创建note.log文件", "InitStr");
                    System.IO.File.Create(g_f.g_logPath).Close();
                    g_f.Log(g_f.g_errorLogPath, "note.log文件不存在，已创建note.log文件");
                }
            }
            g_f.FileCompression(g_f.g_logPath, g_f.g_dairyPath);
            if (System.IO.Directory.Exists(g_f.g_currentPath + g_f.g_libCoreStr)) {
                // 设置隐藏文件夹
                System.IO.File.SetAttributes(g_f.g_currentPath + g_f.g_libCoreStr, FileAttributes.Hidden);
            }
        }

        void InitImageHome()
        {
            this.PathEditArea.Text = g_tipsPathEditArea; // 初始化主页路径输入提示语
            this.PathEditArea.ForeColor = System.Drawing.Color.FromArgb(255, 192, 128);  // 提示语灰化
            this.AllowDrop = true;
            uiRadioButton1.Checked = true;
        }

        void InitImage()
        {
            InitImageHome();
            //g_f.CreateShortcutOnDesktop("昆易工具"); // 创建快捷方式必须在InitializeComponent();完成后
        }

        private void PathEditArea_MouseHover(object sender, EventArgs e)
        {
            if (PathEditArea.Text == g_tipsPathEditArea)
            {
                PathEditArea.Text = null;
            }
            PathEditArea.ForeColor = ThemeColor;
        }

        private void PathEditArea_MouseLeave(object sender, EventArgs e)
        {
            if (PathEditArea.Text == null || PathEditArea.Text == "")
            {
                InitImageHome();
            }
            this.PathEditArea.Font = new Font(PathEditArea.Font, PathEditArea.Font.Style & ~FontStyle.Bold);
        }

        private void Tab0_DragDrop(object sender, DragEventArgs e)
        {
            Array aryFiles = ((System.Array)e.Data.GetData(DataFormats.FileDrop));
            for (int i = 0; i < aryFiles.Length; i++)
            {
                g_dropStr = aryFiles.GetValue(i).ToString() + Environment.NewLine.Replace("\r\n", "");
                this.PathEditArea.Text = "";
                //Show(g_dropStr, "drop");
                this.PathEditArea.Text = g_dropStr;
                //g_f.Log("g_dropStr:" + g_dropStr);
            }
            //TransformStart();
            //PathEditArea.Text = g_tipsPathEditArea; // 初始化主页路径输入提示语
        }

        private void Tab0_Leave(object sender, EventArgs e)
        {
            //this.PathEditArea.Text = "";
            //this.PathEditArea.ScrollToCaret();
            //Show("g_dropStr: " + g_dropStr, "leave");
            //this.PathEditArea.Text = g_dropStr;
            //this.PathEditArea.ScrollToCaret();
            //MainPage.ActiveForm.TopMost = false;
        }

        private void Tab0_Enter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Link;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            if (uiRadioButton1.Checked)
            {
                KingstToReg();
            }
            else if(uiRadioButton2.Checked)
            {
                DSViewToReg();
            }
            else if(uiRadioButton3.Checked)
            {
                BypassToReg();
            }
            BtnTransform.BackColor = ThemeColor;
        }
        private void DSViewToReg()
        {
            TransformStart();
        }
        private void BypassToReg()
        {
            TransformStart();
        }
        private void TransformStart()
        {
            g_f.Log("[TransformStart] " + PathEditArea.Text);
            TransformFunc g_t = new TransformFunc();
            if (PathEditArea.Text == null || PathEditArea.Text == "" ||
                PathEditArea.Text == g_tipsPathEditArea)
            {
                g_t.TransformFuncEntry(null);
                g_f.Log("[TransformStart] no file path");
            }
            else
            {
                g_t.TransformFuncEntry(PathEditArea.Text);
            }
        }

        private void KingstToReg()
        {
            g_f.Log("[KingstToReg] " + PathEditArea.Text);
            g_defaultPath = PathEditArea.Text;
            TransformFunc g_t = new TransformFunc();
            g_t.TransformFuncToCfg(g_defaultPath);

            //thread_a = new Thread(ThreadHandle);
            //thread_a.Name = "kingst_progress_bar";
            //thread_a.Start();
            //TimerProgressBar.Enabled = true;


            //TransformFunc g_t = new TransformFunc();
            //g_t.TransformFuncToCfg(PathEditArea.Text);
            //this.KingstBar.Visible = true;
            //KingstBar.Value = 0;

        }
    }
}
