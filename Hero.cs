using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProjeto
{
    public class Hero
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SecretId { get; set; }
        public List<string> Powers { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Age);
        }
    }
}
