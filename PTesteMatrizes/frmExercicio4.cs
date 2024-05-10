using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMatrizes
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[6];
            int[] comprimento = new int[6];
            string auxiliar = "";

            for (int i = 0; i < 6; i++)
            {
                nomes[i] = Interaction.InputBox($"Entre com o {i + 1}° nome", "Entre com os nomes");
                comprimento[i] = nomes[i].Replace(" ","").Length;
                auxiliar = $"o nome {nomes[i]} tem {comprimento[i]} caracteres";
                lstbxNomes.Items.Add(auxiliar);
            }

        }
    }
}
