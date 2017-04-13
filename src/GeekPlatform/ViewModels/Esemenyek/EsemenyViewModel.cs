using System;

namespace GeekPlatform.ViewModels.Esemenyek
{
    public class EsemenyViewModel
    {
        public String Id { get; set; }

        public String Cim { get; set; }

        public String Leiras { get; set; }

        public String CoverUrl { get; set; }

        public String Helyszin { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}