using System.Text.Json;
using NUnit.Framework;

public static class SetsAndMaps
{
    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for returning all symmetric pairs of words.  
    ///
    /// For example, if words was: [am, at, ma, if, fi], we would return :
    ///
    /// ["am & ma", "if & fi"]
    ///
    /// The order of the array does not matter, nor does the order of the specific words in each string in the array.
    /// at would not be returned because ta is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember the assumption above
    /// that there were no duplicates) and therefore should not be returned.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    public static string[] FindPairs(string[] words)
    {
        HashSet<string> wordSet = [];
        HashSet<string> pairs = [];
        foreach (string word in words) wordSet.Add(word);
        foreach (string word in wordSet)
        {
            if (word.CompareTo(new String([word[1], word[0]])) != 0 && !pairs.Contains(word + " & " + new String([word[1], word[0]])) && !pairs.Contains(new String([word[1], word[0]]) + " & " + word) && wordSet.Contains(word) && wordSet.Contains(new String([word[1], word[0]])))
                pairs.Add(word + " & " + new String([word[1], word[0]]));
        }
        return pairs.ToArray<string>();
    }

    /// <summary>
    /// Read a census file and summarize the degrees (education)
    /// earned by those contained in the file.  The summary
    /// should be stored in a dictionary where the key is the
    /// degree earned and the value is the number of people that 
    /// have earned that degree.  The degree information is in
    /// the 4th column of the file.  There is no header row in the
    /// file.
    /// </summary>
    /// <param name="filename">The name of the file to read</param>
    /// <returns>fixed array of divisors</returns>
    public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        Dictionary<string, int> degrees = [];
        foreach (string line in File.ReadLines(filename))
        {
            string[] fields = line.Split(",");
            if (degrees.ContainsKey(fields[3])) degrees[fields[3]]++;
            else degrees.Add(fields[3], 1);
        }
        return degrees;
    }

    /// <summary>
    /// Determine if 'word1' and 'word2' are anagrams.  An anagram
    /// is when the same letters in a word are re-organized into a 
    /// new word.  A dictionary is used to solve the problem.
    /// 
    /// Examples:
    /// is_anagram("CAT","ACT") would return true
    /// is_anagram("DOG","GOOD") would return false because GOOD has 2 O's
    /// 
    /// Important Note: When determining if two words are anagrams, you
    /// should ignore any spaces.  You should also ignore cases.  For 
    /// example, 'Ab' and 'Ba' should be considered anagrams
    /// 
    /// Reminder: You can access a letter by index in a string by 
    /// using the [] notation.
    /// </summary>
    public static bool IsAnagram(string word1, string word2)
    {
        Dictionary<char, int> letters = [];
        int counter = 0;
        int index = 0;
        string shorterWord, longerWord;
        if (word1.Length == int.Min(word1.Length, word2.Length))
        {
            shorterWord = word1;
            longerWord = word2;
        }
        else
        {
            shorterWord = word2;
            longerWord = word1;
        }
        foreach (char character in longerWord)
        {
            char letter = Char.ToLower(character);
            if (!Char.IsWhiteSpace(letter))
            {
                if (letters.TryGetValue(letter, out int value)) letters[letter] = ++value;
                else letters.Add(letter, 1);
                if (letters[letter] == 0) counter--;
                else if (letters[letter] == 1) counter++;
            }
            if (index < shorterWord.Length)
            {
                letter = Char.ToLower(shorterWord[index]);
                if (!Char.IsWhiteSpace(letter))
                {
                    if (letters.TryGetValue(letter, out int value)) letters[letter] = --value;
                    else letters.Add(letter, -1);
                    if (letters[letter] == 0) counter--;
                    else if (letters[letter] == -1) counter++;
                }
            }
            index++;
        }
        return counter == 0;
    }

    /// <summary>
    /// This function will read JSON (Javascript Object Notation) data from the 
    /// United States Geological Service (USGS) consisting of earthquake data.
    /// The data will include all earthquakes in the current day.
    /// 
    /// JSON data is organized into a dictionary. After reading the data using
    /// the built-in HTTP client library, this function will return a list of all
    /// earthquake locations ('place' attribute) and magnitudes ('mag' attribute).
    /// Additional information about the format of the JSON data can be found 
    /// at this website:  
    /// 
    /// https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php
    /// 
    /// </summary>
    public static string[] EarthquakeDailySummary()
    {
        const String uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using HttpClient client = new();
        using HttpRequestMessage getRequestMessage = new(HttpMethod.Get, uri);
        using Stream jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using StreamReader reader = new(jsonStream);
        String json = reader.ReadToEnd();
        JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };
        FeatureCollection featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);
        List<String> earthquakes = [];
        foreach (Feature feature in featureCollection.features)
        {
            String earthquake = feature.properties.place + " - Mag " + feature.properties.mag.ToString();
            Console.WriteLine(earthquake);
            earthquakes.Add(earthquake);
        }
        return earthquakes.ToArray<String>();
        // TODO Problem 5:
        // 1. Add code in FeatureCollection.cs to describe the JSON using classes and properties 
        // on those classes so that the call to Deserialize above works properly.
        // 2. Add code below to create a string out each place a earthquake has happened today and its magitude.
        // 3. Return an array of these string descriptions.
    }
}