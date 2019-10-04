# StringExtensionMethod-CSharp
<ul style="list-style-type:square;"> </ul>
<li>Type of class and type of method must be static also method must be return a string type</li>
<li>The parameter of method must be start with "this" e.g -> ToCustomNameFormat(this string input) </li>
<li>
   This exaple is created for a custom name format. e.g. -> Input: john doe, Output : John Doe
  <br/>
  e.g. -> Input: sarı çizmeli mehmet ağa, Output: Sarı Çizmeli Mehmet Ağa 
</li>
</ul>
<br/>
<h3>Calling The Function <h3>
<p>
  '''cs
    string Name ="john doe"; 
    Console.WriteLine(Name.ToCustomNameFormat());
     //John Doe
</p>

