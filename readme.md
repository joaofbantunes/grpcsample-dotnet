# About

Very simple sample of an gRPC client implemented in C# (implemented a Go server in [this repository](https://github.com/joaofbantunes/grpcsample-go).)

Consider I'm on Windows for the next steps

# Steps I took
1. Create projects (gRPC requires .NET Standard 1.5)
2. On the CodingMilitia.GrpcSample.Proto project, added the nuget packages for gRPC
```
dotnet add package Grpc
dotnet add package Google.Protobuf
dotnet add package Grpc.Tools
```
3. Instead of creating a shared location for the service definition to be, I copied it into this repository, I don't need to mention that this is bad and is only acceptable cause I'm trying things out
4. Created the file generate-code-from-proto.bat to take care of generating the csharp code from the service definition
5. Added the Grpc and Protobuf nuget packages to CodingMilitia.GrpcSample.Client
```
dotnet add package Grpc
dotnet add package Google.Protobuf
```
6. Implement the program
7. Launch the server developed on [this repository](https://github.com/joaofbantunes/grpcsample-go).
8. Launch the client `dotnet run`
9. See things working :)