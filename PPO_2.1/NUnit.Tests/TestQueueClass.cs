using NUnit.Framework;
using PPO_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestQueueClass
    {
        [Test]
        public void TestEnqueue1()
        {
            MyQueue queue = new MyQueue();
            List<int> tstvalues = new List<int>();
            bool bool_value = true;

            tstvalues.Add(1);
            tstvalues.Add(2);
            tstvalues.Add(3);
            tstvalues.Add(4);
            tstvalues.Add(5);
            tstvalues.Add(6);
            tstvalues.Add(7);

            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);
            queue.enqueue(6);
            queue.enqueue(7);

            List<int> received_values = queue.GetList();

            if (received_values.Count != tstvalues.Count)
                bool_value = false;

            for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                if (received_values[i] != tstvalues[i])
                    bool_value = false;

            Assert.IsTrue(bool_value);
        }

        [Test]
        public void Test_Dequeue_Empty()
        {
            MyQueue queue = new MyQueue();

            Assert.False(queue.dequeue());
        }

        [Test]
        public void Test_Min_Empty()
        {
            MyQueue queue = new MyQueue();
            int value = 0;

            Assert.False(queue.minimum(out value));
        }

        public void Test_Max_Empty()
        {
            MyQueue queue = new MyQueue();
            int value = 0;

            Assert.False(queue.maximum(out value));
        }

        [Test]
        public void TestDequeue1()
        {
            MyQueue queue = new MyQueue();
            List<int> tstvalues = new List<int>();
            bool bool_value = true;

            tstvalues.Add(-30);
            tstvalues.Add(40);
            tstvalues.Add(-50);
            tstvalues.Add(60);

            queue.enqueue(-10);
            queue.enqueue(20);
            queue.enqueue(-30);
            queue.enqueue(40);
            queue.enqueue(-50);
            queue.enqueue(60);

            bool_value = queue.dequeue() && queue.dequeue();

            List<int> received_values = queue.GetList();

            if (received_values.Count != tstvalues.Count)
                bool_value = false;

            for (int i = 0; (bool_value == true) && (i < received_values.Count); i++)
                if (received_values[i] != tstvalues[i])
                    bool_value = false;

            Assert.IsTrue(bool_value);
        }

        [Test]
        public void TestDequeue2()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;

            queue.enqueue(-10);
            queue.enqueue(20);

            bool_value = queue.dequeue() && queue.dequeue();

            List<int> received_values = queue.GetList();

            Assert.IsTrue(bool_value && received_values.Count == 0);
        }


        [Test]
        public void TestDequeue3()
        {
            MyQueue queue = new MyQueue();
            List<int> tstvalues = new List<int>();
            bool bool_value = true;

            queue.enqueue(1);
            bool_value = queue.dequeue() && queue.dequeue();

            List<int> received_values = queue.GetList();

            if (received_values.Count != tstvalues.Count)
                bool_value = false;

            Assert.IsTrue(!bool_value && received_values.Count == 0);
        }

        [Test]
        public void Test_GetList_Empty()
        {
            MyQueue queue = new MyQueue();
            List<int> received_values = queue.GetList();

            Assert.IsTrue(received_values.Count == 0);
        }

        [Test]
        public void Test_Max1()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int max = 0;

            queue.enqueue(-2);
            queue.enqueue(-1);
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(2);

            bool_value = queue.maximum(out max);

            Assert.IsTrue(bool_value && max == 2);
        }

        [Test]
        public void Test_Max2()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int max = 0;

            queue.enqueue(2);
            queue.enqueue(-1);
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(-2);

            bool_value = queue.maximum(out max);

            Assert.IsTrue(bool_value && max == 2);
        }

        [Test]
        public void Test_Max3()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int max = 0;

            queue.enqueue(3);
            queue.enqueue(-21);
            queue.enqueue(9);
            queue.enqueue(13);
            queue.enqueue(-2);

            bool_value = queue.maximum(out max);

            Assert.IsTrue(bool_value && max == 13);
        }

        [Test]
        public void Test_Max4()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int max = 0;

            queue.enqueue(13);
            queue.enqueue(3);
            queue.enqueue(-21);
            queue.enqueue(9);
            queue.enqueue(-2);
            queue.dequeue();

            bool_value = queue.maximum(out max);

            Assert.IsTrue(bool_value && max == 9);
        }

        [Test]
        public void Test_Min1()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int min = 0;

            queue.enqueue(2);
            queue.enqueue(-1);
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(-2);

            bool_value = queue.minimum(out min);

            Assert.IsTrue(bool_value && min == -2);
        }

        [Test]
        public void Test_Min2()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int min = 0;

            queue.enqueue(-2);
            queue.enqueue(-1);
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(2);

            bool_value = queue.minimum(out min);

            Assert.IsTrue(bool_value && min == -2);
        }

        [Test]
        public void Test_Min3()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int min = 0;

            queue.enqueue(3);
            queue.enqueue(13);
            queue.enqueue(9);
            queue.enqueue(-21);
            queue.enqueue(-2);

            bool_value = queue.minimum(out min);

            Assert.IsTrue(bool_value && min == -21);
        }

        [Test]
        public void Test_Min4()
        {
            MyQueue queue = new MyQueue();
            bool bool_value = true;
            int min = 0;

            queue.enqueue(-21);
            queue.enqueue(3);
            queue.enqueue(13);
            queue.enqueue(9);
            queue.enqueue(-2);

            queue.dequeue();

            bool_value = queue.minimum(out min);

            Assert.IsTrue(bool_value && min == -2);
        }

    }
}
