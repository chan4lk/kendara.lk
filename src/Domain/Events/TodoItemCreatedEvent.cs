using KendaraLK.Domain.Common;
using KendaraLK.Domain.Entities;

namespace KendaraLK.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
