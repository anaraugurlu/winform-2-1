using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_2_1
{
    class Json
    {
        static void JsonDeserializer()
        {


            //Human[] humans2 = null;
            //var serializer = new JsonSerializer();
            //using (StreamReader  sr = new StreamReader("humans.json"))
            //{
            //    using (var jw = new JsonTextWriter(sr))
            //    {

            //        humans2 = serializer.Deserialize(sr)
                    
            //            }
            //} 

        }
     public   static void JsonSerialize(List<Human>humans)
        {
            
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("humans.json"))


            {


                using (var jw = new JsonTextWriter(sw))


                {


                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;


                    serializer.Serialize(jw, humans);


                }


            }
        }
    }
}
