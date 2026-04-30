namespace BeepPlayer
{
    partial class frmBeepPlayer
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
            this.btn1 = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Tomato;
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(35, 52);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 132);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Do";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Location = new System.Drawing.Point(28, 12);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(853, 222);
            this.palMain.TabIndex = 1;
            this.palMain.Paint += new System.Windows.Forms.PaintEventHandler(this.palMain_Paint);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Pink;
            this.btn8.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.ForeColor = System.Drawing.Color.Crimson;
            this.btn8.Location = new System.Drawing.Point(735, 52);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(94, 132);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Do";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.MediumPurple;
            this.btn7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(635, 52);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(94, 132);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Si";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(535, 52);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(94, 132);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "La";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(435, 52);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(94, 132);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Sol";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Green;
            this.btn4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(335, 52);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 132);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Fa";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(235, 52);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 132);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Mi";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Orange;
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(135, 52);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 132);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Re";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // frmBeepPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(914, 252);
            this.Controls.Add(this.palMain);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBeepPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "簡易電子琴";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeepPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmBeepPlayer_Load);
            this.SizeChanged += new System.EventHandler(this.frmBeepPlayer_SizeChanged);
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
    }
}

