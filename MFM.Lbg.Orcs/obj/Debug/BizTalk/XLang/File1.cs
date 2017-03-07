
#pragma warning disable 162

namespace MFM.Lbg.Orcs.GenItems
{

    [System.SerializableAttribute]
    sealed public class __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERY__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY _schema = new MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY();

        public __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERY__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERY__)
        },
        0,
        @"http://www.ibm.com/maximo#QueryMXVISIONLOCQUERY"
    )]
    [System.SerializableAttribute]
    sealed internal class QueryMXVISIONLOCQUERYRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERY__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERY__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public QueryMXVISIONLOCQUERYRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERYResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse _schema = new MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse();

        public __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERYResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERYResponse__)
        },
        0,
        @"http://www.ibm.com/maximo#QueryMXVISIONLOCQUERYResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class QueryMXVISIONLOCQUERYResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERYResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __MFM_Lbg_Orcs_GenItems_MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo_QueryMXVISIONLOCQUERYResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public QueryMXVISIONLOCQUERYResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "QueryMXVISIONLOCQUERY",
        new System.Type[]{
            typeof(MFM.Lbg.Orcs.GenItems.QueryMXVISIONLOCQUERYRequest), 
            typeof(MFM.Lbg.Orcs.GenItems.QueryMXVISIONLOCQUERYResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class MTFMVISIONFM_MTFMVISIONLOCQUERYPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public MTFMVISIONFM_MTFMVISIONLOCQUERYPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public MTFMVISIONFM_MTFMVISIONLOCQUERYPortType(MTFMVISIONFM_MTFMVISIONLOCQUERYPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            MTFMVISIONFM_MTFMVISIONLOCQUERYPortType p = new MTFMVISIONFM_MTFMVISIONLOCQUERYPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo QueryMXVISIONLOCQUERY = new Microsoft.XLANGs.Core.OperationInfo
        (
            "QueryMXVISIONLOCQUERY",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(MTFMVISIONFM_MTFMVISIONLOCQUERYPortType),
            typeof(QueryMXVISIONLOCQUERYRequest),
            typeof(QueryMXVISIONLOCQUERYResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "QueryMXVISIONLOCQUERY" ] = QueryMXVISIONLOCQUERY;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 102 "F:\Latch\MFM Integration Apps Group\BizTalk2013\Beacon\MFM.Lbg.Interface\MFM.Lbg.Orcs\GenItems\MTFMVISIONFM_MTFMVISIONLOCQUERY.odx"
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class MTFMVISIONFM_MTFMVISIONLOCQUERYClient : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(MTFMVISIONFM_MTFMVISIONLOCQUERYClient));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static MTFMVISIONFM_MTFMVISIONLOCQUERYClient()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public MTFMVISIONFM_MTFMVISIONLOCQUERYClient(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "MTFMVISIONFM_MTFMVISIONLOCQUERYClient", tracker)
        {
            ConstructorHelper();
        }

        public MTFMVISIONFM_MTFMVISIONLOCQUERYClient(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "MTFMVISIONFM_MTFMVISIONLOCQUERYClient")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>6f64abc0-c66a-4137-a38b-3197ee8f6790</ShapeID>      
<children>                </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'MTFMVISIONFM_MTFMVISIONLOCQUERYClient'</ActionName><IsAtomic>0</IsAtomic><Line>102</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bfe6d97b-3396-4935-b3a7-8f38e6f6fea5' LowerBound='1.1' HigherBound='27.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='MFM.Lbg.Orcs.GenItems' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='21a482a9-ef73-4899-8c93-edc47141743d' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;MTFMVISIONFM_MTFMVISIONLOCQUERYPortType&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='MTFMVISIONFM_MTFMVISIONLOCQUERYPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7f60cd88-8945-458f-bff4-75f5f6c82e49' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;QueryMXVISIONLOCQUERY&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='QueryMXVISIONLOCQUERY' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b97c9a49-5c03-4728-807d-cb8cf88e417b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.41'>
                    <om:Property Name='Ref' Value='MFM.Lbg.Orcs.GenItems.QueryMXVISIONLOCQUERYRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://www.ibm.com/maximo/wsdl/MTFMVISIONFM_MTFMVISIONLOCQUERY:QueryMXVISIONLOCQUERYRequest&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='2378e81b-0ddc-4452-9724-122c2eaf3c94' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.43' HigherBound='16.72'>
                    <om:Property Name='Ref' Value='MFM.Lbg.Orcs.GenItems.QueryMXVISIONLOCQUERYResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://www.ibm.com/maximo/wsdl/MTFMVISIONFM_MTFMVISIONLOCQUERY:QueryMXVISIONLOCQUERYResponse&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='a21dd6dc-cebe-4a9e-9107-e8d01c3d8e6e' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;QueryMXVISIONLOCQUERYRequest&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='QueryMXVISIONLOCQUERYRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='38acd582-a2fa-4515-a3f2-b9ae47190811' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4a2d5178-0d3a-42aa-b5ad-c4c25de122d6' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;QueryMXVISIONLOCQUERYResponse&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='QueryMXVISIONLOCQUERYResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='c6083c8c-7501-4d0f-a5cb-280185ecfd2c' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='9c555f0f-6849-4ffd-b0b6-484b459d0561' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;MTFMVISIONFM_MTFMVISIONLOCQUERY&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='MTFMVISIONFM_MTFMVISIONLOCQUERYClient' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='6f64abc0-c66a-4137-a38b-3197ee8f6790' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MTFMVISIONFM_MTFMVISIONLOCQUERYClient")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                MTFMVISIONFM_MTFMVISIONLOCQUERYClient __svc__ = (MTFMVISIONFM_MTFMVISIONLOCQUERYClient)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "MTFMVISIONFM_MTFMVISIONLOCQUERYClient")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                MTFMVISIONFM_MTFMVISIONLOCQUERYClient __svc__ = (MTFMVISIONFM_MTFMVISIONLOCQUERYClient)_service;
                base.Finally();
            }

        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] { };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return null; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1 __ctx1__ = (__MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1)_stateMgrs[1];
            __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0 __ctx0__ = (__MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1 __ctx1__ = (__MTFMVISIONFM_MTFMVISIONLOCQUERYClient_1)_stateMgrs[1];
            __MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0 __ctx0__ = (__MTFMVISIONFM_MTFMVISIONLOCQUERYClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 5;
            case 5:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
