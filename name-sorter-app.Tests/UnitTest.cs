using name_sorter_app;

namespace NameSortingApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SortNames_SortsCorrectly()
        {
            List<string> unsortedNames = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder"
            };

            List<string> expectedSortedNames = new List<string>
            {
                "Adonis Julius Archer",
                "Vaughn Lewis",
                "Janet Parsons",
                "Shelby Nathan Yoder"
            };

            List<string> sortedNames = NameSorter.SortNames(unsortedNames);

            Assert.That(sortedNames, Is.EqualTo(expectedSortedNames));
            Console.WriteLine("Unit test passed: SortNames_SortsCorrectly");
        }
    }
}
