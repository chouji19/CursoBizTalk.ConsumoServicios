namespace CursoBizTalk.ConsumoServicios.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON",@"CuentasRespJSON")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CuentasRespJSON"})]
    public sealed class CuentasResponseJSON : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://CursoBizTalk.ConsumoServicios.Esquemas.CuentasResponseJSON"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CuentasRespJSON"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""Result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""Success"" type=""xs:boolean"" />
              <xs:element minOccurs=""0"" name=""codError"" type=""xs:unsignedByte"" />
              <xs:element name=""Mensaje"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Cuentas"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""idCuenta"" type=""xs:unsignedByte"" />
              <xs:element minOccurs=""0"" name=""NumeroCuenta"" type=""xs:unsignedInt"" />
              <xs:element minOccurs=""0"" name=""TipoCuenta"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Saldo"" type=""xs:unsignedShort"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CuentasResponseJSON() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CuentasRespJSON";
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
