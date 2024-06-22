<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <style>
          table{
            width:70%;
          }
          td{
            padding: 5px;
            padding-left: 10px;
            padding-right: 10px;
            border-bottom: solid 1px grey;
          }
        </style>
      </head>
      <body>
        <h1 style="color:red">Libreria</h1>
        <table>
          <tr>
            <td style="text-align:center">
              <p><b>Titulo</b></p>
            </td>
            <td style="text-align:center">
              <p><b>Autor</b></p>
            </td>
            <td style="text-align:center">
              <p><b>Editorial</b></p>
            </td>
            <td style="text-align:center">
              <p><b>ISBN</b></p>
            </td>
            <td style="text-align:center">
              <p><b>Verion Kindle</b></p>
            </td>
            <td style="text-align:center">
              <p><b>Precio</b></p>
            </td>
          </tr>
          <xsl:apply-templates select="libreria/libro"></xsl:apply-templates>
        </table>
<!--Instrucciones de compra-->
        <h1 style="color:grey;">Instrucciones de Compra</h1>
        <br/>
        <xsl:apply-templates select="libreria/instruccionesCompra"></xsl:apply-templates>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="libro">
    <xsl:for-each select=".">
      <xsl:sort select="precio" order="ascending" />
      <tr>
        <td>
          <xsl:value-of select="titulo"></xsl:value-of>
        </td>
        <td>
            <p>
              <xsl:value-of select="autor/nombre" /> 
              <xsl:text>  </xsl:text>
              <xsl:value-of select="autor/apellido" />
            </p>
        </td>
        <td>
          <xsl:value-of select="editorial"></xsl:value-of>
        </td>
        <td style="text-align:center">
          <xsl:value-of select="titulo/@ISBN"></xsl:value-of>
        </td>
        <td style="text-align:center">
          <xsl:if test="disponibleKindle = 'true'">Si</xsl:if>
          <xsl:if test="disponibleKindle = 'false'">No</xsl:if>
        </td>
        <xsl:if test="precio &gt; 20">
            <td style="text-align:center; border-bottom: solid 1px red;">
            <p style="color:red;">
              <xsl:value-of select="precio"></xsl:value-of>
              <xsl:text> </xsl:text>
              <xsl:value-of select="precio/@moneda"></xsl:value-of>
            </p>
          </td>
        </xsl:if>
        <xsl:if test="precio &lt;= 20">
          <td style="text-align:center; border-bottom: solid 1px green;">
          <p style="color:green;">
            <xsl:value-of select="precio"></xsl:value-of>
            <xsl:text> </xsl:text>
            <xsl:value-of select="precio/@moneda"></xsl:value-of>
          </p>
          </td>
        </xsl:if>
      </tr>
    </xsl:for-each>
  </xsl:template>

  <xsl:template match="instruccionesCompra">
    <ol>
      <xsl:for-each select="paso">
        <li>
          <xsl:value-of select="." />
        </li>
      </xsl:for-each>
    </ol>
  </xsl:template>
</xsl:stylesheet>