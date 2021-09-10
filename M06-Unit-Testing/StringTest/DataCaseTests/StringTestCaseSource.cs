using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelperTests.DataCaseTests
{
    public class StringTestCaseSource
    {
        public static object[] NullCasesEmptyStringExpected =
        {
        new object[] { null, "SomeText", ""},
        new object[] { "SomeText", null, ""},
        new object[] { null, null, "" }
        };

        public static object[] NullCases0StringExpected =
        {
        new object[] { null, "SomeText", "0"},
        new object[] { "SomeText", null, "0"},
        new object[] { null, null, "0" }
        };

        public static object[] NullCase0StringExpected =
        {
        new object[] { null, "0"},
        new object[] { "", "0"},
        };

        public static object[] NullOrEmptyStringCase0DoubleExpected =
        {
        new object[] { null, 0d},
        new object[] { "", 0d},
        };

        public static object[] NullOrEmptyStringCaseEmptyStringExpected =
        {
        new object[] { null, ""},
        new object[] { "", ""},
        };


    }
}
