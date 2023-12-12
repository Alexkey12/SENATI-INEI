using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DESIGNER.Tools
{
    public   class Aviso
    {

        public void informar(string mensaje) 
        {
            MessageBox.Show(
                mensaje,
                "Informar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public void Advertir(string mensaje) 
        {
            MessageBox.Show(
                 mensaje,
                 "Advertencia",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
        }

        public void Preguntar(string mensaje) 
        {
            MessageBox.Show(
                  mensaje,
                  "preguntar",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);
        }
    }
}
