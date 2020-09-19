using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using OxideBand.Models;

namespace OxideBand.APIs
{
    public static class BitMidi
    {
        public static BitMidiResult Search(string Query, int Page = 0)
        {
            string URL = $"https://bitmidi.com/api/midi/search?q={WebUtility.UrlEncode(Query)}&page={Page}";

            HttpWebRequest Request = WebRequest.CreateHttp(URL);
            Request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            using (MemoryStream ReadStream = new MemoryStream())
            {
                response.GetResponseStream().CopyTo(ReadStream);
                string JSON = Encoding.UTF8.GetString(ReadStream.ToArray());
                BitMidiResponse midiResponse = JsonConvert.DeserializeObject<BitMidiResponse>(JSON);
                System.Console.WriteLine($"has {midiResponse.result.total} results");
                return midiResponse.result;
            }
        }

        public static void DownloadMidi(BitMidiResultEntry midi, Stream stream)
        {
            string URL = $"https://bitmidi.com" + midi.downloadUrl;
            using (WebClient client = new WebClient())
            {
                byte[] Buffer = client.DownloadData(URL);
                stream.Write(Buffer, 0, Buffer.Length);
                stream.Flush();
            }
        }
    }
}