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

namespace UserModule_20_EVENT_HVAC_MESSAGE_LIST_V1_0
{
    public class UserModuleClass_20_EVENT_HVAC_MESSAGE_LIST_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput STORE;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_LIST;
        Crestron.Logos.SplusObjects.DigitalInput REFRESH_LIST;
        Crestron.Logos.SplusObjects.DigitalInput SELECT1;
        Crestron.Logos.SplusObjects.DigitalInput SELECT2;
        Crestron.Logos.SplusObjects.DigitalInput SELECT3;
        Crestron.Logos.SplusObjects.DigitalInput SELECT4;
        Crestron.Logos.SplusObjects.DigitalInput SELECT5;
        Crestron.Logos.SplusObjects.DigitalInput SELECT6;
        Crestron.Logos.SplusObjects.DigitalInput SELECT7;
        Crestron.Logos.SplusObjects.DigitalInput SELECT8;
        Crestron.Logos.SplusObjects.DigitalInput SELECT9;
        Crestron.Logos.SplusObjects.DigitalInput SELECT10;
        Crestron.Logos.SplusObjects.DigitalInput SELECT11;
        Crestron.Logos.SplusObjects.DigitalInput SELECT12;
        Crestron.Logos.SplusObjects.DigitalInput SELECT13;
        Crestron.Logos.SplusObjects.DigitalInput SELECT14;
        Crestron.Logos.SplusObjects.DigitalInput SELECT15;
        Crestron.Logos.SplusObjects.DigitalInput SELECT16;
        Crestron.Logos.SplusObjects.DigitalInput SELECT17;
        Crestron.Logos.SplusObjects.DigitalInput SELECT18;
        Crestron.Logos.SplusObjects.DigitalInput SELECT19;
        Crestron.Logos.SplusObjects.DigitalInput SELECT20;
        Crestron.Logos.SplusObjects.StringInput MESSAGE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput FORWARD_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput FORWARD_MESSAGE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE9__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE10__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE11__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE12__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE13__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE14__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE15__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE16__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE17__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE18__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE19__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE20__DOLLAR__;
        object STORE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 80;
                _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 81;
                _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 82;
                _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 83;
                _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 84;
                _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 85;
                _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 86;
                _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 87;
                _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 88;
                _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 89;
                _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 90;
                _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 91;
                _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 92;
                _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 93;
                _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 94;
                _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 95;
                _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 96;
                _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 97;
                _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 98;
                _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 99;
                _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  .UpdateValue ( MESSAGE__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 101;
                MESSAGE20__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 102;
                MESSAGE19__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 103;
                MESSAGE18__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 104;
                MESSAGE17__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 105;
                MESSAGE16__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 106;
                MESSAGE15__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 107;
                MESSAGE14__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 108;
                MESSAGE13__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 109;
                MESSAGE12__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 110;
                MESSAGE11__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 111;
                MESSAGE10__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 112;
                MESSAGE9__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 113;
                MESSAGE8__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 114;
                MESSAGE7__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 115;
                MESSAGE6__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 116;
                MESSAGE5__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 117;
                MESSAGE4__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 118;
                MESSAGE3__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 119;
                MESSAGE2__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 120;
                MESSAGE1__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CLEAR_LIST_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 124;
            _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 125;
            _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 126;
            _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 127;
            _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 128;
            _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 129;
            _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 130;
            _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 131;
            _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 132;
            _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 133;
            _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 134;
            _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 135;
            _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 136;
            _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 137;
            _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 138;
            _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 139;
            _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 140;
            _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 141;
            _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 142;
            _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 143;
            _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  .UpdateValue ( "cleared"  ) ; 
            __context__.SourceCodeLine = 145;
            MESSAGE20__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 146;
            MESSAGE19__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 147;
            MESSAGE18__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 148;
            MESSAGE17__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 149;
            MESSAGE16__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 150;
            MESSAGE15__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 151;
            MESSAGE14__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 152;
            MESSAGE13__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 153;
            MESSAGE12__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 154;
            MESSAGE11__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 155;
            MESSAGE10__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 156;
            MESSAGE9__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 157;
            MESSAGE8__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 158;
            MESSAGE7__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 159;
            MESSAGE6__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 160;
            MESSAGE5__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 161;
            MESSAGE4__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 162;
            MESSAGE3__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 163;
            MESSAGE2__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 164;
            MESSAGE1__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object REFRESH_LIST_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        MESSAGE20__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 171;
        MESSAGE19__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 172;
        MESSAGE18__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 173;
        MESSAGE17__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 174;
        MESSAGE16__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 175;
        MESSAGE15__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 176;
        MESSAGE14__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 177;
        MESSAGE13__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 178;
        MESSAGE12__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 179;
        MESSAGE11__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 180;
        MESSAGE10__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 181;
        MESSAGE9__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 182;
        MESSAGE8__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 183;
        MESSAGE7__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 184;
        MESSAGE6__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 185;
        MESSAGE5__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 186;
        MESSAGE4__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 187;
        MESSAGE3__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 188;
        MESSAGE2__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 189;
        MESSAGE1__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT1_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 196;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 197;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_40__" , 25 , __SPLS_TMPVAR__WAITLABEL_40___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_40___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 199;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT2_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 206;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_41__" , 25 , __SPLS_TMPVAR__WAITLABEL_41___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_41___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 208;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT3_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 215;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 216;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_42__" , 25 , __SPLS_TMPVAR__WAITLABEL_42___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_42___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 218;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT4_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 224;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 225;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_43__" , 25 , __SPLS_TMPVAR__WAITLABEL_43___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_43___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 227;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT5_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 233;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 234;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_44__" , 25 , __SPLS_TMPVAR__WAITLABEL_44___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_44___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 236;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT6_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 242;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 243;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_45__" , 25 , __SPLS_TMPVAR__WAITLABEL_45___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_45___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 245;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT7_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 251;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 252;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_46__" , 25 , __SPLS_TMPVAR__WAITLABEL_46___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_46___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 254;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT8_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 260;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 261;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_47__" , 25 , __SPLS_TMPVAR__WAITLABEL_47___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_47___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 263;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT9_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 269;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 270;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_48__" , 25 , __SPLS_TMPVAR__WAITLABEL_48___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_48___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 272;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT10_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 278;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 279;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_49__" , 25 , __SPLS_TMPVAR__WAITLABEL_49___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_49___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 281;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT11_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 287;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 288;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_50__" , 25 , __SPLS_TMPVAR__WAITLABEL_50___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_50___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 290;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT12_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 296;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 297;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_51__" , 25 , __SPLS_TMPVAR__WAITLABEL_51___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_51___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 299;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT13_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 305;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 306;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_52__" , 25 , __SPLS_TMPVAR__WAITLABEL_52___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_52___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 308;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT14_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 314;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 315;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_53__" , 25 , __SPLS_TMPVAR__WAITLABEL_53___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_53___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 317;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT15_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 323;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 324;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_54__" , 25 , __SPLS_TMPVAR__WAITLABEL_54___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_54___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 326;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT16_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 332;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 333;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_55__" , 25 , __SPLS_TMPVAR__WAITLABEL_55___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_55___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 335;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT17_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 341;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 342;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_56__" , 25 , __SPLS_TMPVAR__WAITLABEL_56___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_56___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 344;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT18_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 350;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 351;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_57__" , 25 , __SPLS_TMPVAR__WAITLABEL_57___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_57___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 353;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT19_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 359;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 360;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_58__" , 25 , __SPLS_TMPVAR__WAITLABEL_58___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_58___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 362;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SELECT20_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 368;
        FORWARD_MESSAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 369;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_59__" , 25 , __SPLS_TMPVAR__WAITLABEL_59___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_59___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 371;
            Functions.Pulse ( 10, FORWARD_MESSAGE ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.MESSAGE1_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE2_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE3_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE4_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE5_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE6_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE7_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE8_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE9_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE10_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE11_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE12_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE13_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE14_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE15_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE16_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE17_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE18_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE19_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.MESSAGE20_TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    STORE = new Crestron.Logos.SplusObjects.DigitalInput( STORE__DigitalInput__, this );
    m_DigitalInputList.Add( STORE__DigitalInput__, STORE );
    
    CLEAR_LIST = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_LIST__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_LIST__DigitalInput__, CLEAR_LIST );
    
    REFRESH_LIST = new Crestron.Logos.SplusObjects.DigitalInput( REFRESH_LIST__DigitalInput__, this );
    m_DigitalInputList.Add( REFRESH_LIST__DigitalInput__, REFRESH_LIST );
    
    SELECT1 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT1__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT1__DigitalInput__, SELECT1 );
    
