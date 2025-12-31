using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class Asset
  {
    public int AssetId { get; set; }

    [Required]
    [StringLength(50)]
    public string AssetTag { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Category { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }

    public DateTime? PurchaseDate { get; set; }
    public DateTime? WarrantyExpiry { get; set; }

    [Required]
    public string Status { get; set; }
  }
}
