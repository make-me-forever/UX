namespace Nice
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Tab0 = new Sunny.UI.UITabControlMenu();
            this.TabWnd = new System.Windows.Forms.TabPage();
            this.uiRadioButton3 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.PathEditArea = new Sunny.UI.UITextBox();
            this.BtnTransform = new Sunny.UI.UIButton();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.Tab0.SuspendLayout();
            this.TabWnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab0
            // 
            this.Tab0.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Tab0.Controls.Add(this.TabWnd);
            this.Tab0.Controls.Add(this.Tab1);
            this.Tab0.Controls.Add(this.Tab2);
            this.Tab0.Controls.Add(this.Tab3);
            this.Tab0.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tab0.FillColor = System.Drawing.Color.White;
            this.Tab0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tab0.HotTrack = true;
            this.Tab0.Location = new System.Drawing.Point(-1, -2);
            this.Tab0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tab0.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Tab0.Multiline = true;
            this.Tab0.Name = "Tab0";
            this.Tab0.SelectedIndex = 0;
            this.Tab0.ShowToolTips = true;
            this.Tab0.Size = new System.Drawing.Size(720, 438);
            this.Tab0.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab0.Style = Sunny.UI.UIStyle.Custom;
            this.Tab0.StyleCustomMode = true;
            this.Tab0.TabBackColor = System.Drawing.Color.LightGray;
            this.Tab0.TabIndex = 0;
            this.Tab0.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.Tab0.TabSelectedForeColor = System.Drawing.Color.White;
            this.Tab0.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.Tab0.TabStop = false;
            this.Tab0.TabUnSelectedForeColor = System.Drawing.Color.Black;
            this.Tab0.ZoomScaleDisabled = true;
            // 
            // TabWnd
            // 
            this.TabWnd.AllowDrop = true;
            this.TabWnd.BackColor = System.Drawing.Color.White;
            this.TabWnd.Controls.Add(this.uiRadioButton3);
            this.TabWnd.Controls.Add(this.uiRadioButton2);
            this.TabWnd.Controls.Add(this.uiRadioButton1);
            this.TabWnd.Controls.Add(this.PathEditArea);
            this.TabWnd.Controls.Add(this.BtnTransform);
            this.TabWnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.TabWnd.Location = new System.Drawing.Point(201, 0);
            this.TabWnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabWnd.Name = "TabWnd";
            this.TabWnd.Size = new System.Drawing.Size(519, 438);
            this.TabWnd.TabIndex = 0;
            this.TabWnd.Text = "转  换";
            this.TabWnd.ToolTipText = "相机配置格式互转";
            this.TabWnd.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tab0_DragDrop);
            this.TabWnd.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tab0_Enter);
            this.TabWnd.DragLeave += new System.EventHandler(this.Tab0_Leave);
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton3.Location = new System.Drawing.Point(75, 172);
            this.uiRadioButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton3.Size = new System.Drawing.Size(106, 18);
            this.uiRadioButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton3.TabIndex = 10;
            this.uiRadioButton3.Text = "5ev-Bypass";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton2.Location = new System.Drawing.Point(75, 137);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton2.Size = new System.Drawing.Size(74, 18);
            this.uiRadioButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton2.TabIndex = 9;
            this.uiRadioButton2.Text = "DSView";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton1.Location = new System.Drawing.Point(75, 102);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.uiRadioButton1.Size = new System.Drawing.Size(74, 18);
            this.uiRadioButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton1.TabIndex = 8;
            this.uiRadioButton1.Text = "Kingst";
            // 
            // PathEditArea
            // 
            this.PathEditArea.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathEditArea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathEditArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PathEditArea.Location = new System.Drawing.Point(75, 41);
            this.PathEditArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathEditArea.MinimumSize = new System.Drawing.Size(1, 16);
            this.PathEditArea.Name = "PathEditArea";
            this.PathEditArea.Padding = new System.Windows.Forms.Padding(5);
            this.PathEditArea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.PathEditArea.ShowText = false;
            this.PathEditArea.Size = new System.Drawing.Size(361, 29);
            this.PathEditArea.Style = Sunny.UI.UIStyle.Custom;
            this.PathEditArea.TabIndex = 4;
            this.PathEditArea.Text = "请输入文件路径,如：E:\\config.txt";
            this.PathEditArea.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PathEditArea.Watermark = "";
            this.PathEditArea.MouseLeave += new System.EventHandler(this.PathEditArea_MouseLeave);
            this.PathEditArea.MouseHover += new System.EventHandler(this.PathEditArea_MouseHover);
            // 
            // BtnTransform
            // 
            this.BtnTransform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransform.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.FillPressColor = System.Drawing.Color.Silver;
            this.BtnTransform.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnTransform.ForeHoverColor = System.Drawing.Color.DimGray;
            this.BtnTransform.Location = new System.Drawing.Point(410, 368);
            this.BtnTransform.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnTransform.Name = "BtnTransform";
            this.BtnTransform.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnTransform.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.BtnTransform.Size = new System.Drawing.Size(72, 35);
            this.BtnTransform.Style = Sunny.UI.UIStyle.Custom;
            this.BtnTransform.TabIndex = 0;
            this.BtnTransform.Text = "生  成";
            this.BtnTransform.TipsColor = System.Drawing.Color.White;
            this.BtnTransform.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.Color.White;
            this.Tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.Tab1.Location = new System.Drawing.Point(201, 0);
            this.Tab1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(519, 438);
            this.Tab1.TabIndex = 1;
            this.Tab1.Text = "文  件";
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.Color.White;
            this.Tab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.Tab2.Location = new System.Drawing.Point(201, 0);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(519, 438);
            this.Tab2.TabIndex = 2;
            this.Tab2.Text = "配  置";
            // 
            // Tab3
            // 
            this.Tab3.AllowDrop = true;
            this.Tab3.BackColor = System.Drawing.Color.White;
            this.Tab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.Tab3.Location = new System.Drawing.Point(201, 0);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(519, 438);
            this.Tab3.TabIndex = 3;
            this.Tab3.Text = "设  置";
            // 
            // HomePage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.Tab0);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(53)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "昆  易  电  子";
            this.TopMost = true;
            this.Tab0.ResumeLayout(false);
            this.TabWnd.ResumeLayout(false);
            this.TabWnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu Tab0;
        private System.Windows.Forms.TabPage TabWnd;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.TabPage Tab3;
        private Sunny.UI.UIButton BtnTransform;
        private Sunny.UI.UITextBox PathEditArea;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
    }
}

