namespace ClientApps.Core.Abstractions.Services.SpeechServices
{
    public interface ISpeechService
    {
        Task SpeakAsync(string message, CancellationToken cancellationToken = default);

        Task CancelSpeakAsync(CancellationToken cancellationToken = default);
    }
}