
namespace SenacFoods
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        // 0-disponivel 1-ocupado 2-reservado
        public int SituacaoMesa { get; set; }
    }
}
