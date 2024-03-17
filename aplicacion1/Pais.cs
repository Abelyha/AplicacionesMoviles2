using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion1
{
    public class Pais
    {
        public string Name { get; set; }
        public string Ubication { get; set; }


    public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}