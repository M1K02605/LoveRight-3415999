using SQLite;
namespace LoveRight.Models
{
    [Table("memories")]
    public class MemoryModel : ObservableObject
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        [MaxLength(260)]

        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public string ImageFilePath { get; set; }
    }
}
