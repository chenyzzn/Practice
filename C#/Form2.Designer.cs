namespace C_
{
    partial class Form2
    {
        private Button Back;
        private System.Windows.Forms.DataGridView Data;
        private void InitializeComponent()
        {
            Back = new Button();
            Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(Data)).BeginInit();
            SuspendLayout();

            // buttonSend
            Back.Location = new Point(600, 350);
            Back.Name = "Back";
            Back.Text = "返回";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 0;

            // dataGridViewOrders
            Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data.Location = new System.Drawing.Point(12, 12);
            Data.Name = "dataGridViewOrders";
            Data.Size = new System.Drawing.Size(400, 250);
            Data.TabIndex = 1;
    
            // Order List
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Data);
            Name = "Order List";
            Text = "出餐紀錄";
            ((System.ComponentModel.ISupportInitialize)(Data)).EndInit();
            this.Load += new System.EventHandler(this.Form2_Load);
            ResumeLayout(false);
        }
    }
}
