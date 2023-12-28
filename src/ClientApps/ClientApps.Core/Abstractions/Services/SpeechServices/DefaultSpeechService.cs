namespace ClientApps.Core.Abstractions.Services.SpeechServices
{
    public abstract class DefaultSpeechService : ISpeechService
    {
        public virtual Task CancelSpeakAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task SpeakAsync(string message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}