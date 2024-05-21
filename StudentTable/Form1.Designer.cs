
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 556);
            this.Controls.Add(this.sqL_DataGridView_student);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SQLUI.SQL_DataGridView sqL_DataGridView_student;
    }
}

