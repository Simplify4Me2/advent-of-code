namespace advent_of_code_2024_app.Day1
{
    public class ListSimilarizer
    {
        private List<int> _leftList;
        private List<int> _rightList;

        public ListSimilarizer(List<int> leftList, List<int> rightList)
        {
            _leftList = leftList;
            _rightList = rightList;
        }

        public int CalculateSum()
        {
            int index = 0;
            int length = _leftList.Count;
            int sum = 0;

            for (int i = 0; i < length; i++) 
            { 
                int leftNumber = _leftList[i];

                List<int> similarOccurences = _rightList.FindAll(x => x == leftNumber);

                sum += leftNumber * similarOccurences.Count;
                index++;
            }

            return sum;
        }
    }
}
