//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HKD_ClothesShop.Modal
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.DacDiem_SanPham = new HashSet<DacDiem_SanPham>();
        }
    
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public string MoTa { get; set; }
        public decimal DonGia { get; set; }
        public byte[] AnhBiaSP { get; set; }
        public string ChatLieu { get; set; }
        public System.DateTime NgayCapNhat { get; set; }
        public bool TrangThai { get; set; }
        public string MaLoaiSP { get; set; }
        public string MaThuongHieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DacDiem_SanPham> DacDiem_SanPham { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
