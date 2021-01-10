using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class MyOrders
        {
            Order<Delivery, StructOrder>[] orders;

            private Order<Delivery, StructOrder> order;
            public MyOrders(Order<Delivery, StructOrder> order )
            {
                orders = new Order<Delivery, StructOrder>[10];
                this.order = order;
            }

            public Order<Delivery, StructOrder> this[int index]
            {
                get
                {
                    return orders[index];
                }
                set
                {
                    orders[index] = value;
                }
            }

        }

        abstract class Delivery
        {
            public string Address;
        }

        abstract class Payment
        {
            public abstract void ToPay();
        }

        class PaymentCard : Payment
        {
            public override void ToPay()
            {
                Console.WriteLine("Card");
            }
        }

        class PaymentCash : Payment
        {
            public override void ToPay()
            {
                Console.WriteLine("Cash");
            }
        }

        class HomeDelivery : Delivery
        {
            /* ... */
        }

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }

        class Order<TDelivery,
        TStruct> where TDelivery : Delivery
            where TStruct : StructOrder
        {
            public TDelivery Delivery;
            public TStruct StructOrder;

            public int Number;

            public string Description;

            public static int countProduct; 

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            public static int CountProduct
            {
                get { return countProduct; }
                set 
                {
                    if(value < 0)
                        Console.WriteLine("Пустой заказ не обслуживается");
                    else
                    {
                        countProduct = value;
                    }
                }
            }
            // ... Другие поля
        }

        class StructOrder
        {
            private int id;

            private Product productDescription;

            public int ID 
            {
                get
                {
                    return id;
                }
                private set
                {
                    id = value;
                }
            }
            public Product Description 
            {
                get
                {
                    return productDescription;
                }
                set
                {
                    productDescription = value;
                }
            }
        }

        class Product
        {
            private int price;

            private string descprition;

            public Product()
            {

            }

            public Product(int priceProduct, string descpritionProduct)
            {
                price = priceProduct;
                descprition = descpritionProduct;
            }
        }

        class CategoryProduct
        {
            private Product product;

            public CategoryProduct()
            {
                product = new Product();
            }
        }
    }
}

