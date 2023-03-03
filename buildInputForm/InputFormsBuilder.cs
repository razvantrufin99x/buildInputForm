using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace buildInputForm
{
    public class InputFormsBuilder
    {
        public Form forma;
        public List<Control> listControls = new List<Control>();

        public InputFormsBuilder()
        {

        }
        public InputFormsBuilder( Form f )
        {
            forma = f;
        }

        public void addControl(ref Control c)
        {
            listControls.Add(c);
        }
        public void addControl(Control c)
        {
            listControls.Add(c);
        }
        public void showControls()
        {
            for(int i = 0; i<listControls.Count; i++)
            {
                forma.Controls.Add(listControls[i]);
            }
        }
    }
}
