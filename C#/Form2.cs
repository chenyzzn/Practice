using System.Data;

namespace C_
{
    public partial class Form2 : Form
    {
        private DataTable orderTable;

        public Form2(DataTable table)
        {
            InitializeComponent();
            orderTable = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Data.DataSource = orderTable;
        }
    }
}
