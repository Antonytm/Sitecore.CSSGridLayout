$version = $env:APPVEYOR_BUILD_VERSION
if ($version -eq $null) {
    $version = "1.0.0"
}
"Package version: " + $version

Remove-Item build\package -Recurse -ErrorAction Ignore
Remove-Item build\artifacts -Recurse -ErrorAction Ignore
New-Item -Name build\package -ItemType directory
New-Item -Name build\artifacts -ItemType directory
New-Item -Name build\package\Data -ItemType directory
New-Item -Name build\package\bin -ItemType directory
New-Item -Name build\package\App_Config\Include\Foundation -ItemType directory

Copy-Item .\src\Foundation\CSSGridLayout\code\bin\Foundation.CSSGrid* .\build\package\bin
Copy-Item .\src\Foundation\CSSGridLayout\code\App_Config\Include\CSSGridLayout\Foundation.CSSGridLayout.config .\build\package\App_Config\Include\Foundation
Copy-Item .\src\Foundation\CSSGridLayout\serialization\* .\build\package\Data -recurse

$packageCmd = "Sitecore.Courier.Runner.exe -t build\package -o build\artifacts\sitecore.cssgrid." + $version + ".update -r"
iex $packageCmd