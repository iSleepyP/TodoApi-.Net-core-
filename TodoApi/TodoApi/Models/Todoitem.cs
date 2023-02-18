using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Todoitem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Iscomplete { get; set; }

    }
}
