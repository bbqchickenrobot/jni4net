//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.logger {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KnowledgeRuntimeLoggerFactoryService {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;)Lorg/drools/lo" +
            "gger/KnowledgeRuntimeLogger;")]
        global::org.drools.logger.KnowledgeRuntimeLogger newFileLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0, global::java.lang.String par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;I)Lorg/drools/l" +
            "ogger/KnowledgeRuntimeLogger;")]
        global::org.drools.logger.KnowledgeRuntimeLogger newThreadedFileLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0, global::java.lang.String par1, int par2);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/event/KnowledgeRuntimeEventManager;)Lorg/drools/logger/KnowledgeRunt" +
            "imeLogger;")]
        global::org.drools.logger.KnowledgeRuntimeLogger newConsoleLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KnowledgeRuntimeLoggerFactoryService_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService), typeof(global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService), typeof(global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService_))]
    internal sealed partial class @__KnowledgeRuntimeLoggerFactoryService : global::java.lang.Object, global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _newFileLogger0;
        
        internal static global::net.sf.jni4net.jni.MethodId _newThreadedFileLogger1;
        
        internal static global::net.sf.jni4net.jni.MethodId _newConsoleLogger2;
        
        private @__KnowledgeRuntimeLoggerFactoryService(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService.staticClass = @__class;
            global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newFileLogger0 = @__env.GetMethodID(global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService.staticClass, "newFileLogger", "(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;)Lorg/drools/lo" +
                    "gger/KnowledgeRuntimeLogger;");
            global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newThreadedFileLogger1 = @__env.GetMethodID(global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService.staticClass, "newThreadedFileLogger", "(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;I)Lorg/drools/l" +
                    "ogger/KnowledgeRuntimeLogger;");
            global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newConsoleLogger2 = @__env.GetMethodID(global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService.staticClass, "newConsoleLogger", "(Lorg/drools/event/KnowledgeRuntimeEventManager;)Lorg/drools/logger/KnowledgeRunt" +
                    "imeLogger;");
        }
        
        public global::org.drools.logger.KnowledgeRuntimeLogger newFileLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newFileLogger0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        public global::org.drools.logger.KnowledgeRuntimeLogger newThreadedFileLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0, global::java.lang.String par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newThreadedFileLogger1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
            }
        }
        
        public global::org.drools.logger.KnowledgeRuntimeLogger newConsoleLogger(global::org.drools.@event.KnowledgeRuntimeEventManager par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService._newConsoleLogger2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KnowledgeRuntimeLoggerFactoryService);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "newFileLogger", "newFileLogger0", "(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;)Lorg/drools/lo" +
                        "gger/KnowledgeRuntimeLogger;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "newThreadedFileLogger", "newThreadedFileLogger1", "(Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;I)Lorg/drools/l" +
                        "ogger/KnowledgeRuntimeLogger;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "newConsoleLogger", "newConsoleLogger2", "(Lorg/drools/event/KnowledgeRuntimeEventManager;)Lorg/drools/logger/KnowledgeRunt" +
                        "imeLogger;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle newFileLogger0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;)Lorg/drools/logger/KnowledgeRuntimeLogger;
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;)Lorg/drools/logger/KnowledgeRuntimeLogger;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__real.newFileLogger(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle newThreadedFileLogger1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1, int par2) {
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;I)Lorg/drools/logger/KnowledgeRuntimeLogger;
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;Ljava/lang/String;I)Lorg/drools/logger/KnowledgeRuntimeLogger;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__real.newThreadedFileLogger(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1), par2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle newConsoleLogger2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;)Lorg/drools/logger/KnowledgeRuntimeLogger;
            // (Lorg/drools/event/KnowledgeRuntimeEventManager;)Lorg/drools/logger/KnowledgeRuntimeLogger;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.logger.KnowledgeRuntimeLoggerFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.logger.KnowledgeRuntimeLogger>(@__env, @__real.newConsoleLogger(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.KnowledgeRuntimeEventManager>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.logger.@__KnowledgeRuntimeLoggerFactoryService(@__env);
            }
        }
    }
    #endregion
}