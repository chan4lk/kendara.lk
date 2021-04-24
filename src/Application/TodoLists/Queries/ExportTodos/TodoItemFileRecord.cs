using KendaraLK.Application.Common.Mappings;
using KendaraLK.Domain.Entities;

namespace KendaraLK.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
