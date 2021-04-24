using KendaraLK.Domain.Common;
using System.Threading.Tasks;

namespace KendaraLK.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
