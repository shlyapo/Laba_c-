using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeee;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace FileService
{
    public class FileService<T> : IFileService<T> where T : class
    {
        public FileService()
        { }
        public IEnumerable<T> ReadFile(string fileName)
        {
            using (StreamReader fs = File.OpenText(fileName))
            {
                JsonSerializer s = new JsonSerializer();
                List<T> f = (List<T>)s.Deserialize(fs, typeof(List<T>));
                return f;
            }
        }


        public void SaveData(IEnumerable<T> data, string fileName)
        {
            using (StreamWriter fs = File.CreateText(fileName))
            {
                JsonSerializer s = new JsonSerializer();
                s.Serialize(fs, data);
            }
        }

    }
}
