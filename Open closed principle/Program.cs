namespace Open_closed_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            PrintManager manager = new PrintManager();
            List<Human> list = c.Get();
            manager.PrintConsole(list);
            HumanRepository repository = new HumanRepository();
            repository.SaveXmlSerializer(list);
            c.RemoveAll();
            list = c.Get();
            manager.PrintConsole(list);
            list = repository.LoadXmlSerializer();
            manager.PrintConsole(list);
            repository.SaveJSONSerializer(list);
            c.RemoveAll();
            list = c.Get();
            manager.PrintFile(list);
            list = repository.LoadJSONSerializer();
            manager.PrintFile(list);
        }
    }
}
