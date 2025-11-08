using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkNotes.Views.UserControls
{
    public partial class UCInicio : UserControl
    {
        public UCInicio(string numero)
        {
            InitializeComponent();
            lblNotasTotalCreadas.Text = numero;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, circlePanel.Width, circlePanel.Height);
            circlePanel.Region = new Region(path);
        }//Mady by Lexor_12 || kennygamer17 on github
    }
}
