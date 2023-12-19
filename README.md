CREATE USER 'username'@'%' IDENTIFIED BY 'password'
GRANT ALL PRIVILEGES ON *.* TO 'username'@'%' WITH GRANT OPTION
FLUSH PRIVILEGES;

https://www.youtube.com/watch?v=XqADA64-d1c&t=232s
start at 1:50 

USE  petpal;

CREATE TABLE admin_credentials (
	admin_user_number INT PRIMARY KEY,
    admin_username VARCHAR(255) NOT NULL,
    admin_password VARCHAR(255) NOT NULL
);

INSERT INTO admin_credentials (admin_user_number, admin_username, admin_password) VALUES (
	0,
	'admin',
    'LazuvE4xZU0yaueImzl+1Q/35a//N00fiVJYZf2H7+A='
);

select * From admin_credentials;

CREATE TABLE user_credentials (
user_number INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
user_name VARCHAR(25) NOT NULL,
salted_hash VARCHAR(255) NOT NULL,
security_question VARCHAR(255) NOT NULL,
answer VARCHAR(255) NOT NULL
);

CREATE TABLE user_info (
id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
fName VARCHAR(255) NOT NULL,
lName VARCHAR(255) NOT NULL,
contact VARCHAR(255) NOT NULL,
home_address VARCHAR(255) NOT NULL,	
city VARCHAR(255) NOT NULL,	
province VARCHAR(255) NOT NULL,	
profileImage BLOB,
user_number INT,
FOREIGN KEY(user_number) REFERENCES user_credentials(user_number)
);

SELECT * FROM user_info;
SELECT * FROM user_credentials;
SELECT * FROM pet_info;

UPDATE clients_credentials SET salted_hash = "123" WHERE user_name = "frieren";

CREATE TABLE pet_info (
pet_id INT NOT NULL,
pet_name VARCHAR(255) NOT NULL,
owner_name VARCHAR(255) NOT NULL,
species VARCHAR(255) NOT NULL,
gender VARCHAR(255) NOT NULL,
breed VARCHAR(255) NOT NULL,
bio VARCHAR(255) NOT NULL,
birthday DATE NOT NULL,
current_food VARCHAR(255) NOT NULL,
current_med VARCHAR(255) NOT NULL,
current_med_take DATETIME,
weight VARCHAR(255) NOT NULL,
profileImage longBLOB,
user_number INT,
FOREIGN KEY(user_number) REFERENCES user_credentials(user_number)
);

drop TABLE pet_info;

SELECT * FROM pet_info;

SELECT host FROM mysql.user WHERE User = 'root';
CREATE USER 'sakayanagi'@'192.168.100.33' IDENTIFIED BY 'pass';
GRANT ALL PRIVILEGES ON *.* TO 'root'@'localhost' WITH GRANT OPTION;
FLUSH PRIVILEGES;

CREATE TABLE sample (
	date_only DATE,
    date_tim DATETIME
);

INSERT into sample (date_only, date_tim) VALUES(
	'2011-11-11',
    '2011-11-10 11:11:11'
);

select pet_id, pet_name, user_info.fName 
FROM pet_info
INNER JOIN user_info ON pet_info.user_number = user_info.user_number;


-- Staffs

CREATE TABLE clinic_personnel_credentials (
user_number INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
user_name VARCHAR(25) NOT NULL,
salted_hash VARCHAR(255) NOT NULL
);

CREATE TABLE clinic_personnel_info (
id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
fName VARCHAR(255) NOT NULL,
lName VARCHAR(255) NOT NULL,
mName VARCHAR(255) NOT NULL,
contact VARCHAR(255) NOT NULL,
address VARCHAR(255) NOT NULL,	
position VARCHAR(255) NOT NULL,
specialization TEXT NOT NULL,
department VARCHAR(255) NOT NULL,
resume_path VARCHAR(255) NOT NULL,
certification_path VARCHAR(255) NOT NULL,
workingHours VARCHAR(255) NOT NULL,
salary DECIMAL(8, 2) NOT NULL,
startDate DATE NOT NULL,
user_number INT,
FOREIGN KEY(user_number) REFERENCES clinic_personnel_credentials(user_number)
);

SELECT * FROM clinic_personnel_info;
SELECT * FROM clinic_personnel_credentials;

drop table clinic_personnel_credentials;
drop table clinic_personnel_info;

