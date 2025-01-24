namespace WebApplication1
{
    public class Average
    {
        private List<double> values;

        public Average()
        {
            values = [];
        }

        public void AddValue(double value)
        {
            values.Add(value);
        }

        public double GetAverage()
        {
            if (values.Count == 0)
            {
                return 0;
            }
            return values.Sum() / values.Count;
        }

        public List<double> GetValues()
        {
            return new List<double>(values);
        }
    }
}
