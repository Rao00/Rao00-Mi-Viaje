<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <style>
          table{
            
          }
          td{
            padding: 10px;
            border: 2px solid red;
          }
          h1{
            color: blue;
            font-family: "Arial";
          }
          h2{
            font-family: "Arial";
            font-weight:bold
          }
          p{
            font-family: "Arial";
            font-weight:bold;
            font-size: 20px;
            border-bottom: 2px solid lightgrey;
          }
        </style>
      </head>
      <body>  
        <h1>Ecuaciones almacenadas y formas de resolverlas</h1>
        <table>
          <tr>
            <td style="width: 100px;">
              <p style="margin-right:30px;">Ecuaciones:</p>
            </td>
            <xsl:apply-templates select="situaciones/situacion/nombre"></xsl:apply-templates>
          </tr>
          <tr>
            <td>
              <p style="margin-right:30px;">Complejidad:</p>
            </td>
            <xsl:apply-templates select="situaciones/situacion/@complejidad"></xsl:apply-templates>
          </tr>
          <tr>
            <td style="border-bottom: 2px solid red">
              <p style="margin-right:30px;">Resultado X:</p>
            </td>
            <xsl:apply-templates select="situaciones/situacion/patrones/patron[resultado/text() = 'x']" />
          </tr>
          <tr>
            <td style="border-bottom: 2px solid red">
              <p style="margin-right:30px;">Resultado Y:</p>
            </td>
            <xsl:apply-templates select="situaciones/situacion/patrones/patron[resultado/text() = 'y']" />
          </tr>
          <tr>
            <td>
              <p style="margin-right:30px;">Resultado Z:</p>
            </td>
            <xsl:apply-templates select="situaciones/situacion/patrones/patron[resultado/text() = 'z']" />
          </tr>
        </table>
        <img src="./santiago.jpg"></img><!--Imagen para subir nota-->
      </body>
    </html>
  </xsl:template>

  <xsl:template match="nombre">
      <td style="border-left: 2px solid red;">
        <p>
          <xsl:value-of select="." />
        </p>
      </td>
  </xsl:template>

  <xsl:template match="@complejidad">
    <td style="border-left: 2px solid red;">
      <p>
        <xsl:value-of select="." />
      </p>
    </td>
  </xsl:template>

  <xsl:template match="patron[resultado/text() = 'x']">
    <xsl:if test="resultado = 'x'">
      <td style="border-left: 2px solid red; width: 200px;">
        <xsl:for-each select="operacion/paso">
          <p>
            <xsl:value-of select="." />
          </p>
        </xsl:for-each>
      </td>
    </xsl:if>
  </xsl:template>

  <xsl:template match="patron[resultado/text() = 'y']">
    <xsl:if test="resultado = 'y'">
      <td style="border-left: 2px solid red; width: 200px;">
        <xsl:for-each select="operacion/paso">
          <p>
            <xsl:value-of select="." />
          </p>
        </xsl:for-each>
      </td>
    </xsl:if>
  </xsl:template>

  <xsl:template match="patron[resultado/text() = 'z']">
    <xsl:if test="resultado = 'z'">
      <td style="border-left: 2px solid red; width: 200px;">
        <xsl:for-each select="operacion/paso">
          <p>
            <xsl:value-of select="." />
          </p>
        </xsl:for-each>
      </td>
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>
