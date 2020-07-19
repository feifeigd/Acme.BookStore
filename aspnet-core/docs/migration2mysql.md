
参考： https://www.sohu.com/a/213814486_468635

数据库从SQL server转Mysql后
删除 Migrations 文件夹
然后重新初始化 
```
 Add-Migration "AbpZero_Initial"
```
注意：初始化的名字"AbpZero_Initial"不能变

写入数据库
```
update-database
```
