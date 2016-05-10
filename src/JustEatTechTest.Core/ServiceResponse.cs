namespace JustEatTechTest.Core
{
    public class ServiceResponse<T> where T : class
    {
        public T Data { get; private set; }
        public bool Error { get; private set; }
        public string Message { get; private set; }

        private ServiceResponse() { }

        public static ServiceResponse<T> CreateSuccess(T data) 
        {
            return new ServiceResponse<T> {Data = data};
        }

        public static ServiceResponse<T> CreateFailure(string errorMessage)
        {
            return new ServiceResponse<T> {Error = true, Message = errorMessage};
        }

    }
}