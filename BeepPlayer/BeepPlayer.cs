using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BeepPlayer
{
    public partial class frmBeepPlayer : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
        
        int initWidth = 0;
        int initHeight = 0;
        Dictionary<string, Rect> initControl = new Dictionary<string, Rect>();
        Color originalButtonColor = SystemColors.Control;
        
        public frmBeepPlayer()
        {
            InitializeComponent();
            InitializeButton();
        }
        
        private void InitializeButton()
        {
            // 讓btn1~btn8共用同一個事件處理函式
            btn2.Click += btn1_Click_1;
            btn3.Click += btn1_Click_1;
            btn4.Click += btn1_Click_1;
            btn5.Click += btn1_Click_1;
            btn6.Click += btn1_Click_1;
            btn7.Click += btn1_Click_1;
            btn8.Click += btn1_Click_1;
        }
        
        private void frmBeepPlayer_Load(object sender, EventArgs e)
        {
            // 儲存表單的初始尺寸
            this.initWidth = this.Width;
            this.initHeight = this.Height;

            // 儲存所有控制項的初始位置和大小
            foreach (Control ctl in this.palMain.Controls)
            {
                this.initControl.Add(ctl.Name, new Rect(ctl.Left, ctl.Top, ctl.Width, ctl.Height));
            }
        }

        private async void btn1_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            // 儲存原始顏色
            Color originalColor = btn.BackColor;
            
            // 按下效果：改變背景顏色
            btn.BackColor = Color.LightBlue;
            btn.Enabled = false;
            
            // 使用非同步方式播放聲音，避免阻擋 UI
            await Task.Run(() => Beep(freq[btn.TabIndex], 300));
            
            // 還原顏色
            btn.BackColor = originalColor;
            btn.Enabled = true;
        }

        private void frmBeepPlayer_SizeChanged(object sender, EventArgs e)
        {
            // 防止 initWidth 或 initHeight 為 0 時發生錯誤
            if (this.initWidth <= 0 || this.initHeight <= 0)
                return;

            // 計算視窗大小的變化比例
            double widthRatio = (double)this.Width / this.initWidth;
            double heightRatio = (double)this.Height / this.initHeight;

            // 根據比例調整所有按鈕的位置和大小
            foreach (Control ctl in this.palMain.Controls)
            {
                if (initControl.ContainsKey(ctl.Name))
                {
                    Rect originalRect = initControl[ctl.Name];
                    
                    ctl.Left = (int)(originalRect.Left * widthRatio);
                    ctl.Top = (int)(originalRect.Top * heightRatio);
                    ctl.Width = (int)(originalRect.Width * widthRatio);
                    ctl.Height = (int)(originalRect.Height * heightRatio);
                }
            }
        }

        private void frmBeepPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要離開嗎?", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void palMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
