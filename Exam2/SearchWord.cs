namespace ExamCsharp.Exam2;

public class SearchWord
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        Console.Write("Nhap tu khoa can tim: ");
        string searchWord = Console.ReadLine();
        int count = 0;
        int index = 0;
        while (index < input.Length)
        {
            index = input.IndexOf(searchWord, index);
            if (index == -1)
                break;
            count++;
            index += searchWord.Length;
        }
        Console.WriteLine("Tu khoa '{searchWord}' xuat hien trong chuoi: {count} lan");
    }
}