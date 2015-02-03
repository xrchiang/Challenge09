using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STGCodeChallenge150203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DoTheWork();
        }

        private void DoTheWork()
        {
            // This assumes that the input is a comma-delimited list of integers
            // The range of a C# int is -2,147,483,648 to 2,147,483,647

            // Get the list of Fibonacci Sequence numbers that are in the int range
            List<int> FibNbrs = GetFibInts();

            try
            {
                List<int> InputNbrs = txtInput.Text.Split(',').Select(int.Parse).ToList();

                StringBuilder sb = new StringBuilder();
                foreach (int i in InputNbrs)
                {
                    if (sb.Length > 0)
                        sb.Append(",");
                    sb.Append(FibNbrs.Contains(i) ? "IsFibo" : "IsNotFibo");
                }
                MessageBox.Show(sb.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input was detected");
            }
        }

        private List<int> GetFibInts()
        {
            // Generate the list of Fibonacci Sequence numbers that are in the int range
            List<int> FibSeq = new List<int>();
            bool StillValid = true;

            FibSeq.Add(0);
            FibSeq.Add(1);

            while (StillValid)
            {
                long NextNbr;
                int indx = FibSeq.Count;
                NextNbr = (long)FibSeq[indx - 2] + FibSeq[indx - 1];

                StillValid = (NextNbr <= int.MaxValue);
                if (StillValid)
                    FibSeq.Add((int)NextNbr);
            }

            return FibSeq;
        }
    }
}
