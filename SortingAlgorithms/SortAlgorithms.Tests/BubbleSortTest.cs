using SortingAlgorithms.Classes;

namespace SortAlgorithms.Tests
{
    public class BubbleSortTest
    {
        [Test]
        public void Sorting_ArrayOfIntegers()
        {
            // ARRANGE
            int[] arrayOfIntegers = new int[] {9,8,7,6,5,4,3,2,1,0};
            var bubbleSort = new BubbleSort();

            // ACT
            bubbleSort.SortIntegers(arrayOfIntegers);

            // ASSERT
            int[] expectedResult = new int[] {0,1,2,3,4,5,6,7,8,9};

            Assert.That(arrayOfIntegers, Is.EqualTo(expectedResult));

        }

    }
}