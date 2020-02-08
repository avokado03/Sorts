using System.Windows.Forms;

namespace Visualization
{
    public class BlocksMoving
    {
        public Panel[] Move(Panel[] panels, int from, int to)
        {
            var tempPanel = panels[from];
            panels[from] = panels[to];
            panels[to] = tempPanel;
            return panels;
        }
    }
}
