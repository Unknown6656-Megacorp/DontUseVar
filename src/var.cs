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


[Obsolete(MESSAGE, error: true)]
[EditorBrowsable(EditorBrowsableState.Never), CompilerGenerated, DebuggerNonUserCode, DebuggerStepThrough]
public sealed class var
    : Exception
{
    private const string MESSAGE = "Do not use 'var' as an type identifier. Specify the full type identifier instead.";
    private const int HRESULT = unchecked((int)0x8013153A); // COR_E_INVALIDPROGRAM


    /// <summary>
    /// Prevent instantiation of this class (even through reflection).
    /// <para/>
    /// As we cannot use <see href="https://learn.microsoft.com/en-us/dotnet/api/system.invalidprogramexception"/> in <c>NETSTANDARD 1.0</c>, we have to provide the <see cref="Exception.HResult"/> manually.
    /// </summary>
    private var()
        : base(MESSAGE)
    {
        HResult = HRESULT;
        HelpLink = "https://docs.microsoft.com/dotnet/csharp/language-reference/keywords/var";

        throw this;
    }
}

#pragma warning restore
