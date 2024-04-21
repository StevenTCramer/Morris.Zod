using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace Morris.Zod.AttributeProcessors;

public class RegularExpressionAttributeProcessor : AttributeProcessorBase
{
	public override void Process(IndentedTextWriter builder, ValidationAttribute attribute, string propertyName)
	{
		if (attribute is not RegularExpressionAttribute regexAttribute)
			return;

		builder.Write($".regex('/{regexAttribute.Pattern}/'{CommaErrorMessageFor(attribute, propertyName)})");
	}
}

