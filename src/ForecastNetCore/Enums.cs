using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForecastNetCore
{
    public enum Unit
    {
        us,
        si,
        ca,
        uk,
        auto
    }

    public enum Exclude
    {
        currently,
        minutely,
        hourly,
        daily,
        alerts,
        flags
    }

    public enum Extend
    {
        hourly
    }
}
