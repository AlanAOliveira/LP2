using Microsoft.VisualBasic;
using System.Collections;

namespace PTesteMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[20];
            string auxiliar;

            for (int i = 0; i < numeros.Length; i++)
            {
                auxiliar = Interaction.InputBox($"Digite um N°{i + 1}", "Entrada de dados");
                if (!int.TryParse(auxiliar, out numeros[i]))
                {
                    MessageBox.Show("Insira um Numero Valido");
                    i--;
                }
            }
            Array.Reverse(numeros);
            auxiliar = "";

            foreach (int numero in numeros)
            {
                auxiliar += numero + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            ArrayList nomes = new ArrayList() { "Ana", "André", "Debora", "Fatima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            nomes.Remove("Otávio");

            string lista = "";
            foreach (string nome in nomes)
            {
                lista += nome + "\n";
            }
            MessageBox.Show(lista);

        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            string auxiliar, medias = "";
            double media = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    media = 0;
                    auxiliar = Interaction.InputBox($"Para o {i + 1}° aluno digite a {j + 1}° nota", "Entrada de notas");
                    if (!double.TryParse(auxiliar, out notas[i, j]))
                    {
                        MessageBox.Show("Digite uma nota valida");
                        j--;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                media = 0;
                for (int j = 0; j < 3; j++)
                {
                    media += notas[i, j];
                }
                medias += $"Aluno {i + 1}: Média: {media / 3}\n";
            }
            MessageBox.Show(medias);
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"]?.Activate();
            }
            else
            {
                frmExercicio4 objFrm4 = new frmExercicio4();

                objFrm4.Show();
            }
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"]?.Activate();
            }
            else
            {
                frmExercicio5 objFrm5 = new frmExercicio5();

                objFrm5.Show();
            }
        }
    }
}
