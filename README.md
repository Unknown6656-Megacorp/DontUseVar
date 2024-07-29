[![](https://img.shields.io/github/downloads/Unknown6656-Megacorp/DontUseVar/total)](https://github.com/Unknown6656-Megacorp/Unknown6656.DontUseVar/releases)
[![](https://img.shields.io/nuget/vpre/Unknown6656.DontUseVar)](https://www.nuget.org/packages/Unknown6656.DontUseVar/)
[![](https://img.shields.io/nuget/dt/Unknown6656.DontUseVar)](https://www.nuget.org/packages/Unknown6656.DontUseVar/)

# Don't use `var`!

A minimalistic library which will prevent code from compiling if `var` is used as a type identifier instead of the type name.<br/>
![image](https://github.com/Unknown6656-Megacorp/DontUseVar/assets/8807985/a6ec0c32-fc18-44c7-b416-d3f075931736)<br/>
![image](https://github.com/Unknown6656-Megacorp/DontUseVar/assets/8807985/f60a1d90-63c3-4175-aebf-60e71ee21f1e)

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


> [!CAUTION]
> As NuGet dependencies are cascading transitively, it might be wise to reference `Unknown6656.DontUseVar` only during Debug mode:
> ```xml
> <ItemGroup Condition="'$(Configuration)' == 'Debug'">
>     <PackageReference Include="Unknown6656.DontUseVar" Version="*" />
> </ItemGroup>
> ```
> Otherwise, other code bases using your library will also be forced to not use var, which might lead to breaking changes (especially when anonymous classes are involved).
