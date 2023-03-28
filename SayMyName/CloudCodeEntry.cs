using Unity.Services.CloudCode.Core;

namespace SayMyName
{
    public class CloudCodeEntry
    {
        [CloudCodeFunction("SayHello")]
        public string Hello(string name)
        {
            return $"Hello, my is {name}!";
        }

    }
}