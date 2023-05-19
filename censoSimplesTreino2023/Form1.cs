using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace censoSimplesTreino2023
{
    public partial class Form1 : Form
    {
        int idade = 0;
        int solteiro = 0;
        int casado = 0;
        int masculino = 0;
        int feminino = 0;
        int pessoas_cadastradas = 0;
        int menores_idade = 0;
        int idade_experiente = 0;
        string nome_experiente = "";
        string sexo_experiente = "";
        string civil_experiente = "";
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Criando condicionais para caso as caixas de texto fiquem vazias.
            if (string.IsNullOrEmpty(tb_idade.Text))
            {
                MessageBox.Show("Você não digitou sua idade");
                return;
            }
            if (string.IsNullOrEmpty(tb_nome.Text))
            {
                MessageBox.Show("Você não digitou seu nome");
                return;
            }
            if (string.IsNullOrEmpty(cb_civil.Text))
            {
                MessageBox.Show("Você não digitou seu estado cívil");
                return;
            }
            if(string.IsNullOrEmpty(cb_sexo.Text))
            {
                MessageBox.Show("Você não digitou seu sexo");
                return;
            }

            //Não é permitido digitar uma idade maior do que 110
            if (int.Parse(tb_idade.Text) > 110)
            {
                MessageBox.Show("Digite uma idade válida");
                return;
            }





            //Verificando se a pessoa é de maior ou não
            // Caso seja será adicionado no label "Maiores de idade:"
            // Caso não seja será adicionado no label "Menores de idade:"
            int maiorIdade = int.Parse(tb_idade.Text);
            if (maiorIdade >= 18)
            {
                idade++;
                lb_maioridade.Text = ($"Maiores de idade: {idade}");
            }
            if (maiorIdade < 18 && maiorIdade > 0)
            {
                menores_idade++;
                lb_menoresIdade.Text = ($"Menores de idade: {menores_idade}");
            }
           
          
            //Verificando se a pessoa é solteira ou casada
            /*Caso a pessoa não selecione uma opção aparecerá uma mensagem 
              avisando a pessoa para selecionar uma opção*/
            switch (cb_civil.Text)
            {
                case"Solteiro":
                    solteiro++;
                lb_solteiro.Text = ($"Solteiros: {solteiro}");
                    break;

                case "Casado":
                    casado++;
                    lb_casado.Text = ($"Casados: {casado}");
                    break;

                default:
                    MessageBox.Show("Por favor escolha um estado cívil válido");
                    break;
            }
            // Verificando o sexo da pessoa
            /*Caso a pessoa não selecione uma opção aparecerá uma mensagem 
              avisando a pessoa para selecionar uma opção*/
            switch (cb_sexo.Text)
            {
                case "Masculino":
                    masculino++;
                    lb_masculino.Text = ($"Masculino: {masculino}");
                    break;

                case "Feminino":
                    feminino++;
                    lb_feminino.Text = ($"Feminino: {feminino}");
                    break;

                default:
                    MessageBox.Show("Por favor selecione uma opção de sexo válida");
                    break;
            }
            //Verificando pessoas cadastradas
            pessoas_cadastradas++;
            lb_pessoas.Text = ($"Pessoas Cadastradas: {pessoas_cadastradas}");

            //Verificando a pessoa mais experiente (com mais idade)
            if (idade_experiente < int.Parse(tb_idade.Text))
            {
                nome_experiente = tb_nome.Text;
                idade_experiente = int.Parse(tb_idade.Text);
                sexo_experiente = cb_sexo.Text;
                civil_experiente = cb_civil.Text;
            }
            /*Exibindo na tela o nome,idade, sexo e 
             estado cívil da pessoa mais experiente */
            lb_experiente.Text = ($"Seu nome é {nome_experiente} você tem {idade_experiente} anos, é do " +
             $"sexo {sexo_experiente}, seu estado cívil é {civil_experiente} e é a pessoa mais experiente " +
                    $"desse censo");
           

        }

        private void tb_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Utilizando o método ApenasTexto para que o usuário não possa
              digitar números*/
            Program.ApenasTexto(e);
        }

        private void tb_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Utilizando o método ApenasNumero para que o usuário não possa
              digitar letras*/
            Program.ApenasNumero(e);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            //Limpando...
            tb_nome.Clear();
            tb_idade.Clear();
            cb_civil.SelectedIndex= -1;
            cb_sexo.SelectedIndex = -1;
        }
    }
}
