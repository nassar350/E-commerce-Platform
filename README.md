<p align="center">
    <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=30&pause=1000&width=435&lines=E-commerce+Platform" alt="head" />
</p>

## Project Description
E-commerce Platform: Handle product listings, customer accounts, orders, payments, and shipping details.

<br />

## Table of Contents

* [ER Diagram](./ER-Diagram%20and%20Mapping/E-Commerce%20ER-Diagram.png)
* [Rational Schema](./ER-Diagram%20and%20Mapping/E-commerce%20mapping.jpg)
* [Physical Schema](./ER-Diagram%20and%20Mapping/E-Commerce%20Schema.png)
* [Database Data Insertion](#DATA-Insertion-Into-Database)
* [Project Screens](#project-screens)

<br />

## ER Diagram
![ERD](./ER-Diagram%20and%20Mapping/E-Commerce%20ER-Diagram.png)


## Schema
![Schema](./ER-Diagram%20and%20Mapping/E-Commerce%20Schema.png)
```sql
-- Customer table
create table Customer (
Customer_id int primary key,
Name tinytext not null,
Email tinytext not null,
Password tinytext not null,
Gender varchar(7) check (Gender in ('Male','Female')),
Birth_date date,
Address text
);

-- product table
create table Product (
Product_id int primary key,
Name tinytext not null,
Price int not null,
Description longtext
);

-- orders table
create table orders (
Order_id int primary key,
Customer_id int,
Order_price int not null,
Products_quantity int not null,
foreign key (Customer_id) references customer(Customer_id)
);

-- shipping detail table
create table shipping_detail (
Order_id int,
Address text not null,
Phone_Number varchar(30) not null,
Current_Status tinytext check (Current_Status in ('Confirmed','Shipping','Shipped')),
foreign key (order_id) references orders(order_id)
);

-- payment table
create table Payment (
Order_id int,
Customer_id int,
Amount int not null,
Current_Status tinytext check (Current_Status in ('Pending','Paid')),
primary key (order_id),
foreign key (order_id) references orders(Order_id),
foreign key (Customer_id) references customer(Customer_id)
);

-- order_list table
create table order_list (
Order_id int,
Product_id int,
Product_quantity int not null,
primary key (Order_id, Product_id),
foreign key (order_id) references orders(Order_id),
foreign key (Product_id) references Product(Product_id)
);
```

## DATA Insertion Into Database
```sql
-- data insertion
-- Insert dummy data into Customer table
INSERT INTO Customer (Customer_id, Name, Email, Password, Gender, Birth_date, Address) VALUES
(1, 'John Doe', 'john.doe@example.com', 'password123', 'Male', '1985-06-15', '123 Main St, Springfield'),
(2, 'Jane Smith', 'jane.smith@example.com', 'securepass456', 'Female', '1990-08-23', '456 Elm St, Metropolis'),
(3, 'Sam Green', 'sam.green@example.com', 'mypassword789', 'Male', '1982-02-01', '789 Oak St, Gotham'),
(4, 'Anna Black', 'anna.black@example.com', '1234abcd', 'Female', '1995-11-30', '101 Pine St, Star City');

-- Insert dummy data into Product table
INSERT INTO Product (Product_id, Name, Price, Description) VALUES
(1, 'Laptop', 1000, 'High-performance laptop with 16GB RAM and 512GB SSD'),
(2, 'Smartphone', 500, 'Latest smartphone with 6-inch display and 128GB storage'),
(3, 'Tablet', 300, '10-inch tablet with stylus support'),
(4, 'Headphones', 150, 'Noise-cancelling over-ear headphones'),
(5, 'Keyboard', 100, 'Mechanical keyboard with RGB lighting');

-- Insert dummy data into Orders table
INSERT INTO orders (Order_id, Order_price, Products_quantity, Customer_id) VALUES
(1, 1500, 3, 1),
(2, 500, 1, 2),
(3, 600, 2, 3),
(4, 2500, 5, 4);

-- Insert dummy data into Shipping Detail table
INSERT INTO shipping_detail (Order_id, Address, Phone_Number, Current_Status) VALUES
(1, '123 Main St, Springfield', '555-0101', 'Confirmed'),
(2, '456 Elm St, Metropolis', '555-0102', 'Shipping'),
(3, '789 Oak St, Gotham', '555-0103', 'Shipped'),
(4, '101 Pine St, Star City', '555-0104', 'Confirmed');

-- Insert dummy data into Payment table
INSERT INTO Payment (Order_id, Customer_id, Amount, Current_Status) VALUES
(1, 1, 1500, 'Paid'),
(2, 2, 500, 'Pending'),
(3, 3, 600, 'Paid'),
(4, 4, 2500, 'Pending');

-- Insert dummy data into Order List table
INSERT INTO order_list (Order_id, Product_id, Product_quantity) VALUES
(1, 1, 1),
(1, 2, 1),
(1, 4, 1),
(2, 3, 1),
(3, 5, 2),
(3, 2, 1),
(4, 1, 2),
(4, 3, 2),
(4, 5, 1);
```

<br />

## Project Screens
Here are some screenshots of the project:

*Base Application Page*
![Screenshot 1](./GUI%20Pictures/Base%20App%20Page.png)

*Add A Customer Page*
![Screenshot 2](./GUI%20Pictures/Add%20a%20Customer%20Page.png)

*Modify A Customer Info Page*
![Screenshot 3](./GUI%20Pictures/Modify%20Customer%20Info%20Page.png)

*View All Customers Page*
![Screenshot 3](./GUI%20Pictures/View%20all%20Customers%20Page.png)
