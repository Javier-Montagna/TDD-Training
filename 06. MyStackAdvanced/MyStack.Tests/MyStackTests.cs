using System;
using Xunit;
using Stack.Library;

namespace Stack.Tests
{
    public class MyStackTests
    {
        [Fact]
        public void CanPushIntoStack()
        {
            var stack = new MyStack<string>();

            var fooStack = stack.Push("foo");
            Assert.Equal(0, stack.Count);
            Assert.Equal(1, fooStack.Count);
        }

        [Fact]
        public void CanPeekItem()
        {
            //Given
            var stack = new MyStack<string>();
            var fooStack = stack.Push("foo");
            //When

            //Then
            Assert.Equal("foo", fooStack.Peek());
            Assert.Equal("foo", fooStack.Peek());
        }

        [Fact]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            var barStack = stack.Push("foo").Push("bar");

            var fooStack = barStack.Pop();
            var emptyStack = fooStack.Pop();

            Assert.Equal(2, barStack.Count);
            Assert.Equal(1, fooStack.Count);
            Assert.Equal(0, emptyStack.Count);
        }
    }
}
