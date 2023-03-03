using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buildInputForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declare
        public InputFormsBuilder ifb;
        //counter of Controlls added
        public int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
            ifb = new InputFormsBuilder(this);


            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Nume:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 20;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "numele de familie";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 20;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 20;


            ifb.showControls();


        }
    }
}
