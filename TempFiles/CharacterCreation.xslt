<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="no" indent="yes" />
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/Brushes[1]/Brush[@Name='Culture.Banner.Layer.4']/Styles[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="Style">
				<xsl:attribute name="Name">empire2</xsl:attribute>
				<xsl:element name="BrushLayer">
					<xsl:attribute name="Name">Default</xsl:attribute>
					<xsl:attribute name="Sprite">CharacterCreation\Culture\empire_4</xsl:attribute>
				</xsl:element>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/Brushes[1]/Brush[@Name='Culture.Banner.Layer.3']/Styles[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="Style">
				<xsl:attribute name="Name">empire2</xsl:attribute>
				<xsl:element name="BrushLayer">
					<xsl:attribute name="Name">Default</xsl:attribute>
					<xsl:attribute name="Sprite">CharacterCreation\Culture\empire_3</xsl:attribute>
				</xsl:element>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/Brushes[1]/Brush[@Name='Culture.Banner.Layer.2']/Styles[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="Style">
				<xsl:attribute name="Name">empire2</xsl:attribute>
				<xsl:element name="BrushLayer">
					<xsl:attribute name="Name">Default</xsl:attribute>
					<xsl:attribute name="Sprite">CharacterCreation\Culture\empire_2</xsl:attribute>
				</xsl:element>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/Brushes[1]/Brush[@Name='Culture.Banner.Layer.2']/Styles[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="Style">
				<xsl:attribute name="Name">empire2</xsl:attribute>
				<xsl:element name="BrushLayer">
					<xsl:attribute name="Name">Default</xsl:attribute>
					<xsl:attribute name="Sprite">CharacterCreation\Culture\empire_2</xsl:attribute>
				</xsl:element>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/Brushes[1]/Brush[@Name='Culture.Banner.Layer.1']/Styles[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="Style">
				<xsl:attribute name="Name">empire2</xsl:attribute>
				<xsl:element name="BrushLayer">
					<xsl:attribute name="Name">Default</xsl:attribute>
					<xsl:attribute name="Sprite">CharacterCreation\Culture\empire_1</xsl:attribute>
				</xsl:element>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>
