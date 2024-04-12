
using LabTask_24;

Product product1 = new("Corek", 15, 10, 5);
Product product2 = new("Adicto", 32, 2, 8);
Product product3 = new("Pomoidor",5, 5, 10);
Product product4 = new("Coca-Cola", 50, 1, 3);
Product product5 = new("Yumurta", 0.5, 0,1);

Product[] basketProducts = { product2, product4, product5 };

Product[] products = {product1, product2, product3, product4, product5};


Market market = new(products);

Customer customer = new("Pasha", "Allahverdiyev", 50, 100);


market.Shopping(customer.InBasket(basketProducts),customer);





