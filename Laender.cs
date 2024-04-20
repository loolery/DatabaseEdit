using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Laender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public double Einwohner { get; set; }
        public string Hauptstadt { get; set; } 
        public string Fahne {  get; set; }
        public int FifaPunkte { get; set; }
        public string Tm_Id { get; set; }


    }
    public class Ligen
    {
        public int Id { get; set; }
        public int Land_Id { get; set; }    
        public int Rang {  get; set; }  
        public string Name {  set; get; }
        public int Groesse { get; set; }
        public string BildURL { get; set; }
        public string Tm_Link { set; get; }
        public string LandURL { set; get; }

    }
    public class vereine
    {
        public int Id { get; set; }

    }
}
