using System.Globalization;

namespace RegexPatterns
{
    public static class RegexPattern
    {
        /// <summary>
        /// Microsoft reference source data annotation email pattern.
        /// </summary>
        /// Source: https://github.com/Microsoft/referencesource/blob/master/System.ComponentModel.DataAnnotations/DataAnnotations/EmailAddressAttribute.cs
        ///
        public const string Email = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";  

        /// <summary>
        /// Common phone pattern.
        /// </summary>
        /// Source: https://stackoverflow.com/a/18091377 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public const string Phone = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

        /// <summary>
        ///  Decimal number pattern. It allows both "." and "," separators.
        /// </summary>
        /// 
        public const string Decimal = @"^[+-]?\d{1,9}[,.]?\d{0,5}$";

        /// <summary>
        ///  Decimal number pattern. It allows only "," separator.
        /// </summary>
        /// 
        public const string DecimalComma = @"^[+-]?\d{1,9},?\d{0,5}$";

        /// <summary>
        ///  Decimal number pattern. It allows only "." separator.
        /// </summary>
        /// 
        public const string DecimalDot = @"^[+-]?\d{1,9}.?\d{0,5}$";

        /// <summary>
        /// Pattern for numbers on scientific notation. It allows both "." and "," separators.
        /// </summary>
        ///
        public const string DecimalScientific = @"^[\+-]?\d{1,9}[,.]?\d{0,5}[eE][\+-] ?\d{1,2}$";

        /// <summary>
        /// Pattern for numbers on scientific notation. It allows only "," separator.
        /// </summary>
        ///
        public const string DecimalScientificComma = @"^[\+-]?\d{1,9},?\d{0,5}[eE][\+-] ?\d{1,2}$";

        /// <summary>
        /// Pattern for numbers on scientific notation. It allows only "." separator.
        /// </summary>
        ///
        public const string DecimalScientificDot = @"^[\+-]?\d{1,9}.?\d{0,5}[eE][\+-] ?\d{1,2}$";
    }
}