﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace treeDiM.StackBuilder.Exporters {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class placement {
        
        private int itemIdField;
        
        private double xField;
        
        private double yField;
        
        private double zField;
        
        private HAxis lField;
        
        private bool lFieldSpecified;
        
        private HAxis wField;
        
        private bool wFieldSpecified;
        
        /// <remarks/>
        public int itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        public HAxis L {
            get {
                return this.lField;
            }
            set {
                this.lField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LSpecified {
            get {
                return this.lFieldSpecified;
            }
            set {
                this.lFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HAxis W {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WSpecified {
            get {
                return this.wFieldSpecified;
            }
            set {
                this.wFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    public enum HAxis {
        
        /// <remarks/>
        XN,
        
        /// <remarks/>
        XP,
        
        /// <remarks/>
        YN,
        
        /// <remarks/>
        YP,
        
        /// <remarks/>
        ZN,
        
        /// <remarks/>
        ZP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class loadSpace {
        
        private int idField;
        
        private string nameField;
        
        private double lengthField;
        
        private double widthField;
        
        private double maxLoadHeightField;
        
        private double maxLoadWeightField;
        
        private double baseHeightField;
        
        private double maxLengthOverhangField;
        
        private double maxWidthOverhangField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public double length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public double width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public double maxLoadHeight {
            get {
                return this.maxLoadHeightField;
            }
            set {
                this.maxLoadHeightField = value;
            }
        }
        
        /// <remarks/>
        public double maxLoadWeight {
            get {
                return this.maxLoadWeightField;
            }
            set {
                this.maxLoadWeightField = value;
            }
        }
        
        /// <remarks/>
        public double baseHeight {
            get {
                return this.baseHeightField;
            }
            set {
                this.baseHeightField = value;
            }
        }
        
        /// <remarks/>
        public double maxLengthOverhang {
            get {
                return this.maxLengthOverhangField;
            }
            set {
                this.maxLengthOverhangField = value;
            }
        }
        
        /// <remarks/>
        public double maxWidthOverhang {
            get {
                return this.maxWidthOverhangField;
            }
            set {
                this.maxWidthOverhangField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class itemList {
        
        private item[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public item[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class item {
        
        private int idField;
        
        private string nameField;
        
        private double lengthField;
        
        private double widthField;
        
        private double heightField;
        
        private double weightField;
        
        private double maxWeightOnTopField;
        
        private bool maxWeightOnTopFieldSpecified;
        
        private string permittedOrientationsField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public double length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public double width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        public double height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
        
        /// <remarks/>
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public double maxWeightOnTop {
            get {
                return this.maxWeightOnTopField;
            }
            set {
                this.maxWeightOnTopField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxWeightOnTopSpecified {
            get {
                return this.maxWeightOnTopFieldSpecified;
            }
            set {
                this.maxWeightOnTopFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string permittedOrientations {
            get {
                return this.permittedOrientationsField;
            }
            set {
                this.permittedOrientationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class orderLine {
        
        private int itemIdField;
        
        private int quantityField;
        
        /// <remarks/>
        public int itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class cOfG {
        
        private double xField;
        
        private double yField;
        
        private double zField;
        
        /// <remarks/>
        public double x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public double y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        public double z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class statistics {
        
        private double loadVolumeField;
        
        private double volumeUtilizationField;
        
        private double weightLoadField;
        
        private double weightUtilizationField;
        
        private double loadHeightField;
        
        private cOfG cOfGField;
        
        /// <remarks/>
        public double loadVolume {
            get {
                return this.loadVolumeField;
            }
            set {
                this.loadVolumeField = value;
            }
        }
        
        /// <remarks/>
        public double volumeUtilization {
            get {
                return this.volumeUtilizationField;
            }
            set {
                this.volumeUtilizationField = value;
            }
        }
        
        /// <remarks/>
        public double weightLoad {
            get {
                return this.weightLoadField;
            }
            set {
                this.weightLoadField = value;
            }
        }
        
        /// <remarks/>
        public double weightUtilization {
            get {
                return this.weightUtilizationField;
            }
            set {
                this.weightUtilizationField = value;
            }
        }
        
        /// <remarks/>
        public double loadHeight {
            get {
                return this.loadHeightField;
            }
            set {
                this.loadHeightField = value;
            }
        }
        
        /// <remarks/>
        public cOfG cOfG {
            get {
                return this.cOfGField;
            }
            set {
                this.cOfGField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class load {
        
        private int loadSpaceIdField;
        
        private statistics statisticsField;
        
        private placement[] placementField;
        
        /// <remarks/>
        public int loadSpaceId {
            get {
                return this.loadSpaceIdField;
            }
            set {
                this.loadSpaceIdField = value;
            }
        }
        
        /// <remarks/>
        public statistics statistics {
            get {
                return this.statisticsField;
            }
            set {
                this.statisticsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("placement")]
        public placement[] placement {
            get {
                return this.placementField;
            }
            set {
                this.placementField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd", IsNullable=false)]
    public partial class orderDocument {
        
        private string authorField;
        
        private System.DateTime dateField;
        
        private units unitField;
        
        private orderDocumentOrderType orderTypeField;
        
        /// <remarks/>
        public string author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        public units unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        
        /// <remarks/>
        public orderDocumentOrderType orderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    public enum units {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("mm|kg")]
        mmkg,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cm|kg")]
        cmkg,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("m|kg")]
        mkg,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("in|lb")]
        inlb,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://plmpack.com/stackbuilder/StackBuilderXMLExport.xsd")]
    public partial class orderDocumentOrderType {
        
        private string orderNumberField;
        
        private loadSpace loadSpaceField;
        
        private item[] itemListField;
        
        private orderLine orderLineField;
        
        private load loadField;
        
        /// <remarks/>
        public string orderNumber {
            get {
                return this.orderNumberField;
            }
            set {
                this.orderNumberField = value;
            }
        }
        
        /// <remarks/>
        public loadSpace loadSpace {
            get {
                return this.loadSpaceField;
            }
            set {
                this.loadSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public item[] itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }
        
        /// <remarks/>
        public orderLine orderLine {
            get {
                return this.orderLineField;
            }
            set {
                this.orderLineField = value;
            }
        }
        
        /// <remarks/>
        public load load {
            get {
                return this.loadField;
            }
            set {
                this.loadField = value;
            }
        }
    }
}
