using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace finally_specflow_project.Utils
{
    public static class TableExtensions
    {
        public static string[] AsStrings(this Table t, string column)
        {
            return t.Rows.Select(r => r[column]).ToArray();
        }

    }
}
