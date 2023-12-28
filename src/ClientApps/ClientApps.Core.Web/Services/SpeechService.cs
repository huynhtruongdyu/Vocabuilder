using ClientApps.Core.Abstractions.Services.SpeechServices;

namespace ClientApps.Core.Web.Services
{
    public class SpeechService : ISpeechService
    {
        public Task CancelSpeakAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task SpeakAsync(string message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}