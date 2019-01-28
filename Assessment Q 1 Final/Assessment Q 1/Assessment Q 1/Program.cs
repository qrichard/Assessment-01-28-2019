using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assessment_Q_1
{
class Program
    {
        static void Main(string[] arguments)
        {
            string filePath = "";
            
                filePath = Prompt("Please enter a '.cs' file path and include the file extension");


                while(!filePath.EndsWith(".cs")){
                    filePath = Prompt("Please enter a '.cs' file path and include the file extension");
                
            }

            StreamReader fileToRead = new StreamReader(filePath);            
            bool multiLined = false;
            bool add = false;          
            while(!fileToRead.EndOfStream){               
                if (!multiLined){
                    add = false;
                }             
                string comments = "";
                string currentLine = fileToRead.ReadLine();                
                for(int i = 0; i < currentLine.Length; i++){                
                    if (i != currentLine.Length - 1){                       
                        if(currentLine[i] == '/' && currentLine[i + 1] == '/'){                           
                            add = true;
                        }
                        
                        if (add == false && currentLine[i] == '/' && currentLine[i + 1] == '*'){
                            add = true;
                            multiLined = true;
                        }
                        
                        if (add == true && currentLine[i] == '*' && currentLine[i + 1] == '/'){
                            add = false;
                            multiLined = false;                         
                            comments += "*/";
                            
                        }
                    }
                   
                    if (add) {

                        comments += currentLine[i].ToString();
                    }
                }
              
                if(comments != ""){
                    Console.WriteLine(comments);
                }
            }
            Console.ReadKey();
        }
        
      
        static string Prompt(string msg){
            Console.Write(msg + ": ");
            return Console.ReadLine();
        }


    }
}
