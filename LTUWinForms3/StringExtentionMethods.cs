namespace LTUWinForms3
{
    //String Extension Methods class
    public static class StringExtentionMethods
    {
        /// <summary>
        /// Checks if strings are not null or empty
        /// </summary>
        /// <param name="text"></param>
        /// <returns>String if string is not null</returns>
        public static bool IsNotNullOrEmpty(this string text)
        {
            return !string.IsNullOrEmpty(text);
        }
    }
}
