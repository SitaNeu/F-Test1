// For more information see https://aka.ms/fsharp-console-apps

let salary = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

printfn "The salary of the employees is:" 

for i in salary do
   printfn " $ %A"i

printfn " " 


let HighSalary = List.filter (fun x -> x > 100000 )salary

printfn "The high-income salary of the employees are: " 

for i in HighSalary do
    printfn " $ %A"i

printfn " " 

printfn " Tax on salary: "

let tax salary =
    if salary <= 49020 then 
        0.15 * float salary
    elif salary <= 98040 then 
        0.205 * float salary
    elif salary <= 151978 then  
        0.26 * float salary
    elif salary <= 216511 then  
        0.29 * float salary
    else 
        0.33 * float salary


let salaryAndTax = salary |> List.map (fun x -> (x, tax x))
 



for i in salaryAndTax do
    
  printfn " $ %A" i
 

printfn " " 


let FilteredList = List.filter ( fun x -> x < 49020)  salary

let FilteredAdded =  FilteredList |> List.map (fun x -> (x, 20000+x))
 

printfn " The salary below $ 49020 with $ 20000 addition are : %A" FilteredAdded
printfn " " 

let FilteredSecond = List.filter ( fun x -> x > 50000 && x < 100000)  salary

let sumUp = List.fold (+) 0 FilteredSecond

printfn " The addition of salary between $ 50000 and $ 100000 is  : $ %A" sumUp

printfn " " 



 


let  Sum (n:int)=
    let rec helper (current:int) (acc:int)=
      if current <= 0 then acc
      else helper (current-3) (acc+current)
    helper n 1

let total = Sum 30
printfn "The sum of the multiples of 3 is  upto 30 : %d" total      

