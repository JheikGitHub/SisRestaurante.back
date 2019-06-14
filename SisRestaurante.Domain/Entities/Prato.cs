namespace SisRestaurante.Domain.Entities
{
    public class Prato
    {
        #region Construtores
        public Prato(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Prato()
        {

        }
        #endregion

        #region Propriedades
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        #endregion

        #region Metodos
        public void ValidaDados()
        {
            if (Nome.Length > 200)
                throw new System.Exception("Campo nome deve possuir ate 200 caracteres");

            if (Nome.Length == 0)
                throw new System.Exception("Campo nome e obrigatorio");

        }
        #endregion
    }
}
