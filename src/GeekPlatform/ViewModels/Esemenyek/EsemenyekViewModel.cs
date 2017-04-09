using System.Collections.Generic;

namespace GeekPlatform.ViewModels.Esemenyek
{
    public class EsemenyekViewModel : ViewModelBase
    {
        public IEnumerable<EsemenyViewModel> Esemenyek { get; set; }
    }
}