using System.Runtime.Serialization;

namespace BusinessLogic
{
    [DataContract]
    public class ErrorApiResponse : IApiResponse
    {
        [DataMember]
        public bool IsSuccess => false;
        // could include an error message, but ErrorCode is enough for this program
        //[DataMember]
        //public string ErrorMessage { get; set; }
        [DataMember]
        public ErrorCode ErrorCode { get; set; }

        public ErrorApiResponse(ErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}