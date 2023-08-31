using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoverLabel
{
    public partial class Form1 : Form
    {
        Label lbl = new Label();
        int pasoHorizontal = 1;
        int pasoVertical = 1;
        int contador = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Red;
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(40, 40);
            lbl.Left = 100;
            lbl.Top = 100;
            this.Controls.Add(lbl);

            do
            {
                lbl.Left = lbl.Left + pasoHorizontal;
                lbl.Top = lbl.Top + pasoVertical;
                this.Refresh();
                if(this.Height < lbl.Top +  lbl.Height)
                {
                    pasoVertical = -1 * pasoVertical;
                }
                contador = contador - 1;

            } while (contador>0);

        }
    }
}
