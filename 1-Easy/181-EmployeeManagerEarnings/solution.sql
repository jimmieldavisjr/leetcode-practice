-- LeetCode Problem 181: Employees Earning More Than Their Managers
-- Difficulty: Easy
-- Date: 2025-07-18
-- Source: https://leetcode.com/problems/employees-earning-more-than-their-managers/
-- 
-- Description:
-- Write a solution to find the employees who earn more than their managers.
-- Return the result table in any order.

--Example:
--
/*
Input: 
Employee table:
+----+-------+--------+-----------+
| id | name  | salary | managerId |
+----+-------+--------+-----------+
| 1  | Joe   | 70000  | 3         |
| 2  | Henry | 80000  | 4         |
| 3  | Sam   | 60000  | Null      |
| 4  | Max   | 90000  | Null      |
+----+-------+--------+-----------+
Output: 
+----------+
| Employee |
+----------+
| Joe      |
+----------+
*/

SELECT e.name AS Employee
FROM Employee e
JOIN Employee m ON e.managerId = m.id
WHERE e.salary > m.salary;