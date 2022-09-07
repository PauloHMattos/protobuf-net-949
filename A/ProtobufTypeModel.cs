using System;
using ProtoBuf.Meta;

namespace A {
    public class ProtobufTypeModel {
        private readonly RuntimeTypeModel _typeModel;

        public ProtobufTypeModel(RuntimeTypeModel typeModel) {
            _typeModel = typeModel;
        }

        public string GetSchemaWorking(Type type) => _typeModel.GetSchema(type);
        public string GetSchemaBroken(Type type) => _typeModel.GetSchema(type, ProtoSyntax.Proto2);
    }
}
