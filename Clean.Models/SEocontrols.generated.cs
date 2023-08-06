//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "sEOControls"
	/// <summary>SEO Controls</summary>
	public partial interface ISEocontrols : IPublishedContent
	{
		/// <summary>Meta Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string MetaDescription { get; }

		/// <summary>Meta Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<string> MetaKeywords { get; }

		/// <summary>Meta Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string MetaName { get; }
	}

	/// <summary>SEO Controls</summary>
	[PublishedModel("sEOControls")]
	public partial class SEocontrols : PublishedContentModel, ISEocontrols
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		public new const string ModelTypeAlias = "sEOControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SEocontrols, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SEocontrols(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Meta Description: Enter the meta description for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => GetMetaDescription(this, _publishedValueFallback);

		/// <summary>Static getter for Meta Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMetaDescription(ISEocontrols that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "metaDescription");

		///<summary>
		/// Meta Keywords: Enter the keywords for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> MetaKeywords => GetMetaKeywords(this, _publishedValueFallback);

		/// <summary>Static getter for Meta Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<string> GetMetaKeywords(ISEocontrols that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<string>>(publishedValueFallback, "metaKeywords");

		///<summary>
		/// Meta Name: Enter the meta name for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaName")]
		public virtual string MetaName => GetMetaName(this, _publishedValueFallback);

		/// <summary>Static getter for Meta Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.4+4df082703500212e5bf2ded279a06d5bbffb212c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMetaName(ISEocontrols that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "metaName");
	}
}
