namespace HW8._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь");
            string path = Console.ReadLine();
            Console.WriteLine($"Размер файлов и папок {DirectorySize.Size(path)} байт");
        }
    }
}
