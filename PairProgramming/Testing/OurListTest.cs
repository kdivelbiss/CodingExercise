namespace Testing
{
    public class OurListTest
    {
        [Fact]
        public void AddingFiveItemsShouldReturnACountOfFive()
        {
            var list = new OurList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            Assert.Equal(5, list.Count);
        }

        [Fact]
        public void ClearShouldResultInEmptyList()
        {
            var list = new OurList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            list.Clear();

            Assert.Equal(0, list.Count);
        }
    }
}