using System.Data;

namespace C_
{
    public partial class Form1 : Form
    {
        private int num = 0;
        private DataTable orderTable; 
        public Form1()
        {
            InitializeComponent();
            orderTable = new DataTable();
            orderTable.Columns.Add("Number", typeof(int));
            orderTable.Columns.Add("Table", typeof(string));
            orderTable.Columns.Add("Item", typeof(string));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table.Items.AddRange(new string[] { "1桌", "2桌", "3桌" });
            Item.Items.AddRange(new string[] { "滷肉飯", "牛肉麵", "豬肉餡餅" });
            Table.SelectedItem = null;
            Item.SelectedItem = null;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string selectedTable = Table.SelectedItem?.ToString() ?? "未選擇桌號";
            string selectedItem = Item.SelectedItem?.ToString() ?? "未選擇品項";
            
            if (Table.SelectedItem == null || Item.SelectedItem == null)
            {
                MessageBox.Show("請先選擇桌號和品項。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string taskText = $"{selectedTable} 點選了 {selectedItem}";
                Control taskItem = new Control(taskText);
                Tasks.Controls.Add(taskItem);
                num += 1;
                
                DataRow newRow = orderTable.NewRow();
                newRow["Number"] = num;
                newRow["Table"] = selectedTable;
                newRow["Item"] = selectedItem;
                orderTable.Rows.Add(newRow);
            }
        }
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(orderTable);
            form2.Show();
        }
    }
}
