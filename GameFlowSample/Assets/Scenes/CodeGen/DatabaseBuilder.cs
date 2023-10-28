// <auto-generated />
#pragma warning disable CS0105
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Collections.Generic;
using System;
using Totekoya.Tables;

namespace Totekoya
{
   public sealed class DatabaseBuilder : DatabaseBuilderBase
   {
        public DatabaseBuilder() : this(null) { }
        public DatabaseBuilder(MessagePack.IFormatterResolver resolver) : base(resolver) { }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<TestMasterMemory> dataSource)
        {
            AppendCore(dataSource, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

    }
}