namespace Realtime_example
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_connectDB = new System.Windows.Forms.Button();
            this.dgv_DB = new System.Windows.Forms.DataGridView();
            this.cht_DB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_renewDB = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connectDB
            // 
            this.btn_connectDB.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_connectDB.Location = new System.Drawing.Point(829, 10);
            this.btn_connectDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connectDB.Name = "btn_connectDB";
            this.btn_connectDB.Size = new System.Drawing.Size(307, 44);
            this.btn_connectDB.TabIndex = 0;
            this.btn_connectDB.Text = "Connect to DB";
            this.btn_connectDB.UseVisualStyleBackColor = false;
            this.btn_connectDB.Click += new System.EventHandler(this.btn_connectDB_Click);
            // 
            // dgv_DB
            // 
            this.dgv_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DB.Location = new System.Drawing.Point(10, 10);
            this.dgv_DB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DB.Name = "dgv_DB";
            this.dgv_DB.RowHeadersWidth = 51;
            this.dgv_DB.RowTemplate.Height = 27;
            this.dgv_DB.Size = new System.Drawing.Size(813, 276);
            this.dgv_DB.TabIndex = 1;
            // 
            // cht_DB
            // 
            chartArea3.Name = "ChartArea1";
            this.cht_DB.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cht_DB.Legends.Add(legend3);
            this.cht_DB.Location = new System.Drawing.Point(10, 290);
            this.cht_DB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cht_DB.Name = "cht_DB";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cht_DB.Series.Add(series3);
            this.cht_DB.Size = new System.Drawing.Size(813, 302);
            this.cht_DB.TabIndex = 2;
            this.cht_DB.Text = "chart1";
            // 
            // btn_renewDB
            // 
            this.btn_renewDB.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_renewDB.Location = new System.Drawing.Point(829, 58);
            this.btn_renewDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_renewDB.Name = "btn_renewDB";
            this.btn_renewDB.Size = new System.Drawing.Size(307, 44);
            this.btn_renewDB.TabIndex = 4;
            this.btn_renewDB.Text = "Automatic renewal every 5 seconds ON / OFF";
            this.btn_renewDB.UseVisualStyleBackColor = false;
            this.btn_renewDB.Click += new System.EventHandler(this.btn_renewDB_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(830, 108);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.Size = new System.Drawing.Size(306, 482);
            this.tb_log.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1142, 602);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_renewDB);
            this.Controls.Add(this.cht_DB);
            this.Controls.Add(this.dgv_DB);
            this.Controls.Add(this.btn_connectDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connectDB;
        private System.Windows.Forms.DataGridView dgv_DB;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_DB;
        private System.Windows.Forms.Button btn_renewDB;
        private System.Windows.Forms.TextBox tb_log;
    }
}

