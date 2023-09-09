using LoveRight.Models;
using LoveRight.Services;
using SQLite;

namespace LoveRight.ViewModel
{
    internal class MemoryViewModel : ObservableObject
    {
        public static MemoryViewModel Current { get; set; }

        SQLiteConnection connection;

        public MemoryViewModel()
        {
            Current = this;
            connection = DatabaseService.Connection;
        }
        public List<MemoryModel> Memories
        {
            get
            {
                return connection.Table<MemoryModel>().ToList();
            }
        }

        public void SaveMemory(MemoryModel model)
        {
            if (model.Id > 0)
            {
                connection.Update(model);
            }
            else
            {
                connection.Insert(model);
            }
        }

        public void DeleteMemory(MemoryModel model)
        {
            if (model.Id > 0)
            {
                connection.Delete(model);
            }
        }


    }
}
