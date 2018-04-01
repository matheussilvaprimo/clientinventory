namespace Infra.Exceptions
{
    public static class ExceptionExtensions
    {
        public static void AddData(this BaseException ex)
        {
            if(ex.CustomCode > 0 && !string.IsNullOrWhiteSpace(ex.CustomMessage))
            {
                ex.Data.Add("custom_code", ex.CustomCode);
                ex.Data.Add("custom_message", ex.Message);
            }
        }
    }
}
