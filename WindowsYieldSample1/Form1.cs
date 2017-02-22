using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsYieldSample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resp1 = ObtenerPares(1, 100);



            var resp2 = ObtenerParesyield(1, 100);

            var resp3 = ObtenerParesyield(1, 100);



        }


        public static IEnumerable<int> ObtenerPares(int inicio, int fin)
        {
            List<int> pares = new List<int>();

            for (int i = inicio; i <= fin; i++)
                if ((i % 2) == 0)
                    pares.Add(i);

            return pares;
        }

        public static IEnumerable<int> ObtenerParesyield(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
            {
                if ((i % 2) == 0)
                {
                    yield return i;
                }
            }
        }

    }
}
