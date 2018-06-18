using ExcluiDadosDuplicados.Repositories;
using System;
using System.Windows.Forms;
using Unity;

namespace ExcluiDadosDuplicados
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Resolvendo as dependências
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBaseRepository, BaseRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Configuração de dependências do formulário
            Application.Run(container.Resolve<Form1>());
        }
    }
}
