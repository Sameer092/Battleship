using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();

            desc.MaximumSize = new Size(478, 0);
            desc.AutoSize = true;

            label2.MaximumSize = new Size(478, 0);
            label2.AutoSize = true;

            label3.MaximumSize = new Size(478, 0);
            label3.AutoSize = true;

            label4.MaximumSize = new Size(478, 0);
            label4.AutoSize = true;

            label5.MaximumSize = new Size(478, 0);
            label5.AutoSize = true;
        }
    }
}
