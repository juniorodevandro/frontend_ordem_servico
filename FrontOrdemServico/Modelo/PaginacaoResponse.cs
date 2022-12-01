namespace FrontOrdemServico.Modelo
{
    public class PaginacaoResponse<T> where T : class
    {
        public IEnumerable<T> Dados { get; set; }
        public long TotalLinhas { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool ordenarDesc { get; set; }
        

        public PaginacaoResponse(IEnumerable<T> dados, long totalLinhas, int skip, int take, bool itemDesc)
        {
            Dados = dados;
            TotalLinhas = totalLinhas;
            Skip = skip;
            Take = take;
            ordenarDesc = itemDesc;
        }
    }
}
