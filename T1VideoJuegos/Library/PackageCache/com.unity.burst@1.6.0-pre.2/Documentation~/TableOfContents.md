* [Burst Documentation](index.md)
  * [Quick Start](docs/QuickStart.md)
    * [Compile a Job with the Burst compiler](docs/QuickStart.md#compile-a-job-with-the-burst-compiler)
    * [Jobs/Burst Menu](docs/QuickStart.md#jobs-burst-menu)
    * [Burst Inspector](docs/QuickStart.md#burst-inspector)
    * [Command-line Options](docs/QuickStart.md#command-line-options)
    * [Just-In-Time (JIT) vs Ahead-Of-Time (AOT) Compilation](docs/QuickStart.md#just-in-time-jit-vs-ahead-of-time-aot-compilation)
  * [C#/.NET Language Support](docs/CSharpLanguageSupport_Types.md)
    * [Supported .NET types](docs/CSharpLanguageSupport_Types.md#supported-net-types)
      * [Primitive types](docs/CSharpLanguageSupport_Types.md#primitive-types)
      * [Vector types](docs/CSharpLanguageSupport_Types.md#vector-types)
      * [Enum types](docs/CSharpLanguageSupport_Types.md#enum-types)
      * [Struct types](docs/CSharpLanguageSupport_Types.md#struct-types)
      * [Pointer types](docs/CSharpLanguageSupport_Types.md#pointer-types)
      * [Generic types](docs/CSharpLanguageSupport_Types.md#generic-types)
      * [Array types](docs/CSharpLanguageSupport_Types.md#array-types)
      * [ValueTuple type](docs/CSharpLanguageSupport_Types.md#valuetuple-type)
    * [Language Support](docs/CSharpLanguageSupport_Lang.md#language-support)
      * [Directly Calling Burst Compiled Code](docs/CSharpLanguageSupport_Lang.md#directly-calling-burst-compiled-code)
      * [Throw and Exceptions](docs/CSharpLanguageSupport_Lang.md#throw-and-exceptions)
      * [Partial support for strings and `Debug.Log`](docs/CSharpLanguageSupport_Lang.md#partial-support-for-strings-and-debuglog)
    * [Intrinsics](docs/CSharpLanguageSupport_Intrinsics.md#intrinsics)
      * [System.Math](docs/CSharpLanguageSupport_Intrinsics.md#systemmath)
      * [System.IntPtr](docs/CSharpLanguageSupport_Intrinsics.md#systemintptr)
      * [System.Threading.Interlocked](docs/CSharpLanguageSupport_Intrinsics.md#systemthreadinginterlocked)
      * [System.Threading.Thread](docs/CSharpLanguageSupport_Intrinsics.md#systemthreadingthread)
      * [System.Threading.Volatile](docs/CSharpLanguageSupport_Intrinsics.md#systemthreadingvolatile)
    * [Unity.Burst.Intrinsics](docs/CSharpLanguageSupport_BurstIntrinsics.md#unityburstintrinsics)
      * [Common](docs/CSharpLanguageSupport_BurstIntrinsics.md#common)
      * [Pause](docs/CSharpLanguageSupport_BurstIntrinsics.md#pause)
      * [Prefetch](docs/CSharpLanguageSupport_BurstIntrinsics.md#prefetch)
      * [umul128](docs/CSharpLanguageSupport_BurstIntrinsics.md#umul128)
      * [Processor specific SIMD extensions](docs/CSharpLanguageSupport_BurstIntrinsics.md#processor-specific-simd-extensions)
      * [`DllImport` and internal calls](docs/CSharpLanguageSupport_BurstIntrinsics.md#dllimport-and-internal-calls)
  * [Debugging and Profiling](docs/DebuggingAndProfiling.md)
    * [Managed Debugging](docs/DebuggingAndProfiling.md#managed-debugging)
    * [Native Debugging](docs/DebuggingAndProfiling.md#native-debugging)
  * [Advanced Usages](docs/AdvancedUsages.md)
    * [BurstDiscard Attribute](docs/AdvancedUsages.md#burstdiscard-attribute)
    * [Synchronous Compilation](docs/AdvancedUsages.md#synchronous-compilation)
    * [Disable Safety Checks](docs/AdvancedUsages.md#disable-safety-checks)
    * [Optimization Choices](docs/AdvancedUsages.md#optimization-choices)
    * [Function Pointers](docs/AdvancedUsages.md#function-pointers)
      * [Performance considerations](docs/AdvancedUsages.md#performance-considerations)
    * [Shared Static](docs/AdvancedUsages.md#shared-static)
    * [Assembly-Level BurstCompile](docs/AdvancedUsages.md#assembly-level-burstcompile)
    * [Dynamic dispatch based on runtime CPU features](docs/AdvancedUsages.md#dynamic-dispatch-based-on-runtime-cpu-features)
  * [Compiler Warnings](docs/Warnings.md)
    * [IgnoreWarning attribute](docs/Warnings.md#ignorewarning-attribute)
    * [BC1370 - An exception was thrown from a function without the correct \\[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")\\] guard...](docs/Warnings.md#bc1370)
    * [BC1371 - A call to the method 'xxx' has been discarded, due to its use as an argument to a discarded method...](docs/Warnings.md#bc1371)
  * [Optimization Guidelines](docs/OptimizationGuidelines.md)
    * [Aliasing](docs/OptimizationGuidelines-Aliasing.md)
      * [The Problem](docs/OptimizationGuidelines-Aliasing.md#the-problem)
        * [No memory aliasing](docs/OptimizationGuidelines-Aliasing.md#no-memory-aliasing)
        * [No memory aliasing with the auto-vectorizer](docs/OptimizationGuidelines-Aliasing.md#no-memory-aliasing-with-the-auto-vectorizer)
        * [Memory aliasing](docs/OptimizationGuidelines-Aliasing.md#memory-aliasing)
        * [Memory aliasing with invalid vectorized code](docs/OptimizationGuidelines-Aliasing.md#memory-aliasing-with-invalid-vectorized-code)
        * [Example of Generated Code](docs/OptimizationGuidelines-Aliasing.md#example-of-generated-code)
      * [Burst and the JobSystem](docs/OptimizationGuidelines-Aliasing.md#burst-and-the-jobsystem)
      * [The NoAlias Attribute](docs/OptimizationGuidelines-Aliasing.md#the-noalias-attribute)
        * [NoAlias Function Paramater](docs/OptimizationGuidelines-Aliasing.md#noalias-function-parameter)
        * [NoAlias Struct Field](docs/OptimizationGuidelines-Aliasing.md#noalias-struct-field)
        * [NoAlias Struct](docs/OptimizationGuidelines-Aliasing.md#noalias-struct)
        * [NoAlias Function Return](docs/OptimizationGuidelines-Aliasing.md#noalias-function-return)
      * [Function Cloning for Better Aliasing Deduction](docs/OptimizationGuidelines-Aliasing.md#function-cloning-for-better-aliasing-deduction)
      * [Aliasing Checks](docs/OptimizationGuidelines-Aliasing.md#aliasing-checks)
    * [Loop Vectorization](docs/OptimizationGuidelines.md#loop-vectorization)
    * [Compiler Options](docs/OptimizationGuidelines.md#compiler-options)
      * [FloatPrecision](docs/OptimizationGuidelines.md#floatprecision)
        * [FloatPrecision.Low](docs/OptimizationGuidelines.md#floatprecisionlow)
      * [Compiler floating point math mode](docs/OptimizationGuidelines.md#compiler-floating-point-math-mode)
    * [AssumeRange Attribute](docs/OptimizationGuidelines.md#assumerange-attribute)
    * [Hint Intrinsics](docs/OptimizationGuidelines.md#hint-intrinsics)
    * [Constant Intrinsics](docs/OptimizationGuidelines.md#constant-intrinsic)
    * [Unity Mathematics](docs/OptimizationGuidelines.md#unitymathematics)
    * [Generic Jobs](docs/OptimizationGuidelines.md#generic-jobs)
    * [SkipLocalsInit Attribute](docs/OptimizationGuidelines.md#skiplocalsinit-attribute)
  * [Standalone Player support](docs/StandalonePlayerSupport.md)
    * [Usage](docs/StandalonePlayerSupport.md#usage)
    * [Burst AOT Settings](docs/StandalonePlayerSupport.md#burst-aot-settings)
    * [Burst AOT Requirements](docs/StandalonePlayerSupport.md#burst-aot-requirements)
      * [Desktop platforms with cross compilation enabled (the default behaviour)](docs/StandalonePlayerSupport.md#desktop-platforms-with-cross-compilation-enabled-the-default-behaviour)
      * [Other platforms and desktops when cross compilation is disabled)](docs/StandalonePlayerSupport.md#other-platforms-and-desktops-when-cross-compilation-is-disabled)
    * [Burst Targets](docs/StandalonePlayerSupport.md#burst-targets)
  * [Modding Support](docs/ModdingSupport.md)
    * [Overview](docs/ModdingSupport.md#overview)
    * [Supported Uses](docs/ModdingSupport.md#supported-uses)
    * [An Example Modding System](docs/ModdingSupport.md#an-example-modding-system)
  * [Known issues](docs/KnownIssues.md)
    * [`DllImport`](docs/KnownIssues.md#known-issues-with-dllimport)
    * [Debugging/Profiling](docs/KnownIssues.md#known-issues-with-debuggingprofiling)
  * [More Information](docs/Presentations.md)
    * [Presentations](docs/Presentations.md#presentations)
    * [Blogs](docs/Presentations.md#blogs)