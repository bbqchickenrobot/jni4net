//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.management {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KBaseConfigurationMonitorMBean {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isIndexLeftBetaMemory();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isShareAlphaNodes();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isRemoveIdentities();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isSequential();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isIndexRightBetaMemory();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getMaxThreads();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isShareBetaNodes();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isMultithreadEvaluation();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getAlphaNodeHashingThreshold();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getAssertBehaviour();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getCompositeKeyDepth();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getEventProcessingMode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getSequentialAgenda();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isAdvancedProcessRuleIntegration();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isMaintainTms();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isMBeansEnabled();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KBaseConfigurationMonitorMBean_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.management.KBaseConfigurationMonitorMBean), typeof(global::org.drools.management.KBaseConfigurationMonitorMBean_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.management.KBaseConfigurationMonitorMBean), typeof(global::org.drools.management.KBaseConfigurationMonitorMBean_))]
    internal sealed partial class @__KBaseConfigurationMonitorMBean : global::java.lang.Object, global::org.drools.management.KBaseConfigurationMonitorMBean {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _isIndexLeftBetaMemory0;
        
        internal static global::net.sf.jni4net.jni.MethodId _isShareAlphaNodes1;
        
        internal static global::net.sf.jni4net.jni.MethodId _isRemoveIdentities2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSequential3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isIndexRightBetaMemory4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMaxThreads5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isShareBetaNodes6;
        
        internal static global::net.sf.jni4net.jni.MethodId _isMultithreadEvaluation7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAlphaNodeHashingThreshold8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAssertBehaviour9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCompositeKeyDepth10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEventProcessingMode11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSequentialAgenda12;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAdvancedProcessRuleIntegration13;
        
        internal static global::net.sf.jni4net.jni.MethodId _isMaintainTms14;
        
        internal static global::net.sf.jni4net.jni.MethodId _isMBeansEnabled15;
        
        private @__KBaseConfigurationMonitorMBean(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass = @__class;
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isIndexLeftBetaMemory0 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isIndexLeftBetaMemory", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isShareAlphaNodes1 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isShareAlphaNodes", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isRemoveIdentities2 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isRemoveIdentities", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isSequential3 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isSequential", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isIndexRightBetaMemory4 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isIndexRightBetaMemory", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getMaxThreads5 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getMaxThreads", "()I");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isShareBetaNodes6 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isShareBetaNodes", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMultithreadEvaluation7 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isMultithreadEvaluation", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getAlphaNodeHashingThreshold8 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getAlphaNodeHashingThreshold", "()I");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getAssertBehaviour9 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getAssertBehaviour", "()Ljava/lang/String;");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getCompositeKeyDepth10 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getCompositeKeyDepth", "()I");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getEventProcessingMode11 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getEventProcessingMode", "()Ljava/lang/String;");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._getSequentialAgenda12 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "getSequentialAgenda", "()Ljava/lang/String;");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isAdvancedProcessRuleIntegration13 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isAdvancedProcessRuleIntegration", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMaintainTms14 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isMaintainTms", "()Z");
            global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMBeansEnabled15 = @__env.GetMethodID(global::org.drools.management.@__KBaseConfigurationMonitorMBean.staticClass, "isMBeansEnabled", "()Z");
        }
        
        public bool isIndexLeftBetaMemory() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isIndexLeftBetaMemory0)));
            }
        }
        
        public bool isShareAlphaNodes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isShareAlphaNodes1)));
            }
        }
        
        public bool isRemoveIdentities() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isRemoveIdentities2)));
            }
        }
        
        public bool isSequential() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isSequential3)));
            }
        }
        
        public bool isIndexRightBetaMemory() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isIndexRightBetaMemory4)));
            }
        }
        
        public int getMaxThreads() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getMaxThreads5)));
            }
        }
        
        public bool isShareBetaNodes() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isShareBetaNodes6)));
            }
        }
        
        public bool isMultithreadEvaluation() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMultithreadEvaluation7)));
            }
        }
        
        public int getAlphaNodeHashingThreshold() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getAlphaNodeHashingThreshold8)));
            }
        }
        
        public global::java.lang.String getAssertBehaviour() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getAssertBehaviour9));
            }
        }
        
        public int getCompositeKeyDepth() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getCompositeKeyDepth10)));
            }
        }
        
        public global::java.lang.String getEventProcessingMode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getEventProcessingMode11));
            }
        }
        
        public global::java.lang.String getSequentialAgenda() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._getSequentialAgenda12));
            }
        }
        
        public bool isAdvancedProcessRuleIntegration() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isAdvancedProcessRuleIntegration13)));
            }
        }
        
        public bool isMaintainTms() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMaintainTms14)));
            }
        }
        
        public bool isMBeansEnabled() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.management.@__KBaseConfigurationMonitorMBean._isMBeansEnabled15)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KBaseConfigurationMonitorMBean);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isIndexLeftBetaMemory", "isIndexLeftBetaMemory0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isShareAlphaNodes", "isShareAlphaNodes1", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isRemoveIdentities", "isRemoveIdentities2", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isSequential", "isSequential3", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isIndexRightBetaMemory", "isIndexRightBetaMemory4", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMaxThreads", "getMaxThreads5", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isShareBetaNodes", "isShareBetaNodes6", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isMultithreadEvaluation", "isMultithreadEvaluation7", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAlphaNodeHashingThreshold", "getAlphaNodeHashingThreshold8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAssertBehaviour", "getAssertBehaviour9", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCompositeKeyDepth", "getCompositeKeyDepth10", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEventProcessingMode", "getEventProcessingMode11", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSequentialAgenda", "getSequentialAgenda12", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAdvancedProcessRuleIntegration", "isAdvancedProcessRuleIntegration13", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isMaintainTms", "isMaintainTms14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isMBeansEnabled", "isMBeansEnabled15", "()Z"));
            return methods;
        }
        
        private static bool isIndexLeftBetaMemory0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isIndexLeftBetaMemory()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isShareAlphaNodes1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isShareAlphaNodes()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isRemoveIdentities2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isRemoveIdentities()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isSequential3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isSequential()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isIndexRightBetaMemory4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isIndexRightBetaMemory()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getMaxThreads5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((int)(@__real.getMaxThreads()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isShareBetaNodes6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isShareBetaNodes()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isMultithreadEvaluation7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isMultithreadEvaluation()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getAlphaNodeHashingThreshold8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((int)(@__real.getAlphaNodeHashingThreshold()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getAssertBehaviour9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getAssertBehaviour());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getCompositeKeyDepth10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((int)(@__real.getCompositeKeyDepth()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getEventProcessingMode11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getEventProcessingMode());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getSequentialAgenda12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getSequentialAgenda());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isAdvancedProcessRuleIntegration13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isAdvancedProcessRuleIntegration()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isMaintainTms14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isMaintainTms()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isMBeansEnabled15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::org.drools.management.KBaseConfigurationMonitorMBean @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.management.KBaseConfigurationMonitorMBean>(@__env, @__obj);
            @__return = ((bool)(@__real.isMBeansEnabled()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.management.@__KBaseConfigurationMonitorMBean(@__env);
            }
        }
    }
    #endregion
}