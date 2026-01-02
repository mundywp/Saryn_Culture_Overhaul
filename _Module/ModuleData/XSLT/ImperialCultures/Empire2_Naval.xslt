<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="no" indent="yes" />
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='empire2']/notable_and_wanderer_templates[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="template">
				<xsl:attribute name="name">NPCCharacter.spc_wanderer_empire_0n</xsl:attribute>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='empire2']/caravan_party_templates[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="caravan_party_template">
				<xsl:attribute name="id">PartyTemplate.naval_caravan_template_empire</xsl:attribute>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='empire']/elite_caravan_party_templates[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="caravan_party_template">
				<xsl:attribute name="id">PartyTemplate.elite_naval_caravan_template_empire</xsl:attribute>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='empire2']">
		<xsl:copy>
			<xsl:copy-of select="@*[name() != 'naval_factor' or name() != 'start_point_position_x' or name() != 'start_point_position_y' or name() != 'shipwright' or name() != 'fishing_party_template' or name() != 'settlement_patrol_template_coastal']" />
			<xsl:attribute name="naval_factor">1.6</xsl:attribute>
			<xsl:attribute name="start_point_position_x" namespace="">776</xsl:attribute>
			<xsl:attribute name="start_point_position_y" namespace="">280</xsl:attribute>
			<xsl:attribute name="shipwright" namespace="">NPCCharacter.shipwright_empire</xsl:attribute>
			<xsl:attribute name="fishing_party_template" namespace="">PartyTemplate.fishing_party_template_empire</xsl:attribute>
			<xsl:attribute name="settlement_patrol_template_coastal" namespace="">PartyTemplate.patrol_party_empire_template_coastal</xsl:attribute>
			<xsl:element name="default_policies">
				<xsl:element name="policy">
					<xsl:attribute name="id">policy_coastal_guard_edict</xsl:attribute>
				</xsl:element>
			</xsl:element>
			<xsl:apply-templates select="node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='empire2']/available_ship_hulls[1]">
		<xsl:copy>
			<xsl:copy-of select="@*" />
			<xsl:apply-templates select="node()" />
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.empire_heavy_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.empire_medium_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.central_light_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.eastern_trade_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.western_light_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.eastern_heavy_ship</xsl:attribute>
			</xsl:element>
			<xsl:element name="ship_hull">
				<xsl:attribute name="id">ShipHull.empire_trade_ship</xsl:attribute>
			</xsl:element>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>