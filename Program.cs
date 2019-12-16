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
            List<string> Plugboard = new List<string>(); //input "plugboard, containing the alphabet
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

            List<string> Rotor2 = new List<string>();
            Rotor2.Add("A");
            Rotor2.Add("J");
            Rotor2.Add("D");
            Rotor2.Add("K");
            Rotor2.Add("S");
            Rotor2.Add("I");
            Rotor2.Add("R");
            Rotor2.Add("U");
            Rotor2.Add("X");
            Rotor2.Add("B");
            Rotor2.Add("L");
            Rotor2.Add("H");
            Rotor2.Add("W");
            Rotor2.Add("T");
            Rotor2.Add("M");
            Rotor2.Add("C");
            Rotor2.Add("Q");
            Rotor2.Add("G");
            Rotor2.Add("Z");
            Rotor2.Add("N");
            Rotor2.Add("P");
            Rotor2.Add("Y");
            Rotor2.Add("F");
            Rotor2.Add("V");
            Rotor2.Add("O");
            Rotor2.Add("E");

            int i = 0;
            while (i < 5)
            {
                string Input;
                Console.WriteLine("Enter a single capitalized letter of the alphabet.");
                Input = Console.ReadLine();
                Console.WriteLine("You have entered '" + Input + "'.");


                int position = Plugboard.IndexOf(Input); //finds the index of the user input in the alphabet 
                Console.WriteLine("Alphabet Index:" + position); //outputs the index of the character


                Input = Rotor1[position];                   //sets the inputted letter to be the corrolating index of the Rotor.
                Console.WriteLine(Input);                   //output

                String R1Rotate = Rotor1[0];                //stores the letter at the top of the rotor
                Rotor1.RemoveAt(0);                         //removes the letter at the top
                Rotor1.Add(R1Rotate);                       //adds the letter to the bottom

            }

        }
    }
}
