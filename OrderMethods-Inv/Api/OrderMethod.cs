namespace OrderMethods_Inv.Api
{
    public interface OrderMethod
    {
        void AddElement(int element);

        void RemoveElement(int element);

        void RemoveElementOfPosition(int position);

        void ShuffleElements();

        void Clear();

        void RandomElements(int size);

        void RandomElements()
        {
            this.RandomElements(5);
        }
    }
}
