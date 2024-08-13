using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQueryHandler<in TQuery, TResonse>
        : IRequestHandler<TQuery, TResonse>
        where TQuery : IQuery<TResonse>
        where TResonse : notnull
    { 
    
    }
}
