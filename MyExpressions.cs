using System;
using System.Linq.Expressions;
using LinqKit;

namespace EFCoreEnumToStringTest
{
    public static class MyExpressions
    {
        public static Expression<Func<MyEntity, MyEnum>> CalculateStatus(DateTime now)
        {
            return e => e.DueAtDate < now ? MyEnum.Overdue : e.Status;
        }

        public static Expression<Func<MyEntity, bool>> GetOverdue(DateTime now)
        {
            var calculatedStatus = CalculateStatus(now);
            return e => calculatedStatus.Invoke(e) == MyEnum.Overdue;
        }
    }
}
