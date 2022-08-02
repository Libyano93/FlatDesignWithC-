using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatDesign.Forms
{
    public partial class FrmMains : Form
    {
        public FrmMains()
        {
            InitializeComponent();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState ==FormWindowState.Normal )
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal ;

            }
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCapsulatin_Click(object sender, EventArgs e)
        {
            if (PnlMain.Size .Width ==175)
            {
                PnlMain.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                PnlMain.Width = 175;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
                button7.RightToLeft = RightToLeft.No;
            }
        }
    }
}
