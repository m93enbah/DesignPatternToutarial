using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace SerIizationCopyPro.Extensions
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Serialize(ms, self);
                ms.Position = 0;
                return (T)s.Deserialize(ms);
            }
        }

        public static T DeepCopyJSON<T>(this T self)
        {
            var ms = new MemoryStream();
            using (var sw = new StreamWriter(stream: ms, encoding: Encoding.UTF8, bufferSize: 4096, leaveOpen: true)) // last parameter is important
            using (var jsonWriter = new JsonTextWriter(sw))
            {
                var s = new JsonSerializer();
                s.Serialize(jsonWriter, self);
                sw.Flush();
                ms.Seek(0, SeekOrigin.Begin);

                using (var sr = new StreamReader(ms))
                {
                    return (T)s.Deserialize(sr, typeof(T));
                }
            }
        }
    }
}
