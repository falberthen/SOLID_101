namespace SOLID_101.Services
{
    /// <summary>
    /// Writing service definition
    /// </summary>
    public interface IWritingService
    {
        public void Write(string message);
        public void WriteLine(string message = "");
    }
}
