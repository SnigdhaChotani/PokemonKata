using System.Text.RegularExpressions;

namespace Core
{
    public static class StringParser
    {
        public static string RemoveNumbers(string stringToModify)
        {
            return Regex.Replace(stringToModify, "[0-9]", "");;
        }
    }
}
