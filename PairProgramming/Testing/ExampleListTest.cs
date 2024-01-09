namespace Testing
{
    public class ExampleListTest
    {
        [Fact]
        public void AddingFiveItemsShouldResultInACountOfFive()
        {
            var exampleList = InitializeList(5);
            Assert.Equal(5, exampleList.Count);
        }

        [Fact]
        public void AddingTwentyItemsShouldResultInACountOfTwenty()
        {
            var exampleList = InitializeList(20);
            Assert.Equal(20, exampleList.Count);
        }

        [Fact]
        public void AddingItemsAndThenClearingShouldResultInACountOfZero()
        {
            var exampleList = InitializeList(5);
            exampleList.Clear();
            Assert.Equal(0, exampleList.Count);
        }

        [Fact]
        public void SettingAValueToFiveAndThenRetrievingItShouldReturnFive()
        {
            var exampleList = InitializeList(5);
            exampleList[1] = 5;
            Assert.Equal(5, exampleList[1]);
        }

        [Fact]
        public void TryingToAccessAnElementAtANegativePositionShouldThrowAnException()
        {
            var exampleList = InitializeList(5);
            Assert.Throws<ArgumentOutOfRangeException>(() => exampleList[-1] = 0);
        }

        [Fact]
        public void ContainsShouldReturnTrueForAnItemThatHasBeenAdded()
        {
            var exampleList = InitializeList(5);
            exampleList[0] = 100;
            Assert.True(exampleList.Contains(100));
        }

        [Fact]
        public void ContainsShouldReturnFalseForAnItemThatHasNotBeenAdded()
        {
            var exampleList = InitializeList(5);
            Assert.False(exampleList.Contains(100));
        }

        [Fact]
        public void IndexOfShouldReturnCorrectLocationForKnownItem()
        {
            var exampleList = InitializeList(5);
            exampleList[2] = 100;
            Assert.Equal(2, exampleList.IndexOf(100));
        }

        [Fact]
        public void IndexOfShouldReturnNegativeOneForUnknownItem()
        {
            var exampleList = InitializeList(5);
            Assert.Equal(-1, exampleList.IndexOf(100));
        }

        [Fact]
        public void InsertedItemShouldExistAtTheCorrectIndex()
        {
            var exampleList = InitializeList(5);
            exampleList.Insert(2, 100);
            Assert.Equal(100, exampleList[2]);
        }

        [Fact]
        public void InsertingAnItemShouldProperlyMoveExistingItems()
        {
            var exampleList = InitializeList(5);
            exampleList[4] = 50;
            exampleList.Insert(2, 100);
            Assert.Equal(50, exampleList[5]);
        }

        private static ExampleList InitializeList(int size)
        {
            var exampleList = new ExampleList();

            for (int i = 0; i < size; i++)
            {
                exampleList.Add(i);
            }

            return exampleList;
        }
    }
}