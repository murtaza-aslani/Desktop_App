using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public class MainForm : Form
    {
        private TextBox messageTextBox;
        private Button showButton;

        public MainForm()
        {
            
            messageTextBox = new TextBox();
            showButton = new Button();

            messageTextBox.Location = new System.Drawing.Point(10, 10);
            messageTextBox.Size = new System.Drawing.Size(200, 20);


            showButton.Location = new System.Drawing.Point(10, 70);
            showButton.Size = new System.Drawing.Size(100, 30);
            showButton.Text = "Show";
            showButton.Click += ShowButton_Click;

           
            Controls.Add(messageTextBox);
            Controls.Add(showButton);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string name = messageTextBox.Text;


            MessageBox.Show("Message: " + name );
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}
