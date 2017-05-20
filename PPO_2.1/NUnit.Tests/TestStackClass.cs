using NUnit.Framework;
using PPO_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    class TestStackClass
    {
        [TestFixture]
        public class TestQueueClass
        {
            [Test]
            public void TestPush1()
            {
                MyStack stack = new MyStack();
                List<Params> tstvalues = new List<Params>();
                bool bool_value = true;

                tstvalues.Add(new Params(1, 1, 1));
                tstvalues.Add(new Params(2, 2, 1));
                tstvalues.Add(new Params(3, 3, 1));
                tstvalues.Add(new Params(4, 4, 1));
                tstvalues.Add(new Params(5, 5, 1));

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);

                List<Params> received_values = stack.GetStack;

                if (received_values.Count != tstvalues.Count)
                    bool_value = false;

                for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                    if (received_values[i] != tstvalues[i])
                        bool_value = false;

                Assert.IsTrue(bool_value);
            }

            [Test]
            public void TestPush2()
            {
                MyStack stack = new MyStack();
                List<Params> tstvalues = new List<Params>();
                bool bool_value = true;

                tstvalues.Add(new Params(0, 0, 0));
                tstvalues.Add(new Params(5, 5, 0));
                tstvalues.Add(new Params(-1, 5, -1));
                tstvalues.Add(new Params(2, 5, -1));
                tstvalues.Add(new Params(6, 6, -1));
                tstvalues.Add(new Params(1, 6, -1));
                tstvalues.Add(new Params(6, 6, -1));
                tstvalues.Add(new Params(-5, 6, -5));

                stack.Push(0);
                stack.Push(5);
                stack.Push(-1);
                stack.Push(2);
                stack.Push(6);
                stack.Push(1);
                stack.Push(6);
                stack.Push(-5);

                List<Params> received_values = stack.GetStack;

                if (received_values.Count != tstvalues.Count)
                    bool_value = false;

                for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                    if (received_values[i] != tstvalues[i])
                        bool_value = false;

                Assert.IsTrue(bool_value);
            }

            [Test]
            public void TestPop1()
            {
                MyStack stack = new MyStack();
                Params value = new Params(); ;

                stack.Push(1);
                stack.Pop(out value);
                stack.Pop(out value);

                List<Params> received_values = stack.GetStack;

                Assert.IsTrue(received_values.Count == 0);
            }

            [Test]
            public void TestPop2()
            {
                MyStack stack = new MyStack();
                List<Params> tstvalues = new List<Params>();
                bool bool_value = true;
                Params value = new Params();

                tstvalues.Add(new Params(1, 1, 1));
                tstvalues.Add(new Params(2, 2, 1));
                tstvalues.Add(new Params(3, 3, 1));
                tstvalues.Add(new Params(4, 4, 1));

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Pop(out value);

                List<Params> received_values = stack.GetStack;

                if (received_values.Count != tstvalues.Count)
                    bool_value = false;

                for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                    if (received_values[i] != tstvalues[i])
                        bool_value = false;

                Assert.IsTrue(bool_value && value == new Params(5, 5, 1));
            }

            [Test]
            public void TestPop3()
            {
                MyStack stack = new MyStack();
                List<Params> tstvalues = new List<Params>();
                bool bool_value = true;
                Params value = new Params();

                tstvalues.Add(new Params(1, 1, 1));
                tstvalues.Add(new Params(4, 4, 1));
                tstvalues.Add(new Params(5, 5, 1));

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Pop(out value);
                stack.Pop(out value);
                stack.Push(4);
                stack.Push(5);

                List<Params> received_values = stack.GetStack;

                if (received_values.Count != tstvalues.Count)
                    bool_value = false;

                for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                    if (received_values[i] != tstvalues[i])
                        bool_value = false;

                Assert.IsTrue(bool_value && value == new Params(2, 2, 1));
            }

            [Test]
            public void Test_Pop_Empty()
            {
                MyStack stack = new MyStack();
                Params value = new Params();

                Assert.False(stack.Pop(out value));
            }

            [Test]
            public void Test_Peek_Empty()
            {
                MyStack stack = new MyStack();
                Params value = new Params();

                Assert.False(stack.Peek(out value));
            }

            [Test]
            public void Test_GetStack_Empty()
            {
                MyStack stack = new MyStack();
                List<Params> received_values = stack.GetStack;

                Assert.IsTrue(received_values.Count == 0);
            }

            [Test]
            public void Test_Peek1()
            {
                MyStack stack = new MyStack();
                Params tstvalue = new Params(3, 3, 1);
                Params received_value = new Params();


                stack.Push(2);
                stack.Push(1);
                stack.Push(3);

                bool bool_value = stack.Peek(out received_value);

                Assert.IsTrue(bool_value && received_value == tstvalue);
            }

            [Test]
            public void Test_Peek2()
            {
                MyStack stack = new MyStack();
                Params tstvalue = new Params(1, 2, 1);
                Params received_value = new Params();
                Params value = new Params();

                stack.Push(2);
                stack.Push(1);
                stack.Push(3);
                stack.Pop(out value);

                bool bool_value = stack.Peek(out received_value);

                Assert.IsTrue(bool_value && received_value == tstvalue);
            }

            [Test]
            public void Test_Peek3()
            {
                MyStack stack = new MyStack();
                Params received_value = new Params();
                Params value = new Params();

                stack.Push(2);
                stack.Pop(out value);      

                Assert.IsFalse(stack.Peek(out received_value));
            }

        }
    }
}
