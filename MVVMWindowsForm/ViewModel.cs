using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMWindowsForm
{
    public class ViewModel
    {
        private Form1 _form1;

        public ViewModel(Form1 form1)
        {
            _form1 = form1;

            foreach(Control item in _form1.Controls)
            {
                if(item is Button)
                {
                    (item as Button).Click += new EventHandler(ViewModel_Click);
                }
            }

            Application.Run(_form1);
        }

        protected void ViewModel_Click(object sender, EventArgs args)
        {
            int result = 0;
            int cumul;
            foreach(Control item in _form1.Controls)
            {
                if (item is TextBox)
                {
                    if(int.TryParse((item as TextBox).Text, out cumul))
                    {
                        result += cumul;
                    }
                }
            }

            foreach(Control item in _form1.Controls)
            {
                if(item is Label && item.TabIndex == 5)
                {
                    (item as Label).Text = result.ToString();
                }
            }
        }
    }
}
