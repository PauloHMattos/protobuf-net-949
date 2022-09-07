using A;
using ProtoBuf;
using ProtoBuf.Meta;

namespace Application {
    internal class Program {
        static void Main(string[] args) {
            var protobufTypeModel = new ProtobufTypeModel(RuntimeTypeModel.Default);

            // Works - proto3
            Console.WriteLine(protobufTypeModel.GetSchemaWorking(typeof(ExampleModel)));
            // Also works - proto2
            Console.WriteLine(RuntimeTypeModel.Default.GetSchema(typeof(ExampleModel), ProtoSyntax.Proto2));
            // MissingMethodException
            Console.WriteLine(protobufTypeModel.GetSchemaBroken(typeof(ExampleModel)));
        }
    }

    [ProtoContract]
    public class ExampleModel {
        [ProtoMember(1)]
        public int Integer { get; set; }
        [ProtoMember(2)]
        public string Str { get; set; }
    }
}