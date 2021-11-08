using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace _053501_Shlyapo_Lab9.Domain
{
    public interface ISerializer
    {
        IEnumerable<Firma> DeSerializeByLINQ(string fileName);
        IEnumerable<Firma> DeSerializeXML(string fileName);
        IEnumerable<Firma> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<Firma> xxx, string fileName);
        void SerializeXML(IEnumerable<Firma> xxx, string fileName);
        void SerializeJSON(IEnumerable<Firma> xxx, string fileName);
    }
}
