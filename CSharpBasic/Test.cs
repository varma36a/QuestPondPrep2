

// MyFileSearch mfs = new MyFileSearch();
// //mfs.Search("E:\\Test");  //blocking call
// mfs.sendData = Receiver;
// Console.WriteLine("Search Started....");

// var res = Task.Run(() =>
//     {
//         mfs.Search("/Users/RohithGVMac/AZ-204");
//     }
// );
// Console.WriteLine("Continue Executing");
// Console.ReadLine();

// static void Receiver(string fileName)
// {
//     Console.WriteLine(fileName);
// }
// public class MyFileSearch
// {

//     public delegate void SearchMethod(string input);
//     public SearchMethod sendData = null;

//     public void Search(string dir)
//     {
//         try
//         {
//             foreach (var d in Directory.GetDirectories(dir))
//             {
//                 foreach (var f in Directory.GetFiles(d))
//                 {
//                     sendData(f);
//                 }
//             }
//         }
//         catch (System.Exception)
//         {

//             throw;
//         }
//     }
// }