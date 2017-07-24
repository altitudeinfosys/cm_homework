var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  		MSBuild("./CM_HomeWork.sln");
});

Task("Run-Unit-Tests")
    .IsDependentOn("Default")
    .Does(() =>
{
    MSTest("./FizzBuzzTest/bin/Debug/" + "FizzBuzzTest.dll");
});


	
RunTarget(target);