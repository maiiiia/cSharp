using System;
using System.IO;


class Program
{
    //идея для улучшенной реализации метода: 
    //делаем массив, где открывающий = 1, закр = -1, иначе 0. 
    //делаем массив из пар (а, б), а - позиция открывающего, б - ближаший закрывающий
    //сортируем по б-а (длина промежутка) от мин к макс, начинаем удалять с мин до макс
    //позиции уже удаленных пишем отдельно, если пара предстоит удалению, но хотя б один ее конец уже удален, то пропускаем

    static bool[] RemoveHtmlTags(StreamReader reader) //returns array of 0 and 1, 1 = remove, 0 = keep
    {
        char openingTag = '<';
        char closingTag = '>';
        int i = 0;
        bool insideTag = false;
        int counterO = 0;
        int counterC = 0;
        bool[] remove_ind = new bool[10000000];

        while (!reader.EndOfStream)
        {
            char el = (char)reader.Read();

            if (el == openingTag)
            {
                counterO++;
                insideTag = true;
                remove_ind[i] = insideTag;
            }
            else if (el == closingTag)
            {
                counterC++;
                if(counterO == counterC)
                {
                    remove_ind[i] = insideTag;
                    insideTag = false;
                }
                
            }
            else
            {
                remove_ind[i] = insideTag;
            }

            i++;
        }
        return remove_ind;
    }

    static void Main(string[] args)
    {

        try
        {
            //string test_input = Console.ReadLine();
            string inputPath = "C:/Users/1295859/Downloads/thirdYearProgramming/cSharp/LessonSeven/html_input.txt";
            FileStream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inputStream);


            bool[] rm_ind = RemoveHtmlTags(reader);
            reader.Close();

            string outputPath = "C:/Users/1295859/Downloads/thirdYearProgramming/cSharp/LessonSeven/html_output.txt";
            FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outputStream);

            FileStream newStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            StreamReader newReader = new StreamReader(newStream);

            int i = 0;
            while (!newReader.EndOfStream)
            {
                char el = (char)newReader.Read();
                if (!rm_ind[i])
                {
                    writer.Write(el);
                }
                i++;
            }
            reader.Close();
            writer.Close();
            Console.WriteLine("HTML tags removed, result saved to html_output.txt.");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }


    }
}