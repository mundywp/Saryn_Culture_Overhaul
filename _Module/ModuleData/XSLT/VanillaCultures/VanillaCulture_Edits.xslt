<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="no" indent="yes" />
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()" />
		</xsl:copy>
	</xsl:template>
	
	<!-- No Template for Aserai, Khuzait, and Nord because their culture names are staying the same in the modded version -->
	<!--
		Empire -> Calradic
		Battania -> Battanian
		Sturgia -> Sturgian
		Vlandia -> Swadian
	-->
	
	<xsl:template match="/SPCultures[1]/Culture[@id='empire']">
		<xsl:copy>
			<!-- This is almost a wholesale copy of the XSLT template from the NavalDLC except we've added in "name" to change the name of the Empire culture. -->
			<!-- Need to keep the rest of the attributes here or the game will crash because it can't find heavy ship names and such -->
			<!-- The same pattern follows for the rest of the templates -->
			<xsl:copy-of select="@*[name() != 'name' or name() != 'basic_troop' or name() != 'naval_factor' or name() != 'start_point_position_x' or name() != 'start_point_position_y' or name() != 'shipwright' or name() != 'fishing_party_template' or name() != 'settlement_patrol_template_coastal']" />
			<xsl:attribute name="name">Calradic</xsl:attribute>
			<xsl:attribute name="basic_troop">NPCCharacter.calradic_recruit</xsl:attribute>
			<!-- Unchanged NavalDLC stuff below this line-->
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
	<xsl:template match="/SPCultures[1]/Culture[@id='sturgia']">
		<xsl:copy>
			<xsl:copy-of select="@*[name() != 'name' or name() != 'naval_factor' or name() != 'start_point_position_x' or name() != 'start_point_position_y' or name() != 'shipwright' or name() != 'fishing_party_template' or name() != 'settlement_patrol_template_coastal']" />
			<xsl:attribute name="name">Sturgian</xsl:attribute>
			<xsl:attribute name="naval_factor">2.2</xsl:attribute>
			<xsl:attribute name="start_point_position_x" namespace="">523</xsl:attribute>
			<xsl:attribute name="start_point_position_y" namespace="">603</xsl:attribute>
			<xsl:attribute name="shipwright" namespace="">NPCCharacter.shipwright_sturgia</xsl:attribute>
			<xsl:attribute name="fishing_party_template" namespace="">PartyTemplate.fishing_party_template_sturgia</xsl:attribute>
			<xsl:attribute name="settlement_patrol_template_coastal" namespace="">PartyTemplate.patrol_party_sturgia_template_coastal</xsl:attribute>
			<xsl:apply-templates select="node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='vlandia']">
		<xsl:copy>
			<xsl:copy-of select="@*[name() != 'name' or name() != 'naval_factor' or name() != 'start_point_position_x' or name() != 'start_point_position_y' or name() != 'shipwright' or name() != 'fishing_party_template' or name() != 'settlement_patrol_template_coastal']" />
			<xsl:attribute name="name">Swadian</xsl:attribute>
			<xsl:attribute name="naval_factor">2.0</xsl:attribute>
			<xsl:attribute name="start_point_position_x" namespace="">305</xsl:attribute>
			<xsl:attribute name="start_point_position_y" namespace="">414</xsl:attribute>
			<xsl:attribute name="shipwright" namespace="">NPCCharacter.shipwright_vlandia</xsl:attribute>
			<xsl:attribute name="fishing_party_template" namespace="">PartyTemplate.fishing_party_template_vlandia</xsl:attribute>
			<xsl:attribute name="settlement_patrol_template_coastal" namespace="">PartyTemplate.patrol_party_vlandia_template_coastal</xsl:attribute>
			<xsl:apply-templates select="node()" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="/SPCultures[1]/Culture[@id='battania']">
		<xsl:copy>
			<xsl:copy-of select="@*[name() != 'name' or name() != 'naval_factor' or name() != 'start_point_position_x' or name() != 'start_point_position_y' or name() != 'shipwright' or name() != 'fishing_party_template' or name() != 'settlement_patrol_template_coastal']" />
			<xsl:attribute name="name">Battania</xsl:attribute>
			<xsl:attribute name="naval_factor">1.4</xsl:attribute>
			<xsl:attribute name="start_point_position_x" namespace="">397</xsl:attribute>
			<xsl:attribute name="start_point_position_y" namespace="">476</xsl:attribute>
			<xsl:attribute name="shipwright" namespace="">NPCCharacter.shipwright_battania</xsl:attribute>
			<xsl:attribute name="fishing_party_template" namespace="">PartyTemplate.fishing_party_template_battania</xsl:attribute>
			<xsl:attribute name="settlement_patrol_template_coastal" namespace="">PartyTemplate.patrol_party_battania_template_coastal</xsl:attribute>
			<xsl:apply-templates select="node()" />
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>