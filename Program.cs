﻿using System.Linq;
using System.Reflection.PortableExecutable;
using aula09.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("artigo sobre C#", "csharp"));
articles.Add(new Article("artigo sobre .NET", "dotnet"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();

var courseOop = new Course("fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("fundamentos C#", "fundamentos-csharp");
var courseAspnet = new Course("fundamentos .NET", "fundamentos-aspnet");

courses.Add(courseOop);
courses.Add(courseCsharp);
courses.Add(courseAspnet);

var careers = new List<Career>();
var careerDotnet = new Career("especialista .NET", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", "", courseOop);
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseCsharp);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspnet);

careerDotnet.Items.Add(careerItem);
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem3);
careers.Add(careerDotnet);
Console.Clear();
foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Level);
    }
}