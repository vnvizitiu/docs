### ObsoleteAttribute exports as both ObsoleteAttribute and DeprecatedAttribute in WinMD scenarios

|   |   |
|---|---|
|Details|When you create a Windows Metadata library (.winmd file), the <xref:System.ObsoleteAttribute?displayProperty=name> attribute is exported as both <xref:System.ObsoleteAttribute?displayProperty=name> and <a href="/uwp/api/windows.foundation.metadata.deprecatedattribute">Windows.Foundation.DeprecatedAttribute</a>.|
|Suggestion|Recompilation of existing source code that uses the <xref:System.ObsoleteAttribute?displayProperty=name> attribute may generate warnings when consuming that code from C++/CX or JavaScript.We do not recommend applying both <xref:System.ObsoleteAttribute?displayProperty=name> and <a href="/uwp/api/windows.foundation.metadata.deprecatedattribute">Windows.Foundation.DeprecatedAttribute</a> to code in managed assemblies; it may result in build warnings.|
|Scope|Edge|
|Version|4.5.1|
|Type|Retargeting|
|Analyzers|<ul><li>CD0048A</li><li>CD0048B</li></ul>|

