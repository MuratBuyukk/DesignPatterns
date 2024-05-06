namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public int ID{ get; set; }

        public GetProductUpdateByIDQuery(int id)
        {
            ID = id;
        }
    }
}
