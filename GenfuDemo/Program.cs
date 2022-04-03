//https://www.nuget.org/packages/GenFu
// See https://www.davepaquette.com/archive/2015/11/15/realistic-sample-data-with-genfu.aspx
//https://github.com/MisterJames/GenFu


using GenFu;
using GenfuDemo;



Console.WriteLine("Hello, World!");

var i = 1;
GenFu.GenFu.Configure<Person>().Fill(p => p.Age).WithinRange(19, 30).Fill(x=>x.Title, () => { return Helper. GetTitle(); })
    .MethodFill<string >(x=>x.SetMiddleName(null))
    .Fill(x=>x.Id, () => { return i++;})
    .Fill(x=>x.EmailAddress , x => { return $"{x.FirstName}.{x.LastName}@gmail.com";}).
    Fill(x=>x.IsRegister).WithRandom(new bool[]{ true, false, true, false, true, false });

var person = A.New<Person>();

var personList= A.ListOf<Person> (10000);

A.Configure<IncidentReport>().Fill(x => x.ReportedBy).WithRandom(personList);
var reports = A.ListOf<IncidentReport>(100000);

Console.ReadKey();