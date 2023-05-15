using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_DALI_SCENE_QUEUE
{
    public class CrestronModuleClass_DALI_SCENE_QUEUE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> SCENE_VALUE;
        Crestron.Logos.SplusObjects.DigitalOutput BALLAST_RECALL_SCENE;
        Crestron.Logos.SplusObjects.DigitalOutput BALLAST_SAVE_SCENE;
        Crestron.Logos.SplusObjects.AnalogOutput BALLAST_NUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput BALLAST_SCENE_NUMBER;
        Crestron.Logos.SplusObjects.DigitalOutput GROUP_RECALL_SCENE;
        Crestron.Logos.SplusObjects.DigitalOutput GROUP_SAVE_SCENE;
        Crestron.Logos.SplusObjects.AnalogOutput GROUP_NUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput GROUP_SCENE_NUMBER;
        InOutArray<UShortParameter> SCENE_INDEX;
        ushort G_QUEUE_START = 0;
        ushort G_QUEUE_END = 0;
        ushort G_PROCESSING = 0;
        ushort [] G_INPUTVALUE;
        ushort [] G_CHANGEDINPUTS;
        ushort G_CHANGEDINPUTCOUNT = 0;
        ushort G_FORINDEX = 0;
        private void PROCESS_QUEUE (  SplusExecutionContext __context__, ushort ENCODED_INDEX , ushort VALUE ) 
            { 
            ushort TYPE = 0;
            
            ushort INDEX = 0;
            
            
            __context__.SourceCodeLine = 77;
            if ( Functions.TestForTrue  ( ( G_PROCESSING)  ) ) 
                {
                __context__.SourceCodeLine = 77;
                Functions.ProcessLogic ( ) ; 
                }
            
            __context__.SourceCodeLine = 78;
            G_PROCESSING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 80;
            TYPE = (ushort) ( (ENCODED_INDEX / 100) ) ; 
            __context__.SourceCodeLine = 81;
            INDEX = (ushort) ( Mod( ENCODED_INDEX , 100 ) ) ; 
            __context__.SourceCodeLine = 83;
            switch ((int)TYPE)
            
                { 
                case 3 : 
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 87;
                    GROUP_NUMBER  .Value = (ushort) ( INDEX ) ; 
                    __context__.SourceCodeLine = 88;
                    GROUP_SCENE_NUMBER  .Value = (ushort) ( VALUE ) ; 
                    __context__.SourceCodeLine = 89;
                    break ; 
                    } 
                
                goto case 1 ;
                case 1 : 
                goto case 0 ;
                case 0 : 
                
                    { 
                    __context__.SourceCodeLine = 94;
                    BALLAST_NUMBER  .Value = (ushort) ( INDEX ) ; 
                    __context__.SourceCodeLine = 95;
                    BALLAST_SCENE_NUMBER  .Value = (ushort) ( VALUE ) ; 
                    __context__.SourceCodeLine = 96;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 100;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 102;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)TYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 105;
                        GROUP_SAVE_SCENE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 106;
                        GROUP_SAVE_SCENE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 110;
                        GROUP_RECALL_SCENE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 111;
                        GROUP_RECALL_SCENE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 115;
                        BALLAST_SAVE_SCENE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 116;
                        BALLAST_SAVE_SCENE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 120;
                        BALLAST_RECALL_SCENE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 121;
                        BALLAST_RECALL_SCENE  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 125;
            G_PROCESSING = (ushort) ( 0 ) ; 
            
            }
            
        object SCENE_VALUE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 136;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_INPUTVALUE[ I ] == 65535))  ) ) 
                    { 
                    __context__.SourceCodeLine = 139;
                    G_CHANGEDINPUTCOUNT = (ushort) ( (G_CHANGEDINPUTCOUNT + 1) ) ; 
                    __context__.SourceCodeLine = 140;
                    G_CHANGEDINPUTS [ G_CHANGEDINPUTCOUNT] = (ushort) ( I ) ; 
                    } 
                
                __context__.SourceCodeLine = 143;
                G_INPUTVALUE [ I] = (ushort) ( SCENE_VALUE[ I ] .UshortValue ) ; 
                __context__.SourceCodeLine = 145;
                CreateWait ( "WAITTIME" , 100 , WAITTIME_Callback ) ;
                __context__.SourceCodeLine = 160;
                RetimeWait ( (int)100, "WAITTIME" ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public void WAITTIME_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 147;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)160; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( G_FORINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G_FORINDEX  >= __FN_FORSTART_VAL__1) && (G_FORINDEX  <= __FN_FOREND_VAL__1) ) : ( (G_FORINDEX  <= __FN_FORSTART_VAL__1) && (G_FORINDEX  >= __FN_FOREND_VAL__1) ) ; G_FORINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 150;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_INPUTVALUE[ G_CHANGEDINPUTS[ G_FORINDEX ] ] == 65535))  ) ) 
                    {
                    __context__.SourceCodeLine = 151;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 152;
                while ( Functions.TestForTrue  ( ( G_PROCESSING)  ) ) 
                    { 
                    __context__.SourceCodeLine = 153;
                    Functions.Delay (  (int) ( 5 ) ) ; 
                    __context__.SourceCodeLine = 152;
                    } 
                
                __context__.SourceCodeLine = 155;
                PROCESS_QUEUE (  __context__ , (ushort)( SCENE_INDEX[ G_CHANGEDINPUTS[ G_FORINDEX ] ] .Value ), (ushort)( G_INPUTVALUE[ G_CHANGEDINPUTS[ G_FORINDEX ] ] )) ; 
                __context__.SourceCodeLine = 156;
                G_INPUTVALUE [ G_CHANGEDINPUTS[ G_FORINDEX ]] = (ushort) ( 65535 ) ; 
                __context__.SourceCodeLine = 157;
                G_CHANGEDINPUTCOUNT = (ushort) ( (G_CHANGEDINPUTCOUNT - 1) ) ; 
                __context__.SourceCodeLine = 147;
                } 
            
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 171;
        G_CHANGEDINPUTCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 172;
        Functions.SetArray (  ref G_INPUTVALUE , (ushort)65535) ; 
        __context__.SourceCodeLine = 173;
        G_QUEUE_START = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 174;
        G_QUEUE_END = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 175;
        G_PROCESSING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 176;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_INPUTVALUE  = new ushort[ 161 ];
    G_CHANGEDINPUTS  = new ushort[ 161 ];
    
    BALLAST_RECALL_SCENE = new Crestron.Logos.SplusObjects.DigitalOutput( BALLAST_RECALL_SCENE__DigitalOutput__, this );
    m_DigitalOutputList.Add( BALLAST_RECALL_SCENE__DigitalOutput__, BALLAST_RECALL_SCENE );
    
    BALLAST_SAVE_SCENE = new Crestron.Logos.SplusObjects.DigitalOutput( BALLAST_SAVE_SCENE__DigitalOutput__, this );
    m_DigitalOutputList.Add( BALLAST_SAVE_SCENE__DigitalOutput__, BALLAST_SAVE_SCENE );
    
    GROUP_RECALL_SCENE = new Crestron.Logos.SplusObjects.DigitalOutput( GROUP_RECALL_SCENE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUP_RECALL_SCENE__DigitalOutput__, GROUP_RECALL_SCENE );
    
    GROUP_SAVE_SCENE = new Crestron.Logos.SplusObjects.DigitalOutput( GROUP_SAVE_SCENE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUP_SAVE_SCENE__DigitalOutput__, GROUP_SAVE_SCENE );
    
    SCENE_VALUE = new InOutArray<AnalogInput>( 160, this );
    for( uint i = 0; i < 160; i++ )
    {
        SCENE_VALUE[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( SCENE_VALUE__AnalogSerialInput__ + i, SCENE_VALUE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( SCENE_VALUE__AnalogSerialInput__ + i, SCENE_VALUE[i+1] );
    }
    
    BALLAST_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( BALLAST_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BALLAST_NUMBER__AnalogSerialOutput__, BALLAST_NUMBER );
    
    BALLAST_SCENE_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( BALLAST_SCENE_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BALLAST_SCENE_NUMBER__AnalogSerialOutput__, BALLAST_SCENE_NUMBER );
    
    GROUP_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( GROUP_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GROUP_NUMBER__AnalogSerialOutput__, GROUP_NUMBER );
    
    GROUP_SCENE_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( GROUP_SCENE_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GROUP_SCENE_NUMBER__AnalogSerialOutput__, GROUP_SCENE_NUMBER );
    
    SCENE_INDEX = new InOutArray<UShortParameter>( 160, this );
    for( uint i = 0; i < 160; i++ )
    {
        SCENE_INDEX[i+1] = new UShortParameter( SCENE_INDEX__Parameter__ + i, SCENE_INDEX__Parameter__, this );
        m_ParameterList.Add( SCENE_INDEX__Parameter__ + i, SCENE_INDEX[i+1] );
    }
    
    WAITTIME_Callback = new WaitFunction( WAITTIME_CallbackFn );
    
    for( uint i = 0; i < 160; i++ )
        SCENE_VALUE[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( SCENE_VALUE_OnChange_0, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_DALI_SCENE_QUEUE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAITTIME_Callback;


const uint SCENE_VALUE__AnalogSerialInput__ = 0;
const uint BALLAST_RECALL_SCENE__DigitalOutput__ = 0;
const uint BALLAST_SAVE_SCENE__DigitalOutput__ = 1;
const uint BALLAST_NUMBER__AnalogSerialOutput__ = 0;
const uint BALLAST_SCENE_NUMBER__AnalogSerialOutput__ = 1;
const uint GROUP_RECALL_SCENE__DigitalOutput__ = 2;
const uint GROUP_SAVE_SCENE__DigitalOutput__ = 3;
const uint GROUP_NUMBER__AnalogSerialOutput__ = 2;
const uint GROUP_SCENE_NUMBER__AnalogSerialOutput__ = 3;
const uint SCENE_INDEX__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
