using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorts.Utils;
using Sorts.Sort;

namespace Sorts
{
    public partial class MainForm : Form
    {
        private int[] arr;
        private ISort sortStrategy;
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            genArrayBox.Text = string.Empty;
            arr = ArrayGenerator.Generate();
            try
            {
                string arrString = arr.ToText();
                genArrayBox.Text = arrString;
                sortBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                genArrayBox.Text = ex.Message;
            }
        }

        private void BubbleRb_CheckedChanged(object sender, EventArgs e)
        {
            sortStrategy = new BubbleSort();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            sortStrategy.Sort(arr, resultBox);
        }

        private void InsertRb_CheckedChanged(object sender, EventArgs e)
        {
            sortStrategy = new InsertionSort();
        }
    }
}
