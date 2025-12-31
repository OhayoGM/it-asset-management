using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class Asset
  {
    public int Id { get; set; }

    public string AssetTag { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;

    public DateTime PurchaseDate { get; set; }
    public string Status { get; set; } = "Available";

    public ICollection<AssetAssignment> Assignments { get; set; }
        = new List<AssetAssignment>();
  }
}
