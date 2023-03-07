namespace RegexPatterns
{
    public static class RegexPatternAll
    {
        /// <summary>
        /// Pattern for email addresses from Microsoft reference source data annotation.
        /// </summary>
        /// Source: https://github.com/Microsoft/referencesource/blob/master/System.ComponentModel.DataAnnotations/DataAnnotations/EmailAddressAttribute.cs
        ///
        public const string Email = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

        /// <summary>
        /// Pattern for email addresses from MSDN.
        /// </summary>
        /// Source: https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format?redirectedfrom=MSDN
        ///
        public const string EmailMSDN = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        /// <summary>
        /// Pattern for email addresses by rhyous (Github).
        /// </summary>
        /// Source: https://github.com/rhyous/EmailRegEx
        /// 
        public const string Email2 =
            @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" // local-part
            + "@"
            + @"((([\w]+([-\w]*[\w]+)*\.)+[a-zA-Z]+)|" // domain
            + @"((([01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]).){3}[01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]))\z"; // or IP Address    

        /// <summary>
        /// Pattern for mobile phone number.
        /// </summary>
        /// Source: https://uibakery.io/regex-library/phone-number-csharp
        /// 
        public const string Phone = @"^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$";

        /// <summary>
        /// Pattern for mobile phone number that enforces NANP Standard rules such as N11 codes are used to provide three-digit dialing access to special services, and thus excludes them using a conditional capture.
        /// </summary>
        /// Source: https://stackoverflow.com/a/47139109 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public const string PhoneNANP = @"((?:\(?[2-9](?:(?=1)1[02-9]|(?:(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?:(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})";

        /// <summary>
        /// Pattern for mobile phone number.
        /// </summary>
        /// Source: https://stackoverflow.com/a/18091377 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public const string Phone2 = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

        /// <summary>
        /// Pattern for mobile phone number.
        /// </summary>
        /// Source: https://stackoverflow.com/a/71642391 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public const string Phone3 = @"\(?\+?\d{1}\)\?\-?\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows both "." and "," delimiters.
        /// </summary>
        /// 
        public const string Decimal = @"^[+-]?\d{1,9}[,.]?\d{0,5}$";

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows only "," delimiter.
        /// </summary>
        /// 
        public const string DecimalComma = @"^[+-]?\d{1,9},?\d{0,5}$";

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows only "." delimiter.
        /// </summary>
        /// 
        public const string DecimalDot = @"^[+-]?\d{1,9}.?\d{0,5}$";

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows both "." and "," delimiters.
        /// </summary>
        ///
        public const string DecimalScientific = @"^[\+-]?\d{1,9}[,.]?\d{0,5}[eE][\+-] ?\d{1,2}$";

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows only "," delimiter.
        /// </summary>
        ///
        public const string DecimalScientificComma = @"^[\+-]?\d{1,9},?\d{0,5}[eE][\+-] ?\d{1,2}$";

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows only "." delimiter.
        /// </summary>
        ///
        public const string DecimalScientificDot = @"^[\+-]?\d{1,9}.?\d{0,5}[eE][\+-] ?\d{1,2}$";

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows both "." and "," delimiters.
        /// </summary>
        ///
        public const string DecimalAny = @"^[\+-]? \d{1,9}[,.]?\d{0,5}([eE][\+-]?)? \d{1,2}$";

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows only "," delimiter.
        /// </summary>
        ///
        public const string DecimalAnyComma = @"^[\+-]? \d{1,9},?\d{0,5}([eE][\+-]?)? \d{1,2}$";

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows only "." delimiter.
        /// </summary>
        ///
        public const string DecimalAnyDot = @"^[\+-]? \d{1,9}.?\d{0,5}([eE][\+-]?)? \d{1,2}$";

        // -----------------------------------------------------------------------------------------
        // Patter for decimal numbers with separator of your current culture 
        // char separator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        // string DecimalCulture = @"^[+-]?\d{1,9}" + separator.ToString() + @"?\d{0,5}$";
        // -----------------------------------------------------------------------------------------


    }
}