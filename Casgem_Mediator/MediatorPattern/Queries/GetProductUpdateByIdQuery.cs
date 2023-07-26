using Casgem_Mediator.MediatorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery:IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }


}
