
namespace StudentTable
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
            this.sqL_DataGridView_student = new SQLUI.SQL_DataGridView();
            this.button_init = new System.Windows.Forms.Button();
            this.button_創建表單 = new System.Windows.Forms.Button();
            this.button_新增 = new System.Windows.Forms.Button();
            this.button_刪除 = new System.Windows.Forms.Button();
            this.button_顯示全部 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqL_DataGridView_student
            // 
            this.sqL_DataGridView_student.AutoSelectToDeep = true;
            this.sqL_DataGridView_student.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_student.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_student.BorderRadius = 10;
            this.sqL_DataGridView_student.BorderSize = 2;
            this.sqL_DataGridView_student.CellBorderColor = System.Drawing.Color.White;
            this.sqL_DataGridView_student.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_student.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_student.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_student.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_student.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_student.columnHeaderBorderColor = System.Drawing.Color.DimGray;
            this.sqL_DataGridView_student.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_student.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_student.columnHeadersHeight = 18;
            this.sqL_DataGridView_student.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_student.DataGridViewAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sqL_DataGridView_student.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_student.ImageBox = false;
            this.sqL_DataGridView_student.Location = new System.Drawing.Point(1, 3);
            this.sqL_DataGridView_student.Name = "sqL_DataGridView_student";
            this.sqL_DataGridView_student.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_student.Password = "user82822040";
            this.sqL_DataGridView_student.Port = ((uint)(3306u));
            this.sqL_DataGridView_student.rowHeaderBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_student.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_student.RowsColor = System.Drawing.SystemColors.Control;
            this.sqL_DataGridView_student.RowsHeight = 10;
            this.sqL_DataGridView_student.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_student.selectedBorderSize = 0;
            this.sqL_DataGridView_student.selectedRowBackColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_student.selectedRowBorderColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_student.selectedRowForeColor = System.Drawing.Color.White;
            this.sqL_DataGridView_student.Server = "127.0.0.0";
            this.sqL_DataGridView_student.Size = new System.Drawing.Size(1254, 357);
            this.sqL_DataGridView_student.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_student.TabIndex = 0;
            this.sqL_DataGridView_student.UserName = "root";
            this.sqL_DataGridView_student.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_student.可選擇多列 = false;
            this.sqL_DataGridView_student.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_student.自動換行 = true;
            this.sqL_DataGridView_student.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_student.邊框樣式 = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqL_DataGridView_student.顯示CheckBox = false;
            this.sqL_DataGridView_student.顯示首列 = true;
            this.sqL_DataGridView_student.顯示首行 = true;
            this.sqL_DataGridView_student.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_student.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(12, 366);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(110, 46);
            this.button_init.TabIndex = 1;
            this.button_init.Text = "Init";
            this.button_init.UseVisualStyleBackColor = true;
            // 
            // button_創建表單
            // 
            this.button_創建表單.Location = new System.Drawing.Point(128, 366);
            this.button_創建表單.Name = "button_創建表單";
            this.button_創建表單.Size = new System.Drawing.Size(110, 46);
            this.button_創建表單.TabIndex = 1;
            this.button_創建表單.Text = "創建表單";
            this.button_創建表單.UseVisualStyleBackColor = true;
            // 
            // button_新增
            // 
            this.button_新增.Location = new System.Drawing.Point(244, 366);
            this.button_新增.Name = "button_新增";
            this.button_新增.Size = new System.Drawing.Size(110, 46);
            this.button_新增.TabIndex = 1;
            this.button_新增.Text = "新增";
            this.button_新增.UseVisualStyleBackColor = true;
            // 
            // button_刪除
            // 
            this.button_刪除.Location = new System.Drawing.Point(360, 366);
            this.button_刪除.Name = "button_刪除";
            this.button_刪除.Size = new System.Drawing.Size(110, 46);
            this.button_刪除.TabIndex = 1;
            this.button_刪除.Text = " 刪除";
            this.button_刪除.UseVisualStyleBackColor = true;
            // 
            // button_顯示全部
            // 
            this.button_顯示全部.Location = new System.Drawing.Point(128, 418);
            this.button_顯示全部.Name = "button_顯示全部";
            this.button_顯示全部.Size = new System.Drawing.Size(110, 46);
            this.button_顯示全部.TabIndex = 1;
            this.button_顯示全部.Text = "顯示全部";
            this.button_顯示全部.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 556);
            this.Controls.Add(this.button_顯示全部);
            this.Controls.Add(this.button_刪除);
            this.Controls.Add(this.button_新增);
            this.Controls.Add(this.button_創建表單);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.sqL_DataGridView_student);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SQLUI.SQL_DataGridView sqL_DataGridView_student;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Button button_創建表單;
        private System.Windows.Forms.Button button_新增;
        private System.Windows.Forms.Button button_刪除;
        private System.Windows.Forms.Button button_顯示全部;
    }
}

