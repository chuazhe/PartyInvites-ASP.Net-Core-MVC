using System.Collections.Generic;
namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses //It's for when you want to be able to use an object with a foreach loop, but you don't know exactly what type you're dealing with
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}