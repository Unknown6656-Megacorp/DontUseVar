[![](https://img.shields.io/github/downloads/Unknown6656-Megacorp/DontUseVar/total)](https://github.com/Unknown6656-Megacorp/Unknown6656.DontUseVar/releases)
[![](https://img.shields.io/nuget/vpre/Unknown6656.DontUseVar)](https://www.nuget.org/packages/Unknown6656.DontUseVar/)
[![](https://img.shields.io/nuget/dt/Unknown6656.DontUseVar)](https://www.nuget.org/packages/Unknown6656.DontUseVar/)

# Don't use `var`!

A minimalistic library (5 KB) which will prevent code from compiling if `var` is used as a type identifier instead of the type name.
To use this library in your project, use one of the following methods:


- **Package Manager:**

    ```batch
    PM> Install-Package Unknown6656.DontUseVar
    ```

- **.NET CLI:**

    ```batch
    > dotnet add package Unknown6656.DontUseVar
    ```

- **Package reference** (e.g. in a `.csproj`/`.vbproj`/`.fsproj` project file):

    ```xml
    <PackageReference Include="Unknown6656.DontUseVar" Version="*" />
    ```

- **Paket CLI:**

    ```batch
    > paket add Unknown6656.DontUseVar
    ```

- **F# Interactive:**

    ```fsharp
    #r "nuget: Unknown6656.DontUseVar, *"
    ```


