USE Student;
CREATE TABLE student_detail(
    student_id INT NOT NULL AUTO_INCREMENT,
    student_name VARCHAR(50) NOT NULL,
    registration_number VARCHAR(50) NOT NULL,
    location VARCHAR(50),
    PRIMARY KEY(student_id)
);
