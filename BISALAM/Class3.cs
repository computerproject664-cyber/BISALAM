using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISALAM
{
    public class ChatterBot
    {
        private string name;
        protected string [] statements;
        private Random rand;
        public ChatterBot(string name, string[] statements)
        {
            string []arr= new string[statements.Length];
            for(int i=0; i<statements.Length; i++)
                arr[i] = statements[i];
            this.statements = arr;
            this.name = name;
            rand = new Random();
        }
        public string GetName() { return name; }
        public virtual string ReplyTo( string statement)
        {
            int x = rand.Next(statements.Length);
            return this.statements[x];
        }


    }
}
