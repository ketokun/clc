using System.Runtime.Serialization;

namespace BusinessLogic
{
    [DataContract]
    public class SuccessApiResponse : IApiResponse
    {
        [DataMember]
        public bool IsSuccess => true;
        [DataMember]
        public decimal? Data { get; set; }

        public SuccessApiResponse(decimal data)
        {
            Data = data;
        }
    }
}