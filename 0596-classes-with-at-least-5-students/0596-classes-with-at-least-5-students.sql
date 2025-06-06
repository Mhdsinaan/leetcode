/* Write your T-SQL query statement below */

select class from Courses group By class having count(student) >=5;