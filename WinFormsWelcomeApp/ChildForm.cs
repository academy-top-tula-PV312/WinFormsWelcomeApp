using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWelcomeApp
{
    public partial class ChildForm : Form
    {
        Form? parent = null;
        public ChildForm()
        {
            InitializeComponent();
        }

        public ChildForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parent is not null)
                parent.BackColor = Color.Aqua;
        }
    }
}
