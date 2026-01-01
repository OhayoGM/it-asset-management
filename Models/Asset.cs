using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class Asset
  {
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Display(Name = "Asset Tag")]
    public string AssetTag { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [StringLength(50)]
    public string Brand { get; set; } = string.Empty;

    [StringLength(50)]
    public string Model { get; set; } = string.Empty;

    [StringLength(100)]
    [Display(Name = "Serial Number")]
    public string SerialNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = "Available";

    [Display(Name = "Purchase Date")]
    [DataType(DataType.Date)]
    public DateTime? PurchaseDate { get; set; }

    public ICollection<AssetAssignment> Assignments { get; set; }
        = new List<AssetAssignment>();
  }
}
