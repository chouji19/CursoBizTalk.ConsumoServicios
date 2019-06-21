namespace CursoBizTalk.ConsumoServicios.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON", typeof(global::CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.ConsumoServicios.Esquemas.AccountResp", typeof(global::CursoBizTalk.ConsumoServicios.Esquemas.AccountResp))]
    public sealed class JSONCuentaResp_AccountResp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON"" xmlns:ns0=""http://CursoBizTalk.ConsumoServicios.Esquemas.AccountResp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CuentasRespJSON"" />
  </xsl:template>
  <xsl:template match=""/s0:CuentasRespJSON"">
    <ns0:AccountResp>
      <xsl:for-each select=""Result"">
        <Result>
          <xsl:if test=""Success"">
            <Success>
              <xsl:value-of select=""Success/text()"" />
            </Success>
          </xsl:if>
          <xsl:if test=""codError"">
            <CodError>
              <xsl:value-of select=""codError/text()"" />
            </CodError>
          </xsl:if>
          <Message>
            <xsl:value-of select=""Mensaje/text()"" />
          </Message>
        </Result>
      </xsl:for-each>
      <xsl:for-each select=""Cuentas"">
        <Accounts>
          <xsl:if test=""idCuenta"">
            <IdAccount>
              <xsl:value-of select=""idCuenta/text()"" />
            </IdAccount>
          </xsl:if>
          <xsl:if test=""NumeroCuenta"">
            <AccountType>
              <xsl:value-of select=""NumeroCuenta/text()"" />
            </AccountType>
          </xsl:if>
          <xsl:if test=""TipoCuenta"">
            <AccountNumber>
              <xsl:value-of select=""TipoCuenta/text()"" />
            </AccountNumber>
          </xsl:if>
          <xsl:if test=""Saldo"">
            <Balance>
              <xsl:value-of select=""Saldo/text()"" />
            </Balance>
          </xsl:if>
        </Accounts>
      </xsl:for-each>
    </ns0:AccountResp>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON";
        
        private const global::CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CursoBizTalk.ConsumoServicios.Esquemas.AccountResp";
        
        private const global::CursoBizTalk.ConsumoServicios.Esquemas.AccountResp _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CursoBizTalk.ConsumoServicios.Esquemas.AccountResp";
                return _TrgSchemas;
            }
        }
    }
}
