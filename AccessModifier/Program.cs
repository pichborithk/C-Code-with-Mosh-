string cheatsheet = @"
+--------------------+--------------------------------------------------------------+
| Modifier           | Class |   Derived Class   | Assembly | Derived Class | World |
|                    |       | (within assembly) |          |    (World)    |       |
+--------------------+--------------------------------------------------------------+
| public             |   Y   |         Y         |     Y    |        Y      |   Y   |
| protected internal |   Y   |         Y         |     Y    |        Y      |   N   |
| protected          |   Y   |         Y         |     N    |        Y      |   N   |
| internal           |   Y   |         Y         |     Y    |        N      |   N   |
| private protected  |   Y   |         Y         |     N    |        N      |   N   |
| private            |   Y   |         N         |     N    |        N      |   N   |
+-----------------------------------------------------------------------------------+";

Console.WriteLine(cheatsheet);