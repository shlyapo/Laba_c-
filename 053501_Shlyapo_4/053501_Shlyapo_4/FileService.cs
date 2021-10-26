using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _053501_Shlyapo_4
{
    class FileService:IFileService
    {
        public FileService()
        { }
        public IEnumerable<Employee> ReadFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                    throw new ArgumentException(nameof(fileName));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // создаем объект BinaryReader
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                    string Name = reader.ReadString();
                    int Cost = reader.ReadInt32();
                    bool OnWeekend = reader.ReadBoolean();
                    bool Married = reader.ReadBoolean();
                    int Age = reader.ReadInt32();
                    Employee a = new Employee(Name, Cost, OnWeekend, Married, Age);
                        yield return a;
                    }
                }
        }

        public void SaveData(IEnumerable<Employee> data, string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
            using (File.Create(fileName)) { };
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (Employee s in data)
                    {
                        writer.Write(s.Name);
                        writer.Write(s.Cost);
                        writer.Write(s.OnWeekend);
                        writer.Write(s.Married);
                        writer.Write(s.Age);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

