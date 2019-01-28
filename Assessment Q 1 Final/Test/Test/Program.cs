using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

             //string that stores the comments one line at a time then prints to screen and resets for the next line
                string comments = "";

                //reading through the file one line at a time
                string current_line = read_file.ReadLine();

                //for loops that goes through the current line of the .cs file looking for comment keywords ('//' and '/*' % '*/')
                for(int i = 0; i < current_line.Length; i++){
                    
                    //this allows the next statements to not go outside of bounds while still making the for loop check the entire line of code
                    if (i != current_line.Length - 1){
                        //if a comment keyword is found then switch the add (add line) bool to true in order to print the line to the screen
                        if(current_line[i] == '/' && current_line[i + 1] == '/'){
                            //bool switched to true
                            add = true;
                        }
                        //if a multiline comment keyword is found then switch the add and the multiline bool to true
                        if (add == false && current_line[i] == '/' && current_line[i + 1] == '*'){
                            add = true;
                            multiLine = true;
                        }
                        //when a multiline comment is found then add and multiline will stay true until the end multiline comment
                        //keyword is found, when found both add and multiline as switched off
                        if (add == true && current_line[i] == '*' && current_line[i + 1] == '/'){
                            add = false;
                            multiLine = false;
                            //adds a end multiline comment keyword to the string b/c it is left off otherwise
                            comments += "*/";
                            
                        }
                    }
                    //if add is true then the comments string is built one char at a time until a single line comment line ends or the
                    //end multiline comment keyword is found
                    //doing this one char at a time allows for inline comments(multiline comments used within code body) to be extracted


        }
    }
}
