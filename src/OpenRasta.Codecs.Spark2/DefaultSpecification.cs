using OpenRasta.Codecs.Spark2.Specification.Builders;
using OpenRasta.Codecs.Spark2.Specification.Helpers;

namespace OpenRasta.Codecs.Spark2.Specification.Syntax
{
	public class DefaultSpecification : ISpecificationProvider
	{
		public IElementTransformerSpecification CreateSpecification()
		{
			var builder = new ElementTransformerSpecificationBuilder();

			builder.MatchAll(Tag.AnchorTag)
				.Do(
				Convert.ToAttributeToHref(),
				Convert.ToTypeAttributeToHref()
				);
			builder.MatchAll(Tag.IframeTag)
				.Do(
				Convert.ToAttributeToSrc()
				);
			builder.MatchAll(Tag.ImageTag)
				.Do(
				Convert.ToAttributeToSrc()
				);
			builder.MatchAll(Tag.FormTag)
				.Do(
				Convert.ForAttributeToAction()
				);
			return builder.Build();
		}
	}

}