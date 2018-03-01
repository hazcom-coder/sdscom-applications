<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html" omit-xml-declaration="yes" />
  
  <xsl:template match="/">
    <ul>
      <xsl:apply-templates/>
    </ul>
  </xsl:template>   
  
  <xsl:template match="*">
    <li>
      <xsl:value-of select="name()" />
      <xsl:if test="text()">
        <xsl:text>: </xsl:text>
        <xsl:apply-templates select="text()" />
      </xsl:if>
      <xsl:if test="*">
        <ul>
          <xsl:apply-templates/>
        </ul>
      </xsl:if>
    </li>
  </xsl:template>

</xsl:stylesheet>
