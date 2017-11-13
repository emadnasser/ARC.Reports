<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <Group Text="">
      <xsl:for-each select="rss/channel/item">
        <item Text="{description}" Header="{title}" NavigateUrl="javascript:void({position()});" Date="{pubDate}" />
      </xsl:for-each>
    </Group>
  </xsl:template> 
</xsl:stylesheet>
