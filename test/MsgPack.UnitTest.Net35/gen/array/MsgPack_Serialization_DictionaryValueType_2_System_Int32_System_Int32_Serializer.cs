﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_DictionaryValueType_2_System_Int32_System_Int32_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<MsgPack.Serialization.DictionaryValueType<int, int>, System.Collections.Generic.KeyValuePair<int, int>> {
        
        public MsgPack_Serialization_DictionaryValueType_2_System_Int32_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_DictionaryValueType_2_System_Int32_System_Int32_Serializer.RestoreSchema()) {
        }
        
        protected override MsgPack.Serialization.DictionaryValueType<int, int> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.DictionaryValueType<int, int> collection = default(MsgPack.Serialization.DictionaryValueType<int, int>);
            collection = new MsgPack.Serialization.DictionaryValueType<int, int>(initialCapacity);
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
