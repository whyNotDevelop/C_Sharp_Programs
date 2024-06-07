using System.ComponentModel;

namespace Online_Shopping_System
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product[] products = new Product[3];
            //(int numOfItems, string Name, double Price, int Product_id)
            //populateProducts(products);
            //Console.WriteLine("\nInvetory count " + products[0].GetIventoryCount());
            // Console.WriteLine("Inventory count "+products[2].GetIventoryCount());
            //displayProduct(products);
            /*
             *  public Customer(string Name, string Phone, string Address)
            {
                customer_id = count + 1; 
                customerName = Name; 
                customerPhone = Phone; 
                customerAddress = Address;
                count++;
            }*/

            displayCustomersInfo();


        }
        public static void displayCustomersInfo()
        {
            Customer[] customers = populateCustomers();
            Console.WriteLine("customer_id\tcustomer_name\t\tcustomer_phone\tcustomer_address");
            
            for(int i = 0; i<customers.Length; i++)
            {
                Console.WriteLine(customers[i].GetCustomer_id()+"\t\t"+ customers[i].GetCustomerName()+"\t\t"+ customers[i].GetCustomerPhone()+"\t"+ customers[i].GetCustomerAddress());
            }
        }
        public static Customer[] populateCustomers()
        {
            string name;
            string phone;
            string address;

            Console.WriteLine("_________Customers' Info_________\n");
            Customer[] customers = new Customer[4];
            for(int i = 0; i< customers.Length; i++)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                phone = Console.ReadLine();
                Console.Write("Enter Physical Address: ");
                address = Console.ReadLine();
                customers[i] = new(name, phone, address);
                Console.WriteLine();

            }
            return customers;

        }
        public static void populateProducts(Product[] products)
        {
            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine("__________Book___________\n");
                Console.Write("Enter the name of the book: ");
                var bookName = Console.ReadLine();
                Console.Write("Enter it price: ");
                double bookPrice = double.Parse(Console.ReadLine());
                Console.Write("How many do you have: ");
                var bookQty = int.Parse(Console.ReadLine());
                Console.Write("Enter it id: ");
                var book_id = int.Parse(Console.ReadLine());
                products[i] = new Book(bookQty, bookName, bookPrice, book_id);
                Console.WriteLine("\nInvetory count " + products[0].GetIventoryCount());
                i++;

                Console.WriteLine("\n__________Clothing__________\n");
                Console.Write("Enter the type of clothing: ");
                var clothingName = Console.ReadLine();
                Console.Write("Enter it price: ");
                double clothingPrice = double.Parse(Console.ReadLine());
                Console.Write("How many do you have: ");
                var clothingQty = int.Parse(Console.ReadLine());
                Console.Write("Enter it id: ");
                var clothing_id = int.Parse(Console.ReadLine());
                products[i] = new Clothing(clothingQty, clothingName, clothingPrice, clothing_id);
                i++;

                Console.WriteLine("\n__________Electronics__________\n");
                Console.Write("Enter the type of eletronic: ");
                var electronicName = Console.ReadLine();
                Console.Write("Enter it price: ");
                double electronicPrice = double.Parse(Console.ReadLine());
                Console.Write("How many do you have: ");
                var electronicQty = int.Parse(Console.ReadLine());
                Console.Write("Enter it id: ");
                var electronic_id = int.Parse(Console.ReadLine());
                products[i] = new Electronics(electronicQty, electronicName, electronicPrice, electronic_id);
                i++;

            }
        }

        public static double calculateCost(Product[] selectedItems)
        {
            double totalPrice=0;
            int len = selectedItems.Length;

            for (int i=0; i<len; i++)
            {
                totalPrice += selectedItems[i].GetPrice();
            }
            return totalPrice;  

        }
        public static void displayProduct(Product[] items)
        {
            int len = items.Length;
            Console.WriteLine("\nSelect Product:");
            for (int i=0; i<len; i++)
            {
                Console.WriteLine("Item name: "+items[i].GetName());
                Console.WriteLine("Price R"+items[i].GetPrice());
                Console.WriteLine("____________________________________________________");


            }

        }
    }
    /*
     * Exercise 2: Online Shopping System Create a class hierarchy for
     * an online shopping system. Define a base class Product 
     with properties like Name, Price, and methods for managing inventory. 
     Create derived classes for different types of products, such as Book, Electronics, 
     and Clothing. Implement specific behavior for each product type, such as
     calculating shipping costs or handling returns.*/
    abstract class Product
    {
        protected string Name;
        protected double Price;
        protected int Product_id;
        protected int quantity;
        protected static int inventoryCount = 0;

        public abstract void manageInventory();

        public string GetName()
        {
            return Name;
        }

        
        public int GetIventoryCount()
        {
            return inventoryCount;
        }
        public double GetPrice()
        {
            return Price;
        }

    }
    interface IOder
    {
        public int orderQuantity {  get; set; }
        double shippingCost();
        void purchase();
        void rejects();
    }
    class Book : Product,IOder
    {
        /*
          * Exercise 2: Online Shopping System Create a class hierarchy for
          * an online shopping system.Define a base class Product
          with properties like Name, Price, and methods for managing inventory.
          Create derived classes for different types of products, such as Book, Electronics,
          and Clothing. Implement specific behavior for each product type, such as
          calculating shipping costs or handling returns.*/

        public int orderQuantity { get; set; }


        public Book(int quantity, string Name, double Price, int Product_id) 
        {
            this.quantity = quantity;
            this.Name = Name;
            this.Price = Price;
            this.Product_id = Product_id;
            inventoryCount += quantity;
        }
       
        public override void manageInventory()
        {

        }
        public double shippingCost()
        {
            return 2343.3;
        }
        public void rejects()
        {

        }

        public void purchase()
        {

        }

    }
    class Clothing : Product, IOder
    {
        public int orderQuantity { get; set; }

        public Clothing(int numOfItems, string Name, double Price, int Product_id)
        {
            this.quantity = numOfItems;
            this.Name = Name;
            this.Price = Price;
            this.Product_id = Product_id;
            inventoryCount += quantity;
        }
       
        public override void manageInventory()
        {

        }
        public double shippingCost()
        {
            return 2343.3;
        }
        public void rejects()
        {

        }

        public void purchase()
        {

        }

    }

    class Electronics : Product,IOder
    {
        public int orderQuantity { get; set; }

        public Electronics(int quantity, string Name, double Price, int Product_id)
        {
            this.quantity = quantity;
            this.Name = Name;
            this.Price = Price;
            this.Product_id = Product_id;
            inventoryCount += quantity;
        }
       

        public override void manageInventory()
        {

        }
        public double shippingCost()
        {
            return 2343.3;
        }
        public void rejects()
        {

        }
        public void purchase()
        {

        }

    }
    public class Customer
    {
        private static int count= 1000;
        private int customer_id;
        private string customerName;
        private string customerPhone;
        private string customerAddress;

        public Customer(string Name, string Phone, string Address)
        {
            customer_id = count + 1; 
            customerName = Name; 
            customerPhone = Phone; 
            customerAddress = Address;
            count++;
        }
        public int GetCustomer_id()
        {
            return customer_id;
        }
        public void SetCustomerName(string name)
        {
            customerName = name;
        }
        public string GetCustomerName() 
        {
            return customerName;
        }
        public string GetCustomerPhone()
        {
            return customerPhone;
        }
        public void SetCustomerPhone(string phone)
        {
            customerPhone = phone;
        }
        public void SetAddress(string address)
        {
            customerAddress = address;
        }
        public void SetCustomerAddress(string address)
        {
            customerAddress = address;
        }
        public string GetCustomerAddress()
        {
            return customerAddress;
        }
        public void placeOrder()
        {

        }


    }


}