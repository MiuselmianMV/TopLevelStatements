using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TopLevelStatements
{
    public class Plane
    {
        private string Name {  get; set; } = string.Empty;
        private string DesignerName { get; set; } = string.Empty;
        private int ReleaseYear { get; set; } = 0;
        private string Type { get; set; } = string.Empty;
         

        public Plane()
        {
            Name = "Unknown";
            DesignerName = "Unknown";
            ReleaseYear = 0;
            Type = "Unknown";
        }

        public Plane(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public Plane(string name, int releaseYear, string designerName)
        {
            Name = name;
            ReleaseYear = releaseYear;
            DesignerName = designerName;
        }

        public Plane(string name, int releaseYear, string designerName, string type)
        {
            Name = name;
            DesignerName = designerName;
            ReleaseYear = releaseYear;
            Type = type;
        }

        public string GetName() { return Name; }
        
        public string GetDesignerName() {  return DesignerName; }
        
        public int GetReleaseYear() {  return ReleaseYear; }
        
        public string GetType() { return Type; }

        public void SetName(string Name) { this.Name = Name; }

        public void SetDesignerName(string DesignerName) { this.DesignerName = DesignerName; }

        public void SetReleaseYear(int ReleaseYear) { this.ReleaseYear = ReleaseYear; }

        public void SetType(string Type) { this.Type = Type; }

        public void ShowInfo()
        {
            Console.WriteLine("Plane's name: {0}. \nDesigner name: {1}. \nYear of release: {2}. \nType of plane: {3}.", Name, DesignerName, ReleaseYear, Type);
        }

    }
}
