using Casgem_Mediator.DAL;
using Casgem_Mediator.MediatorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductId);
            values.Brand=request.Brand;
            values.Name=request.Name;
            values.Price=request.Price;
            values.Stock=request.Stock;
            values.Category =request.Category;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
