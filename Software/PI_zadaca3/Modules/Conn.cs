namespace PI_zadaca3.Modules
{
    /// Klasa za upravljanje povezivanjem s BP
    public static class Conn
    {
        /// Generiram i vraća string za povezivanje s BP
        public static string GetConnectionString()
        {
            string serverName = "31.147.206.65";
            string databaseName = "PI2324_vtomljeno_DB";
            string userName = "PI2324_vtomljeno_User";
            string password = "lfrJZvR=";
            return $"Server={serverName};Database={databaseName};User Id={userName};Password={password};";
        }
    }
}