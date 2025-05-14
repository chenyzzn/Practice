using System.Data;

namespace C_
{
    public class Control : UserControl
    {
        private Label labelTask = new Label();
        private ProgressBar Bar = new ProgressBar();
        private Button btnPause = new Button();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer cTimer = new System.Windows.Forms.Timer();
        private bool Paused = false;
        private bool Done = false;
        private bool Enabled = true;

        //private double counter = 0;

    public Control(string taskText)
    {
        InitializeComponent();
        labelTask.Text = taskText;
    }

        private void InitializeComponent()
        {
            // labelTask
            labelTask.AutoSize = true;
            labelTask.Location = new Point(3, 3);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(70, 15);
            labelTask.TabIndex = 0;

            // progressBar
            Bar.Location = new Point(150, 3);
            Bar.Name = "progressBar";
            Bar.Size = new Size(100, 23);
            Bar.TabIndex = 1;
            Bar.Value = 0;

            // buttonPause
            btnPause.Location = new Point(260, 3);
            btnPause.Name = "buttonPause";
            btnPause.Size = new Size(50, 23);
            btnPause.TabIndex = 2;
            btnPause.Text = "暫停";
            btnPause.BackColor = Color.Crimson;
            btnPause.Click += new EventHandler(btnPause_Click);

            // TaskItemControl
            Controls.Add(labelTask);
            Controls.Add(Bar);
            Controls.Add(btnPause);
            Size = new Size(320, 30);
            ResumeLayout(false);
            PerformLayout();

            // Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            // Counter
            //counter = 0;  
            //cTimer.Interval = 1000;
            //cTimer.Tick += new EventHandler(cTimer_Tick);
            //cTimer.Start();  
        }

        private void btnPause_Click(object sender, EventArgs e)
        {   
            if(Done)
            {
            //    Enabled = false;
                Parent?.Controls.Remove(this);
            }
            else
            {
                if (Paused)
                {
                    timer.Start();
                    btnPause.Text = "暫停";
                    btnPause.BackColor = Color.Crimson;
                }
                else
                {
                    timer.Stop();
                    btnPause.Text = "繼續";
                    btnPause.BackColor = Color.BlanchedAlmond;
                }
                Paused = !Paused;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Bar.Value < 100)
            {
                Bar.Value += 10;
            }
            else
            {
                timer.Stop();
                Done = true;
                btnPause.Text = "送出";
                btnPause.BackColor = Color.DarkSeaGreen;
            }
        }

        //private void cTimer_Tick(object sender, EventArgs e)
        //{
        //    if (Enabled)
        //    {
        //        counter += 1;
        //    }
        //    else
        //    {
        //        cTimer.Stop();
        //        Parent?.Controls.Remove(this);
        //    }
        //}
    }
}