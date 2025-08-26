using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Airport_Ticket_Booking.Interfaces;
using CsvHelper;
using CsvHelper.Configuration;
using Airport_Ticket_Booking.Models;

namespace Airport_Ticket_Booking.Services;

public class CsvFileService<TItem> : IFileService<TItem>
{
    private readonly string _filePath;

    public CsvFileService(string filePath)
    {
        _filePath = filePath;
    }

    public IEnumerable<TItem> GetEnumerableData()
    {
        using var reader = new StreamReader(_filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        foreach (var record in csv.GetRecords<TItem>())
        {
            yield return record; 
        }
    }
    public void SaveEnumerableData(IEnumerable<TItem> enumerable)
    {
        using var writer = new StreamWriter(_filePath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(enumerable);
    }
}