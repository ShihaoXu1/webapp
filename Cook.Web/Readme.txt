1 index & unique
  Unique indexes are indexes that help maintain data integrity by ensuring that
  no two rows of data in a table have identical key values. When you create a unique 
  index for an existing table with data, values in the columns or expressions that 
  comprise the index key are checked for uniqueness.
  

2.datatype
  (1)datetime：from 1753/01/01 to 9999/12/31, Accurate to 1/100s
     datetime2：from 0001/01/01 to 9999/12/31, Accurate 100ns    
	 generally, I choose datetime2, because there is no merit of datetime
  (2)char：size is fixed 1-8000
     varchar：var=variable 1-8000
     nchar nvarchar：1-4000 these two types can be used for both chinese character
	 and english letter. 

3.object relational mapping
  (1)one to many: 
  ORM: For example, the relationship between players and teams, students and classes,
  each student (team member) belongs to only one class (team), and each class (team)
  can have multiple students.

 StudentTable
 --------------
|StudentNumber | 
 --------------
|StudentName   |                         ClassTable
 --------------                          -----------
| ClassNumber  |---> as foreign key <---|ClassNumber|--->primary key
 --------------      of StudentTable     -----------
  (2)one to one:
  For example, the address of school, each school just have one address.

SchoolTable                           SchoolAddress
 ------------                         ---------------
|SchoolNumber|---> as foreign key<---| SchoolNumber  |
 ------------      of SchoolTable     ---------------
| SchoolName |                       |   City        |
 ------------                         ---------------
  (3)many to many:
  This is also a very common relationship, such as students and electives,
  a student can have multiple electives, and an elective can also be 
  selected by multiple students, such as:
  StudentTable
 --------------
|StudentName   |                         Course_Student
 --------------                          -------------
| StudentNumber|---> as foreign key <---|StudentNumber|--->primary key
 --------------      of Course_Student   -------------
                                        | CourseNumber| 
CourseTable                              -------------
 ------------                              |
| CourseName |---> as foreign key <--------|
 ------------      of Course_Student
|CourseNumber|
 ------------