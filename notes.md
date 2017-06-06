#add packagea
dotnet add package Grpc.Tools
dotnet add package Grpc
dotnet add package Google.Protobuf

#command to gen protos
C:\Users\rjleo\.nuget\packages\grpc.tools\1.3.6\tools\windows_x64\protoc.exe -I./protos -
-csharp_out TestService --grpc_out TestService ./protos/test.proto --plugin=protoc-gen-grpc=C:\Users\rjleo\.nuget\packag
es\grpc.tools\1.3.6\tools\windows_x64\grpc_csharp_plugin.exe

