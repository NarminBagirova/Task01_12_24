namespace ClassLibrary
{
    public static class Helper
    {
        public static string CreateBookCode(string bookName, int bookIndex)
        {
            string code=bookName.Substring(0,2).ToUpper()+bookIndex.ToString();
            return code;
        }
    }
}