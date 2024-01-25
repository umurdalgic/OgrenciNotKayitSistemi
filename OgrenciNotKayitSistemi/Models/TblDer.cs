using System;
using System.Collections.Generic;

namespace OgrenciNotKayitSistemi.Models
{
    public partial class TblDer
    {
        public short OgrenciId { get; set; }
        public string? OgrenciNo { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public byte? OgrenciSinav1 { get; set; }
        public byte? OgrenciSinav2 { get; set; }
        public byte? OgrenciSinav3 { get; set; }
        public decimal? Ortalama { get; set; }
        public bool? Durum { get; set; }
    }
}
