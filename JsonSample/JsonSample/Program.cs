using System;
using System.Buffers;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;

namespace JsonSample
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Language { get; set; }
        public Author Author { get; set; }
        public DateTime PublishedAt { get; set; }
        public int PublishedYear { get; set; }
        public bool IsActive { get; set; }
        public string[] Tags { get; set; }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

            #region UTF8 json reader example
            /*
            Console.WriteLine("***Utf8JsonReader Sample***");
            var jsonBytes = File.ReadAllBytes("sample.json");
            var jsonSpan = jsonBytes.AsSpan();
            var json = new Utf8JsonReader(jsonSpan);
            while(json.Read()) Console.WriteLine(GetTokenDesc(json));
            */
            #endregion // 

            #region Reading data using Json Document example
            /*
            Console.WriteLine("***JsonDocument Sample***");
            using var stream = File.OpenRead("sample.json");
            using var doc = JsonDocument.Parse(stream);
            
            var root = doc.RootElement;
            var firstName = root
                .GetProperty("author")
                .GetProperty("firstName")
                .GetString();

            Console.WriteLine($"Author First Name: {firstName}");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("***Enumerate Document***");
            EnumerateElement(root);
            */
            #endregion //

            #region Writing json data using Utf8JsonWriter
            /*
            Console.WriteLine("***Utf8JsonWriter Sample***");
            var options = new JsonWriterOptions
            {
                Indented = true
            };
            var buffer = new ArrayBufferWriter<byte>();
            using var json = new Utf8JsonWriter(buffer, options);

            PopulateJson(json);
            json.Flush();

            var output = buffer.WrittenSpan.ToArray();
            File.WriteAllBytes("written_sample.json", output);
            var ourJson = Encoding.UTF8.GetString(output);
            Console.WriteLine(ourJson);
            */
            #endregion //

            
            Console.WriteLine("***JsonSerializer Sample***");
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var text = File.ReadAllText("sample.json");
            var course = JsonSerializer.Deserialize<Course>(text, options);

            Console.WriteLine($"Course Name: {course.CourseName}");
            Console.WriteLine($"Author: {course.Author.FirstName} " +
                $"{course.Author.LastName}");
            Console.WriteLine(JsonSerializer.Serialize(course, options));
        }

        private static void PopulateJson(Utf8JsonWriter json)
        {
            json.WriteStartObject();

            // Write property name and then value seperately
            json.WritePropertyName("courseName");
            json.WriteStringValue("Build your own application framework");

            // write property name and value in one method
            json.WriteString("language", "C#");

            // create a new object
            json.WriteStartObject("author");
            json.WriteString("firstName", "Matt");
            json.WriteString("lastName", "Honecutt");
            json.WriteEndObject();

            json.WriteEndObject();
        }

        private static string GetTokenDesc(Utf8JsonReader json) =>
            json.TokenType switch
            {
                JsonTokenType.StartObject => "START OBJECT",
                JsonTokenType.EndObject => "END OBJECT",
                JsonTokenType.StartArray => "START ARRAY",
                JsonTokenType.EndArray => "END ARRAY",
                JsonTokenType.PropertyName => $"PROPERTY: {json.GetString()}",
                JsonTokenType.Comment => $"COMMENT: {json.GetString()}",
                JsonTokenType.String => $"STRING: {json.GetString()}",
                JsonTokenType.Number => $"NUMBER: {json.GetInt32()}",
                JsonTokenType.True => $"BOOL: {json.GetBoolean()}",
                JsonTokenType.False => $"BOOL: {json.GetBoolean()}",
                JsonTokenType.Null => "NULL",
                _ => $"**UNHANDLED TOKEN: {json.TokenType}"
            };

        /// <summary>
        /// Recursively enumerate the json document
        /// </summary>
        private static void EnumerateElement(JsonElement root)
        {
            foreach(var prop in root.EnumerateObject())
            {
                if(prop.Value.ValueKind == JsonValueKind.Object)
                {
                    Console.WriteLine($"{prop.Name}:");
                    Console.WriteLine($"--BEGIN OBJECT--");
                    EnumerateElement(prop.Value);
                    Console.WriteLine("--END OBJECT--");
                }
                //else if (prop.Value.ValueKind == JsonValueKind.Array)
                //{

                //}
                else
                {
                    Console.WriteLine($"{prop.Name}: {prop.Value.GetRawText()}");
                }
            }
        }
    }
}
