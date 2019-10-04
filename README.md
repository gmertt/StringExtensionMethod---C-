# StringExtensionMethod-CSharp

- Type of class and type of method must be static also method must be return a string type
- The parameter of method must be start with "this" e.g -> ToCustomNameFormat(this string input)

- This exaple is created for a custom name format. e.g. -> Input: john doe, Output : John Doe
e.g. -> Input: sarı çizmeli mehmet ağa, Output: Sarı Çizmeli Mehmet Ağa 

<br/>
<h3>Calling The Function <h3>
   
```c#
string Name ="john doe"; 
Console.WriteLine(Name.ToCustomNameFormat());
//John Doe


