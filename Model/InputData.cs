namespace WpfClientForm.Model
{
    public class InputData
    {
        public InputData(Culture culture, bool hasGrid)
        {
            Culture = culture;
            HasGrid = hasGrid;
        }

        public bool HasGrid { get; }
        public Culture Culture { get; }
    }
}
