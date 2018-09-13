1.关于index 和 unique
  这两个都是基于快速查找的目的，但是index只是普通的索引他的存在只是加快了对数据的访问速度，但是unique同时添加了约束行为，
  即每一个列值只能是唯一的。
  举例说明：如果一个公司的员工的姓名可能是重复的，那么我们可以定义为index，但是当我们可以确定一个column中绝对不能出现相
  同时，那么就应该设置为unique index，避免了重复数据的出现的同时加快速度。

2.datatype
  (1)datetime：从1753/01/01到9999/12/31的数据精确到百分之三秒
     datetime2：从0001/01/01 到9999/12/31的数据精确到100ns    一般情况选择datetaime2，因为在datetime上看不到什么优势。
  (2)char：定长 1-8000
     varchar：可变 1-8000
     nchar nvarchar：1-4000 不区分英文还是汉字较为方便，但是和char 和 varchar 比较起来在储存的量上有损失。 

3.object relational mapping
  (1)one to many: 
  常见的关系映射，比如球员与球队，学生与班级的关系，
每一个学生（队员）只属于一个班级（球队），每一个
班级（球队）可以拥有多个学生。
建立关系：
 StudentTable
 --------------
|StudentNumber | 
 --------------
|StudentName   |                         ClassTable
 --------------                          -----------
| ClassNumber  |---> as foreign key <---|ClassNumber|--->primary key
 --------------      of StudentTable     -----------
  (2)one to one:
  比如学校的地址，一个学校只能有一个地址。

SchoolTable                           SchoolAddress
 ------------                         ---------------
|SchoolNumber|---> as foreign key<---| SchoolNumber  |
 ------------      of SchoolTable     ---------------
| SchoolName |                       |   City        |
 ------------                         ---------------
  (3)many to many:
  这个也是很常见的关系，比如学生和选修课，一个学生可以有多个选修课，并且
  一个选修课也可以被多个学生选择，比如：
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