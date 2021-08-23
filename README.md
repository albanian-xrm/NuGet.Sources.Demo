# NuGet.Sources.Demo
This is the sourcecode for this demo https://youtu.be/4kD42ptHYmM

The code during the demo was in the path `C:\AlbanianXrm\Demo\SourceOnlyPackages\AlbanianXrm.Demo`

also in the path `C:\AlbanianXrm\Demo\SourceOnlyPackages\NuGet.config` there was the following NuGet config:

```xml
<configuration>
	<packageSources>
	  <clear />
		<add key="Demo" value="C:\AlbanianXrm\Demo\SourceOnlyPackages\NuGets" />
	</packageSources>
</configuration>
```

The developer terminal scripts to generate the packages were the following:

```cmd
 nuget pack .\AlbanianXrm.Demo.Build.nuspec -OutputDirectory "..\..\Nugets"
```

```cmd
 nuget pack .\AlbanianXrm.Demo.Source.nuspec -OutputDirectory "..\..\Nugets"
 ```
