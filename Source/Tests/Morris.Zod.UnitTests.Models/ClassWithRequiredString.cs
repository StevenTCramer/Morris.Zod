using System.ComponentModel.DataAnnotations;

namespace Morris.Zod.TestModels;

public class ClassWithRequiredString
{
	[Required]
	public string Name { get; set; } = null!;
}
