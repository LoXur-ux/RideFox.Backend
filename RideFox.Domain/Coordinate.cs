using System.ComponentModel.DataAnnotations;
using RideFox.Domain.Base;

namespace RideFox.Domain;
public class Coordinate : BaseEntity
{
	[Required] public double Latitude { get; set; }
	[Required] public double Longitude { get; set; }
}
