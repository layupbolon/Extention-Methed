using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    public static class StringExtension
    {
        public static ChineseString AsChineseString(this string s) { return new ChineseString(s); }
        public static ConvertableString AsConvertableString(this string s) { return new ConvertableString(s); }
        public static RegexableString AsRegexableString(this string s) { return new RegexableString(s); }
    }

    public class ChineseString
    {
        private string s;
        public ChineseString(string s) { this.s = s; }
        //转全角
        public string ToSBC(string input) { throw new NotImplementedException(); }
        //转半角
        public string ToDBC(string input) { throw new NotImplementedException(); }
        //获取汉字拼音首字母
        public string GetChineseSpell(string input) { throw new NotImplementedException(); }
    }
    public class ConvertableString
    {
        private string s;
        public ConvertableString(string s) { this.s = s; }
        public bool IsInt(string s) { throw new NotImplementedException(); }
        public bool IsDateTime(string s) { throw new NotImplementedException(); }
        public int ToInt(string s) { throw new NotImplementedException(); }
        public DateTime ToDateTime(string s) { throw new NotImplementedException(); }
    }
    public class RegexableString
    {
        private string s;
        public RegexableString(string s) { this.s = s; }
        public bool IsMatch(string s, string pattern) { throw new NotImplementedException(); }
        public string Match(string s, string pattern) { throw new NotImplementedException(); }
        public string Replace(string s, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator) { throw new NotImplementedException(); }
    }
}
