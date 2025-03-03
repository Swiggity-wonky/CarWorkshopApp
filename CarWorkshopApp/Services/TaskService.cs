namespace CarWorkshopApp.Services
{
    public static class TaskService
    {
        private static List<Task> tasks = new List<Task>();

        public static void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public static IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }
    }
}