using Casgem_Mediator.MediatorPattern.Results;
using MediatR;
using System.Collections.Generic;

namespace Casgem_Mediator.MediatorPattern.Queries
{
    public class GetQueryProduct:IRequest<List<GetProductQueryResult>>
    {
    }
}
