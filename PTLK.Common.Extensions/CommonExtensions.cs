using System;

namespace PTLK.Common.Extensions
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Convert Object to Boolean.
        /// </summary>
        public static bool ToBoolean(this object? value)
        {
            string cleanValue = (value?.ToString() ?? "").Trim();
            if (string.Equals(cleanValue, "FALSE", StringComparison.OrdinalIgnoreCase) || cleanValue == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
