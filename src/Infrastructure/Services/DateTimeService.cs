using KendaraLK.Application.Common.Interfaces;
using System;

namespace KendaraLK.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
