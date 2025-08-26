namespace Airport_Ticket_Booking.Helper;

public static class FileReadWriteHelper
{
    public static void WriteFile(string FilePath,string content)
    {
        File.WriteAllText(FilePath, content);
    }
    public static string ReadFile(string pathToFile)
    {
        return File.ReadAllText(pathToFile);
    }
}