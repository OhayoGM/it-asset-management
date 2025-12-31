using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class AssetAssignment
  {
    public int AssignmentId { get; set; }

    public int AssetId { get; set; }
    public int EmployeeId { get; set; }

    [Required]
    public DateTime AssignedDate { get; set; }

    public DateTime? ReturnedDate { get; set; }
    public string Notes { get; set; }

    // Navigation Properties
    public Asset Asset { get; set; }
    public Employee Employee { get; set; }
  }
}
