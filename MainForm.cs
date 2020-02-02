using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sorts.Sort;
using Sorts.Utils;
using Visualization;

namespace Sorts
{
    public partial class MainForm : Form
    {
        private int[] _generatedArray = Array.Empty<int>();
        private ISorter _sorterStrategy = new BubbleSort();
        private Panel[] _panels = Array.Empty<Panel>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            _generatedArray = ArrayGenerator.Generate();
            var genPanels = new BlocksGeneration(VisualPanel.Height, VisualPanel.Width);
            try
            {
                var arrString = _generatedArray.ToText();
                genArrayBox.Text = arrString;
                _panels = genPanels.Generate(_generatedArray);
                PaintPanels();
                sortBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                genArrayBox.Text = ex.Message;
            }
        }

        private void PaintPanels()
        {
            VisualPanel.Controls.Clear();
            VisualPanel.Controls.AddRange(_panels);
        }

        private void BubbleRb_CheckedChanged(object sender, EventArgs e)
        {
            _sorterStrategy = new BubbleSort();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = string.Empty;
            resultBox.Text = _sorterStrategy.Sort(_generatedArray);
            sortBtn.Enabled = false;
        }

        private void InsertRb_CheckedChanged(object sender, EventArgs e)
        {
            _sorterStrategy = new InsertionSort();
        }

        private void MergeRb_CheckedChanged(object sender, EventArgs e)
        {
            _sorterStrategy = new MergeSort();
        }

        private void CountingRb_CheckedChanged(object sender, EventArgs e)
        {
            _sorterStrategy = new CountingSort();
        }
    }
}
