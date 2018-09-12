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
  
  (2)one to one:
  
  (3)many to many: