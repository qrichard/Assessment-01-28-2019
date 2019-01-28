using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_Q_3
{
 class Program
    {
        static void Main(string[] args)
        {
            
               string textInput = "";
                textInput = Prompt("Enter a '.txt' file paththat includes the '.txt' file extension");

                while(!textInput.EndsWith(".txt")){
                    textInput = Prompt("Enter a '.txt' file path that includes the file extension");
                
            }

            string file = File.ReadAllText(textInput);

     
            char[] split_on = {' ', ',', '.', '\n', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '<', '>', '\'', '"', '\t', '\\', '+', '=', '|', '}', '{', '[', ']', ';', ':', '/', '`', '~', '-', '_'};

            string[] wordsArray = file.Split(split_on, StringSplitOptions.RemoveEmptyEntries);
            int maxIndex = FindMaxLengthIndex(wordsArray);
            int maxLength = wordsArray[maxIndex].Length + 2;


            for (int i = 0; i < maxLength + 2; i++){
                Console.Write("*");
            }

            Console.WriteLine();

            for(int i = 0; i < wordsArray.Length; i++){
                if (wordsArray[i].Length < maxLength){
                    int diff = maxLength - wordsArray[i].Length;
                    Console.Write("* " + wordsArray[i]);

                    for(int j = 0; j < diff - 1; j++){
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }else{
                    Console.WriteLine("* " + wordsArray[i] + "*");
                }
            }
            for (int i = 0; i < maxLength + 2; i++){
                Console.Write("*");
            }
            Console.ReadKey();
        }

        static string Prompt(string msg){
            Console.Write(msg + ": ");
            return Console.ReadLine();
        }

        static int FindMaxLengthIndex(string[] ary){

            int tempIndex = 0;
            int maxLength = ary[0].Length;
          
            for (int i = 1; i < ary.Length; i++){
               
                if (ary[i].Length > maxLength){
                    maxLength = ary[i].Length;
                    tempIndex = i;
                }
            }
            return tempIndex;
        }
    }
}
