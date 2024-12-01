
namespace Open_closed_principle
{
    class Сontainer
    {
        List<Human> list = new List<Human>();

        public void Add(Human human)
        {
            list.Add(human);
            Console.WriteLine("Данные добавлены!");
        }
        public List<Human> Get()
        {
            return list;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= list.Count)
                return;
            list.RemoveAt(index);
            Console.WriteLine("Удаление выполнено!");
        }
        public void RemoveAll()
        {
            list.RemoveRange(0, list.Count);
            Console.WriteLine("Все данные удалены!");
        }
    }
}
