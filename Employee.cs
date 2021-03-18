using System;

class Employee {

  //Fields
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  //propertiespublic string firstname{get; set;}
  public string firstname{get; set;}
  public string lastname{get; set;}
  public string id{get; set;}
  public int age{get; set;}
  public string employmentstatus{get; set;}
  
  //no parameter constructor

  public Employee()
  {
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    age = 0;
    employmentstatus = "active";
  }

  //constructor with parameters

  public Employee(string name1, string name2, string jobid, int empAge)
  {
    firstname = name1;
    lastname = name2;
    id = jobid;
    age = empAge;

    employmentstatus = active;
  }


  public void Intro()
  {
    Console.WriteLine ("The first name is " + firstname);
    Console.WriteLine ("The last name is " + lastname);
    Console.WriteLine ("The ID is " + id);
    Console.WriteLine ("The age is " + age);
    Console.WriteLine ("The employment status is " + employmentstatus);
  }

  

}