setlocal

@rem enter this directory
cd /d %~dp0

set TOOLS_PATH=%userprofile%\.nuget\packages\Grpc.Tools\1.4.0\tools\windows_x64

@rem for some reason this ain't working... hammer time!
@rem %TOOLS_PATH%\protoc.exe "servicedef\*.proto" --csharp_out=. --csharp_opt=file_extension=.g.cs --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe
for %%P in (servicedef\*.proto) do %TOOLS_PATH%\protoc.exe %%P --csharp_out=. --grpc_out . --plugin=protoc-gen-grpc=%TOOLS_PATH%\grpc_csharp_plugin.exe

endlocal