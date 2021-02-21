using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Wipro.ProvaProgramacao.CSharpV3.Domain
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
