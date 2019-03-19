
1..5|foreach-object{$_}


$a = 5
$b = 6
$c = 7
$d = $a,$b,$c
Foreach ($i in $d)
{
$i + 5
}
 $array = @("item1", "item2", "item3")
 
 for($i = 0; $i -lt $array.length; $i++){ $array[$i] }

 $array = @("item1", "item2", "item3")
$counter = 0;

while($counter -lt $array.length){
   $array[$counter]
   $counter += 1
}
 