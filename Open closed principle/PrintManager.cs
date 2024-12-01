using System.Text;

namespace Open_closed_principle
{
    class PrintManager
    {
        public void PrintConsole(List<Human> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                Console.WriteLine(j.Name + "\t" + j.Age);
            }
        }
        public void PrintFile(List<Human> list)
        {
            StreamWriter log_out = new StreamWriter("logfile.txt", true, Encoding.UTF8);
            TextWriter tmp = Console.Out;
            Console.SetOut(log_out);
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                log_out.Close();
                Console.SetOut(tmp);
                return;
            }
            foreach (Human j in list)
            {
                Console.WriteLine(j.Name + "\t" + j.Age);
            }
            log_out.Close();
            Console.SetOut(tmp);
        }
    }
}
