using Inheritance___Lab._1._Farm;
using Inheritance___Lab._2._Multiple_Inheritance_Farm;
using Inheritance___Lab._3._Hierarchical_Inheritance_Farm;
using Inheritance___Lab._4._Custom_Random_List;
using Inheritance___Lab._5._Stack_Of_Strings;

//1
/*Dog dog = new Dog();
dog.Eat();
dog.Bark();*/

//2
/*Puppy puppy = new Puppy();
puppy.Eat();
puppy.Bark();
puppy.Weep();*/

//3
/*Inheritance___Lab._3._Hierarchical_Inheritance_Farm.Dog dog = new Inheritance___Lab._3._Hierarchical_Inheritance_Farm.Dog();
dog.Eat();
dog.Bark();

Cat cat = new Cat();
cat.Eat();
cat.Meow();*/

//4
/*RandomList randomList= new RandomList();
randomList.Add("hi");
randomList.Add("hello");
randomList.Add("first");
randomList.Add("second");
randomList.Add("third");
Console.WriteLine(randomList.RandomString());
Console.WriteLine("The rest of list:");
foreach(string s in randomList)
{
    Console.WriteLine(s);
}*/

//5
StackOfStrings st= new StackOfStrings();
List<string> list= new List<string>();
Console.WriteLine(st.IsEmpty());
list.Add("hi");
list.Add("hello");
list.Add("first");
list.Add("second");
list.Add("third");
st.AddRange(list);
Console.WriteLine(st.IsEmpty());
