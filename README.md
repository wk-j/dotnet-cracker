## ตรวจสอบคุณภาพโค้ด C# ด้วย [Code Cracker](https://github.com/code-cracker/code-cracker) (ตัวอย่างโปรเจค) ###

#### 1. สร้างโปรเจค

```
dotnet new console --language C# --output src/Hello
```

#### 2. ติดตั้ง nuget package ชื่อ CodeCracker.CSharp

```
dotnet add src/Hello/Hello.csproj package CodeCracker.CSharp
```

#### 3. ตรวจสอบโค้ดด้วยคำสั่ง build

```
dotnet build src/Hello/Hello.csproj
```

#### 4. โปรแกรมจะแสดง warning + เลขบรรทัด พร้อมรหัส CXXXXX ดังนี้

```bash
Program.cs(16,20): warning CS0219: The variable 'noVar' is assigned but its value is never used [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(11,23): warning CS0649: Field 'Program.nullVariable' is never assigned to, and will always have its default value null [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(10,16): warning CS0169: The field 'Program.unusedVariable' is never used [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(12,26): warning CC0057: Parameter 'args' is not used. [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(16,13): warning CC0001: Use 'var' instead of specifying the type name. [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(18,13): warning CC0001: Use 'var' instead of specifying the type name. [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
Program.cs(18,13): warning CC0008: You can use initializers in here. [/Users/wk/Source/DotNetCracker/src/Hello/Hello.csproj]
    7 Warning(s)
    0 Error(s)
``` 

#### 5. ให้นำรหัส CXXXXX ไปตรวจสอบในเว็บไซต์ http://code-cracker.github.io/diagnostics.html ว่าต้องแก้ไขอย่างไร

#### 6. แก้โค้ด, สั่ง build จนกว่า warning จะหมดหรือพอใจ