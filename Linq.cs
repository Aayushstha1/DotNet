// See https://aka.ms/new-console-template for more information
Console.WriteLine("List of the user ");
BcaVContext context = new BcaVContext();
List<UserList> userLists = context.UserLists.ToList();
foreach (var user in userLists)
{
    Console.WriteLine(user.UserName);
}
Random random = new Random(DateTime);
userLists newUser UserList();