using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituacaoAprendizagemReceitaCulinaria
{
    public partial class FrmPrincipal : Form
    {
        // Variaveis globais
        int i = 0;

        int contador = 0;

        //Receita teste = new Receita();
        Receita[] receitas = new Receita[100];
        Receita aux = new Receita();

        public void LimpaTelaCadastro()
        {

            txtCadModoPreparo.Clear();
            txtCadNome1.Clear();
            txtCadNomeReceita.Clear();
            txtCadNumPessoas.Clear();
            txtCadPreco.Clear();
            txtCadQtd1.Clear();
            txtCadTempoEstimado.Clear();

            cmbCadCategoria.Text = "";
            cmbCadDificuldade.Text = "";

            txtCadNome1.Clear();
            txtCadNome2.Clear();
            txtCadNome3.Clear();
            txtCadNome4.Clear();
            txtCadNome5.Clear();
            txtCadNome6.Clear();
            txtCadNome7.Clear();
            txtCadNome8.Clear();


            txtCadQtd1.Clear();
            txtCadQtd2.Clear();
            txtCadQtd3.Clear();
            txtCadQtd4.Clear();
            txtCadQtd5.Clear();
            txtCadQtd6.Clear();
            txtCadQtd7.Clear();
            txtCadQtd8.Clear();

        }

        public void LimpaTelaEdit()
        {
            txtEditModoPreparo.Clear();
            txtEditTempoEstimado.Clear();
            txtEditNumPessoas.Clear();
            txtEditPreco.Clear();
            cmbEditCategoria.Text = "";
            cmbEditDificuldade.Text = "";
            cmbEditNomeReceita.Text = "";

            txtEditNome1.Text = "";
            txtEditNome2.Text = "";
            txtEditNome3.Text = "";
            txtEditNome4.Text = "";
            txtEditNome5.Text = "";
            txtEditNome6.Text = "";
            txtEditNome7.Text = "";
            txtEditNome8.Text = "";


            txtEditQtd1.Text = "";
            txtEditQtd2.Text = "";
            txtEditQtd3.Text = "";
            txtEditQtd4.Text = "";
            txtEditQtd5.Text = "";
            txtEditQtd6.Text = "";
            txtEditQtd7.Text = "";
            txtEditQtd8.Text = "";

        }

        public void LimpaTelaVisualizarDificuldade()
        {
            txtVisDifNumPessoas.Text = "";
            txtVisDifPreco.Text = "";
            txtVisDifTempoEstimado.Text = "";
            txtVisDifModoPreparo.Text = "";
            txtVisDifCategoria.Text = "";


            txtVisDifIngrediente1.Text = "";
            txtVisDifIngrediente2.Text = "";
            txtVisDifIngrediente3.Text = "";
            txtVisDifIngrediente4.Text = "";
            txtVisDifIngrediente5.Text = "";
            txtVisDifIngrediente6.Text = "";
            txtVisDifIngrediente7.Text = "";
            txtVisDifIngrediente8.Text = "";

            txtVisDifQtdIngrediente1.Text = "";
            txtVisDifQtdIngrediente2.Text = "";
            txtVisDifQtdIngrediente3.Text = "";
            txtVisDifQtdIngrediente4.Text = "";
            txtVisDifQtdIngrediente5.Text = "";
            txtVisDifQtdIngrediente6.Text = "";
            txtVisDifQtdIngrediente7.Text = "";
            txtVisDifQtdIngrediente8.Text = "";
        }

        public void LimpaTelaVisualizarCategoria()
        {
            txtVisCatNumPessoas.Text = "";
            txtVisCatPreco.Text = "";
            txtVisCatTempoEstimado.Text = "";
            txtVisCatModoPreparo.Text = "";
            txtVisCatDificuldade.Text = "";


            txtVisCatIngrediente1.Text = "";
            txtVisCatIngrediente2.Text = "";
            txtVisCatIngrediente3.Text = "";
            txtVisCatIngrediente4.Text = "";
            txtVisCatIngrediente5.Text = "";
            txtVisCatIngrediente6.Text = "";
            txtVisCatIngrediente7.Text = "";
            txtVisCatIngrediente8.Text = "";

            txtVisCatQtdIngred1.Text = "";
            txtVisCatQtdIngred2.Text = "";
            txtVisCatQtdIngred3.Text = "";
            txtVisCatQtdIngred4.Text = "";
            txtVisCatQtdIngred5.Text = "";
            txtVisCatQtdIngred6.Text = "";
            txtVisCatQtdIngred7.Text = "";
            txtVisCatQtdIngred8.Text = "";
        }

        public void LimpaTelaVisualizarTempo()
        {
            txtVisTemNumPessoas.Text = "";
            txtVisTemPreco.Text = "";
            txtVisTemModoPreparo.Text = "";
            txtVisTemCategoria.Text = "";
            txtVisTemDificuldade.Text = "";

            txtVisTemIngrediente1.Text = "";
            txtVisTemIngrediente2.Text = "";
            txtVisTemIngrediente3.Text = "";
            txtVisTemIngrediente4.Text = "";
            txtVisTemIngrediente5.Text = "";
            txtVisTemIngrediente6.Text = "";
            txtVisTemIngrediente7.Text = "";
            txtVisTemIngrediente8.Text = "";

            txtVisTemQtdIngred1.Text = "";
            txtVisTemQtdIngred2.Text = "";
            txtVisTemQtdIngred3.Text = "";
            txtVisTemQtdIngred4.Text = "";
            txtVisTemQtdIngred5.Text = "";
            txtVisTemQtdIngred6.Text = "";
            txtVisTemQtdIngred7.Text = "";
            txtVisTemQtdIngred8.Text = "";
        }

        public FrmPrincipal()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                receitas[i] = new Receita();

                for (int j = 0; j < 8; j++)
                {
                    receitas[i].Ingredientes[j] = new Ingrediente();
                }

            }

        }

        private void BtnCadSalvar_Click(object sender, EventArgs e)
        {
            string nomeReceita = txtCadNomeReceita.Text;
            string numPessoas = txtCadNumPessoas.Text;
            string tempo = txtCadTempoEstimado.Text;
            string dificuldade = cmbCadDificuldade.Text;
            string categoria = cmbCadCategoria.Text;
            string modoPreparo = txtCadModoPreparo.Text;
            string preco = txtCadPreco.Text;

            string nome1 = txtCadNome1.Text;
            string nome2 = txtCadNome2.Text;
            string nome3 = txtCadNome3.Text;
            string nome4 = txtCadNome4.Text;
            string nome5 = txtCadNome5.Text;
            string nome6 = txtCadNome6.Text;
            string nome7 = txtCadNome7.Text;
            string nome8 = txtCadNome8.Text;

            string qtd1 = txtCadQtd1.Text;
            string qtd2 = txtCadQtd2.Text;
            string qtd3 = txtCadQtd3.Text;
            string qtd4 = txtCadQtd4.Text;
            string qtd5 = txtCadQtd5.Text;
            string qtd6 = txtCadQtd6.Text;
            string qtd7 = txtCadQtd7.Text;
            string qtd8 = txtCadQtd8.Text;

            receitas[i].Nome = nomeReceita;
            receitas[i].NumPessoas = numPessoas;
            receitas[i].TempoPreparo = tempo;
            receitas[i].Dificuldade = dificuldade;
            receitas[i].Categoria = categoria;
            receitas[i].ModoPreparo = modoPreparo;
            receitas[i].Preco = preco;

            receitas[i].Ingredientes[0].Nome = nome1;
            receitas[i].Ingredientes[1].Nome = nome2;
            receitas[i].Ingredientes[2].Nome = nome3;
            receitas[i].Ingredientes[3].Nome = nome4;
            receitas[i].Ingredientes[4].Nome = nome5;
            receitas[i].Ingredientes[5].Nome = nome6;
            receitas[i].Ingredientes[6].Nome = nome7;
            receitas[i].Ingredientes[7].Nome = nome8;

            receitas[i].Ingredientes[0].Quantidade = qtd1;
            receitas[i].Ingredientes[1].Quantidade = qtd2;
            receitas[i].Ingredientes[2].Quantidade = qtd3;
            receitas[i].Ingredientes[3].Quantidade = qtd4;
            receitas[i].Ingredientes[4].Quantidade = qtd5;
            receitas[i].Ingredientes[5].Quantidade = qtd6;
            receitas[i].Ingredientes[6].Quantidade = qtd7;
            receitas[i].Ingredientes[7].Quantidade = qtd8;



            i++;
            contador++;

            cmbVisTodasNomeReceita.Items.Add(nomeReceita);
            cmbVisCatNomeReceita.Items.Add(nomeReceita);
            cmbVisTemNomeReceita.Items.Add(nomeReceita);
            cmbCotIngNomeReceita.Items.Add(nomeReceita);
            cmbVisTemTempoEstimado.Items.Add(tempo);





            LimpaTelaCadastro();
        }

        private void BtnCadLimpar_Click(object sender, EventArgs e)
        {
            LimpaTelaCadastro();
        }

        private void BtnEditLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbEditNomeReceita.Text == receitas[i].Nome)
                {
                    cmbEditNomeReceita.Items.Remove(receitas[i].Nome);
                    cmbVisTodasNomeReceita.Items.Remove(receitas[i].Nome);
                    cmbVisCatNomeReceita.Items.Remove(receitas[i].Nome);
                    cmbVisDifNomeReceita.Items.Remove(receitas[i].Nome);
                    cmbVisTemNomeReceita.Items.Remove(receitas[i].Nome);
                    cmbCotIngNomeReceita.Items.Remove(receitas[i].Nome);


                    receitas[i].Nome = null;
                    receitas[i].NumPessoas = null;
                    receitas[i].Preco = null;
                    receitas[i].TempoPreparo = null;
                    receitas[i].ModoPreparo = null;

                    receitas[i].Categoria = null;
                    receitas[i].Dificuldade = null;

                    receitas[i].Ingredientes[0].Nome = null;
                    receitas[i].Ingredientes[1].Nome = null;
                    receitas[i].Ingredientes[2].Nome = null;
                    receitas[i].Ingredientes[3].Nome = null;
                    receitas[i].Ingredientes[4].Nome = null;
                    receitas[i].Ingredientes[5].Nome = null;
                    receitas[i].Ingredientes[6].Nome = null;
                    receitas[i].Ingredientes[7].Nome = null;

                    receitas[i].Ingredientes[0].Quantidade = null;
                    receitas[i].Ingredientes[1].Quantidade = null;
                    receitas[i].Ingredientes[2].Quantidade = null;
                    receitas[i].Ingredientes[3].Quantidade = null;
                    receitas[i].Ingredientes[4].Quantidade = null;
                    receitas[i].Ingredientes[5].Quantidade = null;
                    receitas[i].Ingredientes[6].Quantidade = null;
                    receitas[i].Ingredientes[7].Quantidade = null;
                }
            }

            LimpaTelaEdit();
        }

        private void CmbEditNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbEditNomeReceita.Text == receitas[i].Nome)
                {
                    txtEditNumPessoas.Text = receitas[i].NumPessoas;
                    txtEditPreco.Text = receitas[i].Preco;
                    txtEditTempoEstimado.Text = receitas[i].TempoPreparo;
                    txtEditModoPreparo.Text = receitas[i].ModoPreparo;

                    cmbEditCategoria.Text = receitas[i].Categoria;
                    cmbEditDificuldade.Text = receitas[i].Dificuldade;

                    txtEditNome1.Text = receitas[i].Ingredientes[0].Nome;
                    txtEditNome2.Text = receitas[i].Ingredientes[1].Nome;
                    txtEditNome3.Text = receitas[i].Ingredientes[2].Nome;
                    txtEditNome4.Text = receitas[i].Ingredientes[3].Nome;
                    txtEditNome5.Text = receitas[i].Ingredientes[4].Nome;
                    txtEditNome6.Text = receitas[i].Ingredientes[5].Nome;
                    txtEditNome7.Text = receitas[i].Ingredientes[6].Nome;
                    txtEditNome8.Text = receitas[i].Ingredientes[7].Nome;

                    txtEditQtd1.Text = receitas[i].Ingredientes[0].Quantidade;
                    txtEditQtd2.Text = receitas[i].Ingredientes[1].Quantidade;
                    txtEditQtd3.Text = receitas[i].Ingredientes[2].Quantidade;
                    txtEditQtd4.Text = receitas[i].Ingredientes[3].Quantidade;
                    txtEditQtd5.Text = receitas[i].Ingredientes[4].Quantidade;
                    txtEditQtd6.Text = receitas[i].Ingredientes[5].Quantidade;
                    txtEditQtd7.Text = receitas[i].Ingredientes[6].Quantidade;
                    txtEditQtd8.Text = receitas[i].Ingredientes[7].Quantidade;
                    aux.contador = i;
                }
            }
        }

        private void BtnEditSalvar_Click(object sender, EventArgs e)
        {
            string nomeReceita = cmbEditNomeReceita.Text;
            string numPessoas = txtEditNumPessoas.Text;
            string tempo = txtEditTempoEstimado.Text;
            string dificuldade = cmbEditDificuldade.Text;
            string categoria = cmbEditCategoria.Text;
            string modoPreparo = txtEditModoPreparo.Text;
            string preco = txtEditPreco.Text;

            string nome1 = txtEditNome1.Text;
            string nome2 = txtEditNome2.Text;
            string nome3 = txtEditNome3.Text;
            string nome4 = txtEditNome4.Text;
            string nome5 = txtEditNome5.Text;
            string nome6 = txtEditNome6.Text;
            string nome7 = txtEditNome7.Text;
            string nome8 = txtEditNome8.Text;

            string qtd1 = txtEditQtd1.Text;
            string qtd2 = txtEditQtd2.Text;
            string qtd3 = txtEditQtd3.Text;
            string qtd4 = txtEditQtd4.Text;
            string qtd5 = txtEditQtd5.Text;
            string qtd6 = txtEditQtd6.Text;
            string qtd7 = txtEditQtd7.Text;
            string qtd8 = txtEditQtd8.Text;

            for (int i = 0; i < 100; i++)
            {
                if (i == aux.contador)
                {
                    receitas[i].Nome = nomeReceita;
                    receitas[i].NumPessoas = numPessoas;
                    receitas[i].TempoPreparo = tempo;
                    receitas[i].Dificuldade = dificuldade;
                    receitas[i].Categoria = categoria;
                    receitas[i].ModoPreparo = modoPreparo;
                    receitas[i].Preco = preco;

                    receitas[i].Ingredientes[0].Nome = nome1;
                    receitas[i].Ingredientes[1].Nome = nome2;
                    receitas[i].Ingredientes[2].Nome = nome3;
                    receitas[i].Ingredientes[3].Nome = nome4;
                    receitas[i].Ingredientes[4].Nome = nome5;
                    receitas[i].Ingredientes[5].Nome = nome6;
                    receitas[i].Ingredientes[6].Nome = nome7;
                    receitas[i].Ingredientes[7].Nome = nome8;

                    receitas[i].Ingredientes[0].Quantidade = qtd1;
                    receitas[i].Ingredientes[1].Quantidade = qtd2;
                    receitas[i].Ingredientes[2].Quantidade = qtd3;
                    receitas[i].Ingredientes[3].Quantidade = qtd4;
                    receitas[i].Ingredientes[4].Quantidade = qtd5;
                    receitas[i].Ingredientes[5].Quantidade = qtd6;
                    receitas[i].Ingredientes[6].Quantidade = qtd7;
                    receitas[i].Ingredientes[7].Quantidade = qtd8;
                }
            }

            cmbEditNomeReceita.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (receitas[i].Nome != null)
                {
                    cmbEditNomeReceita.Items.Add(receitas[i].Nome);
                }
            }
            contador++;

            LimpaTelaEdit();
        }

        private void CmbVisTodasNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cmbVisCatCategoria.Text;
            cmbVisCatNomeReceita.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (categoria == receitas[i].Categoria)
                {
                    cmbVisCatNomeReceita.Items.Add(receitas[i].Nome);
                }
            }

            LimpaTelaVisualizarCategoria();

           
        }


        private void CmbVisDifDificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dificuldade = cmbVisDifDificuldade.Text;
            cmbVisDifNomeReceita.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (dificuldade == receitas[i].Dificuldade)
                {
                    cmbVisDifNomeReceita.Items.Add(receitas[i].Nome);
                }
            }

            LimpaTelaVisualizarDificuldade();
        }

        private void CmbVisCatCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i <= contador; i++)
            {
                if (cmbVisTodasNomeReceita.Text == receitas[i].Nome)
                {
                    txtVisTodasNumPessoas.Text = receitas[i].TempoPreparo;
                    txtVisTodasPreco.Text = receitas[i].Preco;
                    txtVisTodasTempoEstimado.Text = receitas[i].TempoPreparo;
                    txtVisTodasModoPreparo.Text = receitas[i].ModoPreparo;
                    txtVisTodasCategoria.Text = receitas[i].Categoria;
                    txtVisTodasDificuldade.Text = receitas[i].Dificuldade;

                    txtVisTodasIngrediente1.Text = receitas[i].Ingredientes[0].Nome;
                    txtVisTodasIngrediente2.Text = receitas[i].Ingredientes[1].Nome;
                    txtVisTodasIngrediente3.Text = receitas[i].Ingredientes[2].Nome;
                    txtVisTodasIngrediente4.Text = receitas[i].Ingredientes[3].Nome;
                    txtVisTodasIngrediente5.Text = receitas[i].Ingredientes[4].Nome;
                    txtVisTodasIngrediente6.Text = receitas[i].Ingredientes[5].Nome;
                    txtVisTodasIngrediente7.Text = receitas[i].Ingredientes[6].Nome;
                    txtVisTodasIngrediente8.Text = receitas[i].Ingredientes[7].Nome;

                    txtVisTodasQtdIngrediente1.Text = receitas[i].Ingredientes[0].Quantidade;
                    txtVisTodasQtdIngrediente2.Text = receitas[i].Ingredientes[1].Quantidade;
                    txtVisTodasQtdIngrediente3.Text = receitas[i].Ingredientes[2].Quantidade;
                    txtVisTodasQtdIngrediente4.Text = receitas[i].Ingredientes[3].Quantidade;
                    txtVisTodasQtdIngrediente5.Text = receitas[i].Ingredientes[4].Quantidade;
                    txtVisTodasQtdIngrediente6.Text = receitas[i].Ingredientes[5].Quantidade;
                    txtVisTodasQtdIngrediente7.Text = receitas[i].Ingredientes[6].Quantidade;
                    txtVisTodasQtdIngrediente8.Text = receitas[i].Ingredientes[7].Quantidade;

                }
            }

            string categoria = cmbVisCatCategoria.Text;
            cmbVisCatNomeReceita.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (categoria == receitas[i].Categoria)
                {
                    cmbVisCatNomeReceita.Items.Add(receitas[i].Nome);
                }
            }

            LimpaTelaVisualizarCategoria();

        }

        private void CmbVisTemTempoEstimado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempo = cmbVisTemTempoEstimado.Text;
            cmbVisTemNomeReceita.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (tempo == receitas[i].TempoPreparo)
                {
                    cmbVisTemNomeReceita.Items.Add(receitas[i].Nome);
                }
            }
            LimpaTelaVisualizarTempo();
        }

        private void CmbCotIngNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbCotIngNomeReceita.Text == receitas[i].Nome)
                {
                    txtCotIngIngrediente1.Text = receitas[i].Ingredientes[0].Nome;
                    txtCotIngIngrediente2.Text = receitas[i].Ingredientes[1].Nome;
                    txtCotIngIngrediente3.Text = receitas[i].Ingredientes[2].Nome;
                    txtCotIngIngrediente4.Text = receitas[i].Ingredientes[3].Nome;
                    txtCotIngIngrediente5.Text = receitas[i].Ingredientes[4].Nome;
                    txtCotIngIngrediente6.Text = receitas[i].Ingredientes[5].Nome;
                    txtCotIngIngrediente7.Text = receitas[i].Ingredientes[6].Nome;
                    txtCotIngIngrediente8.Text = receitas[i].Ingredientes[7].Nome;

                    txtCotIngQtdIngred1.Text = receitas[i].Ingredientes[0].Quantidade;
                    txtCotIngQtdIngred2.Text = receitas[i].Ingredientes[1].Quantidade;
                    txtCotIngQtdIngred3.Text = receitas[i].Ingredientes[2].Quantidade;
                    txtCotIngQtdIngred4.Text = receitas[i].Ingredientes[3].Quantidade;
                    txtCotIngQtdIngred5.Text = receitas[i].Ingredientes[4].Quantidade;
                    txtCotIngQtdIngred6.Text = receitas[i].Ingredientes[5].Quantidade;
                    txtCotIngQtdIngred7.Text = receitas[i].Ingredientes[6].Quantidade;
                    txtCotIngQtdIngred8.Text = receitas[i].Ingredientes[7].Quantidade;

                }
            }
        }

        private void cmbVisDifNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbVisDifDificuldade.Text == receitas[i].Dificuldade)
                {

                    if (cmbVisDifNomeReceita.Text == receitas[i].Nome)
                    {
                        txtVisDifNumPessoas.Text = receitas[i].TempoPreparo;
                        txtVisDifPreco.Text = receitas[i].Preco;
                        txtVisDifTempoEstimado.Text = receitas[i].TempoPreparo;
                        txtVisDifModoPreparo.Text = receitas[i].ModoPreparo;
                        txtVisDifCategoria.Text = receitas[i].Categoria;

                        txtVisDifIngrediente1.Text = receitas[i].Ingredientes[0].Nome;
                        txtVisDifIngrediente2.Text = receitas[i].Ingredientes[1].Nome;
                        txtVisDifIngrediente3.Text = receitas[i].Ingredientes[2].Nome;
                        txtVisDifIngrediente4.Text = receitas[i].Ingredientes[3].Nome;
                        txtVisDifIngrediente5.Text = receitas[i].Ingredientes[4].Nome;
                        txtVisDifIngrediente6.Text = receitas[i].Ingredientes[5].Nome;
                        txtVisDifIngrediente7.Text = receitas[i].Ingredientes[6].Nome;
                        txtVisDifIngrediente8.Text = receitas[i].Ingredientes[7].Nome;

                        txtVisDifQtdIngrediente1.Text = receitas[i].Ingredientes[0].Quantidade;
                        txtVisDifQtdIngrediente2.Text = receitas[i].Ingredientes[1].Quantidade;
                        txtVisDifQtdIngrediente3.Text = receitas[i].Ingredientes[2].Quantidade;
                        txtVisDifQtdIngrediente4.Text = receitas[i].Ingredientes[3].Quantidade;
                        txtVisDifQtdIngrediente5.Text = receitas[i].Ingredientes[4].Quantidade;
                        txtVisDifQtdIngrediente6.Text = receitas[i].Ingredientes[5].Quantidade;
                        txtVisDifQtdIngrediente7.Text = receitas[i].Ingredientes[6].Quantidade;
                        txtVisDifQtdIngrediente8.Text = receitas[i].Ingredientes[7].Quantidade;
                    }
                    else
                    {
                        LimpaTelaVisualizarDificuldade();
                    }
                }
            }
        }

        private void cmbVisCatNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbVisCatNomeReceita.Text == receitas[i].Nome)
                {

                    if (cmbVisCatCategoria.Text == receitas[i].Categoria)
                    {
                        txtVisCatNumPessoas.Text = receitas[i].TempoPreparo;
                        txtVisCatPreco.Text = receitas[i].Preco;
                        txtVisCatTempoEstimado.Text = receitas[i].TempoPreparo;
                        txtVisCatModoPreparo.Text = receitas[i].ModoPreparo;
                        txtVisCatDificuldade.Text = receitas[i].Dificuldade;

                        txtVisCatIngrediente1.Text = receitas[i].Ingredientes[0].Nome;
                        txtVisCatIngrediente2.Text = receitas[i].Ingredientes[1].Nome;
                        txtVisCatIngrediente3.Text = receitas[i].Ingredientes[2].Nome;
                        txtVisCatIngrediente4.Text = receitas[i].Ingredientes[3].Nome;
                        txtVisCatIngrediente5.Text = receitas[i].Ingredientes[4].Nome;
                        txtVisCatIngrediente6.Text = receitas[i].Ingredientes[5].Nome;
                        txtVisCatIngrediente7.Text = receitas[i].Ingredientes[6].Nome;
                        txtVisCatIngrediente8.Text = receitas[i].Ingredientes[7].Nome;

                        txtVisCatQtdIngred1.Text = receitas[i].Ingredientes[0].Quantidade;
                        txtVisCatQtdIngred2.Text = receitas[i].Ingredientes[1].Quantidade;
                        txtVisCatQtdIngred3.Text = receitas[i].Ingredientes[2].Quantidade;
                        txtVisCatQtdIngred4.Text = receitas[i].Ingredientes[3].Quantidade;
                        txtVisCatQtdIngred5.Text = receitas[i].Ingredientes[4].Quantidade;
                        txtVisCatQtdIngred6.Text = receitas[i].Ingredientes[5].Quantidade;
                        txtVisCatQtdIngred7.Text = receitas[i].Ingredientes[6].Quantidade;
                        txtVisCatQtdIngred8.Text = receitas[i].Ingredientes[7].Quantidade;
                    }
                    else
                    {
                        LimpaTelaVisualizarCategoria();
                    }
                }

            }
        }

        private void cmbVisTemNomeReceita_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)
            {
                if (cmbVisTemNomeReceita.Text == receitas[i].Nome)
                {

                    if (cmbVisTemTempoEstimado.Text == receitas[i].TempoPreparo)
                    {
                        txtVisTemNumPessoas.Text = receitas[i].NumPessoas;
                        txtVisTemPreco.Text = receitas[i].Preco;
                        txtVisTemModoPreparo.Text = receitas[i].ModoPreparo;
                        txtVisTemCategoria.Text = receitas[i].Categoria;
                        txtVisTemDificuldade.Text = receitas[i].Dificuldade;

                        txtVisTemIngrediente1.Text = receitas[i].Ingredientes[0].Nome;
                        txtVisTemIngrediente2.Text = receitas[i].Ingredientes[1].Nome;
                        txtVisTemIngrediente3.Text = receitas[i].Ingredientes[2].Nome;
                        txtVisTemIngrediente4.Text = receitas[i].Ingredientes[3].Nome;
                        txtVisTemIngrediente5.Text = receitas[i].Ingredientes[4].Nome;
                        txtVisTemIngrediente6.Text = receitas[i].Ingredientes[5].Nome;
                        txtVisTemIngrediente7.Text = receitas[i].Ingredientes[6].Nome;
                        txtVisTemIngrediente8.Text = receitas[i].Ingredientes[7].Nome;

                        txtVisTemQtdIngred1.Text = receitas[i].Ingredientes[0].Quantidade;
                        txtVisTemQtdIngred2.Text = receitas[i].Ingredientes[1].Quantidade;
                        txtVisTemQtdIngred3.Text = receitas[i].Ingredientes[2].Quantidade;
                        txtVisTemQtdIngred4.Text = receitas[i].Ingredientes[3].Quantidade;
                        txtVisTemQtdIngred5.Text = receitas[i].Ingredientes[4].Quantidade;
                        txtVisTemQtdIngred6.Text = receitas[i].Ingredientes[5].Quantidade;
                        txtVisTemQtdIngred7.Text = receitas[i].Ingredientes[6].Quantidade;
                        txtVisTemQtdIngred8.Text = receitas[i].Ingredientes[7].Quantidade;
                    }
                    else
                    {
                        LimpaTelaVisualizarTempo();
                    }
                }

            }
        }

        private void tabReceitas_MouseClick(object sender, MouseEventArgs e)
        {
            cmbEditNomeReceita.Items.Clear();
            cmbVisTodasNomeReceita.Items.Clear();
            cmbCotIngNomeReceita.Items.Clear();
            cmbVisTemTempoEstimado.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (receitas[i].Nome != null)
                {
                    cmbEditNomeReceita.Items.Add(receitas[i].Nome);
                    cmbVisTodasNomeReceita.Items.Add(receitas[i].Nome);
                    cmbCotIngNomeReceita.Items.Add(receitas[i].Nome);
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if (receitas[i].TempoPreparo != null)
                {
                    cmbVisTemTempoEstimado.Items.Add(receitas[i].TempoPreparo);
                }
            }

        }
    }
}
