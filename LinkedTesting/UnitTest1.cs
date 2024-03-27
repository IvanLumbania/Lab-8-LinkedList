using Lab_8_LinkedList;


namespace LinkedTesting
{
    [TestFixture]
    public class Tests
    {
        private LinkedList list = new LinkedList();

        //Populate List
        [SetUp]
        public void Setup()
        {
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            list.AddLast("Jane Doe");
            list.AddLast("Bob Bobberson");
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");


        }
        //reset after each test is completed
        [TearDown]
        public void TearDown()
        {
            // Resetting the list by clearing its head and count

            list.Head = null;
            list.Count = 0;
        }

        //Testing the AddFirst method 
        [Test]
        public void AddingNodesToBeginning()
        {
            // Add a node to the beginning of the list
            list.AddFirst("Test First");

            // Assertion to check if the value was added at the beginning
            Assert.AreEqual("Test First", list.GetValue(0));

            // Checks how many items are in the list
            Assert.AreEqual(8, list.Count);

        }

        //Adding to the last of the list
        [Test]
        public void AddingNodesToEnd()
        {
            //Adding node to the end
            list.AddLast("Test Last");

            //Test if Value matches accordingly
            Assert.AreEqual("Test Last", list.GetValue(7));

            Assert.AreEqual(8, list.Count);


        }
        //Testing removeFirst method
        [Test]
        public void RemovingFirstNode()
        {
            //remove first element
            list.RemoveFirst();
            //Check if the 2nd node is now the first
            Assert.AreEqual("Joe Schmoe",list.GetValue(0));
            //Check list count, should be reduced by 1
            Assert.AreEqual(6, list.Count);

        }
        //Testing removing Last node
        [Test]
        public void RemovingLastNode()
        {
            // Remove the last node from the list

            list.RemoveLast();

            //Checks if last node was removed
            Assert.AreEqual("Sam Sammerson", list.GetValue(5));

            //Checks if list count is correct amoutn
            Assert.AreEqual(6, list.Count);

        }

        //Test value at certain index
        [Test]
        public void ValueAtCertainIndex()
        {
            //Value of index 0
            list.GetValue(0);
            Assert.AreEqual("Joe Blow", list.GetValue(0));

            //Checks for value at 6
            list.GetValue(6);
            Assert.AreEqual("Dave Daverson", list.GetValue(6));

            //Checks value at index 3
            list.GetValue(3);
            Assert.AreEqual("Jane Doe", list.GetValue(3));
        }
        //Checks for the size of the list
        [Test]
        public void DetermineSizeOfLize()
        {
            //counts list
            Assert.AreEqual(7, list.Count);
        }

    }
}