using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            Console.WriteLine("Enter a single capitalized letter of the alphabet.");
            Input = Console.ReadLine();
            Console.WriteLine("You have entered '" + Input + "'.");
            List<string> Plugboard = new List<string>(); //input "plugboard, containg the alphabet
            Plugboard.Add("A");                         //add contents
            Plugboard.Add("B");
            Plugboard.Add("C");
            Plugboard.Add("D");
            Plugboard.Add("E");
            Plugboard.Add("F");
            Plugboard.Add("G");
            Plugboard.Add("H");
            Plugboard.Add("I");
            Plugboard.Add("J");
            Plugboard.Add("K");
            Plugboard.Add("L");
            Plugboard.Add("M");
            Plugboard.Add("N");
            Plugboard.Add("O");
            Plugboard.Add("P");
            Plugboard.Add("Q");
            Plugboard.Add("R");
            Plugboard.Add("S");
            Plugboard.Add("T");
            Plugboard.Add("U");
            Plugboard.Add("V");
            Plugboard.Add("W");
            Plugboard.Add("X");
            Plugboard.Add("Y");
            Plugboard.Add("Z");


            int position = Plugboard.IndexOf(Input); //finds the index of the user input in the alphabet 
            Console.WriteLine("Alphabet Index:" + position); //outputs the index of the character

            List<string> Rotor1 = new List<string>(); //first rotor, containing EKMFLGDQVZNTOWYHXUSPAIBRCJ
            Rotor1.Add("E");                          //add contents
            Rotor1.Add("K");
            Rotor1.Add("M");
            Rotor1.Add("F");
            Rotor1.Add("L");
            Rotor1.Add("G");
            Rotor1.Add("D");
            Rotor1.Add("Q");
            Rotor1.Add("V");
            Rotor1.Add("Z");
            Rotor1.Add("N");
            Rotor1.Add("T");
            Rotor1.Add("O");
            Rotor1.Add("W");
            Rotor1.Add("Y");
            Rotor1.Add("H");
            Rotor1.Add("X");
            Rotor1.Add("U");
            Rotor1.Add("S");
            Rotor1.Add("P");
            Rotor1.Add("A");
            Rotor1.Add("I");
            Rotor1.Add("B");
            Rotor1.Add("R");
            Rotor1.Add("C");
            Rotor1.Add("J");

            Input = Rotor1[position]; //sets the inputted letter to the corrolating 
            Console.WriteLine(Input);

        }
    }
}
