using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class AssetAssignment
  {
    public int Id { get; set; }   // ✅ PRIMARY KEY

    public int AssetId { get; set; }
    public int EmployeeId { get; set; }

    public DateTime AssignedDate { get; set; } = DateTime.UtcNow;

    public string? Notes { get; set; }  // optional

    public Asset Asset { get; set; } = null!;
    public Employee Employee { get; set; } = null!;
  }
}
