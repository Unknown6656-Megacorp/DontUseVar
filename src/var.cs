using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System;


#if NET50_OR_GREATER
    #pragma warning disable CA1050 // Declare types in namespaces

    #if NET6_0_OR_GREATER
        #pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    #endif
#else
    #pragma warning disable IDE0079
#endif

#pragma warning disable IDE1006 // Naming Styles


[Obsolete("Do not use 'var' as an type identifier. Specify the full type identifier instead.", error: true)]
[EditorBrowsable(EditorBrowsableState.Never), CompilerGenerated, DebuggerNonUserCode, DebuggerStepThrough]
public ref struct var;

#pragma warning restore
