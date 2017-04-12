namespace Generics
{
    //7. Constraint, Generic Value must be of Type Product(A specficic class, or Family of classes(Books))
    public class DiscountCalcualtor<TProduct> where TProduct : Product
    {
        public float Calculate(TProduct product)
        {
            return product.Price;
        }
    }


    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}