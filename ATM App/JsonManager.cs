using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    static class JsonManager
    {
        public static void SerializeData(Type type, object data, string file_name, DataContractJsonSerializer js = null)
        {
            js = (js == null ? new DataContractJsonSerializer(type) : throw new ArgumentNullException("Can't serialize due to JSON is null"));

            using (var file = new FileStream(file_name, FileMode.OpenOrCreate))
            {
                js.WriteObject(file, data);
            }
        }

        public static void DeserializeData(Type type, object data, string file_name, DataContractJsonSerializer js = null)
        {
            js = (js == null ? new DataContractJsonSerializer(type) : throw new ArgumentNullException("Can't deserialize due to JSON is null"));
            using (var file = new FileStream(file_name, FileMode.OpenOrCreate))
            {
                var newUsers = js.ReadObject(file) as Type;
            }
        }
    }
}
