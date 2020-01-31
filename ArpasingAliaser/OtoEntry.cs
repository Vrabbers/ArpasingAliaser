using System.Linq;

namespace ArpasingAliaser
{
    public struct OtoEntry
    {
        public readonly string Filename;
        public readonly string Alias;
        public readonly string[] Numbers;


        public OtoEntry(string line)
        {
            var splitAtEquals = line.Split('=');
            var otoParams = splitAtEquals[1].Split(',');
            Filename = splitAtEquals[0];
            Alias = otoParams[0];
            Numbers = otoParams.Where((string _, int i) => i > 0).ToArray();
        }

        public OtoEntry(OtoEntry old, string newAlias)
        {
            this = old;
            Alias = newAlias;
        }
        
        public override string ToString() => $"{Filename}={Alias},{string.Join(",", Numbers)}";
        
    }
}