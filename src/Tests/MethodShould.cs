using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class MethodShould
    {
        [Fact]
        public void ReturnTrueIfStringIsMinimumOneNonWhitespaceCharacterLongElseFalse()
        {
            Assert.True("Valid".HasValue());
            Assert.False((null as string).HasValue());
            Assert.False("".HasValue());
            Assert.False("   ".HasValue());
        }

        [Fact]
        public void ReturnTrueIfStringIsAtLeastAsLongAsSpecified()
        {
            Assert.True("Valid".HasValue(5));
            Assert.False("Valid".HasValue(6));
        }

        [Fact]
        public void ReturnSameObjectInstanceAfterMutation()
        {
            var list = new List<int>();
            Assert.Same(list, list.Mutate(l => l.Add(0)));
        }

        [Fact]
        public void AssignToSpecifiedVariableAndReturnSameInstance()
        {
            List<int> list = null;
            var assignedList = new List<int> {0, 1, 2}.Assign(out list);
            
            Assert.NotNull(list);
            Assert.Same(assignedList, list);
        }
    }
}