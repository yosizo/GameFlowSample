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
   public sealed class ImmutableBuilder : ImmutableBuilderBase
   {
        MemoryDatabase memory;

        public ImmutableBuilder(MemoryDatabase memory)
        {
            this.memory = memory;
        }

        public MemoryDatabase Build()
        {
            return memory;
        }

        public void ReplaceAll(System.Collections.Generic.IList<TestMasterMemory> data)
        {
            var newData = CloneAndSortBy(data, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            var table = new TestMasterMemoryTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

        public void RemoveTestMasterMemory(int[] keys)
        {
            var data = RemoveCore(memory.TestMasterMemoryTable.GetRawDataUnsafe(), keys, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            var newData = CloneAndSortBy(data, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            var table = new TestMasterMemoryTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

        public void Diff(TestMasterMemory[] addOrReplaceData)
        {
            var data = DiffCore(memory.TestMasterMemoryTable.GetRawDataUnsafe(), addOrReplaceData, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            var newData = CloneAndSortBy(data, x => x.PersonId, System.Collections.Generic.Comparer<int>.Default);
            var table = new TestMasterMemoryTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

    }
}