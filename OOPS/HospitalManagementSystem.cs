// using System;
// using System.Collections.Generic;

// abstract class Person
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public Person(int id, string name)
//     {
//         Id = id;
//         Name = name;
//     }

//     public virtual void GetDetails()
//     {
//         Console.WriteLine($"Id: {Id}");
//         Console.WriteLine($"Name: {Name}");
//     }

//     public abstract void PerformDuty();
// }

// class Doctor : Person
// {
//     public string Department { get; set; }

//     public Doctor(int id, string name, string department)
//         : base(id, name)
//     {
//         Department = department;
//     }

//     public override void PerformDuty()
//     {
//         Console.WriteLine($"Doctor {Name} is treating patients.");
//     }
// }

// class Nurse : Person
// {
//     public string Department { get; set; }

//     public Nurse(int id, string name, string department)
//         : base(id, name)
//     {
//         Department = department;
//     }

//     public override void PerformDuty()
//     {
//         Console.WriteLine($"Nurse {Name} is assisting doctors.");
//     }
// }

// class Patient : Person
// {
//     private string Disease;

//     public Patient(int id, string name, string disease)
//         : base(id, name)
//     {
//         Disease = disease;
//     }

//     public override void PerformDuty()
//     {
//         Console.WriteLine($"Patient {Name} is receiving treatment.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Person> persons = new List<Person>();

//         persons.Add(new Doctor(
//             101,
//             "Krishna",
//             "Cardiology"));

//         persons.Add(new Nurse(
//             102,
//             "Ravi",
//             "Cardiology"));

//         persons.Add(new Patient(
//             103,
//             "Anu",
//             "Fever"));

//         foreach (Person person in persons)
//         {
//             person.PerformDuty();
//         }
//     }
// }