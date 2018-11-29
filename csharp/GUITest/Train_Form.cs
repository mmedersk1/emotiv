using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITest
{
    public partial class Train_Form : Form
    {
        public Train_Form()
        {
            InitializeComponent();
        }

        private void Train_Form_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button2.Name = "button2";
                button2.Size = new System.Drawing.Size(75, 23);
                button2.TabIndex = 0;
                button2.UseVisualStyleBackColor = true;
                button2.Location = new Point(57, 440);
                button2.Text = textBox1.Text;
                this.Controls.Add(button2);
            }
        }
    }
}
