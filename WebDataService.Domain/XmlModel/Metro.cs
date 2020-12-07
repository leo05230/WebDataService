
// 注意: 產生的程式碼可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0")]
[System.Xml.Serialization.XmlRootAttribute("document-content", Namespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0", IsNullable = false)]
public partial class documentcontent
{
	private documentcontentBody bodyField;
	/// <remarks/>
	public documentcontentBody body
	{
		get
		{
			return this.bodyField;
		}
		set
		{
			this.bodyField = value;
		}
	}


}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
[System.Xml.Serialization.XmlRootAttribute("font-face", Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0", IsNullable = false)]
public partial class fontface
{

	private string nameField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0", IsNullable = false)]
public partial class style
{

	private styleMap[] mapField;

	private styleTableproperties tablepropertiesField;

	private styleTablerowproperties tablerowpropertiesField;

	private styleTablecolumnproperties tablecolumnpropertiesField;

	private styleRubyproperties rubypropertiesField;

	private styleTablecellproperties tablecellpropertiesField;

	private styleParagraphproperties paragraphpropertiesField;

	private styleTextproperties textpropertiesField;

	private string nameField;

	private string familyField;

	private string parentstylenameField;

	private string datastylenameField;

	private string masterpagenameField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("map")]
	public styleMap[] map
	{
		get
		{
			return this.mapField;
		}
		set
		{
			this.mapField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-properties")]
	public styleTableproperties tableproperties
	{
		get
		{
			return this.tablepropertiesField;
		}
		set
		{
			this.tablepropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-row-properties")]
	public styleTablerowproperties tablerowproperties
	{
		get
		{
			return this.tablerowpropertiesField;
		}
		set
		{
			this.tablerowpropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-column-properties")]
	public styleTablecolumnproperties tablecolumnproperties
	{
		get
		{
			return this.tablecolumnpropertiesField;
		}
		set
		{
			this.tablecolumnpropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("ruby-properties")]
	public styleRubyproperties rubyproperties
	{
		get
		{
			return this.rubypropertiesField;
		}
		set
		{
			this.rubypropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-cell-properties")]
	public styleTablecellproperties tablecellproperties
	{
		get
		{
			return this.tablecellpropertiesField;
		}
		set
		{
			this.tablecellpropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("paragraph-properties")]
	public styleParagraphproperties paragraphproperties
	{
		get
		{
			return this.paragraphpropertiesField;
		}
		set
		{
			this.paragraphpropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("text-properties")]
	public styleTextproperties textproperties
	{
		get
		{
			return this.textpropertiesField;
		}
		set
		{
			this.textpropertiesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string family
	{
		get
		{
			return this.familyField;
		}
		set
		{
			this.familyField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("parent-style-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string parentstylename
	{
		get
		{
			return this.parentstylenameField;
		}
		set
		{
			this.parentstylenameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("data-style-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string datastylename
	{
		get
		{
			return this.datastylenameField;
		}
		set
		{
			this.datastylenameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("master-page-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string masterpagename
	{
		get
		{
			return this.masterpagenameField;
		}
		set
		{
			this.masterpagenameField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleMap
{

	private string conditionField;

	private string applystylenameField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string condition
	{
		get
		{
			return this.conditionField;
		}
		set
		{
			this.conditionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("apply-style-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string applystylename
	{
		get
		{
			return this.applystylenameField;
		}
		set
		{
			this.applystylenameField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleTableproperties
{

	private bool displayField;

	private string writingmodeField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
	public bool display
	{
		get
		{
			return this.displayField;
		}
		set
		{
			this.displayField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("writing-mode", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string writingmode
	{
		get
		{
			return this.writingmodeField;
		}
		set
		{
			this.writingmodeField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleTablerowproperties
{

	private string rowheightField;

	private bool useoptimalrowheightField;

	private string breakbeforeField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("row-height", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string rowheight
	{
		get
		{
			return this.rowheightField;
		}
		set
		{
			this.rowheightField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("use-optimal-row-height", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool useoptimalrowheight
	{
		get
		{
			return this.useoptimalrowheightField;
		}
		set
		{
			this.useoptimalrowheightField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("break-before", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string breakbefore
	{
		get
		{
			return this.breakbeforeField;
		}
		set
		{
			this.breakbeforeField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleTablecolumnproperties
{

	private string breakbeforeField;

	private string columnwidthField;

	private bool useoptimalcolumnwidthField;

	private bool useoptimalcolumnwidthFieldSpecified;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("break-before", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string breakbefore
	{
		get
		{
			return this.breakbeforeField;
		}
		set
		{
			this.breakbeforeField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("column-width", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string columnwidth
	{
		get
		{
			return this.columnwidthField;
		}
		set
		{
			this.columnwidthField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("use-optimal-column-width", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool useoptimalcolumnwidth
	{
		get
		{
			return this.useoptimalcolumnwidthField;
		}
		set
		{
			this.useoptimalcolumnwidthField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool useoptimalcolumnwidthSpecified
	{
		get
		{
			return this.useoptimalcolumnwidthFieldSpecified;
		}
		set
		{
			this.useoptimalcolumnwidthFieldSpecified = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleRubyproperties
{

	private string rubyalignField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("ruby-align", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string rubyalign
	{
		get
		{
			return this.rubyalignField;
		}
		set
		{
			this.rubyalignField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleTablecellproperties
{

	private string borderField;

	private string diagonaltlbrField;

	private string verticalalignField;

	private string wrapoptionField;

	private string backgroundcolorField;

	private bool repeatcontentField;

	private bool repeatcontentFieldSpecified;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string border
	{
		get
		{
			return this.borderField;
		}
		set
		{
			this.borderField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("diagonal-tl-br", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string diagonaltlbr
	{
		get
		{
			return this.diagonaltlbrField;
		}
		set
		{
			this.diagonaltlbrField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("vertical-align", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string verticalalign
	{
		get
		{
			return this.verticalalignField;
		}
		set
		{
			this.verticalalignField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("wrap-option", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string wrapoption
	{
		get
		{
			return this.wrapoptionField;
		}
		set
		{
			this.wrapoptionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("background-color", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string backgroundcolor
	{
		get
		{
			return this.backgroundcolorField;
		}
		set
		{
			this.backgroundcolorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("repeat-content", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool repeatcontent
	{
		get
		{
			return this.repeatcontentField;
		}
		set
		{
			this.repeatcontentField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool repeatcontentSpecified
	{
		get
		{
			return this.repeatcontentFieldSpecified;
		}
		set
		{
			this.repeatcontentFieldSpecified = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleParagraphproperties
{

	private string textalignField;

	private string marginleftField;

	private string marginrightField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-align", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string textalign
	{
		get
		{
			return this.textalignField;
		}
		set
		{
			this.textalignField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("margin-left", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string marginleft
	{
		get
		{
			return this.marginleftField;
		}
		set
		{
			this.marginleftField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("margin-right", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string marginright
	{
		get
		{
			return this.marginrightField;
		}
		set
		{
			this.marginrightField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:style:1.0")]
public partial class styleTextproperties
{

	private string colorField;

	private string fontnameField;

	private string fontnameasianField;

	private string fontnamecomplexField;

	private string fontsizeField;

	private string fontsizeasianField;

	private string fontsizecomplexField;

	private string fontfamilygenericField;

	private string textlinethroughstyleField;

	private string fontstyleField;

	private string fontstyleasianField;

	private string fontstylecomplexField;

	private string textunderlinestyleField;

	private string textunderlinetypeField;

	private string fontweightField;

	private string fontweightasianField;

	private string fontweightcomplexField;

	private bool textoutlineField;

	private bool textoutlineFieldSpecified;

	private string textshadowField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string color
	{
		get
		{
			return this.colorField;
		}
		set
		{
			this.colorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontname
	{
		get
		{
			return this.fontnameField;
		}
		set
		{
			this.fontnameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-name-asian", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontnameasian
	{
		get
		{
			return this.fontnameasianField;
		}
		set
		{
			this.fontnameasianField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-name-complex", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontnamecomplex
	{
		get
		{
			return this.fontnamecomplexField;
		}
		set
		{
			this.fontnamecomplexField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-size", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string fontsize
	{
		get
		{
			return this.fontsizeField;
		}
		set
		{
			this.fontsizeField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-size-asian", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontsizeasian
	{
		get
		{
			return this.fontsizeasianField;
		}
		set
		{
			this.fontsizeasianField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-size-complex", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontsizecomplex
	{
		get
		{
			return this.fontsizecomplexField;
		}
		set
		{
			this.fontsizecomplexField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-family-generic", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontfamilygeneric
	{
		get
		{
			return this.fontfamilygenericField;
		}
		set
		{
			this.fontfamilygenericField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-line-through-style", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string textlinethroughstyle
	{
		get
		{
			return this.textlinethroughstyleField;
		}
		set
		{
			this.textlinethroughstyleField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-style", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string fontstyle
	{
		get
		{
			return this.fontstyleField;
		}
		set
		{
			this.fontstyleField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-style-asian", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontstyleasian
	{
		get
		{
			return this.fontstyleasianField;
		}
		set
		{
			this.fontstyleasianField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-style-complex", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontstylecomplex
	{
		get
		{
			return this.fontstylecomplexField;
		}
		set
		{
			this.fontstylecomplexField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-underline-style", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string textunderlinestyle
	{
		get
		{
			return this.textunderlinestyleField;
		}
		set
		{
			this.textunderlinestyleField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-underline-type", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string textunderlinetype
	{
		get
		{
			return this.textunderlinetypeField;
		}
		set
		{
			this.textunderlinetypeField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-weight", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string fontweight
	{
		get
		{
			return this.fontweightField;
		}
		set
		{
			this.fontweightField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-weight-asian", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontweightasian
	{
		get
		{
			return this.fontweightasianField;
		}
		set
		{
			this.fontweightasianField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("font-weight-complex", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string fontweightcomplex
	{
		get
		{
			return this.fontweightcomplexField;
		}
		set
		{
			this.fontweightcomplexField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-outline", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool textoutline
	{
		get
		{
			return this.textoutlineField;
		}
		set
		{
			this.textoutlineField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool textoutlineSpecified
	{
		get
		{
			return this.textoutlineFieldSpecified;
		}
		set
		{
			this.textoutlineFieldSpecified = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("text-shadow", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0")]
	public string textshadow
	{
		get
		{
			return this.textshadowField;
		}
		set
		{
			this.textshadowField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0")]
public partial class documentcontentBody
{

	private documentcontentBodySpreadsheet spreadsheetField;

	/// <remarks/>
	public documentcontentBodySpreadsheet spreadsheet
	{
		get
		{
			return this.spreadsheetField;
		}
		set
		{
			this.spreadsheetField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0")]
public partial class documentcontentBodySpreadsheet
{

	private table[] tableField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table", Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
	public table[] table
	{
		get
		{
			return this.tableField;
		}
		set
		{
			this.tableField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
[System.Xml.Serialization.XmlRootAttribute("calculation-settings", Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0", IsNullable = false)]
public partial class calculationsettings
{

	private bool casesensitiveField;

	private bool searchcriteriamustapplytowholecellField;

	private bool usewildcardsField;

	private bool useregularexpressionsField;

	private bool automaticfindlabelsField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("case-sensitive", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool casesensitive
	{
		get
		{
			return this.casesensitiveField;
		}
		set
		{
			this.casesensitiveField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("search-criteria-must-apply-to-whole-cell", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool searchcriteriamustapplytowholecell
	{
		get
		{
			return this.searchcriteriamustapplytowholecellField;
		}
		set
		{
			this.searchcriteriamustapplytowholecellField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("use-wildcards", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool usewildcards
	{
		get
		{
			return this.usewildcardsField;
		}
		set
		{
			this.usewildcardsField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("use-regular-expressions", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool useregularexpressions
	{
		get
		{
			return this.useregularexpressionsField;
		}
		set
		{
			this.useregularexpressionsField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("automatic-find-labels", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public bool automaticfindlabels
	{
		get
		{
			return this.automaticfindlabelsField;
		}
		set
		{
			this.automaticfindlabelsField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0", IsNullable = false)]
public partial class table
{


	private tableTablerow[] tablerowField;

	private string nameField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-row")]
	public tableTablerow[] tablerow
	{
		get
		{
			return this.tablerowField;
		}
		set
		{
			this.tablerowField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
public partial class tableTablecolumn
{
	private string defaultcellstylenameField;

	private ushort numbercolumnsrepeatedField;

	private bool numbercolumnsrepeatedFieldSpecified;


	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("default-cell-style-name", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string defaultcellstylename
	{
		get
		{
			return this.defaultcellstylenameField;
		}
		set
		{
			this.defaultcellstylenameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("number-columns-repeated", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public ushort numbercolumnsrepeated
	{
		get
		{
			return this.numbercolumnsrepeatedField;
		}
		set
		{
			this.numbercolumnsrepeatedField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool numbercolumnsrepeatedSpecified
	{
		get
		{
			return this.numbercolumnsrepeatedFieldSpecified;
		}
		set
		{
			this.numbercolumnsrepeatedFieldSpecified = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
public partial class tableTablerow
{

	private tableTablerowTablecell[] tablecellField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("table-cell")]
	public tableTablerowTablecell[] tablecell
	{
		get
		{
			return this.tablecellField;
		}
		set
		{
			this.tablecellField = value;
		}
	}

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
public partial class tableTablerowTablecell
{

	private p[] pField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("p", Namespace = "urn:oasis:names:tc:opendocument:xmlns:text:1.0")]
	public p[] p
	{
		get
		{
			return this.pField;
		}
		set
		{
			this.pField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0")]
	public string value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}

}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:text:1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:opendocument:xmlns:text:1.0", IsNullable = false)]
public partial class p
{

	private object sField;

	private string[] textField;

	/// <remarks/>
	public object s
	{
		get
		{
			return this.sField;
		}
		set
		{
			this.sField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string[] Text
	{
		get
		{
			return this.textField;
		}
		set
		{
			this.textField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
public partial class tableNamedexpressions
{

	private tableNamedexpressionsNamedrange namedrangeField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("named-range")]
	public tableNamedexpressionsNamedrange namedrange
	{
		get
		{
			return this.namedrangeField;
		}
		set
		{
			this.namedrangeField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0")]
public partial class tableNamedexpressionsNamedrange
{

	private string nameField;

	private string cellrangeaddressField;

	private string basecelladdressField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("cell-range-address", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string cellrangeaddress
	{
		get
		{
			return this.cellrangeaddressField;
		}
		set
		{
			this.cellrangeaddressField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute("base-cell-address", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
	public string basecelladdress
	{
		get
		{
			return this.basecelladdressField;
		}
		set
		{
			this.basecelladdressField = value;
		}
	}
}

