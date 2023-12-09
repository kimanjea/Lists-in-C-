using System.Formats.Asn1;
using System.Runtime.Versioning;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program {

    static void Main(string [] arg) {
           
           var words = new List<string> {" hello ", "worlds ", "      cnsd okc"};
           var documents = new List<int> {1,2, 3};
            words.Sort();
           foreach (var word in words)
           {
                Console.WriteLine(word.ToUpper());
           }

           for (int i = 0; i < words.Count; i++) //because it is a list of words, we can use .Length we use cound
           {
            Console.WriteLine(words[i].Trim());
           }

            words.Add("Shukra");
            words.Add("Najib");
            documents.Add(45);
            
          var array1 =  words.ToArray();
          var array2 =  documents.ToArray();
          
          
         for (int i = 0; i < array1.Length; i++) //if we want to use .length we have to convert to an array
         {
            Console.WriteLine(array1[i].TrimStart());
           
         }
        

        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
         if (array1.Contains("worlds ")==true) { //trying to search our array also notice how i had to add the space to match my string
            Console.WriteLine("yeerrpp");
                
        }

        // adding to an array would require you to create a function that increases array size and also  copies the elements
        //however if you convert the array into a list, you say on time complexity and do all that in one line
         var jonathan = array1.ToList();

         foreach (var item in jonathan)
         {
            Console.WriteLine(item.ToUpper());
         }


         //lets do a fibonnaci game to teach what it means

         int count = 0;
         var fibonacccii = new List<int> {1,1}; // create a list of the first two in the sequence
        
        while (count < 20) { 

         var numberbefore = fibonacccii[fibonacccii.Count-1]; // grab the last one 
         var numberclosest = fibonacccii[fibonacccii.Count-2];// grab the second last one 
         fibonacccii.Add(numberbefore + numberclosest);
         
         Console.WriteLine(fibonacccii[count]); // prinr out the each
         count++; // count up till 20 numbers in
         
         }
         
        // lets convert this to an array for practice
        var array3 = fibonacccii.ToArray();

        for (int i = 0; i < array3.Length; i++)
        {
            Console.WriteLine(array3[i]);
        }

        }

        


}