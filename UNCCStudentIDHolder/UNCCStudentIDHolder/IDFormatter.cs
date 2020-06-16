using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNCCStudentIDHolder
{
    public class IDFormatter
    {
        BsonDocument reference;
        public IDFormatter(BsonDocument document)
        {
            reference = document;
        }

        public string getName()
        {
            return reference.GetValue("name") + "";
        }

        public string getID()
        {
            return reference.GetValue("id") + "";
        }

        public override string ToString()
        {
            return reference.GetValue("name") + " - " + reference.GetValue("id");
        }
    }
}
