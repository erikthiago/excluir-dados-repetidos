using ExcluiDadosDuplicados.Queries;
using ExcluiDadosDuplicados.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExcluiDadosDuplicados
{
    public partial class Form1 : Form
    {
        private readonly IBaseRepository _baseRepository;

        public Form1(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbQuantidade.Text = "Informe os dados.";
            lvDados.Items.Clear();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string dadoDuplicado1 = "";
            string dadoDuplicado2 = "";

            for (int i = 0; i < lvDados.Items.Count; i++)
            {
                var dados = _baseRepository.GetData(lvDados.Items[i].Text);

                foreach (var item in dados)
                {
                    Entity1 entity1 = (Entity1)item;

                    if (entity1.Prop4 == dadoDuplicado1 && entity1.Prop5 == dadoDuplicado2)
                    {
                        // Pesquisa o dado relacionado
                        var dadosEnvolvidos = _baseRepository.GetDataEnvolved(entity1.Id);
                        foreach (var id in dadosEnvolvidos)
                        {
                            Entity2 entity2 = (Entity2)id;
                            // Exclui o registro da tabela
                            _baseRepository.Delete(Convert.ToInt32(entity2.Id), "NomeTabela", "ValorChaveEstrangeiraOuId");
                        }

                        // Exclui o registro da tabela
                        _baseRepository.Delete(entity1.Id, "NomeTabela", "ValorChaveEstrangeiraOuId");
                        // Exclui o registro da tabela
                        _baseRepository.Delete(entity1.Id, "NomeTabela", "ValorChaveEstrangeiraOuId");
                        // Exclui o registro da tabela
                        _baseRepository.Delete(entity1.Id, "NomeTabela", "ValorChaveEstrangeiraOuId");
                        // Exclui o registro da tabela
                        _baseRepository.Delete(entity1.Id, "NomeTabela", "ValorChaveEstrangeiraOuId");
                        // Exclui o registro da tabela
                        _baseRepository.Delete(entity1.Id, "NomeTabela", "ValorChaveEstrangeiraOuId");
                    }

                    dadoDuplicado1 = entity1.Prop4;
                    dadoDuplicado2 = entity1.Prop5;
                    // Altera a cor do texto para vermelho para sinalizar a exlusão do registro
                    lvDados.Items[i].ForeColor = Color.Red;
                }
            }
        }

        private void txtProtocolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AdicionarDados();
        }

        private void AdicionarDados()
        {
            //Se o protocolo já estiver adicionado, não incluir o mesmo.
            for (int i = 0; i < lvDados.Items.Count; i++)
                if (lvDados.Items[i].Text == txtProtocolo.Text)
                    return;

            lvDados.Items.Add(txtProtocolo.Text);
            lbQuantidade.Text = "Contém " + lvDados.Items.Count + " protocolos.";

            btnProcessar.Enabled = lvDados.Items.Count > 0;

            txtProtocolo.Text = "";

            if (lvDados.Items.Count > 0)
                lvDados.EnsureVisible(lvDados.Items.Count - 1);

            txtProtocolo.Focus();
        }
    }
}
