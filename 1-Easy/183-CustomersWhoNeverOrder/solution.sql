-- LeetCode Problem 183: Customers Who Never Order
-- Difficulty: Easy
-- Date: 2025-08-12
-- Source: https://leetcode.com/problems/customers-who-never-order/
-- 
-- Description:
-- Write a solution to find all customers who never order anything.
-- Return the result table in any order.

--Example:
--
/*
Input: 
Customers table:
+----+-------+
| id | name  |
+----+-------+
| 1  | Joe   |
| 2  | Henry |
| 3  | Sam   |
| 4  | Max   |
+----+-------+
Orders table:
+----+------------+
| id | customerId |
+----+------------+
| 1  | 3          |
| 2  | 1          |
+----+------------+
Output: 
+-----------+
| Customers |
+-----------+
| Henry     |
| Max       |
+-----------+
*/

SELECT c.name AS Customers
FROM Customers AS c
WHERE c.id NOT IN (SELECT customerid FROM Orders);
