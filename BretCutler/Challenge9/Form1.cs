using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge9 {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void cmdCalc_Click(object sender, EventArgs e) {

            lstResults.DataSource = GetResults(txtValues.Text);
        }

        private List<string> GetResults(string p) {

            List<string> rtn = new List<string>();

            string[] values = p.Split(',');

            for (int i = 0; i < values.Length; i++) {
                try {

                    long val = long.Parse(values[i]);

                    rtn.Add(string.Format("{0} - {1}", val, (val.IsFibonacci()) ? "IS Fibonacci" : "NOT Fibonacci"));

                } catch (Exception ex) {
                    rtn.Add(string.Format("{0} - Not Valid Entry", values[i]));
                }
            }

            return rtn;
        }
    }
}