    SELECT2 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT2__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT2__DigitalInput__, SELECT2 );
    
    SELECT3 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT3__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT3__DigitalInput__, SELECT3 );
    
    SELECT4 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT4__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT4__DigitalInput__, SELECT4 );
    
    SELECT5 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT5__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT5__DigitalInput__, SELECT5 );
    
    SELECT6 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT6__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT6__DigitalInput__, SELECT6 );
    
    SELECT7 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT7__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT7__DigitalInput__, SELECT7 );
    
    SELECT8 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT8__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT8__DigitalInput__, SELECT8 );
    
    SELECT9 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT9__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT9__DigitalInput__, SELECT9 );
    
    SELECT10 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT10__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT10__DigitalInput__, SELECT10 );
    
    SELECT11 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT11__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT11__DigitalInput__, SELECT11 );
    
    SELECT12 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT12__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT12__DigitalInput__, SELECT12 );
    
    SELECT13 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT13__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT13__DigitalInput__, SELECT13 );
    
    SELECT14 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT14__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT14__DigitalInput__, SELECT14 );
    
    SELECT15 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT15__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT15__DigitalInput__, SELECT15 );
    
    SELECT16 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT16__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT16__DigitalInput__, SELECT16 );
    
    SELECT17 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT17__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT17__DigitalInput__, SELECT17 );
    
    SELECT18 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT18__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT18__DigitalInput__, SELECT18 );
    
    SELECT19 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT19__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT19__DigitalInput__, SELECT19 );
    
    SELECT20 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT20__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT20__DigitalInput__, SELECT20 );
    
    FORWARD_MESSAGE = new Crestron.Logos.SplusObjects.DigitalOutput( FORWARD_MESSAGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FORWARD_MESSAGE__DigitalOutput__, FORWARD_MESSAGE );
    
    MESSAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MESSAGE__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( MESSAGE__DOLLAR____AnalogSerialInput__, MESSAGE__DOLLAR__ );
    
    FORWARD_MESSAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FORWARD_MESSAGE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FORWARD_MESSAGE__DOLLAR____AnalogSerialOutput__, FORWARD_MESSAGE__DOLLAR__ );
    
    MESSAGE1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE1__DOLLAR____AnalogSerialOutput__, MESSAGE1__DOLLAR__ );
    
    MESSAGE2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE2__DOLLAR____AnalogSerialOutput__, MESSAGE2__DOLLAR__ );
    
    MESSAGE3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE3__DOLLAR____AnalogSerialOutput__, MESSAGE3__DOLLAR__ );
    
    MESSAGE4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE4__DOLLAR____AnalogSerialOutput__, MESSAGE4__DOLLAR__ );
    
    MESSAGE5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE5__DOLLAR____AnalogSerialOutput__, MESSAGE5__DOLLAR__ );
    
    MESSAGE6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE6__DOLLAR____AnalogSerialOutput__, MESSAGE6__DOLLAR__ );
    
    MESSAGE7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE7__DOLLAR____AnalogSerialOutput__, MESSAGE7__DOLLAR__ );
    
    MESSAGE8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE8__DOLLAR____AnalogSerialOutput__, MESSAGE8__DOLLAR__ );
    
    MESSAGE9__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE9__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE9__DOLLAR____AnalogSerialOutput__, MESSAGE9__DOLLAR__ );
    
    MESSAGE10__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE10__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE10__DOLLAR____AnalogSerialOutput__, MESSAGE10__DOLLAR__ );
    
    MESSAGE11__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE11__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE11__DOLLAR____AnalogSerialOutput__, MESSAGE11__DOLLAR__ );
    
    MESSAGE12__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE12__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE12__DOLLAR____AnalogSerialOutput__, MESSAGE12__DOLLAR__ );
    
    MESSAGE13__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE13__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE13__DOLLAR____AnalogSerialOutput__, MESSAGE13__DOLLAR__ );
    
    MESSAGE14__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE14__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE14__DOLLAR____AnalogSerialOutput__, MESSAGE14__DOLLAR__ );
    
    MESSAGE15__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE15__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE15__DOLLAR____AnalogSerialOutput__, MESSAGE15__DOLLAR__ );
    
    MESSAGE16__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE16__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE16__DOLLAR____AnalogSerialOutput__, MESSAGE16__DOLLAR__ );
    
    MESSAGE17__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE17__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE17__DOLLAR____AnalogSerialOutput__, MESSAGE17__DOLLAR__ );
    
    MESSAGE18__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE18__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE18__DOLLAR____AnalogSerialOutput__, MESSAGE18__DOLLAR__ );
    
    MESSAGE19__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE19__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE19__DOLLAR____AnalogSerialOutput__, MESSAGE19__DOLLAR__ );
    
    MESSAGE20__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE20__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE20__DOLLAR____AnalogSerialOutput__, MESSAGE20__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_40___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_40___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_41___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_41___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_42___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_42___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_43___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_43___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_44___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_44___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_45___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_45___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_46___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_46___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_47___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_47___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_48___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_48___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_49___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_49___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_50___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_50___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_51___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_51___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_52___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_52___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_53___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_53___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_54___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_54___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_55___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_55___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_56___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_56___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_57___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_57___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_58___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_58___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_59___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_59___CallbackFn );
    
    STORE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STORE_OnPush_0, false ) );
    CLEAR_LIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_LIST_OnPush_1, false ) );
    REFRESH_LIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( REFRESH_LIST_OnPush_2, false ) );
    SELECT1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT1_OnPush_3, false ) );
    SELECT2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT2_OnPush_4, false ) );
    SELECT3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT3_OnPush_5, false ) );
    SELECT4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT4_OnPush_6, false ) );
    SELECT5.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT5_OnPush_7, false ) );
    SELECT6.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT6_OnPush_8, false ) );
    SELECT7.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT7_OnPush_9, false ) );
    SELECT8.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT8_OnPush_10, false ) );
    SELECT9.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT9_OnPush_11, false ) );
    SELECT10.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT10_OnPush_12, false ) );
    SELECT11.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT11_OnPush_13, false ) );
    SELECT12.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT12_OnPush_14, false ) );
    SELECT13.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT13_OnPush_15, false ) );
    SELECT14.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT14_OnPush_16, false ) );
    SELECT15.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT15_OnPush_17, false ) );
    SELECT16.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT16_OnPush_18, false ) );
    SELECT17.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT17_OnPush_19, false ) );
    SELECT18.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT18_OnPush_20, false ) );
    SELECT19.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT19_OnPush_21, false ) );
    SELECT20.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT20_OnPush_22, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_20_EVENT_HVAC_MESSAGE_LIST_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_40___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_41___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_42___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_43___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_44___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_45___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_46___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_47___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_48___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_49___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_50___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_51___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_52___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_53___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_54___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_55___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_56___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_57___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_58___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_59___Callback;


