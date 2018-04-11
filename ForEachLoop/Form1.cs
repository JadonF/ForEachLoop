/*
 * Created by: Jadon Fournier
 * Created on: 11-Apr-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program uses a for...each loop to change the colours on the form
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachLoop
{
    public partial class frmForEachLoop : Form
    {
        public frmForEachLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //loop it
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Red;
                }
            }
        }
    }
}
