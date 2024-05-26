using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLUI;
using Basic;

namespace StudentTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.button_init.Click += Button_init_Click;
            this.button_創建表單.Click += Button_創建表單_Click;
            this.button_新增.Click += Button_新增_Click;
            this.button_刪除.Click += Button_刪除_Click;
            this.button_顯示全部.Click += Button_顯示全部_Click;
            this.button_編輯.Click += Button_編輯_Click;
            this.button_創建表單.Enabled = false;
            




        }

        

        public enum enum_profile
        {
            GUID,
            名字,
            學號,
            地址,
            英文成績,
            加入時間
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyMessageBox.音效 = false;
            Button_init_Click(null, null);
        }
        private void Button_init_Click(object sender, EventArgs e)
        {
            Table table = new Table("profile");
            table.AddColumnList("GUID", Table.StringType.VARCHAR, 50, Table.IndexType.PRIMARY);
            table.AddColumnList("名字", Table.StringType.VARCHAR, 500, Table.IndexType.INDEX);
            table.AddColumnList("學號", Table.StringType.VARCHAR, 50, Table.IndexType.None);
            table.AddColumnList("地址", Table.StringType.VARCHAR, 50, Table.IndexType.None);
            table.AddColumnList("英文成績", Table.StringType.VARCHAR, 50, Table.IndexType.None);
            table.AddColumnList("加入時間", Table.DateType.DATETIME, 50, Table.IndexType.None);

            this.sqL_DataGridView_student.DataBaseName = "student";
            this.sqL_DataGridView_student.Server = "127.0.0.1";
            this.sqL_DataGridView_student.UserName = "user";
            this.sqL_DataGridView_student.Password = "66437068";
            this.sqL_DataGridView_student.Port = 3306;
            this.sqL_DataGridView_student.Init(table);

            //this.sqL_DataGridView_student.SQL_IsConnect(true);
            bool flag = this.sqL_DataGridView_student.SQL_IsConnect(false);
            Console.WriteLine($"測試{(flag ? "成功" : "失敗")}");

            this.button_創建表單.Enabled = true;
        }

        private void Button_顯示全部_Click(object sender, EventArgs e)
        {
            this.sqL_DataGridView_student.SQL_GetAllRows(true);
        }

        private void Button_創建表單_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sqL_DataGridView_student.SQL_IsTableCreat() == false)
                {
                    this.sqL_DataGridView_student.SQL_CreateTable();
                }
                else
                {
                    this.sqL_DataGridView_student.SQL_CheckAllColumnName(true);
                }
            }
            catch (Exception s)
            {
                MessageBox.Show($"Exception : {s.Message}");
            }
            finally
            {
                Console.WriteLine($"表單創建成功");
            }

            
        }
        private void Button_新增_Click(object sender, EventArgs e)
        {
            object[] value = new object[new enum_profile().GetLength()];
            value[(int)enum_profile.GUID] = Guid.NewGuid().ToString();
            value[(int)enum_profile.名字] = "DOG";
            value[(int)enum_profile.學號] = "111222";
            value[(int)enum_profile.地址] = "地下室";
            value[(int)enum_profile.英文成績] = "30";
            value[(int)enum_profile.加入時間] = DateTime.Now.ToDateTimeString_6();

            this.sqL_DataGridView_student.SQL_AddRow(value, true);
        }
        private void Button_刪除_Click(object sender, EventArgs e)
        {
            List<object[]> list_value = this.sqL_DataGridView_student.Get_All_Select_RowsValues();
            if (list_value.Count() == 0)
            {
                MyMessageBox.ShowDialog("未選取資料");
                return;
            }
            this.sqL_DataGridView_student.SQL_DeleteExtra(list_value, true);

        }
        private void Button_編輯_Click(object sender, EventArgs e)
        {
            List<object[]> list_value = this.sqL_DataGridView_student.Get_All_Select_RowsValues();
            if (list_value.Count() == 0)
            {
                MyMessageBox.ShowDialog("未選取資料");
                return;              
            }
            textBox_名字.Text = list_value[0][(int)enum_profile.名字].ObjectToString();
            textBox_學號.Text = list_value[0][(int)enum_profile.學號].ObjectToString();
            textBox_地址.Text = list_value[0][(int)enum_profile.地址].ObjectToString();
            textBox_英文成績.Text = list_value[0][(int)enum_profile.英文成績].ObjectToString();
        }


        

        
    }
}
