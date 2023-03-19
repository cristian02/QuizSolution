using Model; 

//A1
Child child = new Child(12, "Juan");
Console.WriteLine(child.ToString("Hi"));

//A2 
Animal cat = new Cat(); 
Animal dog = new Dog(); 
cat.makeSound(); 
dog.makeSound(); 

//A3
//interface : puedo implementar varias interfaces solo puedo extender de una clase abstract 
//interface : se pueden implementar o extender 
//interface : no pueden tener contructor, las abstract si 