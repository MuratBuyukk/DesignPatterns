using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.products.Find(query.ID);
            return new GetProductUpdateQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Description = values.Description,
                Price = values.Price,
                Stock = values.Stock,
            };
        }
    }
}
