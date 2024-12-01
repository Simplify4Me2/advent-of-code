namespace advent_of_code_2024_app.Day1
{
    public class ListComparer
    {
        private List<int> _leftList;
        private List<int> _rightList;

        public ListComparer(List<int> leftList, List<int> rightList)
        {
            _leftList = leftList;
            _rightList = rightList;

            _leftList.Sort();
            _rightList.Sort();
        }

        public int CalculateSum()
        {
            int index = 0;
            int length = _leftList.Count;
            int sum = 0;

            for (int i = 0; i < length; i++) 
            { 
                int leftNumber = _leftList[i];
                int rightNumber = _rightList[i];

                sum += Math.Abs(rightNumber - leftNumber);
                index++;
            }

            return sum;
        }
    }
}
