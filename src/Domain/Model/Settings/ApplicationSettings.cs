using System;
namespace Domain.Model.Settings
{
    public class ApplicationSettings
    {
        public MssqlSettings Mssql { get; }
    }

    public struct MssqlSettings
    {
        public string ConnectionString { get; }
    }
}
