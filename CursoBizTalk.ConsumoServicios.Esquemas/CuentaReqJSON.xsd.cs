namespace CursoBizTalk.ConsumoServicios.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON",@"JSONCuentaReq")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"JSONCuentaReq"})]
    public sealed class CuentaReqJSON : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://CursoBizTalk.ConsumoServicios.Esquemas.CuentaReqJSON"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""JSONCuentaReq"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Apellido"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""TipoDocumento"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""NumeroDocumento"" type=""xs:unsignedShort"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CuentaReqJSON() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "JSONCuentaReq";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
