using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*When you post a message on Facebook, depending on the number of people who like your post, 
             * Facebook displays different information.

                If no one likes your post, it doesn't display anything.
                If only one person likes your post, it displays: [Friend's Name] likes your post.
                If two people like your post, it displays: [Friend 1]
            and[Friend 2] like your post.
                If more than two people like your post, it displays: [Friend 1], [Friend 2] 
                and[Number of Other People] others like your post.
                Write a program and continuously ask the user to enter different names, until 
                the user presses Enter (without supplying a name). Depending on the number of names provided, 
                display a message based on the above pattern.
            */

            var nameInput = "";
            var names = new List<string>();
            var likes = 0;
            
            do
            {   Console.WriteLine("Please enter a name: ");
                nameInput = Console.ReadLine();
                Console.WriteLine();//blank
                //add each name to the list only if it's not there already, if it is a duplicate, don't add it.
          
                if (names.Contains(nameInput))
                {
                    Console.WriteLine("Sorry, no duplicate likes.");
                }else if(!names.Contains(nameInput) && !String.IsNullOrWhiteSpace(nameInput)) //don't add blanks to the list either
                {
                    names.Add(nameInput);
                }
                
                Console.WriteLine();//blank

                //count determines path - if 1, if 2, if 3+
                if (names.Count == 1)
                {
                    Console.WriteLine("{0} liked your post", names[0]);   

                }else if (names.Count == 2)
                {
                    Console.WriteLine("{0} and {1} liked your post.", names[0], names[1]);
                    
                }
                else if(names.Count >=3)//if 3+ likes
                {
                   likes = names.Count - 2;
                  Console.WriteLine("{0} and {1} and {2} others liked your post.", names[0], names[1], likes);
                }
                Console.WriteLine();//blank

            } while (String.IsNullOrWhiteSpace(nameInput) == false);
        }
    }
}
