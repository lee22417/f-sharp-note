# List in F#

### 1. Create and Initialize a List
- list literals
```
let list1 = [1;2;3]
```
- cons (::) operator
```
let list1 = 1::2::3::[];;
```
- List.init method of list module
```
let list1 = List.init 5 (fun index -> (index, index*index, index*index*index))
```
- syntactic constructs called List Comprehensions
```
let list1 = [1 .. 10]
let list2 = [ for a in 1 .. 10 do yield (a*a) ]
```
<br>

### 2. Properties of List Data Type
|Property|Type|Description|
|---|---|---|
|Head|'T|The first element|
|Empty|'T list|return an empty list of the appropriate type|
|isEmpty|bool|true if the list is empty|
|Item|'T|The element at the specified index (zero based)|
|Length|int|the number of elements|
|Tail|'T list|the list without the first element|

<br>

### 3. Basic Operators
- append
- average
- averageBy
- choose
- collect
- concat
- empty
- exists
- exists2
- filter
- find
- findIndex
- fold
- fold2
- foldBack
- foldBack2
- forall
- forall2
- head
- init
- isEmpty
- iter
- iter2
- iteri
- iteri2
- length
- map
- map2
- map3
- mapi
- mapi2
- max
- maxBy
- min
- minBy
- nth
- ofArray
- ofSeq
- partition
- permute
- pick
- reduce
- reduceBack
- replicate
- rev
- scan
- scanBack
- sort
- sortBy
- sortWith
- sum
- sumBy
- tail
- toArray
- toSeq
- tryFind
- tryFindIndex
- tryPick
- unzip
- unzip3
- zip
- zip3
<br><br>

# Reference
https://www.tutorialspoint.com/fsharp/fsharp_lists.htm
