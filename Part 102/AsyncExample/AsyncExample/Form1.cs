using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacter()
        {
            int Count = 0;
            using (StreamReader reader = new StreamReader("C:\\Data\\data.txt"))
            {
                string content = reader.ReadToEnd();
                Count = content.Length;
                Thread.Sleep(5000);
            }
            return Count;
        }
        int count = 0;
        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => { count = CountCharacter();
             Action action = new Action(SetLabel);
                this.BeginInvoke(action);
            });

            thread.Start();

            lblCount.Text = "Processing file. Please wait...........";
       
        }
        private void SetLabel()
        {
            lblCount.Text = count.ToString() + " Characterin file.";
        }
    }
}
