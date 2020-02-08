using System.Drawing;
using System.Windows.Forms;
using Visualization.Customization;

namespace Visualization
{
    public class BlocksGeneration
    { 
        private ColorChoice colorChoice;
        private int _parentHeight = 0;
        private int _parentWidth = 0;

        public BlocksGeneration(int parentHeight, int parentWidth)
        {
            colorChoice = new ColorChoice();
            _parentHeight = parentHeight;
            _parentWidth = parentWidth;
        }
        public Panel[] Generate(int[] blocksValues)
        {
            int blockWidth = _parentWidth / blocksValues.Length;
            var panels = new Panel[blocksValues.Length];
            for (int i = 0; i<blocksValues.Length; i++)
            {
                var panel = new Panel();
                int blockHeight = _parentHeight / blocksValues.Length;
                panel.Width = blockWidth;
                panel.Height = blocksValues[i]*blockHeight;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = colorChoice.GetRandomColor();
                panel.Location = new Point(i*blockWidth, 0);
                panel.Top = _parentHeight - panel.Height;
                panels[i] = panel;
            }
            return panels;
        }
    }
}
