# StringExtensionMethod-CSharp

- Type of class and type of method must be static also method must be return a string type
- The parameter of method must be start with "_this_" e.g -> ```c# ToCustomNameFormat(this string input)```

- This exaple is created for a custom name format.
   <br/>
   _e.g_. -> __Input__: john doe, __Output__ : John Doe
   <br/>
   _e.g._ -> __Input__: sarı çizmeli mehmet ağa, __Output__: Sarı Çizmeli Mehmet Ağa 

<br/>
<h3>Calling The Function <h3>
   
```c#
string Name ="john doe"; 
Console.WriteLine(Name.ToCustomNameFormat());
//John Doe
```
asdasd