const uint STORE__DigitalInput__ = 0;
const uint CLEAR_LIST__DigitalInput__ = 1;
const uint REFRESH_LIST__DigitalInput__ = 2;
const uint SELECT1__DigitalInput__ = 3;
const uint SELECT2__DigitalInput__ = 4;
const uint SELECT3__DigitalInput__ = 5;
const uint SELECT4__DigitalInput__ = 6;
const uint SELECT5__DigitalInput__ = 7;
const uint SELECT6__DigitalInput__ = 8;
const uint SELECT7__DigitalInput__ = 9;
const uint SELECT8__DigitalInput__ = 10;
const uint SELECT9__DigitalInput__ = 11;
const uint SELECT10__DigitalInput__ = 12;
const uint SELECT11__DigitalInput__ = 13;
const uint SELECT12__DigitalInput__ = 14;
const uint SELECT13__DigitalInput__ = 15;
const uint SELECT14__DigitalInput__ = 16;
const uint SELECT15__DigitalInput__ = 17;
const uint SELECT16__DigitalInput__ = 18;
const uint SELECT17__DigitalInput__ = 19;
const uint SELECT18__DigitalInput__ = 20;
const uint SELECT19__DigitalInput__ = 21;
const uint SELECT20__DigitalInput__ = 22;
const uint MESSAGE__DOLLAR____AnalogSerialInput__ = 0;
const uint FORWARD_MESSAGE__DigitalOutput__ = 0;
const uint FORWARD_MESSAGE__DOLLAR____AnalogSerialOutput__ = 0;
const uint MESSAGE1__DOLLAR____AnalogSerialOutput__ = 1;
const uint MESSAGE2__DOLLAR____AnalogSerialOutput__ = 2;
const uint MESSAGE3__DOLLAR____AnalogSerialOutput__ = 3;
const uint MESSAGE4__DOLLAR____AnalogSerialOutput__ = 4;
const uint MESSAGE5__DOLLAR____AnalogSerialOutput__ = 5;
const uint MESSAGE6__DOLLAR____AnalogSerialOutput__ = 6;
const uint MESSAGE7__DOLLAR____AnalogSerialOutput__ = 7;
const uint MESSAGE8__DOLLAR____AnalogSerialOutput__ = 8;
const uint MESSAGE9__DOLLAR____AnalogSerialOutput__ = 9;
const uint MESSAGE10__DOLLAR____AnalogSerialOutput__ = 10;
const uint MESSAGE11__DOLLAR____AnalogSerialOutput__ = 11;
const uint MESSAGE12__DOLLAR____AnalogSerialOutput__ = 12;
const uint MESSAGE13__DOLLAR____AnalogSerialOutput__ = 13;
const uint MESSAGE14__DOLLAR____AnalogSerialOutput__ = 14;
const uint MESSAGE15__DOLLAR____AnalogSerialOutput__ = 15;
const uint MESSAGE16__DOLLAR____AnalogSerialOutput__ = 16;
const uint MESSAGE17__DOLLAR____AnalogSerialOutput__ = 17;
const uint MESSAGE18__DOLLAR____AnalogSerialOutput__ = 18;
const uint MESSAGE19__DOLLAR____AnalogSerialOutput__ = 19;
const uint MESSAGE20__DOLLAR____AnalogSerialOutput__ = 20;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public CrestronString MESSAGE1_TEMP__DOLLAR__;
            [SplusStructAttribute(1, false, true)]
            public CrestronString MESSAGE2_TEMP__DOLLAR__;
            [SplusStructAttribute(2, false, true)]
            public CrestronString MESSAGE3_TEMP__DOLLAR__;
            [SplusStructAttribute(3, false, true)]
            public CrestronString MESSAGE4_TEMP__DOLLAR__;
            [SplusStructAttribute(4, false, true)]
            public CrestronString MESSAGE5_TEMP__DOLLAR__;
            [SplusStructAttribute(5, false, true)]
            public CrestronString MESSAGE6_TEMP__DOLLAR__;
            [SplusStructAttribute(6, false, true)]
            public CrestronString MESSAGE7_TEMP__DOLLAR__;
            [SplusStructAttribute(7, false, true)]
            public CrestronString MESSAGE8_TEMP__DOLLAR__;
            [SplusStructAttribute(8, false, true)]
            public CrestronString MESSAGE9_TEMP__DOLLAR__;
            [SplusStructAttribute(9, false, true)]
            public CrestronString MESSAGE10_TEMP__DOLLAR__;
            [SplusStructAttribute(10, false, true)]
            public CrestronString MESSAGE11_TEMP__DOLLAR__;
            [SplusStructAttribute(11, false, true)]
            public CrestronString MESSAGE12_TEMP__DOLLAR__;
            [SplusStructAttribute(12, false, true)]
            public CrestronString MESSAGE13_TEMP__DOLLAR__;
            [SplusStructAttribute(13, false, true)]
            public CrestronString MESSAGE14_TEMP__DOLLAR__;
            [SplusStructAttribute(14, false, true)]
            public CrestronString MESSAGE15_TEMP__DOLLAR__;
            [SplusStructAttribute(15, false, true)]
            public CrestronString MESSAGE16_TEMP__DOLLAR__;
            [SplusStructAttribute(16, false, true)]
            public CrestronString MESSAGE17_TEMP__DOLLAR__;
            [SplusStructAttribute(17, false, true)]
            public CrestronString MESSAGE18_TEMP__DOLLAR__;
            [SplusStructAttribute(18, false, true)]
            public CrestronString MESSAGE19_TEMP__DOLLAR__;
            [SplusStructAttribute(19, false, true)]
            public CrestronString MESSAGE20_TEMP__DOLLAR__;
            
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
