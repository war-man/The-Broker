using Apartment.API.Model;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apartment.API.Infrastructure.Services
{
    public class PicServicesHandler: IPicServicesHandler
    {
        private readonly IEnumerable<IStorage> _storages;
        private readonly IOptions<AppSettings> _options;

        public PicServicesHandler(IEnumerable<IStorage> storages, IOptions<AppSettings> options)
        {
            _storages = storages;
            _options = options;
        }

        public void Subscrib(IPicService picService) => picService.OnFileUploaded += PicService_OnFileUploadAsync;

        private void PicService_OnFileUploadAsync(object sender, FileData fileData)
        {
            //just using local and azure blob storage;
            IStorage storage = _options.Value.AzureStorageEnabled ? 
                                        _storages.FirstOrDefault(s => s.GetType().Name == nameof(AzureStorage)):
                                        _storages.FirstOrDefault(s => s.GetType().Name == nameof(LocalStorage));
            Task.Run(async () => await storage.SaveAsync(fileData)).Wait();
        }
    }
}
