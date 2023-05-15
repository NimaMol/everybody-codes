using CamerasApi;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;


namespace NPO.Service
{
    public interface IDataService
    {
        List<CameraModel> ReadCsv(string filePath);

    }
    public class DataService : IDataService
    { 
    public List<CameraModel> ReadCsv(string filePath)
    {
        List<string[]> rows = new List<string[]>();
        List<CameraModel> cameras = new List<CameraModel>();
        using (TextFieldParser parser = new TextFieldParser(filePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields()!;
                rows.Add(row);
            }

        }

        foreach (string[] row in rows.Skip(1))
        {
            string[] subs = row[0].Split(';');
            int CameraNumber = GetNumber(subs[0]);
            string CameraName = subs[0];
            string Lat = subs.Length > 1 && subs[1].Length > 0 ? subs[1] : string.Empty;
            string Lon = subs.Length > 1 && subs[1].Length > 0 ? subs[2] : string.Empty;
            CameraModel camera = new CameraModel(CameraNumber, CameraName, Lat, Lon);
            cameras.Add(camera);


        }


        return cameras;
    }


    public int GetNumber(string S)
    {
        string numericPart = Regex.Replace(S, @"\D", "");

        if (int.TryParse(numericPart, out int number))
        {
            return (number);
        }
        return 0;
    }
}

}
