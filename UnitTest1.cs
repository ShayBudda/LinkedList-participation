using CS295LinkedLists;

namespace CS295LinkedListsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Enqueue_AddingSingleItem_ShouldAddItem()
        {
            //Arrange
            MyQueue queue = new MyQueue();

            //act
            queue.Enqueue(5);

            //Assert
            Assert.IsTrue(queue.Peek() == 5);
        }
        [TestMethod]
        public void Dequeue_ListHasASingleItem_ListShouldbeNull()
        {
            // Arrange
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);

            //Act
            queue.Dequeue();

            //Assert
            Assert.IsTrue(queue.Peek().Equals(null));
        }
    }
}