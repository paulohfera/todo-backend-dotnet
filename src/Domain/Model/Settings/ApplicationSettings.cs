using System;
namespace Domain.Model.Settings
{
    public sealed class ApplicationSettings
    {
        public MssqlSettings Mssql { get; set; }
    }

    public sealed class MssqlSettings
    {
        public string ConnectionString { get; set; }
    }
}
