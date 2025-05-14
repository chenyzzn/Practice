namespace C_
{
    partial class Form1
    {
        private ComboBox Table;
        private ComboBox Item;
        private Button Send;
        private Button Data;
        private FlowLayoutPanel Tasks;

        private void InitializeComponent()
        {
            Table = new ComboBox();
            Item = new ComboBox();
            Send = new Button();
            Data= new Button();
            Tasks = new FlowLayoutPanel();
            SuspendLayout();

            // Table
            Table.FormattingEnabled = true;
            Table.Location = new Point(50, 50);
            Table.Name = "Table";
            Table.Text = "桌號";
            Table.Size = new Size(121, 23);
            Table.TabIndex = 0;
 
            // Item
            Item.FormattingEnabled = true;
            Item.Location = new Point(200, 50);
            Item.Name = "Item";
            Item.Text = "品項";
            Item.Size = new Size(121, 23);
            Item.TabIndex = 1;

            // buttonSend
            Send.Location = new Point(350, 50);
            Send.Name = "Send";
            Send.Text = "輸入";
            Send.Size = new Size(75, 23);
            Send.TabIndex = 2;
            Send.Click += new EventHandler(btnSend_Click);

            // Tasks
            Tasks.AutoScroll = true;
            Tasks.Location = new Point(50, 100);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(375, 300);
            Tasks.TabIndex = 3;

            //Database
            Data.Location = new Point(600, 350);
            Data.Name = "Data";
            Data.Text = "資料庫";
            Data.Size = new Size(75, 23);
            Data.TabIndex = 4;
            Data.Click += new EventHandler(btnForm2_Click);

            // Order system
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tasks);
            Controls.Add(Send);
            Controls.Add(Item);
            Controls.Add(Table);
            Controls.Add(Data);
            Name = "Order system";
            Text = "點餐系統";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
        }
    }
}
