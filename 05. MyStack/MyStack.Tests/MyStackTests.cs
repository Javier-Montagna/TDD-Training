using System;
using Xunit;
using Stack.Library;

namespace Stack.Tests
{
    public class MyStackTests
    {
        [Fact]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void CanPopOffMultipleItems()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.Equal("bar", stack.Pop());
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void ShouldNotAllowPushNullValue()
        {
            var stack = new MyStack(100);
            Assert.Throws<Exception> (() => stack.Push(null));
        }

        [Fact]
        public void ShouldAllowPullFromEmptyStack()
        {
            var stack = new MyStack(100);
            Assert.Equal(null, stack.Pop());
        }
    }
}
