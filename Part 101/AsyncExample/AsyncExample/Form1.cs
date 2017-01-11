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
                using (StreamReader reader = new StreamReader(@"F:\Programming With DOT NET\C# Console Application\PraGimTech Youtube\Part 101\Data\data.txt"))
                {
                    string content = reader.ReadToEnd();
                    Count = content.Length;
                    Thread.Sleep(5000);
                }         
            return Count;
        }
        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacter);
            task.Start();

            lblCount.Text = "Processing file. Please wait...........";
            int count = await task;
            lblCount.Text = count.ToString() + " Characters in file.";
        }
    }
}
