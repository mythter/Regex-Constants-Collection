﻿using System.Text.RegularExpressions;

namespace RegexPatterns
{
    /// <summary>
    /// Contains all added regex patterns
    /// </summary>
    public static class RegexPatternAll
    {
        /// <summary>
        /// Pattern for email addresses from Microsoft reference source data annotation.
        /// </summary>
        /// Source: https://github.com/Microsoft/referencesource/blob/master/System.ComponentModel.DataAnnotations/DataAnnotations/EmailAddressAttribute.cs
        ///
        public static Regex Email = new Regex(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$");

        /// <summary>
        /// Pattern for email addresses from MSDN.
        /// </summary>
        /// Source: https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format?redirectedfrom=MSDN
        ///
        public static Regex Email2 = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        /// <summary>
        /// Pattern for email addresses by rhyous (Github).
        /// </summary>
        /// Source: https://github.com/rhyous/EmailRegEx
        /// 
        public static Regex Email3 =
            new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" // local-part
            +"@"
            + @"((([\w]+([-\w]*[\w]+)*\.)+[a-zA-Z]+)|" // domain
            + @"((([01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]).){3}[01]?[0-9]{1,2}|2[0-4][0-9]|25[0-5]))\z"); // or IP Address

        /// <summary>
        /// Pattern for validating multiple emails. It allows both "," and ";" delimiters to separate emails
        /// </summary>
        /// Source: https://www.c-sharpcorner.com/blogs/regex-for-multiple-email-validation1
        ///
        public static Regex Email4 = new Regex(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;,.]{0,1}\s*)+$");

        /// <summary>
        /// Email validation as per RFC2822 standards.
        /// </summary>
        /// Source: https://regexr.com/2rhq7
        ///
        public static Regex Email5 = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

        /// <summary>
        /// Pattern for mobile phone number.
        /// </summary>
        /// Source: https://uibakery.io/regex-library/phone-number-csharp
        /// 
        public static Regex Phone = new Regex(@"^\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$");

        /// <summary>
        /// Pattern for mobile phone number that enforces NANP Standard rules such as N11 codes are used to provide three-digit dialing access to special services, and thus excludes them using a conditional capture.
        /// </summary>
        /// Source: https://stackoverflow.com/a/47139109 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public static Regex Phone2 = new Regex(@"((?:\(?[2-9](?:(?=1)1[02-9]|(?:(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?:(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})");

        /// <summary>
        /// Pattern for mobile phone number.
        /// </summary>
        /// Source: https://stackoverflow.com/a/18091377 in https://stackoverflow.com/questions/18091324/regex-to-match-all-us-phone-number-formats
        /// 
        public static Regex Phone3 = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows both "." and "," delimiters.
        /// </summary>
        /// 
        public static Regex Decimal = new Regex(@"^[\+-]?\d+[,.]?\d*$");

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows only "," delimiter.
        /// </summary>
        /// 
        public static Regex DecimalComma = new Regex(@"^[\+-]?\d+,?\d*$");

        /// <summary>
        /// Pattern for decimal numbers on non-scientific notation. It allows only "." delimiter.
        /// </summary>
        /// 
        public static Regex DecimalDot = new Regex(@"^[\+-]?\d+\.?\d*$");

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows both "." and "," delimiters.
        /// </summary>
        ///
        public static Regex DecimalScientific = new Regex(@"^[\+-]?\d+[,.]?\d*[eE][\+-]\d+$");

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows only "," delimiter.
        /// </summary>
        ///
        public static Regex DecimalScientificComma = new Regex(@"^[\+-]?\d+,?\d*[eE][\+-]\d+$");

        /// <summary>
        /// Pattern for decimal numbers on scientific notation. It allows only "." delimiter.
        /// </summary>
        ///
        public static Regex DecimalScientificDot = new Regex(@"^[\+-]?\d+\.?\d*[eE][\+-]\d+$");

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows both "." and "," delimiters.
        /// </summary>
        ///
        public static Regex DecimalAny = new Regex(@"^[\+-]?\d+[,.]?\d*([eE][\+-]?)?\d+$");

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows only "," delimiter.
        /// </summary>
        ///
        public static Regex DecimalAnyComma = new Regex(@"^[\+-]?\d+,?\d*([eE][\+-]?)?\d+$");

        /// <summary>
        /// Pattern for decimal numbers on any notation. It allows only "." delimiter.
        /// </summary>
        ///
        public static Regex DecimalAnyDot = new Regex(@"^[\+-]?\d+\.?\d*([eE][\+-]?)?\d+$");

        // -----------------------------------------------------------------------------------------
        // Patter for decimal numbers with separator of your current culture 
        // char separator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        // Regex  DecimalCulture = new Regex(@"^[+-]?\d+" + separator.ToString() + @"?\d*$");
        // -----------------------------------------------------------------------------------------
    }
}