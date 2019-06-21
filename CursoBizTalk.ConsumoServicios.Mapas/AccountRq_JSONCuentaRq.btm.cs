namespace CursoBizTalk.ConsumoServicios.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.ConsumoServicios.Esquemas.AccountRq", typeof(global::CursoBizTalk.ConsumoServicios.Esquemas.AccountRq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON", typeof(global::CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON))]
    public sealed class AccountRq_JSONCuentaRq : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON"" xmlns:s0=""http://CursoBizTalk.ConsumoServicios.Esquemas.AccountRq"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AccountRq"" />
  </xsl:template>
  <xsl:template match=""/s0:AccountRq"">
    <ns0:JSONCuentaReq>
      <Apellido>
        <xsl:value-of select=""LastName/text()"" />
      </Apellido>
      <TipoDocumento>
        <xsl:value-of select=""DocumentType/text()"" />
      </TipoDocumento>
      <NumeroDocumento>
        <xsl:value-of select=""DocumentNumber/text()"" />
      </NumeroDocumento>
    </ns0:JSONCuentaReq>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CursoBizTalk.ConsumoServicios.Esquemas.AccountRq";
        
        private const global::CursoBizTalk.ConsumoServicios.Esquemas.AccountRq _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON";
        
        private const global::CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CursoBizTalk.ConsumoServicios.Esquemas.AccountRq";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON";
                return _TrgSchemas;
            }
        }
    }
}
