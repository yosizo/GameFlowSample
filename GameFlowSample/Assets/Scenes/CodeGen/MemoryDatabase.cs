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
   public sealed class MemoryDatabase : MemoryDatabaseBase
   {
        public TestMasterMemoryTable TestMasterMemoryTable { get; private set; }

        public MemoryDatabase(
            TestMasterMemoryTable TestMasterMemoryTable
        )
        {
            this.TestMasterMemoryTable = TestMasterMemoryTable;
        }

        public MemoryDatabase(byte[] databaseBinary, bool internString = true, MessagePack.IFormatterResolver formatterResolver = null)
            : base(databaseBinary, internString, formatterResolver)
        {
        }

        protected override void Init(Dictionary<string, (int offset, int count)> header, System.ReadOnlyMemory<byte> databaseBinary, MessagePack.MessagePackSerializerOptions options)
        {
            this.TestMasterMemoryTable = ExtractTableData<TestMasterMemory, TestMasterMemoryTable>(header, databaseBinary, options, xs => new TestMasterMemoryTable(xs));
        }

        public ImmutableBuilder ToImmutableBuilder()
        {
            return new ImmutableBuilder(this);
        }

        public DatabaseBuilder ToDatabaseBuilder()
        {
            var builder = new DatabaseBuilder();
            builder.Append(this.TestMasterMemoryTable.GetRawDataUnsafe());
            return builder;
        }

        public DatabaseBuilder ToDatabaseBuilder(MessagePack.IFormatterResolver resolver)
        {
            var builder = new DatabaseBuilder(resolver);
            builder.Append(this.TestMasterMemoryTable.GetRawDataUnsafe());
            return builder;
        }

        public ValidateResult Validate()
        {
            var result = new ValidateResult();
            var database = new ValidationDatabase(new object[]
            {
                TestMasterMemoryTable,
            });

            ((ITableUniqueValidate)TestMasterMemoryTable).ValidateUnique(result);
            ValidateTable(TestMasterMemoryTable.All, database, "PersonId", TestMasterMemoryTable.PrimaryKeySelector, result);

            return result;
        }

        static MasterMemory.Meta.MetaDatabase metaTable;

        public static object GetTable(MemoryDatabase db, string tableName)
        {
            switch (tableName)
            {
                case "person":
                    return db.TestMasterMemoryTable;
                
                default:
                    return null;
            }
        }

        public static MasterMemory.Meta.MetaDatabase GetMetaDatabase()
        {
            if (metaTable != null) return metaTable;

            var dict = new Dictionary<string, MasterMemory.Meta.MetaTable>();
            dict.Add("person", Totekoya.Tables.TestMasterMemoryTable.CreateMetaTable());

            metaTable = new MasterMemory.Meta.MetaDatabase(dict);
            return metaTable;
        }
    }
}