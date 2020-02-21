using InputForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPutApp
{
    public partial class Form1 : Form
    {
        private InputForm inp;
        public Form1()
        {
            InitializeComponent();

            inp = new InputForm(10, 10, this);

            inp.AddField("name", "Teljes név");
            inp.AddField("email", "E-Mail cím");
            inp.AddField("born", "Születési dátum");
            inp.AddButton("Regisztráció", ButtonClick);
        }
        
        private void ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show(inp.GetValue("name"));
        }
    }
}
