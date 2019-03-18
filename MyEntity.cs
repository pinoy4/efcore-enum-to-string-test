using System;

namespace EFCoreEnumToStringTest
{
    public class MyEntity
    {
        public Guid Id { get; set; }
        public MyEnum Status { get; set; }
        public DateTime DueAtDate { get; set; }
    }
}
