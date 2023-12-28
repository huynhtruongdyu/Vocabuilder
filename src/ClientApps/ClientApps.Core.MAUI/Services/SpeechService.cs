using ClientApps.Core.Abstractions.Services.SpeechServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApps.Core.MAUI.Services
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