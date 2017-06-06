using System;
using System.Threading.Tasks;
using Grpc.Core;
using grpc_test;


public class TestServer : grpc_test.TestService.TestServiceBase {
    public override Task<Response> GetTime(Request req, ServerCallContext ctx) {
        Console.WriteLine("GetTime request recieved.");
        var res = new Response { Body=System.DateTimeOffset.Now.ToString(), Type="DateTime"};
        return Task.FromResult(res);
    }

    public override Task<Response> SaySomething(Request req, ServerCallContext ctx) {
        var res = new Response { Body="SaySomething called.", Type="string"};
        Console.WriteLine($"{req.Body} - {req.Type}");
        return Task.FromResult(res);
    }
}