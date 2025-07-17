/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class BasketballTRM
{
    public static void Run()
    {
        Dictionary<string, int> players = [];
        Dictionary<int, HashSet<String>> scores = [];
        HashSet<int> topNumbers = [];
        int lowestTop = 0;

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            if (players.Keys.Contains(playerId)) players[playerId] += points;
            else players.Add(playerId, points);
            if (scores.ContainsKey(points)) { scores[points].Add(playerId); }
            else scores.Add(points, [playerId]);
            int topPlayerCount = 0;
            foreach (int score in topNumbers)
            {
                topPlayerCount += scores[score].Count;
            }
            if (topPlayerCount <= 10)
            {
                topNumbers.Add(points);
            }
            else if (points > lowestTop)
            {
                if (topNumbers.Contains(lowestTop))
                {
                    topNumbers.Remove(lowestTop);
                }
                lowestTop = points;
                topNumbers.Add(points);
            }
        }
        Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");
        var topPlayers = new string[10];
        int index = 0;
        foreach (int score in topNumbers)
        {
            foreach (String name in scores[score])
            {
                if (index >= 10) break;
                topPlayers[index] = name;
                index++;
            }
        }
        Console.WriteLine($"Top Players: {{{string.Join(", ", topPlayers)}}}");
    }
}